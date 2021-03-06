﻿using Efrpg.Filtering;

namespace Efrpg.ForeignKeyStrategies
{
    public class BaseForeignKeyNamingStrategy
    {
        protected readonly Table _table;
        protected readonly IDbContextFilter _filter;

        public BaseForeignKeyNamingStrategy(IDbContextFilter filter, Table table)
        {
            _filter = filter;
            _table  = table;
        }
    }
}