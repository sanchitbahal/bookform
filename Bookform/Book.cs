using System.Collections.Generic;

namespace Bookform
{
	public class Book
	{
		public string Name { get; private set; }

		public string Image { get; private set; }

		public Book(string name, string image)
		{
			Name = name;
			Image = image;
		}

		public static List<Book> All { 
			get {
				return new List<Book> {
					new Book("Book 1", "The_Secret"),
					new Book("Book 2", "The_Secret"),
					new Book("Book 3", "The_Secret"),
					new Book("Book 4", "The_Secret"),
					new Book("Book 5", "The_Secret")
				}; 
			} 
		}
	}
}

