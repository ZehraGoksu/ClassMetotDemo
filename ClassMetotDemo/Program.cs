using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			
				Customer customer1 = new Customer { Id = 1, Name = "Fuat", Surname = "Kara", Age = 25, Email = "123@gmail.com" };
				Customer customer2 = new Customer { Id = 2, Name = "Oktay", Surname = "Güzel", Age = 56, Email = "wygrg@gmail.com" };
				Customer customer3 = new Customer { Id = 3, Name = "Funda", Surname = "Hane", Age = 73, Email = "fhbf@gmail.com" };
				Customer customer4 = new Customer { Id = 4, Name = "Sanem", Surname = "Varlı", Age = 34, Email = "fbhf@gmail.com" };
				Customer customer5 = new Customer { Id = 5, Name = "Tilbe", Surname = "Kendi", Age = 39, Email = "xsfb@gmail.com" };

				CustomerManager manager = new CustomerManager();
				manager.Add(customer3);
				manager.Delete(customer5);

				Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };
				foreach (var item in customers)
				{
					Console.WriteLine(item.Id + "." + item.Name + " " + item.Surname + "  Yaş: " + item.Age + "  E-Posta " + item.Email);

				}

			
		}
	}
	
}
	