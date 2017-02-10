﻿using AtddSampleWeb.Models;
using FluentAutomation;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AtddSampleWebTests.steps
{
    [Binding]
    [Scope(Feature = "BookMaintenance")]
    public class BookMaintenanceSteps : FluentTest
    {
        private BookRegisterPage _bookRegisterPage;

        [BeforeScenario()]
        public void BeforeScenario()
        {
            this._bookRegisterPage = new BookRegisterPage(this);
        }

        [Given(@"go to Book Registering Page")]
        public void GivenGoToBookRegisteringPage()
        {
            this._bookRegisterPage.Go();
        }

        [Given(@"a book for registering")]
        public void GivenABookForRegistering(Table table)
        {
            var book = table.CreateInstance<BookViewMoel>();
            ScenarioContext.Current.Set<BookViewMoel>(book);
        }

        [When(@"Add book into library")]
        public void WhenAddBookIntoLibrary()
        {
            var book = ScenarioContext.Current.Get<BookViewMoel>();
            this._bookRegisterPage.Create(book);
        }

        [Then(@"added successfully message should be displayed")]
        public void ThenAddedSuccessfullyMessageShouldBeDisplayed()
        {
            string addedSuccessFulMessage = GetSuccessfulMessage();
            this._bookRegisterPage.ShouldDisplay(addedSuccessFulMessage);
        }

        private string GetSuccessfulMessage()
        {
            return "新增成功";
        }
    }
}