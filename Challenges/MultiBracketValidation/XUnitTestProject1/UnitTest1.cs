using System;
using Xunit;
using MultiBracketValidation;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanParseCurlyBraces()
        {
            Assert.True(Program.MultiBracketValidation("{}"));
        }

        [Fact]
        public void CanParseMultipleBraces()
        {
            Assert.True(Program.MultiBracketValidation("{}(){}"));
        }
    
        [Fact]
        public void CanParseMultiBracketsWithChars()
        {
            Assert.True(Program.MultiBracketValidation("()[[Extra Characters]]"));
        }

        [Fact]
        public void CanParseMultiBrackets2()
        {
            Assert.True(Program.MultiBracketValidation("(){}[[]]"));
        }

        [Fact]
        public void CanParseMultiBracketsWithChars2()
        {
            Assert.True(Program.MultiBracketValidation("{}{Code}[Fellows](())"));
        }

        [Fact]
        public void FalseForMismatchedBraces1()
        {
            Assert.False(Program.MultiBracketValidation("[({}]"));
        }

        [Fact]
        public void FalseForMismatchedBraces2()
        {
            Assert.False(Program.MultiBracketValidation("(]("));
        }

        [Fact]
        public void FalseForMismatchedBraces3()
        {
            Assert.False(Program.MultiBracketValidation("{(})"));
        }

    }
}
