namespace CodedUi.Generator.SpecFlowPlugin
{
    using NUnit.Framework;
    using TechTalk.SpecFlow.Generator.Plugins;

    public class CodedUiPluginTests : UnitTestBase
    {
        [Test]
        public void ImplementsIGeneratorPlugin()
        {
            // Arrange
            CodedUiPlugin sut = null;

            // Act
            sut = new CodedUiPlugin();

            // Assert
            Assert.IsInstanceOf<IGeneratorPlugin>(sut);
        }
    }
}
