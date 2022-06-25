using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SplitTheBill.Controllers;

namespace SplitTheBill.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId {get;set;}
        [Required(ErrorMessage = "Pole Nazwa jest wymagane.")]
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(2000)]
        public string? Description {get;set;}
        
        public bool Done {get;set;}
    }
}
