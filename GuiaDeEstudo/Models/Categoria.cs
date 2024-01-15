using LiteDB;
using System.ComponentModel.DataAnnotations;

namespace GuiaDeEstudo.Models;

public class Categoria
{
    [BsonId]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Tema> Tema { get; set; }
    public DateTime Created { get; set; }
}
