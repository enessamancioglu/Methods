using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Thanks.Added to Basket:"+product.Name);
        }

        public void Add2(int productId,string productName,double productPrice,string productDescription,int stock)
        {
            Console.WriteLine(productId+productName+productPrice+productDescription+stock);
        }
    }
}
