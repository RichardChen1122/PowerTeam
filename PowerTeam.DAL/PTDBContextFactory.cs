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
            optionsBuilder.UseSqlServer("Server=tcp:testproviderserver.database.windows.net,1433;Initial Catalog=providertest;Persist Security Info=False;User ID=asplab;Password=Windows10!dfu;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new PTDBContext(optionsBuilder.Options);
        }
    }
}
