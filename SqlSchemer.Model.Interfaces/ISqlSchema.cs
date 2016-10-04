using System.Collections.Generic;

namespace SqlSchemer.Model.Interfaces
{
    public interface ISqlSchema
    {
        IList<ISqlTable> Tables { get; }
    }
}
