using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace GerenciadorDeVeiculos
{
    public class Carro: Veiculo
    {
        public int NumeroDePortas { get; set; }
        public Carro(int numeroDePortas) : base(marca,modelo,ano,combustivel)
        {
            NumeroDePortas = numeroDePortas;
        }










    }
}
