using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoExercicio;
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
    public virtual string ObterItem()
    {
       return $"Codigo: {Codigo}, Titulo: {Titulo}, Ano: {Ano}, Disponivel: {Disponivel}";
        
    }
}