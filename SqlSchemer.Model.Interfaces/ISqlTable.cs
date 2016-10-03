using System.Collections.Generic;

namespace SqlSchemer.Model.Interfaces
{
    public interface ISqlTable
    {
        ISqlTableMetadata Metadata { get; }

        IEnumerable<ISqlTableField> Fields { get; }

        IEnumerable<ISqlTableField> PrimaryKey { get; }

        IEnumerable<IForeignKey> ForeignKeys { get; }

    }
}