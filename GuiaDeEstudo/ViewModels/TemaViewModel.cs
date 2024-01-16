using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GuiaDeEstudo.Models;
using GuiaDeEstudo.Repositorios;
using System.Collections.ObjectModel;

namespace GuiaDeEstudo.ViewModels;

public partial class TemaViewModel : ObservableObject, IQueryAttributable
{
    private readonly IRepositorio _repositorio;
    private Categoria _categoria;

    [ObservableProperty]
    ObservableCollection<Tema> _temas;


    [ObservableProperty]
    string _nome;
    [ObservableProperty]
    bool _isRefreshing;

    public TemaViewModel(IRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        _categoria = (Categoria)query["Categoria"];

        Refresh();
    }
    void Load()
    {
        Nome = _categoria.Name;
        Temas = new ObservableCollection<Tema>(_categoria.Tema);
    }

    [RelayCommand]
    async Task Delete(Tema tema)
    {
        bool result = await Application.Current.MainPage.DisplayAlert("Excluir", "Deseja excluir esse tema?", "Sim", "Não");

        if (result)
        {
            _categoria.Tema.Remove(tema);
            _repositorio.PutCategoria(_categoria);
            Load();
        }
    }

    [RelayCommand]
    void Refresh()
    {
        try
        {
            IsRefreshing = true;
            Load();
        }
        finally
        {
            IsRefreshing = false;
        }
    }
}
