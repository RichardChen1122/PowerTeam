using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.DAL
{
    public class PTDBContextFactory: IDesignTimeDbContextFactory<PTDBContext>
    {

        public PTDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PTDBContext>();
            optionsBuilder.UseSqlServer("Server=webnetqasqlawp1;Initial Catalog=powerteam;Persist Security Info=False;User ID=sa;Password=ASP+Rocks4U;Connection Timeout=30;");

            return new PTDBContext(optionsBuilder.Options);
        }
    }
}
