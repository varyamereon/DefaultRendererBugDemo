using MvvmHelpers;
using System.Collections.Generic;

namespace DefaultRendererBugDemo.Models
{
	public class Book : ObservableObject
	{
		private string name;
		public string Name
		{
			get => name;
			set => SetProperty(ref name, value);
		}

		private string author;
		public string Author
		{
			get => author;
			set => SetProperty(ref author, value);
		}

		public override string ToString() => Name;

		public static List<Book> Books => new List<Book>()
		{
			new Book()
			{
				Author="JK Rowling",
				Name="Harry Potter"
			},
			new Book()
			{
				Author="JK Rowling",
				Name="Fantastic Beasts"
			},
			new Book()
			{
				Author="JRR Tolkein",
				Name="Lord of the Rings"
			}
		};
	}
}
