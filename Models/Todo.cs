using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Title")]
        [Required(ErrorMessage = "Mandatory field")]
        public string Title { get; set; }
        [DisplayName("Done!")]
        public bool Done { get; set; }
        [DisplayName("Created ")]
        public DateTime CreateAt { get; set; } = DateTime.Now;
        [DisplayName("Last update: ")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        [DisplayName("User")]
        public string User { get; set; }
    }
}