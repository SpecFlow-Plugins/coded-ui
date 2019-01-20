/* The MIT License (MIT)

Copyright (c) 2019-2019 Fabricio Correa Duarte

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

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
