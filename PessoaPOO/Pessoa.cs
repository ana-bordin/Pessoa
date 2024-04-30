using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaPOO
{
    internal class Pessoa
    {
        string Nome;
        int Idade;

        public Pessoa() { }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setIdade(int idade)
        {
            this.Idade = idade;
        }
        public int getIdade()
        {
            return this.Idade;
        }
    }
}
