using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaSistema;

namespace BibliotecaTests
{
    public class LivroTests {
    
        [Fact]
        public void DeveTentarInstanciarUmLivroComNomeVazioERetornarMensagemDeErro() {
            
            try {
                Livro livro = new("");

                Assert.Fail("Uma exceção deveria ter sido lançada mas não foi");
            } catch (ArgumentException e) {

                Assert.Equal("Nome do livro não pode ser vazio", e.Message);
            }
        }

        [Fact]
        public void DeveInstanciarUmLivroComNomeValidoERetornarMensagemDeSucesso() {
            
            try {
                
                string nome = "O Senhor dos Anéis";

                Livro livro = new(nome);

                Assert.Equal("O Senhor dos Anéis", livro.Nome);
            } catch (ArgumentException e) {

                Assert.Fail("Uma exceção foi lançada mas não deveria ter sido");
            }
            
        }
    }
}