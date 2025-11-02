using System;

namespace POO_Celulares.Apps
{
    public interface IApp
    {
        string Nome { get; }
        void Abrir();
        void Fechar();
    }
}
