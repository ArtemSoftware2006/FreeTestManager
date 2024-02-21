using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeTestManager.Entities
{
    public class Question
    {
        public Question() 
        {
            Answers = new List<Answer>();
            Id = Guid.NewGuid();
        }
        public Question(Guid id, string text, List<Answer> answers)
        {
            Id = id;
            Text = text;
            Answers = answers;
        }

        public Guid Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers{ get; set; }

        public Question Clone()
        {
            var clonedQuestion = new Question
            {
                Id = this.Id,
                Text = this.Text,
                Answers = this.Answers.Select(a => a.Clone()).ToList()
            };

            return clonedQuestion;
        }
    }
}
