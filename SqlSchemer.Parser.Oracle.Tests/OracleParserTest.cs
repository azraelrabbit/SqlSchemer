using SqlSchemer.Parser.Oracle.Tests.TestCases;
using System;
using Xunit;

namespace SqlSchemer.Parser.Oracle.Tests
{
    public class OracleParserTest
    {
        private readonly OracleParser sut = new OracleParser();

        [Fact]
        public void ThrowsExceptionForNullScript()
        {
            var caught = Assert.Throws<ArgumentNullException>(() => sut.ParseScript(null));
            Assert.True(caught.Message.Contains("sqlSchemaScriptLines"));
        }

        [Fact]
        public void ReturnsNotNullSchemaForValidScript()
        {
            var sqlSchemaScriptLines = SingleTableWithIndex.SCRIPT.Split('\n');
            Assert.NotNull(sut.ParseScript(sqlSchemaScriptLines));
        }

        [Fact]
        public void ReturnsSchemaWithOneTableForValidScript()
        {
            var sqlSchemaScriptLines = SingleTableWithIndex.SCRIPT.Split('\n');
            var schema = sut.ParseScript(sqlSchemaScriptLines);
            Assert.Equal(1, schema.Tables.Count);
        }
    }
}
