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

            List<Computer> products = new List<Computer>();

            products.Add(new Server( specificationsServer[1],
                int.Parse(specificationsServer[2]), int.Parse(specificationsServer[3])));
            products.Add(new Pc(int.Parse(specificationsPc[0]),
                specificationsPc[2], int.Parse(specificationsPc[3]), int.Parse(specificationsPc[4])));


            products.Add(new GamingLaptop(0, true, 2.1));
            products.Add(new Macbook(1,  true, 1.7));
            Console.WriteLine("У нас на складе осталось всего два ноутбука,первый игровой,а второй это 'Макбук' :");
            Console.WriteLine($"Первый: {products[2].StorageTime}," +
                              $"А цена всего лишь {products[2].Cost}");
            Console.WriteLine($"Второй: {products[3].StorageTime}," +
                              $"А цена всего лишь {products[3].Cost}");
            Console.WriteLine($"Еще вы можете заказать {products[1].ToString()} или {products[1].ToString()}");


            Informs promotion = Discount;
            SellProduct(products[3], promotion);
        }

        private static void Discount()
        {
            Console.WriteLine("У нас была акция и поэтому мы вам вернем  10 % от суммы покупки в течении " +
                              "14 дней если вы не вернете товар .");
        }
    }
}