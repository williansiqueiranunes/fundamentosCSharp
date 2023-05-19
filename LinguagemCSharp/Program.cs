// See https://aka.ms/new-console-template for more information
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





