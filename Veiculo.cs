using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVeiculos
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Combustivel { get; set; }

       public Veiculo(string marca,string modelo,int ano,string combustivel ) 
        {
            Marca = marca;  
            Modelo = modelo;    
            Ano = ano; 
            Combustivel= combustivel;
        }   
        public virtual double CalcularEficiencia()
        {
            return 0; 
        }
        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Combustivels {Combustivel}");
        }

    }
}
