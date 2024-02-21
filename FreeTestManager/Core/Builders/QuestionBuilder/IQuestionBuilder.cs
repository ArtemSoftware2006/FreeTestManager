using FreeTestManager.Entities;
using System.Collections.Generic;

namespace FreeTestManager.Core.Builders.QuestionBuilder
{
    public interface IQuestionBuilder
    {
        Question Question { get; set; }
        void AddText(string text);
        void AddAnswer(Answer answer);
        void DeleteAnswer(Answer answer);
        void AddRange(List<Answer> answers);
        Question GetQuestion();
        void Clear();
    }
}
