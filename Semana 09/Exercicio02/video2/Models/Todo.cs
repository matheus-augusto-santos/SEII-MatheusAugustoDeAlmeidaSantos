using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Required Field")]
        public string Title { get; set; }

        [DisplayName("Done")]
        public bool Done { get; set; }

        [DisplayName("Created in")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Last Update in")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string User { get; set; }
    }
}
