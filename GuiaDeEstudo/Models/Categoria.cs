using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDeEstudo.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Tema> Tema { get; set; }
}
public class Tema
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Concluido { get; set; }
    public int Realizado { get; set; }
    public int Acerto { get; set; }
    public double Percentual { get; set; }
}