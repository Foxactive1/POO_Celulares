using System;

namespace POO_Celulares.Celulares
{
    public class Iphone : Celular
    {
        public Iphone(string modelo) : base("Apple", modelo) { }

        public override void TirarFoto() => Console.WriteLine($"{Marca} {Modelo}: Tirando foto em Modo Retrato.");
        public override void EnviarMensagem(string mensagem) => Console.WriteLine($"{Marca} {Modelo}: Enviando via iMessage: {mensagem}");
    }
}
