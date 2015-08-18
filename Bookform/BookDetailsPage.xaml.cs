using Xamarin.Forms;

namespace Bookform
{
	public partial class BookDetailsPage : ContentPage
	{
		public BookDetailsPage(Book selectedBook)
		{
			InitializeComponent();

			BindingContext = selectedBook;
		}
	}
}

