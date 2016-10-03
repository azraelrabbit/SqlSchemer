using SqlSchemer.Model;
using SqlSchemer.Model.Interfaces;
using SqlSchemer.Parser.Interfaces;
using System;

namespace SqlSchemer.Parser.Oracle
{
    public sealed class OracleParser : ISqlSchemaParser
    {
        public ISqlSchema ParseScript(string[] sqlSchemaScriptLines)
        {
            if (sqlSchemaScriptLines == null) throw new ArgumentNullException(nameof(sqlSchemaScriptLines));
            return new SqlSchema();
        }
    }
}
