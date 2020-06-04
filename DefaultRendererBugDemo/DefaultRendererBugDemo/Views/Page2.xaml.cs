using DefaultRendererBugDemo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DefaultRendererBugDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		private readonly Page2ViewModel viewModel;

		public Page2()
		{
			InitializeComponent();

			viewModel = (Page2ViewModel)BindingContext;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			viewModel.OnAppearing();
		}
	}
}