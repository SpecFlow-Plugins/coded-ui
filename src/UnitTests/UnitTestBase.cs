namespace CodedUi.Generator.SpecFlowPlugin
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class UnitTestBase
    {
        protected void Arrange(Action arrangeBlock)
        {
            try
            {
                arrangeBlock.Invoke();
            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message, ex);
            }
        }
    }
}
