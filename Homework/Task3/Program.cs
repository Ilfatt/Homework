using System;
using System.IO;

namespace Task3
{
    public delegate void Informs();

    static class Program
    {
        private static int _wallet ;

        private static void AddToWallet(int sum)
        {
            _wallet = _wallet + sum;
        }

        private static void SellProduct(Computer product, Informs del)
        {
            AddToWallet(product.Sell(del));
        }

        public static void Main()
        {
            string[] specificationsServer;
            string[] specificationsPc;
            string path = @"C:\Users\salav\Documents\Howework\hw-salavatyllinilfat\Task5\Specifications.txt";
            using (StreamReader specifications = new StreamReader(path))
            {
                specificationsServer = specifications.ReadLine().Split(' ');
                specificationsPc = specifications.ReadLine().Split(' ');
                specifications.Close();
            }

            var product3 = new Server(int.Parse(specificationsServer[0]), specificationsServer[1],
                int.Parse(specificationsServer[2]), int.Parse(specificationsServer[3]));
            var product4 = new Pc(int.Parse(specificationsPc[0]), int.Parse(specificationsPc[1]),
                specificationsPc[2], int.Parse(specificationsPc[3]), int.Parse(specificationsPc[4]));


            var product1 = new GamingLaptop(0, 85000, true, 2.1);
            var product2 = new Mackbook(1, 160000, true, 1.7);
            Console.WriteLine("У нас на складе осталось всего два ноутбука,первый игровой,а второй это 'Макбук' :");
            Console.WriteLine($"Первый: {product1.StorageTime}," +
                              $"{product1.Severity()}," +
                              $"{product1.HaveBacklight()}." +
                              $"А цена всего лишь {product1.Cost}");
            Console.WriteLine($"Второй: {product2.StorageTime}," +
                              $"{product2.Severity()}," +
                              $"{product2.HaveTouchBar()}." +
                              $"А цена всего лишь {product2.Cost}");
            Console.WriteLine($"Еще вы можете заказать {product4.ToString()} или {product3.ToString()}");


            Informs promotion = Discount;
            SellProduct(product1, promotion);
        }

        private static void Discount()
        {
            Console.WriteLine("У нас была акция и поэтому мы вам вернем  10 % от суммы покупки в течении " +
                              "14 дней если вы не вернете товар .");
        }
    }
} World!");