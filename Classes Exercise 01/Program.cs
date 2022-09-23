using Classes_Exercise_01;
using System;

namespace Classes_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region// TODO: Create a public Employee class

            // Inside of the Employee class:
            // Thought experiment: (True or False) We can instantiate this class with a default constructor
            // TODO: false (bc we created a parameterized constructor we overrided the default. So, if we want to be able to use the default we must explicitly type it out)

            #endregion

            #region // TODO: Create a public Product class 


            #endregion
            // TODO: Create a new employee and give all of its properties values

            var employee1 = new Employee("Gary", ' ', "Li", "mail@email.com", "41522222222", "CEO", DateTime.Today);




            // TODO: Call all of the methods you created inside of that class
            Employee.SetPassword(employee1, "Garyspassword");
            Employee.ShowPassword(employee1);
            Employee.EmployeeReport(employee1);

            // TODO: Create a new product and give all of its properties values
            var product1 = new Product()
            {
                Name = "Car",
                   Price = 1023.23,
                    CategoryID = 123,
                    OnSale = true,
            StockLevel = 300000,
        };

            // TODO: Call all of the methods you created inside of that class
            Product.SetProductId(product1, 11);
            Product.ShowProductId(product1);
            Product.ShowProductCount(product1);
        }
    }
}
