using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace estacionamento.veiculo.teste
{
    public  class PatioTestes
    {
        [Fact]
        public void ValidaFaturamento()
        {
            //Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "Leandro";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "preto";
            veiculo.Modelo = "fusca";
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double fauramento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, fauramento);


        }

        [Theory]
        [InlineData("Leandro","asd-1452","preto","gol")]
        [InlineData("Jose", "pol-2236", "verde", "fusca")]
        [InlineData("Maria", "a2d-1452", "preto", "alinen")]
        public void ValidaFaturamentoComVeiculos(string proprietario,
            string placa,string cor, string modelo)
        {
            //Arranga

            Patio estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor; 
            veiculo.Modelo = modelo;

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act

            double faturamento = estacionamento.TotalFaturado();

            //Assert

            Assert.Equal(2,faturamento);

        }

    }
}
