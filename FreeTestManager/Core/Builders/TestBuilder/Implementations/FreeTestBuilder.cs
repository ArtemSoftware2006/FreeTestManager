using FreeTestManager.Entities;
using FreeTestManager.TestBuilder;
using System;
using System.Collections.Generic;

namespace FreeTestManager.Core.Builders.TestBuilder.Implementations
{
    public class FreeTestBuilder : ITestBuilder
    {
        public Test Test { get; set; }

        public FreeTestBuilder()
        {
            Test = new Test();
        }
        public void AddAuthor(string author)
        {
            Test.Author = author;
        }

        public void AddDateTimeCreated(DateTime dateTime)
        {
            Test.Created = dateTime;
        }

        public void AddQuestion(Question question)
        {
            Test.Questions.Add(question);
        }

        public void AddQuestionRange(List<Question> questions)
        {
            Test.Questions.AddRange(questions);
        }

        public void AddTitle(string title)
        {
            Test.Title = title;
        }

        public Test GetResult()
        {
            return Test;
        }
    }
}
