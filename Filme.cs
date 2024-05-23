using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoExercicio;
{
    public class Filme : ItemLocadora
    {
            public string Diretor { get; set; }
    public int Duracao { get; set; }

    public Filme(int codigo, string titulo, int ano, string diretor, int duracao)
        : base(codigo, titulo, ano)
    {
        Diretor = diretor;
        Duracao = duracao;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Diretor: {Diretor}, Duracao: {Duracao} min";
    }

    }
}