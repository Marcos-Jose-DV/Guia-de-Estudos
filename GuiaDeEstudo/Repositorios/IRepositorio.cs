using GuiaDeEstudo.Models;

namespace GuiaDeEstudo.Repositorios;

public interface IRepositorio
{
    List<Categoria> GetAll();
    void PostCategoria(Categoria categoria);
    void PutCategoria(Categoria categoria);
    void DeleteCategoria(Categoria categoria);
    void DeleteAll();
}
