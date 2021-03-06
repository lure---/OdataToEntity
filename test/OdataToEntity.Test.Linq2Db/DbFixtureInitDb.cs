﻿using Microsoft.EntityFrameworkCore;
using OdataToEntity.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdataToEntity.Test
{
    public sealed class DbFixtureInitDb : DbFixture
    {
        public DbFixtureInitDb()
        {
            using (var context = new OrderContext())
                context.Database.ExecuteSqlCommand("dbo.ResetDb");
            base.ExecuteBatchAsync("Add").GetAwaiter().GetResult();
        }
    }
}
