using System.Collections.Generic;

namespace SqlSchemer.Model.Interfaces
{
    public interface ISqlTable
    {
        string Name { get; }

        IList<ISqlTableField> Fields { get; }

        IList<ISqlTableField> PrimaryKey { get; }

        IList<IForeignKey> ForeignKeys { get; }

    }
}