using System.Collections.Generic;

namespace SqlSchemer.Model.Interfaces
{
    public interface ISqlTable
    {
        ISqlTableMetadata Metadata { get; }

        IList<ISqlTableField> Fields { get; }

        IList<ISqlTableField> PrimaryKey { get; }

        IList<IForeignKey> ForeignKeys { get; }

    }
}