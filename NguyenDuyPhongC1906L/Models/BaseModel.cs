using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenDuyPhongC1906L.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string UserNew { get; set; }

        public DateTime? DateNew { get; set; }

        public string UserEdit { get; set; }

        public DateTime? DateEdit { get; set; }
    }
}
