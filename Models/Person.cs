using System.ComponentModel.DataAnnotations;

namespace SomethingAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Country Country { get; set; }

    }
}
