using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyon
{
    class Class1
    {
        class MyList<T>
        {
            T[] items;

            public MyList()
            {
                items = new T[0];
            }

            public void Add(T item)
            { 
                T[] tempArray = items;
                items = new T[items.Length+1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                   items[i] = tempArray[i];

                }

                items[items.Length - 1] = item;



            }

            static void Main(string[] args)
            {

                //List<string>  isimler1 = new List<string>{"Ali","Murat","Taner","Taha"};
                //Console.WriteLine(isimler1[0] );
                //Console.WriteLine(isimler1[1]);
                //Console.WriteLine(isimler1[2]);
                //Console.WriteLine(isimler1[3]);
                //isimler1.Add("Burak");
                //Console.WriteLine(isimler1[4]);
                //Console.WriteLine(isimler1[0]);











            }

        }
    }
}
