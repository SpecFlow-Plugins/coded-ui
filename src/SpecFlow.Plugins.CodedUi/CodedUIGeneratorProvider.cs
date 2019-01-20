/* The MIT License (MIT)

Copyright (c) 2015 Fabricio Correa Duarte

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

namespace CodedUi.Generator.SpecFlowPlugin
{
    using System.CodeDom;
    using TechTalk.SpecFlow.Generator;
    using TechTalk.SpecFlow.Generator.UnitTestProvider;
    using TechTalk.SpecFlow.Utils;

    public class CodedUIGeneratorProvider : MsTest2010GeneratorProvider
    {
        public CodedUIGeneratorProvider(CodeDomHelper codeDomHelper)
            : base(codeDomHelper) { }

        private const string TestClassAttribute = @"Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute";
        private const string CodedUiTestClassAttribute = @"Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute";

        public override void SetTestClass(TestClassGenerationContext generationContext, string featureTitle, string featureDescription)
        {
            base.SetTestClass(generationContext, featureTitle, featureDescription);

            // Remove TestClass attribute
            foreach (CodeAttributeDeclaration declaration in generationContext.TestClass.CustomAttributes)
            {
                if (declaration.Name == TestClassAttribute)
                {
                    generationContext.TestClass.CustomAttributes.Remove(declaration);
                    break;
                }
            }

            // Add CodedUITest attribute to class
            generationContext.TestClass.CustomAttributes.Add(new CodeAttributeDeclaration(new CodeTypeReference(CodedUiTestClassAttribute)));
        }

        public override void FinalizeTestClass(TestClassGenerationContext generationContext)
        {
            base.FinalizeTestClass(generationContext);

            var msTestContextGeneration =
                new CodeExpressionStatement(
                    new CodeMethodInvokeExpression(
                        new CodeTypeReferenceExpression("testRunner.ScenarioContext"),
                        "Add",
                        new CodeExpression[]
                        {
                            new CodePrimitiveExpression("MSTestContext"),
                            new CodeArgumentReferenceExpression("TestContext")
                        }));

            generationContext.ScenarioInitializeMethod.Statements.Add(msTestContextGeneration);
            var msTestAssignment =
                new CodeAssignStatement(
                    new CodeVariableReferenceExpression("myTestContext"),
                    new CodeVariableReferenceExpression("testContext"));
            generationContext.TestClassInitializeMethod.Statements.Add(msTestAssignment);
            var mstestContextFiled = new CodeMemberField
            {
                Attributes = MemberAttributes.Private | MemberAttributes.Static | MemberAttributes.Final,
                Name = "myTestContext",
                Type = new CodeTypeReference(TESTCONTEXT_TYPE),
            };

            generationContext.TestClass.Members.Add(mstestContextFiled);

            var mstestContextProperty = new CodeMemberProperty();
            mstestContextProperty.Name = "TestContext";
            mstestContextProperty.Type = new CodeTypeReference(TESTCONTEXT_TYPE);
            mstestContextProperty.Attributes =
                      (mstestContextProperty.Attributes & ~MemberAttributes.AccessMask) |
                         MemberAttributes.Public;
            mstestContextProperty.GetStatements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("myTestContext")));
            mstestContextProperty.SetStatements.Add(new CodeAssignStatement(new CodeVariableReferenceExpression("myTestContext"), new CodePropertySetValueReferenceExpression()));

            generationContext.TestClass.Members.Add(mstestContextProperty);
        }
    }
}
