namespace calculadora;
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual operação deseja realizar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("Informe a opção:");
        short opcao = short.Parse(Console.ReadLine() ?? "");
        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    private static NumerosOperacao PedirNumeros() {
        Console.Clear();
        var numeros = new NumerosOperacao();
        Console.WriteLine("");
        Console.Write("Informe o primeiro número: ");
        numeros.PrimeiroNumero = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("");
        Console.Write("Informe o segundo número: ");
        numeros.SegundoNumero = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("");
        return numeros;
    }

    private static void ExibirResultado(int resultado)
    {
        Console.WriteLine($"O resultado é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    private static void Soma()
    {
        var numeros = PedirNumeros();
        ExibirResultado(numeros.PrimeiroNumero + numeros.SegundoNumero);
    }

    private static void Subtracao()
    {
        var numeros = PedirNumeros();
        ExibirResultado(numeros.PrimeiroNumero - numeros.SegundoNumero);
    }

    private static void Multiplicacao()
    {
        var numeros = PedirNumeros();
        ExibirResultado(numeros.PrimeiroNumero * numeros.SegundoNumero);
    }
    
    private static void Divisao()
    {
        var numeros = PedirNumeros();
        if (numeros.SegundoNumero == 0)
        {
            Console.WriteLine("Não pode dividir por zero");
            Console.ReadKey();
            Menu();
        }
        ExibirResultado(numeros.PrimeiroNumero / numeros.SegundoNumero);
    }

}

struct NumerosOperacao {
    public int PrimeiroNumero;
    public int SegundoNumero;
}
