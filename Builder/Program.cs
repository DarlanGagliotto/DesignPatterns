using System;


namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria fabricante
            Fabricante fabricante = new Fabricante();

            // Permite que a classe builder esteja pronta

            ICelular celularBuilder = null;

           // Criação telefone Android
            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("Um novo celular foi construido: {0}", celularBuilder.Celular.NomeCelular);
            Console.WriteLine("Sistema: {0}", celularBuilder.Celular.Sistema);
            Console.WriteLine("Tela: {0}", celularBuilder.Celular.Tela);
            Console.WriteLine("Camera: {0}", celularBuilder.Celular.Camera);
            Console.WriteLine("Bateria: {0}", celularBuilder.Celular.Bateria);

            Console.WriteLine();
            Console.WriteLine();

            // Criação telefone Iphone
            celularBuilder = new IPhoneBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("Um novo celular foi construido: {0}", celularBuilder.Celular.NomeCelular);
            Console.WriteLine("Sistema: {0}", celularBuilder.Celular.Sistema);
            Console.WriteLine("Tela: {0}", celularBuilder.Celular.Tela);
            Console.WriteLine("Camera: {0}", celularBuilder.Celular.Camera);
            Console.WriteLine("Bateria: {0}", celularBuilder.Celular.Bateria);

        }
    }
}
