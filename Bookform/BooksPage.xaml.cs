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
				BindingContext = books;
				Device.BeginInvokeOnMainThread(() => lstBooks.ItemsSource = books);
			}
		}

		async void onItemTapped(object sender, ItemTappedEventArgs args)
		{
			var bookDetailsPage = new BookDetailsPage((Book)args.Item);
			await Navigation.PushAsync(bookDetailsPage);
		}
	}
}
