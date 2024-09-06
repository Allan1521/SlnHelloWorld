// See https://aka.ms/new-console-template for more information


//C# é uma linguagem compilada e tipada

//int - números inteiros
//int variavelNumerica = 2;

//double variavelNumericaDecimal = 3.0;
//double - números decimais

//string - textos
//string nome = "Allan";

//bool - booleano(true/false)
//bool temArCondicionado = false;

//char - único caracter('usa-se apóstos')
//char caracterUnico = 'S';

using PrjHelloWord.models;
using System.Reflection.Metadata;

Pessoa minhaPessoa = new Pessoa();
//Definindo uma variável como tipo pessoa p/armazenar um 
//objeto pessoa. Nenhum tipo vai funcionar

Console.WriteLine("Hello, Digite seu nome:");
minhaPessoa.Nome = Console.ReadLine();
Console.WriteLine("hello, Digite sua idade:");
minhaPessoa.Idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O nome da pessoa é {minhaPessoa.Nome} e a idade {minhaPessoa.Idade} anos.");







