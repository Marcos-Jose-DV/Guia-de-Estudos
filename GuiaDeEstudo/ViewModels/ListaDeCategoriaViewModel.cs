using CommunityToolkit.Mvvm.ComponentModel;
using GuiaDeEstudo.Models;
using GuiaDeEstudo.Repositorios;

namespace GuiaDeEstudo.ViewModels;

public partial class ListaDeCategoriaViewModel : ObservableObject
{
    private readonly IRepositorio _repositorio;
    [ObservableProperty]
    List<Categoria> _categorias = new List<Categoria>();


    public ListaDeCategoriaViewModel(IRepositorio repositorio)
    {
        _repositorio = repositorio;
        //SeedData();

        Categorias = _repositorio.GetAll();
    }

    private void SeedData()
    {
        var categorias = new Categoria
        {

            Id = 1,
            Name = "Matemática",
            Tema = new List<Tema>
            {
                new Tema
                {
                    Id = 1,
                    Title = "Álgebra",
                    Concluido = true,
                    Realizado = 10,
                    Acerto = 8,
                    Percentual = 80.0
                },
                new Tema
                {
                    Id = 2,
                    Title = "Geometria",
                    Concluido = false,
                    Realizado = 5,
                    Acerto = 4,
                    Percentual = 80.0
                }
            }
        };
       
        _repositorio.PostCategoria(categorias);

        categorias = new Categoria
        {
            Id = 2,
            Name = "Ciências",
            Tema = new List<Tema>
                {
                    new Tema
                    {
                        Id = 3,
                        Title = "Biologia",
                        Concluido = true,
                        Realizado = 8,
                        Acerto = 7,
                        Percentual = 87.5
                    },
                    new Tema
                    {
                        Id = 4,
                        Title = "Química",
                        Concluido = false,
                        Realizado = 3,
                        Acerto = 2,
                        Percentual = 66.7
                    }
                }
        };

        _repositorio.PostCategoria(categorias);
    }
}
