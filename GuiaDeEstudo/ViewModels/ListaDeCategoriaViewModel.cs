using CommunityToolkit.Mvvm.ComponentModel;
using GuiaDeEstudo.Models;
using GuiaDeEstudo.Repositorios;
using GuiaDeEstudo.Views;
using System.Windows.Input;

namespace GuiaDeEstudo.ViewModels;

public partial class ListaDeCategoriaViewModel : ObservableObject
{
    private readonly IRepositorio _repositorio;
    [ObservableProperty]
    List<Categoria> _categorias = new List<Categoria>();

    [ObservableProperty]
    bool _isVisibleForm;


    public ICommand NavigationCategoriaCommand
        => new Command<Categoria>(NavigationCategoria);

    private async void NavigationCategoria(Categoria categoria)
    {
        var navigationParameter = new Dictionary<string, object>
        {
            { "Categoria", categoria }
        };
        await Shell.Current.GoToAsync($"TemaPage", navigationParameter);
    }

    public ListaDeCategoriaViewModel(IRepositorio repositorio)
    {
        _repositorio = repositorio;
        //Delete();
        //SeedData();

        var c = _repositorio.GetAll();
        Categorias = c;
    }

    private void SeedData()
    {
        var categoriasPortuguesa = new Categoria
        {
            Name = "Língua Portuguesa",
            Created = DateTime.UtcNow,
            Tema = new List<Tema>
            {
                new Tema { Title = "Compreensão e Interpretação de Textos", Concluido = true, Realizado = 10, Acerto = 8 },
                new Tema { Title = "Tipologia Textual", Concluido = false, Realizado = 5, Acerto = 4 },
                new Tema { Title = "Ortografia", Concluido = true, Realizado = 7, Acerto = 6 },
                new Tema { Title = "Gramática", Concluido = false, Realizado = 4, Acerto = 3 },
                new Tema { Title = "Literatura", Concluido = true, Realizado = 9, Acerto = 8 },
                new Tema { Title = "Novo Tema 1", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Novo Tema 2", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Novo Tema 3", Concluido = true, Realizado = 6, Acerto = 5 },
                new Tema { Title = "Novo Tema 4", Concluido = false, Realizado = 4, Acerto = 3 },
                new Tema { Title = "Novo Tema 5", Concluido = true, Realizado = 7, Acerto = 6 },
                new Tema { Title = "Novo Tema 6", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Novo Tema 7", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Novo Tema 8", Concluido = true, Realizado = 6, Acerto = 5 },
                new Tema { Title = "Novo Tema 9", Concluido = false, Realizado = 4, Acerto = 3 },
                new Tema { Title = "Novo Tema 10", Concluido = true, Realizado = 7, Acerto = 6 },
                new Tema { Title = "Novo Tema 11", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Novo Tema 12", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Novo Tema 13", Concluido = true, Realizado = 6, Acerto = 5 },
            }
        };

        _repositorio.PostCategoria(categoriasPortuguesa);

        var categoriasMatematica = new Categoria
        {
            Name = "Matemática",
            Created = DateTime.UtcNow,
            Tema = new List<Tema>
            {
                new Tema { Title = "Raiz Quadrada", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Regra de 2", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Álgebra", Concluido = true, Realizado = 6, Acerto = 5 },
                new Tema { Title = "Geometria", Concluido = false, Realizado = 4, Acerto = 3 },
                new Tema { Title = "Trigonometria", Concluido = true, Realizado = 7, Acerto = 6 },
                new Tema { Title = "Novo Tema 1", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Novo Tema 2", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Novo Tema 3", Concluido = true, Realizado = 6, Acerto = 5 },
                new Tema { Title = "Novo Tema 4", Concluido = false, Realizado = 4, Acerto = 3 },
                new Tema { Title = "Novo Tema 5", Concluido = true, Realizado = 7, Acerto = 6 },
                new Tema { Title = "Novo Tema 6", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Novo Tema 7", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Novo Tema 8", Concluido = true, Realizado = 6, Acerto = 5 },
                new Tema { Title = "Novo Tema 9", Concluido = false, Realizado = 4, Acerto = 3 },
                new Tema { Title = "Novo Tema 10", Concluido = true, Realizado = 7, Acerto = 6 },
                new Tema { Title = "Novo Tema 11", Concluido = true, Realizado = 8, Acerto = 7 },
                new Tema { Title = "Novo Tema 12", Concluido = false, Realizado = 3, Acerto = 2 },
                new Tema { Title = "Novo Tema 13", Concluido = true, Realizado = 6, Acerto = 5 },
            }
        };

        _repositorio.PostCategoria(categoriasMatematica);
    }
    void Delete()
    {
        _repositorio.DeleteAll();
    }
}
