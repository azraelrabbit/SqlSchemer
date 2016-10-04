namespace SqlSchemer.Model.Interfaces
{
    public interface IForeignKey
    {
        ISqlTableField Source { get; }

        ISqlTable TargetTable { get; }

        ISqlTableField TargetField { get; }
    }
}