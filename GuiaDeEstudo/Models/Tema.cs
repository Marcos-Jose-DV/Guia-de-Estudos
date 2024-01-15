using LiteDB;

namespace GuiaDeEstudo.Models;

public class Tema
{
    [BsonId]
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Concluido { get; set; }
    public int Realizado { get; set; }
    public int Acerto { get; set; }
    public double Percentual => (double)Acerto / (double)Realizado * 100;
}