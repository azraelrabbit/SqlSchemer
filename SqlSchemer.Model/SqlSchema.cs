using System;
using System.Collections.Generic;
using SqlSchemer.Model.Interfaces;

namespace SqlSchemer.Model
{
    public class SqlSchema : ISqlSchema
    {
        public ISqlSchemaMetadata Metadata
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<ISqlTable> Tables
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
