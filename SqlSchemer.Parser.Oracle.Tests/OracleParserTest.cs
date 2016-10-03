using SqlSchemer.Model.Interfaces;
using Xunit;

namespace SqlSchemer.Parser.Oracle.Tests
{
    public class OracleParserTest
    {
        private readonly OracleParser sut = new OracleParser();

        [Fact]
        public void T1()
        {
            string[] sqlSchemaScriptLines = null;

            ISqlSchema result = sut.ParseScript(sqlSchemaScriptLines);

            Assert.NotNull(result);
        }
    }
}
