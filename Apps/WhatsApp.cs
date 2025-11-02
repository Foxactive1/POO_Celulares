using System;

namespace POO_Celulares.Apps
{
    public class WhatsApp : IApp
    {
        public string Nome => "WhatsApp";

        public void Abrir() => Console.WriteLine("Abrindo WhatsApp...");
        public void Fechar() => Console.WriteLine("Fechando WhatsApp...");
    }
}
