using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTodo.Models
{
    [Table("tbl_Todo")]
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Título")]
        [MaxLength(100)]
        [MinLength(3)]
        public string Title { get; set; }

        [Display(Name = "Finalizado ?")]
        public bool Done { get; set; } = false;
    }
}
