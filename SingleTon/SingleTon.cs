using System;

namespace SingleTon
{
    public sealed class SingleTon
    {
        private static SingleTon instanciaBola = null;

        public static SingleTon GetInstanciaBola
        {
            get
            {
                if (instanciaBola == null)
                {
                    instanciaBola = new SingleTon();

                    Console.WriteLine("Bola em jogo!");
                }

                return instanciaBola;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
