using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_601_10.Customers;

namespace Assignment_601_10.managers
{
    internal class CustomerManager
    {
        private List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"Đã thêm khách hàng: {customer.Name}");
        }

        public void Update(string name, Customer updatedCustomer)
        {
            var customer = customers.FirstOrDefault(c => c.Name == name);
            if (customer != null)
            {
                customer.Email = updatedCustomer.Email;
                customer.Number = updatedCustomer.Number;
                customer.Tickets = updatedCustomer.Tickets;
                Console.WriteLine($"Đã cập nhật thông tin khách hàng: {name}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy khách hàng tên: {name}");
            }
        }

        public void Remove(string name)
        {
            var customer = customers.FirstOrDefault(c => c.Name == name);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine($"Đã xóa khách hàng: {name}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy khách hàng tên: {name}");
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("----- Danh sách khách hàng -----");
            if (customers.Count == 0)
            {
                Console.WriteLine("Không có khách hàng nào.");
            }
            else
            {
                foreach (var customer in customers)
                {
                    customer.Print();
                    Console.WriteLine("--------------------------------");
                }
            }
        }

        public void Print(string name)
        {
            var customer = customers.FirstOrDefault(c => c.Name == name);
            if (customer != null)
            {
                customer.Print();
            }
            else
            {
                Console.WriteLine($"Không tìm thấy khách hàng tên: {name}");
            }
        }
    }
}
