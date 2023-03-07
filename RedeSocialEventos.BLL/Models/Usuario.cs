using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Usuario
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public string Apelido { get; set; }

    public string FotoPerfil { get; set; }

    public DateTime DataNascimento { get; set; }

    public string? Genero { get; set; }

    public string? Pronome { get; set; }

    public string Cidade { get; set; }

    public string Bio { get; set; }

}

