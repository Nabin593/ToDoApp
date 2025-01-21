using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter the Description.")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter a DueDate.")]
        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage = "Please Select a Category.")]
        public string CategoryId { get; set; } = string.Empty;
    }
}
