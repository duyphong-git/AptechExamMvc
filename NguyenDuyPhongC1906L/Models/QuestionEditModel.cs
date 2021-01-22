using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NguyenDuyPhongC1906L.Models
{
    public class QuestionEditModel
    {
        public int Id { get; set; }

        [DisplayName("Question")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        public string Name { get; set; }

        [DisplayName("Question Type")]
        [Required(ErrorMessage = "Question Type required")]
        public int QuestionType { get; set; }
    }
}
