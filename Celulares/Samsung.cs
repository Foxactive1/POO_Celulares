using System;

namespace POO_Celulares.Celulares
{
    public class Samsung : Celular
    {
        public Samsung(string modelo) : base("Samsung", modelo) { }

        public override void TirarFoto() => Console.WriteLine($"{Marca} {Modelo}: Tirando foto em Modo Noturno.");
        public override void EnviarMensagem(string mensagem) => Console.WriteLine($"{Marca} {Modelo}: Enviando via SMS: {mensagem}");
    }
}

