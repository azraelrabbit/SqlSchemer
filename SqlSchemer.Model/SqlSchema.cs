﻿using System;
using System.Collections.Generic;
using SqlSchemer.Model.Interfaces;

namespace SqlSchemer.Model
{
    public class SqlSchema : ISqlSchema
    {
        public IList<ISqlTable> Tables
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
