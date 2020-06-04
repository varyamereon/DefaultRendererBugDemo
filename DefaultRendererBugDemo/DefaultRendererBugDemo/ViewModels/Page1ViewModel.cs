using DefaultRendererBugDemo.Models;
using MvvmHelpers;
using System.Collections.ObjectModel;

namespace DefaultRendererBugDemo.ViewModels
{
	public class Page1ViewModel : BaseViewModel
	{
		private ObservableCollection<Book> books;
		public ObservableCollection<Book> Books
		{
			get => books;
			set => SetProperty(ref books, value);
		}

		public Page1ViewModel()
		{
			//Books = new ObservableCollection<Book>(Book.Books);
		}

		internal void OnAppearing()
		{
			Books = new ObservableCollection<Book>(Book.Books);
		}
	}
}
