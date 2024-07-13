using System.ComponentModel.DataAnnotations;

namespace Connecting_To_Database.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public int? Roll {  get; set; }  
    }
}
