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

            // Find All
            /*Console.WriteLine("Show All Supplier");
            var suppliers = iRepoSupp.FindAll();
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"{supplier.ToString()}");
            }*/

            // Find By Id
            /*Console.WriteLine("Find By Id");
            var supplierById = iRepoSupp.FindById(10);
            Console.WriteLine($"{supplierById.ToString()}");*/

            // Create
            /*var newSupp = new Supplier
            {
                CompanyName = "Miniso",
                ContactName = "Julian",
                ContactTitle = "Sales Manager",
                HomePage = "#FORMAGGI.HTM#"
            };

            Console.WriteLine("Create");
            newSupp = iRepoSupp.Save(ref newSupp);
            Console.WriteLine(newSupp.ToString());*/

            // Update
            var updateSupp = new Supplier
            {
                SupplierId = 35,
                CompanyName = "Miniso Plus",
                ContactName = "Julian Aditya",
                ContactTitle = "Sales Manager",
                HomePage = "#FORMAGGI.HTM#"
            };

            updateSupp = iRepoSupp.Update(updateSupp);
            Console.WriteLine(updateSupp.ToString());

            // Delete
            /*Console.WriteLine("Delete");
            iRepoSupp.Delete(36);*/
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
