using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class ItemLocadora
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public ItemLocadora(int codigo, string titulo, int ano)
    {
        Codigo = codigo;
        Titulo = titulo;
        Ano = ano;
    }


        
    }
}