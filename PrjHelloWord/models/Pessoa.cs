using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace é aqui que construimos pacotes, onde vc organiza a classe. 
//Seria o nome completo da sua classe.
//E é comum usar namespace em qlqr linguagem
namespace PrjHelloWord.models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() // Com o atalho CTO  acessa o método construtor padrão no C# e no Java tbém.
        {
            
        }

    }
}
