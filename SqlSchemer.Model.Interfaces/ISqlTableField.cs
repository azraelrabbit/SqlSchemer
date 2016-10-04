namespace SqlSchemer.Model.Interfaces
{
    public interface ISqlTableField
    {
        string Name { get; }

        string SqlType { get; }

        bool IsNull { get; }
    }
}