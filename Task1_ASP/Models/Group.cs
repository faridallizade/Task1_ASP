﻿namespace Task1_ASP.Models
{
    public class Group
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public List<Student> students = new List<Student>();
    }
}
