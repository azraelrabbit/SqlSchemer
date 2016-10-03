using System;
using SqlSchemer.Model.Interfaces;
using SqlSchemer.Parser.Interfaces;

namespace SqlSchemer.Parser.Oracle
{
    public sealed class OracleParser : ISqlSchemaParser
    {
        public ISqlSchema ParseScript(string[] sqlSchemaScriptLines)
        {
            throw new NotImplementedException();
        }
    }
}
