namespace Demo.Console;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");
        int idade = 18;
        string nome = "stopiglia";
        decimal valor = 100.50m;
        bool bonito = true;
        System.Console.WriteLine($"Nome: {nome}, Idade: {idade}, Valor: {valor}, Bonito: {bonito}");

        int quantidade = 100;
        decimal total = quantidade * valor;
        System.Console.WriteLine($"Quantidade: {quantidade}, Total: {total}");

        bool mariorIdade = idade >= 18;
        bool menorIdade = idade < 5;
        System.Console.WriteLine($"Maior Idade: {mariorIdade}, Menor Idade: {menorIdade}");

        string valorStr = "50";
        int valorInt = int.Parse(valorStr);
        System.Console.WriteLine($"Valor String: {valorStr}, Valor Int: {valorInt}");

        int valorInt2 = Convert.ToInt32(valorStr);
        System.Console.WriteLine($"Valor String: {valorStr}, Valor Int2: {valorInt2}");

        string salarioStr = "100.5";
        decimal salario = decimal.Parse(salarioStr);
        System.Console.WriteLine($"Salario String: {salarioStr}, Salario Decimal: {salario}");

        string salarioStr2 = salario.ToString();
        System.Console.WriteLine($"Salario Decimal: {salario}, Salario String2: {salarioStr2}");

        if (idade > 18)
        {
            System.Console.WriteLine("Você é maior de idade.");
        }
        else if (idade == 18)
        {
            System.Console.WriteLine("Você tem exatamente 18 anos.");
        }
        else
        {
            System.Console.WriteLine("Você é menor de idade.");
        }

        bool EMariorIdade = (idade >= 18) ? true : (idade == 18) ? true : false;
        string EMaiorIdadeStr = EMariorIdade ? "É maior de idade." : "É menor de idade.";
        System.Console.WriteLine($"{EMaiorIdadeStr} : {EMariorIdade}");

        int[] numeros2 = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numeros2.Length; i++)
        {
            System.Console.WriteLine($"numeros2[{i}] = {numeros2[i]}");
        }
    }
}

