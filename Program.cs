using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products1 = new Products();
            products1.ProductName = "Keyboard";
            products1.productPrice = 350;
            products1.ProductStockAmount = 150;

            Products products2 = new Products();
            products2.ProductName = "Mouse";
            products2.productPrice = 120;
            products2.ProductStockAmount = 80;

            Products products3 = new Products();
            products3.ProductName = "Monitor";
            products3.productPrice = 1500;
            products3.ProductStockAmount = 50;
               

            Products[] urunler = new Products[]
            {
                products1, products2, products3
            };

            Console.WriteLine("foreach ile");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ProductName + " : " + urun.productPrice);
            }
            Console.WriteLine("for ile");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ProductName + " : " + urunler[i].productPrice);
            }

            Console.WriteLine("while ile");
            
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].ProductName + " : " + urunler[j].productPrice);
                j++;
            }
        }
    }

    class Products
    {
        public string ProductName { get; set; }
        public int  productPrice { get; set; }
        public int ProductStockAmount { get; set; }
    }
}
