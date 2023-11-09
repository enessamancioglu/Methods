namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

           Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya Apple";
            product1.Stock = 100;

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 75;
            product2.Description = "Diyarbakir Watermelon";
            product2.Stock = 200;

            Product[] products = { product1, product2 };



            foreach (var product in products)
            { 
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Stock);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("----------Methods------------");

            BasketManager basketManager = new BasketManager();
         
            basketManager.Add(product1);
            basketManager.Add(product2);

            BasketManager basketManager1 = new BasketManager();
            basketManager1.Add2(1,"erik",200,"Izmir erigi",500);

        }
    }
}