using System.Collections.Generic;

namespace UniManager.App.Models.Student
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
    }
}
