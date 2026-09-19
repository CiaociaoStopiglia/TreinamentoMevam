using System.ComponentModel.DataAnnotations.Schema;

public class Pessoa ()
{

    public Pessoa(string nome, int idade, string altura) : this()
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
    }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public string Altura { get; set; }
}