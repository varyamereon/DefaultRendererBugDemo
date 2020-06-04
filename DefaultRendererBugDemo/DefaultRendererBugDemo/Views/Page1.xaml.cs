
using DefaultRendererBugDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DefaultRendererBugDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		private Page1ViewModel viewModel;

		public Page1()
		{
			InitializeComponent();

			viewModel = (Page1ViewModel)BindingContext;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			viewModel.OnAppearing();
		}
	}
}