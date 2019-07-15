using System;
using System.Collections.Generic;
using System.Text;

namespace MultiInhiritance
{
    class Parent : IDisposable
    {
        // by default the access modifier is private
        // The object member data
        protected int x;
        protected int y;
        // the class data Static 
        static int Count;
        // static constructor can't be public 
        static  Parent()
        {
            Count = 0;
        }
        // default constructor
        public Parent()
        {
            x = y = 0;
            Count++;
        }
        // Parametrized Constructor
        public Parent(int x , int y , bool IsClass)
        {
            this.x = x;
            this.y = y;
            if (IsClass)//if not one from Inhirited
            {
                Count++;

            }
           
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public virtual int  Product()
        {
            return x * y;
        }
        public static int GetCount()
        {
            return Count;
        }
        bool is_disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!is_disposed) // only dispose once!
            {
                if (disposing)
                {
                    Console.WriteLine("Not in destructor, OK to reference other objects");
                }
                // perform cleanup for this object
                Console.WriteLine("Disposing...");
            }
            this.is_disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            // tell the GC not to finalize
            GC.SuppressFinalize(this);
        }
         ~Parent()
        {
            Count--;
            Dispose(false);
            Console.WriteLine("The Object is Destructed");
        }

    }
}
