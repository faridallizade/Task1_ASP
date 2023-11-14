namespace Task1_ASP.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public int GroupId { get; set; }
        public Group group { get; set; }
    }
}
