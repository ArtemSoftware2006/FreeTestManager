using FreeTestManager.Entities;
using System;
using System.Collections.Generic;

namespace FreeTestManager.TestBuilder
{
    public interface ITestBuilder
    {
        Test Test { get; set; }
        void AddTitle(string title);
        void AddAuthor(string author);
        void AddDateTimeCreated(DateTime dateTime);
        void AddQuestion(Question question);
        void AddQuestionRange(List<Question> questions);
        Test GetResult();
    }
}
