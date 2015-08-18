using System.Collections.Generic;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Xamarin.Forms;

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

		public static List<Book> All = new List<Book>();
	}
}

