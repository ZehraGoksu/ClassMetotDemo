using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	class CustomerManager
	{
			List<Customer> customers = new List<Customer>();

			public void List(Customer customer)
			{
				foreach (var item in customers)
				{
					Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + "  " + item.Age + " " + item.Email);
				}
			}
			public void Add(Customer customer)
			{
				Console.WriteLine(customer.Name + " " + "adlı müşteri başarılı bir şekilde kaydedildi.");

			}

			public void Delete(Customer customer)
			{
				Console.WriteLine(customer.Name + " " + "adlı müşteri başarılı bir şekilde silindi.");

			}

		
	 }
	
}
