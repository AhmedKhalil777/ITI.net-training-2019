using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    class Program
    {
        static void Main(string[] args)
        {


            northwindEntities DB = new northwindEntities();
            var query1=DB.Customers.Select(cust => cust.CustomerID);


            var firstCustomer = DB.Customers.First().Orders.Select(order=>new {order.CustomerID,order.OrderDate });

            foreach (var item in firstCustomer)
            {
                Console.WriteLine(item);
            }








          //  List<string> Names = new List<string>() { "mona", "hend", "Hala", "Mostafa", "ahmed", "mohammed", "Yara", "hesham" };

          //  int[] Numbers = new int[] { 3, 1, 4, 3, 6, 3, 8, 9, 12, 11, 8 };

          //  #region Features
          //  //1- implicitly typed local variable
          //  //must be intialized (can not intialiezed with null)

          //  //2- Object Intializer 

          //    //Customer customer = new Customer() { FirstName = "Mona", LastName = "Ali" };
          //  //Console.WriteLine(customer);

          //  //3- Anonymouse Type (LINQ Feature) used for data projection (ReadOnly)
          //  //var + new + object intializer
          //  //toString  , properties names if not exist  , read only , can't assign to different type

          //  var student = new {ID=40,fName="Eman", lName="Fathi" };
          //  //var CustomerProj = new {customer.LastName };
          //  //Console.WriteLine(CustomerProj);
           
          //  //4-Anonymoue Method and Lambda Expression  
          //  List<string> result = Names.FindAll(str=>str.Length>3);
          //  foreach (var item in result)
          //  {
          //  //    Console.WriteLine(item);
          //  }
            


          //  //5- Extenstion Method 

          //  string myName = "Eman Fathi";

          //  //Console.WriteLine(StringExtensions.wordCount(myName,4));
          //  //Console.WriteLine(myName.wordCount(5));
          //  #endregion


          //  //Linq Methods (Enumerable class Methods)

          //  #region where

          //  //Enumerable.Where()
          //  //Method Expression
          //  var query1=Names.Where(str => str.Length >= 5);
          //  Names.Add("emanfathi");

          //  foreach (var item in query1)
          //  {
          //      //Console.WriteLine(item);
          //  }

          //  //query expression   should end with select or group by

          //  #endregion


          //  #region Select

          //  //1-select method directly with and without anonymous type
          //  //var query2 = Names.Select(str => new { Name=str.ToUpper(),length=str.Length });
          //  //var query2 = Names.Select(str => str.Length>3);

          ////  var query2 = Names.Select(name => name.ToUpper());
          //  var query2 = Names.Select(name => new {name,NAME=name.ToUpper(),name.Length });
          //  foreach (var item in query2 )
          //  {
          //  //    Console.WriteLine(item);
          //  }
          //  var query3 = //Names.Where(name => name.Length > 5)
          //      query1.Select(name=>name.ToUpper());
          //  foreach (var item in query3)
          //  {
          //      Console.WriteLine(item);
          //  }


          //  var query5 = from name in Names
          //               where name.Length >= 5
          //               select new {name=name.ToLower() };




            //2- chaining methods directly or form another query
            // var query3 = query1.Select(str => new { Name = str.ToLower() });
//            #endregion


            #region Deffered Excution
           




            #endregion




            #region Distinct , min , max , avg , take ,takeWile,skip and skipWile
            
            #endregion




            #region First, Last, FirstOrDefault , LastOrDefault and Single , SingleOrDefault  
            
            #endregion

            #region order  asec and desc

            //method
            
            #endregion


            #region  SelectMany and GroupBy
            
            #endregion

            #region let
            #endregion

        }
    }
}
