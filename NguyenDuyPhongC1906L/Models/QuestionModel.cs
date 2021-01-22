using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenDuyPhongC1906L.Models
{
    [Table("Question")]
    public class QuestionModel : BaseModel
    {
        public int QuestionTypeModelId { get; set; }
        public virtual QuestionTypeModel QuestionTypeModel { get; set; }
    }
}
