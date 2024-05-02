using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaSistema
{
    public class Biblioteca
    {

        public List<Livro> Livros { get; set; }

        public Biblioteca() {
            Livros = new();
        }

        public string AdicionarLivro(string nome) {
            Livro novoLivro = new(nome);
            Livros.Add(novoLivro);
            return "Livro adicionado com sucesso";
        }

        public string EmprestarLivro(string nome) {
            foreach(Livro livro in Livros) {
                if (livro.Nome == nome) {
                    if (livro.Status == "Emprestado") {
                        return "Livro já emprestado";
                    }
                    livro.Status = "Emprestado";
                    return "Livro emprestado com sucesso";
                }
            }
            return "Livro não encontrado";
        }

        public string DevolverLivro(string nome) {
            foreach(Livro livro in Livros) {
                if (livro.Nome == nome) {
                    if (livro.Status == "Disponível") {
                        return "Não é possível devolver um livro que não foi emprestado";
                    }
                    livro.Status = "Emprestado";
                    return "Livro devolvido com sucesso";
                }
            }
            return "Livro não encontrado";
        }

        public string VerificarStatusDoLivro(string nome) {
            foreach(Livro livro in Livros) {
                if (livro.Nome == nome) {
                    return livro.Status;
                }
            }
            return "Livro não encontrado";
        }
    }
}