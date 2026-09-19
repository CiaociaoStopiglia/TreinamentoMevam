using System.Runtime.CompilerServices;

public class Program
{
    //public static void Main(string[] args)
    //{

        //var pessoa = new Pessoa ();

        //pessoa.Nome = "João";
        //pessoa.Altura = "1.81";
        //pessoa.Idade = 18;

        //Console.WriteLine($"Nome: {pessoa.Nome}");
        //Console.WriteLine($"Altura: {pessoa.Altura}");
        //Console.WriteLine($"Idade: {pessoa.Idade}");

    //}

    //============================//

    // public static void Main(string[] args)
    // {
    //     var listPessoas = new List<Pessoa>();

    //     var pessoa = new Pessoa();
    //     pessoa.Nome = "João";
    //     pessoa.Idade = 18;
    //     pessoa.Altura = "1,81";

    //     var pessoa2 = new Pessoa();
    //     pessoa2.Nome = "Marcelo Fabrício";
    //     pessoa2.Idade = 10;
    //     pessoa2.Altura = "1,51";

    //     listPessoas.Add(pessoa);
    //     listPessoas.Add(pessoa2);


        // listPessoas.Add(new Pessoa () { Nome = "João", Idade = 18, Altura = "1,81"});
        // listPessoas.Add(new Pessoa () { Nome = "Marcelo Fabrício", Idade = 10, Altura = "1,51"});

        //Console.WriteLine(listPessoas.Count);
    //}

    //=======================//

    public static void Main(string[] args)
    {
        var dicNomes = new Dictionary<int, string>();

        dicNomes.Add(0, "Bruno");
        dicNomes.Add(1, "Miguel");
        dicNomes.Add(12, "Bruna");

        // foreach (var item in dicNomes)
        // {
        //     Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value});
        // }

        Console.WriteLine(dicNomes[12]);
    }
}
