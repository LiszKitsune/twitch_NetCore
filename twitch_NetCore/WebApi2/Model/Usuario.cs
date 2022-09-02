using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Model
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }

        public Usuario (string nome, string sobrenome, int idade, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Endereco = endereco;
        }
    }
}
