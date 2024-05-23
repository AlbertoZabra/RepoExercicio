// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using ConsoleApp1;

// ***********************************************************************************************************************
// -------- Para criar um novo projeto, crie uma nova janela e abra uma pasta que esta pasta se tornará seu novo namespace
// -------- em seguida abra um novo terminal e digite: dotnet new console



// ------------- Lampada.cs
// var minhaLampada = new Lampada();
// System.Console.WriteLine(minhaLampada.Intensidade);//cw<tab> criar o console.writeline
// //minhaLampada.Estado = true;
// minhaLampada.Intensidade = 50; //comentar ctrl;
// System.Console.WriteLine(minhaLampada.Intensidade);//cw<tab>
// System.Console.WriteLine(minhaLampada.LampadaLigada());

// ------------- Contador.cs
// var meuContador = new Contador();

// meuContador.Incrementar();
// meuContador.Incrementar();
// meuContador.Incrementar();
// meuContador.Decrementar();

//------------- Termometro.cs
// var meuTermometro = new Termometro();

// meuTermometro.DefinirFaixaTemperatura(18.0,24.0);
// meuTermometro.AjustarTemperatura(30);
// meuTermometro.AjustarTemperaturaCelsius(22);


// System.Console.WriteLine(meuTermometro.MostrarTemperatura());
// System.Console.WriteLine(meuTermometro.LerTemperatura());

//-------Laços

    // for (int i = 0; i < 10; i++)
    // {
    //     System.Console.WriteLine(i);
    // }

//-------Array
//  int[] numeros = [1,2,3,4,5];
// System.Console.WriteLine(numeros[4]);
// foreach (var item in numeros)
// {
//     System.Console.WriteLine(item);
// }

// int idade = 34;

// if (idade >= 13 && idade <= 17)
// {
//     System.Console.WriteLine($"Adolescente de {idade} anos");    
// }else if (idade >= 18 && idade <=35)
// {
//     System.Console.WriteLine($"Jovem de {idade} anos");
// }else if (idade >= 36 && idade <=59 )
// {
//     System.Console.WriteLine($"Adulto de {idade} anos");
// }else{System.Console.WriteLine($"Idoso de {idade} anos");}



// Smartphone Celular = new Smartphone("SamSung","S20",2020,"Android",80);
// Celular.Ligar();

// System.Console.WriteLine(Celular.ObterDescricao());  
// Tablet tablet = new Tablet("Apple","Ipad",2019,8,76);
// System.Console.WriteLine(tablet.ObterDescricao());


// Cobertura Chocolatudo = new Cobertura("Chocolate",1000,"Ninho","Chocolate");
// Chocolatudo.AddSabor();
// System.Console.WriteLine(Chocolatudo.FinalizarBolo()); 


// Exercicio de Pilha na sala de aula ----------------------------------------------------------------

        // Stack<string> historico = new();
        // Dictionary<string, List<string>> biblioteca = [];

        // biblioteca.Add("Ficção", new List<string>() { "Duna", "Harry Potter 1", "Narnia" });
        // biblioteca.Add("Ação", new List<string>() { "MIB", "Duro de Matar", "O poderoso chefao" });
        // biblioteca.Add("Historia", new List<string>() { "A Mumia", "Crespulo", "Alexandre, o grande" });
        // biblioteca.Add("Terror", new List<string>() { "Colheita Maldita" });

        // AdicionarLivroLido(ref historico, ref biblioteca, "Terror", "Sexta Feira 13");
        // AdicionarLivroLido(ref historico, ref biblioteca, "Terror", "Panico");
        // AdicionarLivroLido(ref historico, ref biblioteca, "Ficção", "Interstellar");
        // AdicionarLivroLido(ref historico, ref biblioteca, "Ação", "Velozes e Furiosos");
        // AdicionarLivroLido(ref historico, ref biblioteca, "Historia", "Cleopatra");

        // var livroPraLer = RecomendarProximoLivro(historico, biblioteca);
        // Console.WriteLine(livroPraLer);
        // Console.WriteLine();

        // static void AdicionarLivroLido(ref Stack<string> historico,
        // ref Dictionary<string, List<string>> livros, string genero, string livro)
        // {
        //     historico.Push(livro);

        //     if (!livros.ContainsKey(genero))
        //     {
        //         livros[genero] = new List<string>();
        //     }

        //     livros[genero].Add(livro);
        // }


        // static string RecomendarProximoLivro(Stack<string> historico,
        // Dictionary<string, List<string>> livros)
        // {
        //     //var contador = 0;
        //     Dictionary<string, int> contador = new();
        //     foreach (var livroLido in historico)
        //     {
        //         string genero = livros.FirstOrDefault(s => s.Value.Contains(livroLido)).Key;
        //         if (contador.ContainsKey(genero))
        //         {
        //             contador[genero]++;
        //         }
        //         else
        //         {
        //             contador[genero] = 1;
        //         }
        //     }
        //     var generoMaisFrequente = contador.OrderByDescending(cont => cont.Value).First().Key;

        //     var livrosNLidos = livros[generoMaisFrequente].Except(historico).ToList();
        //     return livrosNLidos.First();
        // }



// ---------------------------------------------------------------------------------------------
//             Exercicio 
// Desenvolva um sistema para um editor de texto que suporte múltiplas sessões de edição simultâneas,
// cada uma com capacidade de desfazer e refazer ações. Cada sessão representa um documento ou aba 
// no editor.

 









// ---------------------------------------------------------------------------------------------

/*

List<Livro> biblioteca = new List<Livro>
{
new Livro { Titulo = "A História do Amanhã", Autor = "Yuval Noah Harari", NumeroDePaginas = 500, 
Categoria = "História" },
new Livro { Titulo = "Sapiens", Autor = "Yuval Noah Harari", NumeroDePaginas = 450, Categoria = 
"Antropologia" },
new Livro { Titulo = "1984", Autor = "George Orwell", NumeroDePaginas = 328, Categoria = "Ficção" },
new Livro { Titulo = "O Sol é Para Todos", Autor = "Harper Lee", NumeroDePaginas = 384, Categoria = 
"Ficção" },
new Livro { Titulo = "A Revolução dos Bichos", Autor = "George Orwell", NumeroDePaginas = 112, 
Categoria = "Ficção" },
new Livro { Titulo = "Cem Anos de Solidão", Autor = "Gabriel García Márquez", NumeroDePaginas = 
417, Categoria = "Ficção" },
new Livro { Titulo = "Os Miseráveis", Autor = "Victor Hugo", NumeroDePaginas = 1463, Categoria = 
"Ficção Histórica" },
new Livro { Titulo = "Crime e Castigo", Autor = "Fyodor Dostoevsky", NumeroDePaginas = 671, 
Categoria = "Ficção" },
new Livro { Titulo = "Breves Respostas para Grandes Questões", Autor = "Stephen Hawking", 
NumeroDePaginas = 256, Categoria = "Ciência" },
new Livro { Titulo = "Uma Breve História do Tempo", Autor = "Stephen Hawking", NumeroDePaginas = 
212, Categoria = "Ciência" },
new Livro { Titulo = "Os Elementos da Experiência do Usuário", Autor = "Jesse James Garrett", 
NumeroDePaginas = 208, Categoria = "Design" },
new Livro { Titulo = "Design de Interação", Autor = "Jenny Preece", NumeroDePaginas = 809, Categoria
= "Design" },
new Livro { Titulo = "O Poder do Hábito", Autor = "Charles Duhigg", NumeroDePaginas = 400, 
Categoria = "Autoajuda" },
new Livro { Titulo = "Como Fazer Amigos e Influenciar Pessoas", Autor = "Dale Carnegie", 
NumeroDePaginas = 288, Categoria = "Autoajuda" },
new Livro { Titulo = "Subliminar", Autor = "Leonard Mlodinow", NumeroDePaginas = 304, Categoria = 
"Psicologia" },
new Livro { Titulo = "Freakonomics", Autor = "Steven D. Levitt", NumeroDePaginas = 336, Categoria = 
"Economia" },
new Livro { Titulo = "Outliers", Autor = "Malcolm Gladwell", NumeroDePaginas = 336, Categoria = 
"Psicologia" },
new Livro { Titulo = "Don't Make Me Think", Autor = "Steve Krug", NumeroDePaginas = 200, Categoria 
= "Tecnologia" },
new Livro { Titulo = "O Andar do Bêbado", Autor = "Leonard Mlodinow", NumeroDePaginas = 272, 
Categoria = "Ciência" },
new Livro { Titulo = "O Gene Egoísta", Autor = "Richard Dawkins", NumeroDePaginas = 360, Categoria 
= "Biologia" },
new Livro { Titulo = "O Mundo Assombrado pelos Demônios", Autor = "Carl Sagan", NumeroDePaginas 
= 480, Categoria = "Ciência" }
};

// Exercícios

// 1 - Lista de Todos os Livros por Categoria:
//     Os livros devem ser ordenados por título dentro de cada categoria.

    var livrosPorCategoria = biblioteca
        .OrderBy(l => l.Categoria)
        .ThenBy(l => l.Titulo)
        .GroupBy(l => l.Categoria)
        .Select(g => g.ToList())
        .ToList();
// Verificar se deu certo:
    Console.WriteLine("\nVerificando o Exercício 1\n");
    foreach (var categoria in livrosPorCategoria)
    {
        Console.WriteLine($"Categoria: {categoria.First().Categoria}");
        foreach (var livro in categoria)
        {
            Console.WriteLine($"- {livro.Titulo} ({livro.Autor})");
        }
        int qtdletras = 11 + categoria.First().Categoria.Length;
        string asteriscos = string.Empty.PadLeft(qtdletras,'*');
        Console.WriteLine(asteriscos);
    }

// 2 - Livros com Mais de 400 Páginas:
    // Identificar livros considerados "longos".
    var livrosMaisDe400 = biblioteca
        .Where(l => l.NumeroDePaginas > 400)
        .OrderBy(l => l.Categoria)
        .ThenBy(l => l.Titulo)
        .GroupBy(l => l.Categoria)
        .Select(grp => grp.ToList())
        .ToList();

// Verificar se deu certo:
    Console.WriteLine("\nVerificando o Exercício 2\n");
    foreach (var categoria in livrosMaisDe400)
    {
        Console.WriteLine($"Categoria: {categoria.First().Categoria}");
        foreach (var livro in categoria)
        {
            Console.WriteLine($"- {livro.Titulo} ({livro.NumeroDePaginas})");
        }
        int qtdletras = 11 + categoria.First().Categoria.Length;
        string asteriscos = string.Empty.PadLeft(qtdletras,'*');
        Console.WriteLine(asteriscos);
    }

// 3 - Quantidade de Livros por Autor:
    // Agrupar livros por autor e contar quantos livros cada um tem.
    var livrosPorAutor = biblioteca
        .GroupBy(l => l.Autor)
        .Select(a => new { Autor = a.Key, QuantidadeLivros = a.Count() })
        .OrderByDescending(x => x.QuantidadeLivros)
        .ToList();

// Verificar se deu certo:
   Console.WriteLine("\nVerificando o Exercício 3\n");
   foreach (var autor in livrosPorAutor)
    {
        Console.WriteLine($"{autor.Autor}: {autor.QuantidadeLivros} livro(s)");
    }

// 4 - Livros que Contêm a Palavra "História" no Título:
    // Filtrar e listar livros cujos títulos contêm a palavra "História".

    var livrosHistoria = biblioteca
        .Where(l => l.Titulo.Contains("História"))
        .OrderBy(l => l.Titulo)
        .ToList();

// Verificar se deu certo:
   Console.WriteLine("\nVerificando o Exercício 4\n");
    foreach (var titulo in livrosHistoria)
    {
        Console.WriteLine($"Livro: {titulo.Titulo}\n   de: {titulo.Autor}");
    }

// 5 - Autores com Dois ou mais Livros Publicados:
    // Identificar autores prolíficos.
    var autoresMais2 = biblioteca
        .GroupBy(l => l.Autor)       // Agrupa os livros por autor
        .Where(g => g.Count() >= 2) // Onde os grupos tenham 2 ou mais ocorrencias
        .Select(a => a.Key) 
        .ToList();                // Seleciona os autores dos grupos e bota na lista

// Verificar se deu certo:
    Console.WriteLine("\nVerificando o Exercício 5\n");
    foreach (var autor in autoresMais2)
    {
        Console.WriteLine($"Autor com mais de 2 obras: {autor}");
    }



*/
/*
GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
gerenciador.AdicionarTarefa("Estudar C#");
gerenciador.AdicionarTarefa("Ler documentação do .NET");
Console.WriteLine("Tarefas pendentes:");
gerenciador.MostrarTarefas();


gerenciador.CompletarTarefa();
Console.WriteLine("Tarefas após completar uma:");
gerenciador.MostrarTarefas();
*/




