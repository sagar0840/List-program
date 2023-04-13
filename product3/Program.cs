



namespace product3
{
    internal class Program
    {
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
            {
                foreach (string p in mlist) ;
                {
                    Console.WriteLine(p);
                }
                List<Product> productlist = new List<Product>();
                productlist.Add(new Product { Id = 1, Name = "mouse", Price = 899 });
                {
                    foreach (product productlist in product) ;
                }
            }
    }
}
