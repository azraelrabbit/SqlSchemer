using SqlSchemer.Model;
using SqlSchemer.Model.Interfaces;
using SqlSchemer.Parser.Interfaces;
using System;

namespace SqlSchemer.Parser.Oracle
{
    public sealed class OracleParser : ISqlSchemaParser
    {
        public OracleParser() { }

        public ISqlSchema ParseScript(string[] sqlSchemaScriptLines)
        {
            if (sqlSchemaScriptLines == null) throw new ArgumentNullException(nameof(sqlSchemaScriptLines));

            var sqlSchema = new SqlSchema();

            return sqlSchema;
        }
    }
}
