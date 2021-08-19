using System;

namespace Deneme123123
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                

                Products product1 = new Product();
                product1.ProductName = "Elma";
                product1.Price= 75;
                product1.Stars = 5;

                Products product2 = new Product();
                product2.ProductName = "armut";
                product2.Price = 44;
                product2.Stars = 2;

                Products product3 = new Product();
                product3.ProductName = "ayva";
                product3.Price = 32;
                product3.Stars = 4;



                

                Product[] Products = new Product[] { product1, product2, product3};
                foreach (var kurs in kurslar)
                {
                    Console.WriteLine(product.ProductName + " : " + product.Price +" : "+product.Stars);
                }
            }
        }
        class Products
        {

            public string ProductName { get; set; }

            public int  Price { get; set; }

            public int  Stars { get; set; }

        }
    }
        }
    }
    }

