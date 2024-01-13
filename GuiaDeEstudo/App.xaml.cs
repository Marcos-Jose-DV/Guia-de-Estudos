using GuiaDeEstudo.Views;

namespace GuiaDeEstudo
{
    public partial class App : Application
    {
        public App(ListaDeCategoriaPage page)
        {
            InitializeComponent();

            MainPage = page;
        }
    }
}
