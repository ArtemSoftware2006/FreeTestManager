using System;
using System.Collections.Generic;

namespace FreeTestManager.Entities
{
    public class Test
    {
        public Test() 
        {
            Questions = new List<Question>();
            Id = Guid.NewGuid();
        }
        public Test(Guid id, string title, string author, DateTime created, List<Question> questions)
        {
            Id = id;
            Title = title;
            Author = author;
            Created = created;
            Questions = questions;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public List<Question> Questions { get; set; }
    }
}
