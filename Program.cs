using System;

namespace Odev
{
    internal class Program
    {
        private static void Main(string[] args)
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
            Console.WriteLine("- - - - - - - - - - - -");
            foreach (var urun in urunler)
            {
                Console.WriteLine($"Ürün Adı : {urun.ProductName} \nÜrün Fiyatı : {urun.productPrice} TL \nÜrün Adedi : {urun.ProductStockAmount}");
            }
            Console.WriteLine("for ile");
            Console.WriteLine("- - - - - - - - - - - -");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"Ürün Adı : {urunler[i].ProductName} \nÜrün Fiyatı : {urunler[i].productPrice} TL \nÜrün Adedi : {urunler[i].ProductStockAmount}");
            }

            Console.WriteLine("while ile");
            Console.WriteLine("- - - - - - - - - - - -");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine($"Ürün Adı : {urunler[j].ProductName} \nÜrün Fiyatı : {urunler[j].productPrice} TL \nÜrün Adedi : {urunler[j].ProductStockAmount}");
                j++;
            }
        }
    }

    internal class Products
    {
        public string ProductName { get; set; }
        public int productPrice { get; set; }
        public int ProductStockAmount { get; set; }
    }
}