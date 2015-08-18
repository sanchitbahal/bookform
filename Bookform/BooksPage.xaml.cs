using Xamarin.Forms;
using System.Net.Http;

namespace Bookform
{
	public partial class BooksPage : ContentPage
	{
		public BooksPage()
		{
			InitializeComponent();

			getBooks();
		}

		async void getBooks()
		{
			using (var service = new BookService(new HttpClient())) {
				var books = await service.GetBooksAsync();
				Book.All = books;
				Device.BeginInvokeOnMainThread(() => lstBooks.ItemsSource = books);

			}
		}
	}
}
