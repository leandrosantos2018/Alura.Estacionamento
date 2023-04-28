using Alura.Estacionamento.Modelos;

namespace estacionamento.veiculo.teste
{
    public class VeiculoTeste
    {
        [Fact]
        public void VeiculoTesteAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();
            
            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }
        [Fact]
        public void VeiculoTesteFreiar()
        {
            //Arrange
            var veiculo = new Veiculo();
            
            //Act
            veiculo.Frear(10);
            
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);

    
        }

        
    }
}