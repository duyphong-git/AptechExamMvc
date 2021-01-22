using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NguyenDuyPhongC1906L.Models
{
    public class QuestionViewModel
    {
        public int Id { get; set; }

        [DisplayName("Question")]
        public string Name { get; set; }
        public string TypeName { get; set; }
    }
}
