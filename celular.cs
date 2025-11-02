abstract class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public List<IApp> AppsInstalados { get; set; }

    // Métodos comuns: Ligar, Desligar, InstalarApp, AbrirApp
    // Métodos abstratos: TirarFoto, EnviarMensagem
}
