using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Estacionamento2.Models
{
    public class Estacionamento
    {
         private decimal precoInicial = 0;
         private decimal precoPorHora = 0;   
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial,decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
       
       //public decimal precoInicial { get; set; }
       // public decimal precoPorHora { get; set; }
        public void AdicionarVeiculo(){
            Console.WriteLine("Digite a Placa do Veiculo");
            string placa="";
            placa = Console.ReadLine();
            veiculos.Add(placa);

        }
      
        public void RemoverVeiculo()
        {
            string placa ="";
            Console.WriteLine("Digite a placa do veículo para remover: ");
            placa = Console.ReadLine();
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
           
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            //if(veiculos.Count > 0)
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas );

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculo()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {   
              
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                for(int x=0;x<veiculos.Count ;x++){
                    Console.WriteLine(veiculos[x]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
               
            }
        }
    }
}