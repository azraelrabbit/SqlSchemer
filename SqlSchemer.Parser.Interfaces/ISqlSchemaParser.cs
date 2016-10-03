using SqlSchemer.Model.Interfaces;

namespace SqlSchemer.Parser.Interfaces
{
    public interface ISqlSchemaParser
    {
        ISqlSchema ParseScript(string[] sqlSchemaScriptLines);
    }
}
