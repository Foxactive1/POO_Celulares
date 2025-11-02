using System;

namespace POO_Celulares.Apps
{
    public class Instagram : IApp
    {
        public string Nome => "Instagram";

        public void Abrir() => Console.WriteLine("Abrindo Instagram...");
        public void Fechar() => Console.WriteLine("Fechando Instagram...");
    }
}
