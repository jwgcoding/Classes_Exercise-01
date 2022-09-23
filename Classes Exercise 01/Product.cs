using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Tracing;
using System.Text;
// TODO: Create a public Product class
namespace Classes_Exercise_01
{
    class Product
    {
        // TODO: Create a private field _productID of type long
        private long _productID;

        // TODO: Create a private field _productCount of type int
        private int _productCount;
        // TODO: Create a public Name property of type string
        public string Name { get; set; }
        // TODO: Create a public Price property of type double
        public double Price { get;set; }
        // TODO: Create a public CategoryID property of type int
        public int CategoryID { get; set; }
        // TODO: Create a public OnSale property of type bool
        public bool OnSale { get; set; }
        // TODO: Create a public StockLevel property of type int
        public int StockLevel { get; set; }

        // TODO: Create a default constructor that increments the _productCount every time a new product is created
        public Product()
        {
            _productCount++;
        }

        // TODO: Create a parameterized constructor that does the same thing and initializes all of the properties
        public Product(string name, double price, int category, bool onSale, int stockLevel)
        {
            _productCount++;
            Name = name;
            Price = price;
            CategoryID = category;
            OnSale = onSale;
            StockLevel = stockLevel;
            
        }
        // TODO: Create a method that gets the _productID and displays it creatively
        public static void ShowProductId(Product p)
        {
            Console.WriteLine($"The product id you are looking for is: {p._productID}");
        }
       
        // TODO: Create a method that sets the _productID
        public static void SetProductId(Product p, int id)
        {
            p._productID = id;
        }
       
        // TODO: Create a method that shows the current product count
        public static void ShowProductCount(Product p)
        {
            Console.WriteLine($"The total product count right now for your product is : {p._productCount}");
        }
       
    }
}
