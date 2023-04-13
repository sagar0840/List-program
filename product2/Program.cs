using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace product2
{
    internal class item
    {
        internal static string key;
        internal static string value;
    }

    internal class product
    {
    }

    class Product
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int Price { get; internal set; }
    }

    internal class Program
    {
        private static IEnumerable<product> prod;

        static void Main(string[] args)
        {
            List<int> slist = new List<int>();
            slist.Add(1);
            slist.Add(2);
            slist.Add(3);

            foreach (int item in slist)
            {
                Console.WriteLine(item);
            }
            List<string> mlist = new List<string>();
            mlist.Add("pune");
            mlist.Add("mumbai");
            mlist.Add("delhi");


            foreach (string m in mlist) ;
            {
                Console.WriteLine(mlist);
            }
            List<Product> prodlist = new List<Product>();
            prodlist.Add(new Product { Id = 1, Name = "mouse", Price = 899 });
            {
                foreach (product productlist in prod) ;
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(91, "ind");
            dictionary.Add(92, "UAS");
            {
                foreach (KeyValuePair<int, string> item in dictionary) ;
                Console.WriteLine(item.key + "   " + item.value);
            }

        }
    }
}


    
    


