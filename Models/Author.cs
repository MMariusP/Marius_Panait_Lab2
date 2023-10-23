using System.ComponentModel.DataAnnotations;

namespace Marius_Panait_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string firstNmae { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        public string FullName { get { return this.firstNmae + " " + this.lastName; } }

        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
