using FreeTestManager.Entities;
using System.Collections.Generic;

namespace FreeTestManager.Core.Builders.QuestionBuilder.Implementations
{
    public class FreeQuestionBuilder : IQuestionBuilder
    {
        public Question Question { get; set; }

        public FreeQuestionBuilder() 
        {
            Question = new Question();
        }
        public void AddAnswer(Answer answer)
        {
            Question.Answers.Add(answer);
        }

        public void AddRange(List<Answer> answers)
        {
            Question.Answers.AddRange(answers);
        }

        public void AddText(string text)
        {
            Question.Text = text;
        }

        public Question GetQuestion()
        {
            return Question;
        }

        public void Clear()
        {
            Question = new Question();
        }
    }
}
