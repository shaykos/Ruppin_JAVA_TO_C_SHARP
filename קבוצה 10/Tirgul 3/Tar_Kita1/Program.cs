using System.Net;

namespace Tar_Kita1
{
    // המחלקה הראשית של התוכנית
    internal class Program
    {
        static void Main(string[] args)
        {
            //// יצירת אובייקט של המוצר
            //Product p1 = new Product("iPhone", 999); // הפעלת הבנאי של המחלקה עם שם ומחיר

            //// הצגת המידע של המוצר
            //p1.Show();

            ////private vs public
            //Console.WriteLine(p1.name); // ניתן לגשת לשם כי הוא public
            ////Console.WriteLine(p1.price); // לא ניתן לגשת למחיר כי הוא private

            //p1.name = "iPhone 14"; // ניתן לשנות את השם כי הוא public
            //p1.Show();

            /*
             Product[] products =
            {
                new Product("iPhone", 999),
                new Product("Samsung Galaxy", 899),
                new Product("Google Pixel", 799)
            };
             */

            Product[] products = new Product[3];
            products[0] = new Product("iPhone", 999);
            products[1] = new Product("Samsung Galaxy", 899);
            products[2] = new Product("Google Pixel", 799);

            foreach (Product p in products)
            {
                p.Show();
            }
        }
    }

    //המחלקה של המוצר
    internal class Product
    {
        //שדות של המחלקה
        public string name;
        private int price;


        //בנאי של המחלקה
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}, Price: {price}");
        }

        public void ApplyDiscount(int amount)
        {
            if (price - amount > 0)
                price -= amount;
        }
    }

}
