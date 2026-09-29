using Xunit;
using GamerProfile.App;

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceTests
    {
        private readonly PerfilJogadorService _service;

        public PerfilJogadorServiceTests()
        {
            _service = new PerfilJogadorService();
        }

        // Teste 1: Valida a formatação correta da tag do usuário
        [Fact]
        public void GerarTagUsuario_DeveRetornarFormatoCorreto()
        {
            // Arrange
            string nickname = "Aragorn";
            string codigo = "1042";
            string esperado = "Aragorn#1042";

            // Act
            string resultado = _service.GerarTagUsuario(nickname, codigo);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        // Teste 2: Valida a soma do XP com o bônus de 100 pontos
        [Fact]
        public void CalcularXPTotal_DeveSomarXPComBonus()
        {
            // Arrange
            int xpFase1 = 200;
            int xpFase2 = 300;
            int esperado = 600; // 200 + 300 + 100

            // Act
            int resultado = _service.CalcularXPTotal(xpFase1, xpFase2);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        // Teste 3: Valida as regras de elegibilidade para Ranked
        [Fact]
        public void EEligivelParaRanked_DeveRetornarTrueParaNivelMaiorOuIgual15()
        {
            // Arrange
            int nivel = 15;

            // Act
            bool resultado = _service.EEligivelParaRanked(nivel);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void EEligivelParaRanked_DeveRetornarFalseParaNivelMenorQue15()
        {
            // Arrange
            int nivel = 10;

            // Act
            bool resultado = _service.EEligivelParaRanked(nivel);

            // Assert
            Assert.False(resultado);
        }
    }
}