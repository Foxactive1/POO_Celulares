using System;
using POO_Celulares.Celulares;
using POO_Celulares.Apps;

namespace POO_Celulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular meuIphone = new Iphone("14 Pro");
            Celular meuSamsung = new Samsung("Galaxy S23");

            // Testando Iphone
            meuIphone.Ligar();
            meuIphone.TirarFoto();
            meuIphone.EnviarMensagem("Olá, galera!");
            meuIphone.InstalarApp(new WhatsApp());
            meuIphone.InstalarApp(new Instagram());
            meuIphone.AbrirApp("WhatsApp");
            meuIphone.AbrirApp("Instagram");
            meuIphone.AbrirApp("Facebook");
            meuIphone.Desligar();

            Console.WriteLine();

            // Testando Samsung
            meuSamsung.Ligar();
            meuSamsung.TirarFoto();
            meuSamsung.EnviarMensagem("Oi, pessoal!");
            meuSamsung.InstalarApp(new WhatsApp());
            meuSamsung.AbrirApp("WhatsApp");
            meuSamsung.Desligar();
        }
    }
}
