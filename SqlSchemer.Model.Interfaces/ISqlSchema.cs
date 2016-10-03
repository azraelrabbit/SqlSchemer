using System.Collections.Generic;

namespace SqlSchemer.Model.Interfaces
{
    public interface ISqlSchema
    {
        ISqlSchemaMetadata Metadata { get; }

        IEnumerable<ISqlTable> Tables { get; }
    }
}
