using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Status { get; set; }

        public Livro(string nome) {
            if (nome == "") {
                throw new ArgumentException("Nome do livro não pode ser vazio");
            }
            this.Nome = nome;
            this.Status = "Disponível";
        }
        
    }
}