﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



/**
 * Inicialização de Variaveis
 */

// int idade; // declarado mas não inicializada
int altura = 175; // inicializada
var peso = 80; // será tipado quando atribuido o valor
// var teste; -> nã0 pode ser usado. Para usar "var", precisa inicializar
Console.WriteLine(altura);
Console.WriteLine(peso);

// const int IDADE_INICIAL; -> ERRADO
const int IDADE_MINIMA = 18;
// const var IDADE_MAXIMA = 60; -> ERRADO
// const var IDADE_FINAL; -> ERRADO
Console.WriteLine(IDADE_MINIMA);



/**
 * Tipos de variáveis
 * https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/#types-and-variables
 */
 #pragma warning disable 0219 // desativa aviso variável não utilizada

byte valorByte = 128; // 0 até 255
sbyte valorByteNegativo = -64; // -128 até 127

short valorShort = -10; // -32.768 até 32.767 (16-bit)
ushort valorUshort = 10; // 0 até 65,535 (16-bit)

int valorInt = -20; // -2.147.483.648 até 2.147.483.647 (32-bit)
uint valorUint = 20; // 0 até 4.294.967.295 (32-bit)

long valorLong = -30; // -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807 (64-bit)
ulong valorUlong = 30; // 0 até 18.446.744.073.709.551.615 (64-bit)


float valorFloat = 1.2f; // Precisão ~6-9 dígitos (4 bytes)
double valorDouble = 2.3; // Precisão ~15-17 dígitos (8 bytes)
decimal valorDdecimal = 3.4m; // Precisão 28-29 dígitos (16 bytes)

bool boleano = true;

char umCaracter = 'a'; // apenas 1 caracter
string palavra = "csharp"; 

var fruta = "maçã"; // na primeira atrivuição, o var vai ser uma string, depois não pode ser mudado o tipo
var quantidade = 20;

object qualquerCoisa; // object não precisa ter inicialização
qualquerCoisa = 10;



// Tipos Nulos. Usando o "?" força a variável receber um valor nulo.
int? valorSemnada = null;
string? valorVazio = null;



/** Alias **/
int valorA = 30; // alias
Int32 valorB = 30; // tipo

string textoA = "aaa"; // alias
System.String textoB = "bbb"; // tipo



/** Valores Padrão **/
/// int => 0
/// float => 0
/// double => 0
/// decimal => 0
/// bool => false
/// char => '\0'
/// string => ""



/*
 * Coversão Implícita
 * tabela conversão: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions
 */
float valor = 25.8f;
int outro = 25;
valor = outro; // conversão



/*
 * Coversão Explícita
 * tabela conversão: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions#explicit-numeric-conversions
 */
int inteiro = 100;
uint inteicoSemSinal = (uint)inteiro;



/** Parse **/
int inteiroParse = int.Parse("100"); // espera uma string para converter
double valorParse = double.Parse("10.2"); // cuidar para que a string temha somente o valor do tipo



/** Convert **/
int valorConvertA = Convert.ToInt16("100");
int valorConvertB = Convert.ToInt16(2.5);



/* Operações Aritméticas */
// soma __________ ( + )
// subtração _____ ( - )
// multiplicção __ ( * )
// divisão _______ ( / )

// segue a regra da matemática | 1° ( * e / ) | 2° ( + e - )



/* Operações de Atribuição */
int v = 0;
v += 5; // x = x + 5
v -= 1; // x = x - 2
v *= 10; // x = x * 10
v /= 2; // x = x / 2



/* Operações de Comparação */
// igual ___________ ( == )
// diferente _______ ( != )
// maior ___________ ( > )
// menor ___________ ( < )
// maior ou igual __ ( >= )
// menor ou igual __ ( <= )



/* Operadores Lógicos */
// E / AND ________ ( && )
// OU / OR ________ ( || )
// NEGAÇÃO / NOT __ ( ! )



/* Condicionais */
var value = 1;

if (value == 1) {
    Console.WriteLine("Valor 1");
} else if (value == 2) {
    Console.WriteLine("Valor 2");
} else {
    Console.WriteLine("Valor Padrao");
}


switch (value)
{
    case 1:
        Console.WriteLine("Valor 1");
        break;
    case 2:
        Console.WriteLine("Valor 2");
        break;
    default:
        Console.WriteLine("Valor Padrao");
        break;
}



/* Laços Repetição */

int[] lista = new int[] { 1, 2, 3 };

for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine("Index: " + i + " Valor: " + lista[i]);
}

foreach (var item in lista)
{
    Console.WriteLine("Valor: " + item);
}


int contadorWhile = 0;
while (contadorWhile < 5)
{
    Console.WriteLine("contadorWhile: " + contadorWhile);
    contadorWhile++;
}


int contadorDoWhile = 0;
do
{
    Console.WriteLine("contadorDoWhile: " + contadorDoWhile);
    contadorDoWhile++;
} while (contadorDoWhile < 5);





/* Métodos */

static void MeuMetodo(string parametro) // criando o método sem retorno (void)
{
    Console.WriteLine(parametro);
}
MeuMetodo("Olá Mundo"); // executando o método


static string RetornaNomeCompleto(string nome, string sobrenome) // método com retorno
{
    return nome + " " + sobrenome;
}
Console.WriteLine(RetornaNomeCompleto("Fulano", "De Tal"));



static string RetornaNomeIdade( // método com parâmetro opcional
    string nome,
    int idade = 30 // a idade vai ter 30 como valor padrão
    // parâmetros opcionais, tem que ser os últimos da lista de parâmetros
)   
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}
Console.WriteLine(RetornaNomeIdade("Fulano"));
Console.WriteLine(RetornaNomeIdade("Fulano", 40));





/* Value Types */

// Armazenados na STACK ("Garbage Collector" não tem acesso)
// Buit-in, structs, enuns
// O valor será COPIADO

int x = 25;
int y = x; // Y é uma cópia de X
Console.WriteLine(x); // 25
Console.WriteLine(y); // 25
x = 30;
Console.WriteLine(x); // 30
Console.WriteLine(y); // 25



/* Reference Types */

// Será armazenado na HEAP, a variável tem uma referência para o valor na HEAP
// Class, Object, Array, ...
// Quando não existe mais referência, o valor é apagado da HEAP (Garbage Collector passa excluindo)

var arrayA = new string[2];
arrayA[0] = "Item 1";
var arrayB = arrayA; // Não copia o conteúdo, só a referência;
Console.WriteLine(arrayA[0]); // "Item 1"
Console.WriteLine(arrayB[0]); // "Item 1"
arrayA[0] = "Item 1 modificado";
Console.WriteLine(arrayA[0]); // "Item 1 modificado"
Console.WriteLine(arrayB[0]); // "Item 1 modificado"




/* Strucs */

// Parecido com uma classe, a direrença que é amarzenada na stack e tem o valor, não uma referência
// Pode tem propriedade e métodos, pode criar um construtor (não pode ser vazio)
// Mais informações em: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/struct

/*
struct Produto
{
    public string Nome;
    public int Quantidade;

    public string Descricao()
    {
        return $"O produto {Nome} tem a quantidade de {Quantidade}.";
    }
}

var produto = new Produto();
produto.Nome = "Tênis";
produto.Quantidade = 10;
Console.WriteLine(produto.Descricao());
*/




/* Enuns*/

// Uma estrutura que retorna um int e melhora a visualização do dado
// Mais informações em: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/enum

/*
enum EStatus {
    Ativo = 1,
    Desabilitado = 2,
    Excluido = 3
}

var status = EStatus.Ativo;
Console.WriteLine(status); // Ativo
Console.WriteLine((int)status); // 1
*/

