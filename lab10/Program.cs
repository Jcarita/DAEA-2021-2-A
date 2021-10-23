using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        public static NorthwndDataContext context = new NorthwndDataContext();
        static void Main(string[] args)
        {

            additionalActivity02();

            Console.ReadKey();
        }
        public static void exerciseI()
        {
            //creacion de la consulta
            var query = from p in context.Products
                        where p.Categories.CategoryName == "Beverages"
                        select p;
            //Ejecucion de la consulta
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }
        }
        public static void exerciseJ()
        {
            //creacion de la consulta
            var query = from p in context.Products
                        where p.UnitPrice < 20
                        select p;
            //Ejecucion de la consulta
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            }
        }
        public static void exerciseK_i()
        {
            var query = from p in context.Products
                        where p.ProductName.Contains("Queso")
                        
                        select p;
            foreach (var prod in query) 
            {
                Console.WriteLine("ID={0} \t Product Name={1}", prod.ProductID,prod.ProductName);            
            }
        }
        public static void exerciseK_I_I()
        {
            var query = from p in context.Products
                        where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Product Name={1}", prod.ProductID, prod.ProductName);
            }
        }
        public static void exerciseK_I_I_I()
        {
            var query = from p in context.Products
                        where SqlMethods.Like(p.ProductName, "A%")
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("Product Name={0}",prod.ProductName);
            }
        }
        public static void exerciseK_IV()
        {
            var query = from p in context.Products
                        where p.UnitsInStock == 0
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0}", prod.ProductID);
            }
        }
        public static void exercise_K_V()
        {
            var query = from p in context.Products
                        where p.Discontinued == true
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0}", prod.ProductID);
            }
        }
        public static void exercise_L()
        {
            Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;
            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();
        }
        public static void exercise_N()
        {
            Categories c = new Categories();
            c.CategoryName = "Clothes";
            c.Description = "All types clothing";
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();
        }

        public static void exercise_O()
        {
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges();
        }
        public static void exercise_P()
        {
            var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();
        }
        public static void additionalActivity01()
        {
            var product = from p in context.Products
                          where p.Categories.CategoryName == "Dairy Products"
                          select p;
             
            foreach (var prod in product)
            {
                Console.WriteLine("ID={0} \t Name={1,25} \t Provider={2}",prod.ProductID,prod.ProductName,prod.Suppliers.CompanyName);
            }
        }
        public static void additionalActivity02()
        {
            var product = from p in context.Products
                          where p.Suppliers.Country == "USA"
                          select p;

            foreach (var prod in product)
            {
                Console.WriteLine("Product={0,35} \t Provider={1,30} \t Country={2}", prod.ProductName, prod.Suppliers.CompanyName, prod.Suppliers.Country);
            }
        }
    }
}
