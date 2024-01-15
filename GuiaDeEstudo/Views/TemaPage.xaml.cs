using GuiaDeEstudo.ViewModels;

namespace GuiaDeEstudo.Views;

public partial class TemaPage : ContentPage
{
	public TemaPage(TemaViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}