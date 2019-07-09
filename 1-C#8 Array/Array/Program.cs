using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            m:
            Console.WriteLine(@"Enter The Number of Array Code :"
                             +"\n===================================================="+
                              "\n1 - 3 versions of Declaring Arrays"+
                              "\n2 - passing Array" 
                              +"\n3 - Return Array"
                              +"\n4- Index");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                declareArrays();
                goto m ;

                case 2:
                int[] arr = new int[]{-10,3,6};
               System.Console.WriteLine(PassArray(arr)); 
               goto m;

               case 3:
               System.Console.WriteLine(string.Join(" ",returnArray()));
               goto m;

               case 4:
               int[] r =new int[] {10,20};
               int[] z = new int[0];
               Index(r);
               Index(null);
               Index(z);
               goto m;

                default:
                goto m; 
            }         
        }

#region Declare versions Of String Arrays

        static void declareArrays()
        {
            //version 1
             string[] animals1 = new  string[3];
             animals1[0] ="deers";
             animals1[1]="moose";
             animals1[2] ="boars";
             System.Console.WriteLine("Animals1 :" +animals1.Length);
            //version 2
             string[] animals2 = new string[]{"deers", "moose", "boars"};
             System.Console.WriteLine("Animals2 :" +animals2.Length);
            //version 3
             string[] animals3 = {"deers", "moose", "boars"};
             System.Console.WriteLine("Animals3 :" +animals3.Length);


        }

#endregion
 
#region Int array, parameter.
       static int PassArray(int[] array)
       {
           return array[0]*2;
       }
#endregion 

#region  Return Array
        static string[] returnArray()
    {
        string[] array = new string[2];
        array[0] = "THANK";
        array[1] = "YOU";
        return array;
    }
#endregion
  
#region Index
 static void Index(int[] arr){

     if (arr.Length > 0&& arr !=null)
     {
         System.Console.WriteLine(arr[0]);
     }
 }  
    
#endregion

    }
}
