﻿using Day07.DbContext;
using Day07.Entity;
using Day07.Repository;
using Microsoft.Extensions.Configuration;

namespace Day07
{
    internal class Program
    {
        private static IConfigurationRoot Configuration;
        private static void Main(string[] args)
        {
            BuildConfiguration();
            var dapperDbContext = new DapperDbContext(Configuration.GetConnectionString("NorthWindDS"));


            IRepositoryBase<Supplier> iRepoSupp = new SupplierRepository(dapperDbContext);
            var suppliers = iRepoSupp.FindAll();
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"{supplier.ToString()}");
            }
        }

        private static void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            //Console.WriteLine(Configuration.GetConnectionString("NorthWindDS"));
        }
    }
}
