using System;
using System.Collections.Generic;

namespace Restaurant
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		public class Menu
		{
			public static List<MenuItem> Items = new List<MenuItem>();
			public static List<string> CategoryList = new List<string>();
		}

		public class MenuItem
		{
			public string name;
			public double price;
			public string description;
			public string category;
			public string status;
			public DateTime lastEditted;

			public MenuItem(string itemName,double itemPrice, string itemDescription,string itemCategory, string itemStatus, DateTime whenLastEditted)
			{
				name = itemName;
				price = itemPrice;
				description = itemDescription;
				category = itemCategory;
				status = itemStatus;
				lastEditted = whenLastEditted;
			}
		}

		public class DisplayMenu
		{
			public void Display()
			{
				//Print items to be displayed
			}

			public void DisplayMenuOptions()
			{
				//Provide the user options as what of the menu they want displayed aka pick category if wanted
			}
		}

		public class EditMenu
		{
			public static void CreateItem()
			{
				//Create new item
			}

			public static void AddItem()
			{
				//Add item to menu
			}

			public static void RemoveItem()
			{
				//Get item to remove and take it off the menu
			}

			public static void EradicateItem()
			{
				//Completely delete item from existing
			}
		}
	}
}
