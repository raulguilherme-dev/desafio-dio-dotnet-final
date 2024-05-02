using Microsoft.VisualBasic;
using BibliotecaSistema;

namespace BibliotecaTests;

public class BibliotecaTests
{
    Biblioteca biblioteca = new();

    [Fact]
    public void DeveAdicionarUmLivroNaListaERetornarMensagemDeSucesso() {

        string nome = "O Senhor dos Anéis";

        string resultado = biblioteca.AdicionarLivro(nome);

        Assert.Equal("Livro adicionado com sucesso", resultado);
    }

    [Fact]
    public void DeveTentarEmprestarUmLivroQueNaoExisteNaListaERetornarMensagemDeErro() {

        string nome = "A Culpa é das Estrelas";

        string resultado = biblioteca.EmprestarLivro(nome);

        Assert.Equal("Livro não encontrado", resultado);
    }

    [Fact]
    public void DeveTentarEmprestarUmLivroQueJaEstaEmprestadoERetornarMensagemDeErro() {

        string nome = "A Culpa é das Estrelas";

        biblioteca.AdicionarLivro(nome);

        biblioteca.EmprestarLivro(nome);

        string resultado = biblioteca.EmprestarLivro(nome);

        Assert.Equal("Livro já emprestado", resultado);
    }

    [Fact]
    public void DeveEmprestarUmLivroQueExisteNaListaERetornarMensagemDeSucesso() {

        string nome = "O Senhor dos Anéis";

        biblioteca.AdicionarLivro(nome);

        string resultado = biblioteca.EmprestarLivro(nome);

        Assert.Equal("Livro emprestado com sucesso", resultado);
    }

    [Fact]
    public void DeveTentarDevolverUmLivroQueNaoExisteNaListaERetornarMensagemDeErro() {

        string nome = "A Cabana";

        string resultado = biblioteca.DevolverLivro(nome);

        Assert.Equal("Livro não encontrado", resultado);
    }

    [Fact]
    public void DeveDevolverUmLivroQueExisteNaListaERetornarMensagemDeSucesso() {

        string nome = "O Senhor dos Anéis";

        biblioteca.AdicionarLivro(nome);

        biblioteca.EmprestarLivro(nome);

        string resultado = biblioteca.DevolverLivro(nome);

        Assert.Equal("Livro devolvido com sucesso", resultado);
    }

    [Fact]
    public void DeveTentarDevolverUmLivroQueNaoFoiEmprestadoERetornarMensagemDeErro() {

        string nome = "1984";

        biblioteca.AdicionarLivro(nome);

        string resultado = biblioteca.DevolverLivro(nome);

        Assert.Equal("Não é possível devolver um livro que não foi emprestado", resultado);
    }

    [Fact]
    public void DeveTentarVerificarStatusDeUmLivroQueNaoExisteNaListaERetornarMensagemDeErro() {

        string nome = "O Pequeno Príncipe";

        string resultado = biblioteca.VerificarStatusDoLivro(nome);

        Assert.Equal("Livro não encontrado", resultado);
    }

    [Fact]
    public void DeveVerificarStatusDeUmLivroQueExisteNaListaERetornarSeuStatusAtual() {

        string nome = "O Senhor dos Anéis";

        biblioteca.AdicionarLivro(nome);

        string resultado = biblioteca.VerificarStatusDoLivro(nome);

        Assert.True(resultado == "Disponível" || resultado == "Emprestado");
    }


}