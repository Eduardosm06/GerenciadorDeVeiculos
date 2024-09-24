using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVeiculos
{
    public class Garagem
    {
        public List<Veiculo> Veiculos { get; set; }

        public Garagem() 
        {
            Veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public void MostrarDetalhesVeiculos()
        {
            foreach(var veiculo in Veiculos)
            {
                veiculo.MostrarDetalhes();
            }
        }

        public double CalcularEficienciaTotal()
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo na garagem.");
                return 0;
            }

            double eficienciaTotal = 0;

            foreach (var veiculo in Veiculos)
            {
                eficienciaTotal += veiculo.CalcularEficiencia;
            }

            return eficienciaTotal;
        }
    }
}
