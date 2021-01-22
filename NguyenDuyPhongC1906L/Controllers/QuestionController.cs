using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenDuyPhongC1906L.Dao;
using NguyenDuyPhongC1906L.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NguyenDuyPhongC1906L.Controllers
{
    public class QuestionController : Controller
    {
        private readonly DataContext _dbContext;

        public QuestionController(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public IActionResult Index(String sortOrder, string searchString)
        {
            ViewData["NoSortParam"] = String.IsNullOrEmpty(sortOrder) ? "" : "";
            ViewData["IdSortParm"] = sortOrder  == "id_desc" ? "id" : "id_desc";
            ViewData["NameSortParm"] = sortOrder == "name_desc" ? "name" : "name_desc";
            ViewData["TypeSortParm"] = sortOrder == "type_desc" ? "type" : "type_desc";
            ViewData["QuestionNameFilter"] = searchString;

            var questViews = _dbContext.QuestionModels
                .Join(_dbContext.QuestionTypeModels,
                    q => q.QuestionTypeModelId,
                    t => t.Id,
                    (q, t) => new QuestionViewModel
                    {
                        Id = q.Id,
                        Name = q.Name,
                        TypeName = t.Name
                    }
                    ).ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                questViews = questViews.Where(s => s.Name.Contains(searchString) || s.TypeName.Contains(searchString)).ToList();
            } else
            {

            }

            switch (sortOrder)
            {
                case "id":
                    questViews = questViews.OrderBy(x => x.Id).ToList();
                    break;
                case "id_desc":
                    questViews = questViews.OrderByDescending(x => x.Id).ToList();
                    break;
                case "name_desc":
                    questViews = questViews.OrderByDescending(x=>x.Name).ToList();
                    break;
                case "name":
                    questViews = questViews.OrderBy(x => x.Name).ToList();
                    break;
                case "type":
                    questViews = questViews.OrderBy(x => x.TypeName).ToList();
                    break;
                case "type_desc":
                    questViews = questViews.OrderByDescending(x => x.TypeName).ToList();
                    break;
                default:
                    questViews = questViews.OrderBy(x => x.Id).ToList();
                    break;
            }

            return View(questViews);
        }

        public IActionResult Create()
        {
            var types = _dbContext.QuestionTypeModels.ToList();
            SelectList typeList = new SelectList(types, "Id", "Name");
            ViewBag.typeList = typeList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(QuestionEditModel model)
        {
            if (ModelState.IsValid)
            {
                var question = new QuestionModel
                {
                    Name = model.Name,
                    QuestionTypeModelId = model.QuestionType,
                    DateNew = DateTime.Now,
                    UserNew = "UserTest"
                };

                _dbContext.QuestionModels.Add(question);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Create));
            }

        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = _dbContext.QuestionModels.FirstOrDefault(x => x.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            var editModel = new QuestionEditModel
            {
                Id = question.Id,
                Name = question.Name,
                QuestionType = question.QuestionTypeModelId
            };

            var types = _dbContext.QuestionTypeModels.ToList();
            SelectList typeList = new SelectList(types, "Id", "Name");
            ViewBag.typeList = typeList;

            return View(editModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, QuestionEditModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            try { 
                if (ModelState.IsValid)
                {
                    var old = _dbContext.QuestionModels.Find(model.Id);
                    old.Name = model.Name;
                    old.QuestionTypeModelId = model.QuestionType;
                    old.UserEdit = "UserEdit";
                    old.DateEdit = DateTime.Now;

                    _dbContext.QuestionModels.Update(old);
                    _dbContext.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(model.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {

            if (String.IsNullOrEmpty(id.ToString()) || !QuestionExists(id))
            {
                return NotFound();
            }

            var question = _dbContext.QuestionModels.FirstOrDefault(x => x.Id == id);

            if (question == null)
            {
                return NotFound();
            }

            var editModel = new QuestionEditModel
            {
                Id = question.Id,
                Name = question.Name,
                QuestionType = question.QuestionTypeModelId
            };

            return View(editModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var question = _dbContext.QuestionModels.Find(id);

            _dbContext.QuestionModels.Remove(question);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool QuestionExists(int id)
        {
            return _dbContext.QuestionModels.Any(x => x.Id == id);
        }

    }
}