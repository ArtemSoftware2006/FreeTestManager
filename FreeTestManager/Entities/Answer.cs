using System;

namespace FreeTestManager.Entities
{
    public class Answer
    {
        public Answer() 
        {
            Id = Guid.NewGuid();
        }
        public Answer(Guid id, string text, bool isTrue, float value)
        {
            Id = id;
            Text = text;
            IsTrue = isTrue;
            Value = value;
        }

        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
        public float Value { get; set; }

        public Answer Clone()
        {
            var clonedAnswer = new Answer
            {
                Id = this.Id,
                Text = this.Text,
                IsTrue = this.IsTrue,
                Value = this.Value,
            };

            return clonedAnswer;
        }
    }
}
