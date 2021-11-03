using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise_15();
            
        }
        static public void exercise_2()
        {
            using (AdventureWorks2017Entities AWEntities = new AdventureWorks2017Entities())
            {
                var products = AWEntities.Products;
                //IQueryable<String> productNames = from p in products
                //                                select p.Name;

                IQueryable<String> productNames = products.Select(p => p.Name);
                Console.WriteLine("Productos: ");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
            }
        }
        static public void exercise_3()
        {
            using (AdventureWorks2017Entities AWEntities = new AdventureWorks2017Entities())
            {
                var products = AWEntities.Products;
                IQueryable<Product> productQuery = from p in products
                                                  select p;

                IQueryable<Product> largeProducts = productQuery.Where(p => p.Size == "L");
                Console.WriteLine("Productos Size 'L' : ");
                foreach (var product in largeProducts)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadKey();
            }
        }

        static public void exercise_4()
        {
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                IQueryable<Product> productsQuery = from product in context.Products
                                                    select product;
                Console.WriteLine("Productos: ");
                foreach (var prod in productsQuery) 
                {
                    Console.WriteLine(prod.Name);
                }
                Console.ReadKey();
            }
        }
        static public void exercise_5()
        {
            using(AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                var query = from product in context.Products
                            select new
                            {
                                ProductId = product.ProductID,
                                ProductName = product.Name
                            };
                Console.WriteLine("Informacion de productos: ");
                foreach(var productInfo in query)
                {
                    Console.WriteLine("Product Id: {0} Product name: {1}", productInfo.ProductId, productInfo.ProductName);
                }
                Console.ReadKey();
            }
        }
        static public void exercise_6()
        {
            decimal totalDue = 500.00M;
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                //var contacts = context.Contac
            }
        }
        static public void exercise_8()
        {
            int orderQtyMin = 2;
            int orderQtyMax = 6;
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                var query = from order in context.SalesOrderDetails
                            where order.OrderQty > orderQtyMin
                            && order.OrderQty > orderQtyMax
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                OrderQty = order.OrderQty
                            };
                foreach( var order in query)
                {
                    Console.WriteLine("Order ID: {0} Order quantity: {1}",
                        order.SalesOrderID, order.OrderQty);
                }
                Console.ReadKey();
            }
        }
        static public void exercise_9()
        {
            String color = "Red";
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                var query = from product in context.Products
                            where product.Color == color
                            select new
                            {
                                Name = product.Name,
                                ProductNumber = product.ProductNumber,
                                ListPrice = product.ListPrice
                            };
                foreach (var product in query)
                {
                    Console.WriteLine("Name: {0}", product.Name);
                    Console.WriteLine("Product number: {0}", product.ProductNumber);
                    Console.WriteLine("List Price: ${0}", product.ListPrice);
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }
            
        }
        static public void exercise_10()
        {
            using (AdventureWorks2017Entities AWEntities = new AdventureWorks2017Entities())
            {
                int?[] productModelIds = { 19, 26, 118 };
                var products = from p in AWEntities.Products
                               where productModelIds.Contains(p.ProductModelID)
                               select p;
                foreach (var product in products)
                {
                    Console.WriteLine("{0}: {1}",
                        product.ProductModelID, product.ProductID);
                }
                Console.ReadKey();
            }
        }
        static public void exercise_12()
        {
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                IQueryable<Decimal> sortedPrices = from p in context.Products
                                                   orderby p.ListPrice descending
                                                   select p.ListPrice;
                Console.WriteLine("Lista de precios desde el mas alto al mas bajo: ");
                foreach (Decimal price in sortedPrices) 
                {
                    Console.WriteLine(price);
                }
                Console.ReadKey();
            }
        }
        static void exercise_14()
        {
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                var products = context.Products;
                var query = from product in products
                            group product by product.Style into g
                            select new
                            {
                                Style = g.Key,
                                AverageListPrice = g.Average(product => product.ListPrice)
                            };
                foreach (var product in query) 
                {
                    Console.WriteLine($"Estilo: {product.Style} Precio promedio: {product.AverageListPrice}");
                }
                Console.ReadKey();
            }
        }
        static void exercise_15()
        {
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities()) 
            {
                var products = context.Products;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };
                foreach (var product in query) 
                {
                    Console.WriteLine($"Color = { product.Color } \t Cantidad = { product.ProductCount }");
                }
                Console.ReadKey();
            }
        }
    }
}
