using SoftDelete.Interfaces;

namespace SoftDelete.Models
{
    public class Student : ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }
    }
}
