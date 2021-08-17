using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Store
    {
        Article[] articles = { new Article("A", "AA", 5), new Article("B", "BB", 10), new Article("C", "CC", 15), new Article("D", "DD", 20), new Article("E", "EE", 25) };

        public void PrintByIndex(int index)
        {
            Console.WriteLine($"Product info by index {index}:  \n Prod title: {articles[index].ProductTitle} \n Store title: {articles[index].StoreTitle} \n Prod price: {articles[index].ProductPrice}");
        }

        public void PrintByTitle(string prodTitle)
        {
            bool flag = false;
            int index = 0;
            for (int i =0; i < articles.Length; i++)
            {
                if (articles[i].ProductTitle == prodTitle)
                {
                    flag = true;
                    index = i;
                }
                    
            }
            if (flag == true)
                Console.WriteLine($" Prod title: {articles[index].ProductTitle} \n Store title: {articles[index].StoreTitle} \n Prod price: {articles[index].ProductPrice}");
            else
                Console.WriteLine("There is no such product");

        }
    }
}
