namespace Calculator.Specs.Steps
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class AdditionSteps
    {
        UI.AdderClasses.Adder adder = new UI.AdderClasses.Adder();
        [Given(@"the calculator is running")]
        public void GivenTheCalculatorIsRunning()
        {
            adder.Lunch();
        }


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            if (adder.UIAdderWindow.UIItem0Window.UIELeftEdit.Text == "0")
                adder.UIAdderWindow.UIItem0Window.UIELeftEdit.Text = p0.ToString();
            else
                adder.UIAdderWindow.UIItem0Window1.UIERightEdit.Text = p0.ToString();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Mouse.Click(adder.UIAdderWindow.UIAddWindow.UIAddButton);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            string expected = p0.ToString();
            string actual = adder.UIAdderWindow.UIItem3Window.FriendlyName;
            Assert.AreEqual(expected, actual);
        }
    }
}
