using System;
using System.Collections.Generic;

namespace ProductGroups
{
    class Program
    {
        enum ProductGroup
        {
            Clothing,
            Footwear,
            Electronics
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> products = new Dictionary<int, string>()
            {
                { 1, "Футболка" },
                { 2, "Джинси" },
                { 3, "Сукня" },
                { 4, "Чоботи" },
                { 5, "Кросівки" },
                { 6, "Телевізор" },
                { 7, "Смартфон" },
                { 8, "Ноутбук" },
                { 9, "Планшет" }
            };

            string author = "Тараненко";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Перелік товарів:");
            Console.WriteLine();
            Console.WriteLine("Одяг:");
            PrintProductsByGroup(ProductGroup.Clothing, products);
            Console.WriteLine();

            Console.WriteLine("Взуття:");
            PrintProductsByGroup(ProductGroup.Footwear, products);
            Console.WriteLine();

            Console.WriteLine("Електротовари:");
            PrintProductsByGroup(ProductGroup.Electronics, products);
            Console.WriteLine();

            Console.WriteLine("Введіть номери товарів, які ви бажаєте придбати:");
            string input = Console.ReadLine();
            string[] selectedProducts = input.Split(',');

            Console.WriteLine("Ви обрали наступні товари:");

            List<string> selectedClothing = new List<string>();
            List<string> selectedFootwear = new List<string>();
            List<string> selectedElectronics = new List<string>();

            foreach (string selectedProduct in selectedProducts)
            {
                int productNumber = int.Parse(selectedProduct.Trim());
                if (products.ContainsKey(productNumber))
                {
                    string productName = products[productNumber];
                    ProductGroup group = GetProductGroup(productNumber);

                    switch (group)
                    {
                        case ProductGroup.Clothing:
                            selectedClothing.Add(productName);
                            break;
                        case ProductGroup.Footwear:
                            selectedFootwear.Add(productName);
                            break;
                        case ProductGroup.Electronics:
                            selectedElectronics.Add(productName);
                            break;
                    }
                }
            }

            Console.WriteLine("Одяг:");
            foreach (string clothing in selectedClothing)
            {
                Console.WriteLine(clothing);
            }
            Console.WriteLine();

            Console.WriteLine("Взуття:");
            foreach (string footwear in selectedFootwear)
            {
                Console.WriteLine(footwear);
            }
            Console.WriteLine();

            Console.WriteLine("Електротовари:");
            foreach (string electronics in selectedElectronics)
            {
                Console.WriteLine(electronics);
            }
            Console.WriteLine();

            Console.WriteLine("Автор програми: " + author);
            Console.ReadLine();
        }

        static void PrintProductsByGroup(ProductGroup group, Dictionary<int, string> products)
        {
            foreach (KeyValuePair<int, string> product in products)
            {
                if (GetProductGroup(product.Key) == group)
                {
                    Console.WriteLine(product.Key + " - " + product.Value);
                }
            }
        }

        static ProductGroup GetProductGroup(int productNumber)
        {
            if (productNumber <= 3)
            {
                return ProductGroup.Clothing;
            }
            else if (productNumber <= 5)
            {
                return ProductGroup.Footwear;
            }
            else
            {
                return ProductGroup.Electronics;
            }
        }
    }
}