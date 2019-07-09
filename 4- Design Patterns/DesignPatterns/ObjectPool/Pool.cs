using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
     public class Pool<T> where T : new()
    {
        List<T> Available = new List<T>();
        List<T> InUse = new List<T>();

        public T Get()
        {
            lock(Available){
                if (Available.Count != 0)
                {
                    T obj = Available[0];
                    InUse.Add(obj);
                    Available.RemoveAt(0);
                    return obj;
                }
                else
                {
                    T obj = new T();
                    InUse.Add(obj);
                    return obj;
                    
                }
            }
        }


        public void Relese(T obj)
        {
            CleanUp(obj);
            lock (Available)
            {
                Available.Add(obj);
                InUse.Remove(obj);
            }

        }

        private void CleanUp(T obj)
        {
          // Any Code For cleaning
        }
    }


}
