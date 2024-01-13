using GuiaDeEstudo.ViewModels;

namespace GuiaDeEstudo.Views;

public partial class ListaDeCategoriaPage : ContentPage
{
	public ListaDeCategoriaPage(ListaDeCategoriaViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}