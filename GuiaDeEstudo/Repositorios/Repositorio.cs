using GuiaDeEstudo.Models;
using LiteDB;

namespace GuiaDeEstudo.Repositorios;

public class Repositorio : IRepositorio
{
    private readonly LiteDatabase _database;
    private readonly string collectionName = "categorias";
    public Repositorio(LiteDatabase database)
    {
        _database = database;
    }
   
    public List<Categoria> GetAll()
    {
        return _database
              .GetCollection<Categoria>(collectionName)
              .Query()
              .OrderByDescending(x => x.Created)
              .ToList();
    }

    public void PostCategoria(Categoria categoria)
    {
        var col = _database.GetCollection<Categoria>(collectionName);
        col.Insert(categoria);
        col.EnsureIndex(x => x.Created);
    }

    public void PutCategoria(Categoria categoria)
    {
        var col = _database.GetCollection<Categoria>(collectionName);
        col.Update(categoria);
    }
    public void DeleteCategoria(Categoria categoria)
    {
        var col = _database.GetCollection<Categoria>(collectionName);
        col.Delete(categoria.Id);
    }
    public void DeleteAll()
    {
        _database.GetCollection(collectionName).DeleteAll();
    }
}
