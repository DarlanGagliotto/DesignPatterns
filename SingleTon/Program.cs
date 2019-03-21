using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {

            SingleTon jogador1 = SingleTon.GetInstanciaBola;
            jogador1.Mensagem("Jogador 1 : Bola no centro do campo!");

            SingleTon jogador2 = SingleTon.GetInstanciaBola;
            jogador2.Mensagem("Jogador 2 : Recebe a bola do jogador 1!");

            SingleTon jogador3 = SingleTon.GetInstanciaBola;
            jogador3.Mensagem("Jogador 3 : Cabeceia o lançamento do jogador 2!");

            Console.ReadKey();
        }
    }
}
