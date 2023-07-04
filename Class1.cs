using System;
using System.Collections.Generic;

namespace ClassLibrary
{
	public class Garage
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public List<Car> Cars = new List<Car>();

		public Garage(string name, string address)
		{
			Name = name;
			Address = address;
		}

		public void ShowAll()
		{
			Console.Write("Гараж:\n" +
				$"\tНазвание: {Name}\n" +
				$"\tАдрес: {Address}\n\n" +
				"Список машин:\n");

			Cars.Sort();
			foreach (var car in Cars)
			{
				car.Show();
			}
		}
	}

	public class Car : IComparable<Car>
	{
		public string Owner { get; set; }
		public string Number { get; set; }

		public Car(string owner, string number)
		{
			Owner = owner;
			Number = number;
		}

		public int CompareTo(Car other)
		{
			return Owner.CompareTo(other.Owner);
		}

		// Этот метод выводит информацию о машине
		public void Show()
		{
			Console.WriteLine("Машина:\n" +
				$"\tВладелец: {Owner}\n" +
				$"\tНомер: {Number}");
		}
	}
}
