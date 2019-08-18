using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> num = new List<int> { 2, 4, 6,2 ,7, 7, 1, 8, 9, 3, 0 };
            //var query1=num.Distinct().OrderBy(s => s).Select(numb => new { Number = numb, Multiply = numb * numb });
            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);

            //}

            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //var query2 = names.Where(name => name.Length == 3);
            // var query3 = query2.Select(name => name.ToUpper());

            //foreach (var item in query3)
            //{
            //    Console.WriteLine(item);
            //}

            NORTHWNDEntities DB = new NORTHWNDEntities();
            #region Ef Day1
            //    var query1 = DB.Customers.Select(a => a.CustomerID);
            //    foreach (var item in query1)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    var query2 = DB.Orders.Select(s => new { s.OrderID, s.OrderDate, s.CustomerID });
            //    foreach (var item in query2)
            //    {
            //        Console.WriteLine(item);
            //    }

            #endregion

            #region Task1
            //var query1 = DB.Customers.Single(c => c.CustomerID == "ANTON").Orders.Select(orders => new { orders.ShipName, orders.CustomerID });
            //Order newOrder = new Order { CustomerID = "ANTON", EmployeeID = 3, ShipName = "Hello" };
            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("***********************************************************************");
            ////DB.Orders.Add(newOrder);
            //DB.Customers.Single(c => c.CustomerID == "ANTON").Orders.Add(newOrder);
            //DB.SaveChanges();
            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task2
            //var query2 = DB.Products.Single(p => p.ProductID == 10).Order_Details.Select(o => new { o.Quantity, o.UnitPrice });
            //foreach (var item in query2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Task3
            //  var query3 = DB.Orders.Select(o => new { o.OrderID, o.OrderDate });
            //  foreach (var item in query3)
            //  {
            //      Console.WriteLine(item);
            //  }
            //  Console.WriteLine( "*****************************************************");
            // var delDetailedOrder = DB.Orders.Single(o => o.OrderID == 10259).Order_Details;

            //  var delOrder = DB.Orders.Single(o => o.OrderID == 10259);
            //  foreach (var item in delDetailedOrder)
            //  {
            //      DB.Order_Details.Remove(item);

            //  }

            //  DB.Orders.Remove(delOrder);
            //DB.SaveChanges();
            //  foreach (var item in query3)
            //  {
            //      Console.WriteLine(item);
            //  }
            #endregion
            #region Task5
            DB.Employees.Single(e => e.FirstName == "Nancy").Title = "Hr Manager";
            var Supervisor = DB.Employees.Single(e => e.FirstName == "Nancy").Employee1;
            Console.WriteLine("Name =  " + Supervisor.FirstName + "  " + Supervisor.LastName);
            DB.SaveChanges();
            #endregion
            var query5 = DB.Employees.Single(e => e.FirstName == "Nancy");

                } }
}
