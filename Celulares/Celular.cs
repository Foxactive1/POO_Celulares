using System;
using System.Collections.Generic;
using POO_Celulares.Apps;

namespace POO_Celulares.Celulares
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<IApp> AppsInstalados { get; set; }

        public Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            AppsInstalados = new List<IApp>();
        }

        public void Ligar() => Console.WriteLine($"{Marca} {Modelo} está ligando...");
        public void Desligar() => Console.WriteLine($"{Marca} {Modelo} está desligando...");

        public void InstalarApp(IApp app)
        {
            AppsInstalados.Add(app);
            Console.WriteLine($"{Marca} {Modelo} instalou {app.Nome}");
        }

        public void AbrirApp(string nomeApp)
        {
            var app = AppsInstalados.Find(a => a.Nome == nomeApp);
            if (app != null) app.Abrir();
            else Console.WriteLine($"{Marca} {Modelo} não tem {nomeApp} instalado.");
        }

        public abstract void TirarFoto();
        public abstract void EnviarMensagem(string mensagem);
    }
}
