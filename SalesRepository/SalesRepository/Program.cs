using SalesRepository.Data_Access_Layer;
using SalesRepository.Sales_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesCustomerBusiness customerBusiness = new SalesCustomerBusiness(new CustomerRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'I' for Insert, 'U' for Update, 'R' for Remove, 'S' for Search, 'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Customer> _listCustomer = customerBusiness.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("CustomerID   |   CustomerName   |  CustomerAddress");
                        foreach (Customer _customer in _listCustomer)
                        {
                            Console.WriteLine(_customer.CustomerId + "            |         " + _customer.CustomerName + "        |         " + _customer.CustomerAddress);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a CustomrId to find a Customer:");
                        string id = Console.ReadLine();
                        Customer aCstomer = customerBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aCstomer.CustomerId + ". " + aCstomer.CustomerName + " -- " + aCstomer.CustomerAddress);
                    }
                    else if (command == "I")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Customer aCustomer = new Customer();
                        aCustomer.CustomerId = Convert.ToInt32(id);
                        aCustomer.CustomerName = name;
                        aCustomer.CustomerAddress = address;
                        bool isExecuted = customerBusiness.Add(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Insert.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Customer aCustomer = new Customer();
                        aCustomer.CustomerId = Convert.ToInt32(id);
                        aCustomer.CustomerName = name;
                        aCustomer.CustomerAddress = address;
                        bool isExecuted = customerBusiness.Update(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Update.");
                        }
                    }
                    else if (command == "R")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = customerBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Successfully Removed.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Remove.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
