using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVeiculos
{
    public class Moto :Veiculo 
    {
        public int Cilindradas { get; set; }

        public Moto(int cilindradas) : base(marca, modelo, ano, combustivel)
        {
            Cilindradas = cilindradas;
        }

        public override double CalcularEficiencia()
        {

        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Combustivels {Combustivel}, Cilindradas {Cilindradas}");
        }
    }
}
