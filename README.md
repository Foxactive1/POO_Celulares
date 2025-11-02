# POO_Celulares

![C#](https://img.shields.io/badge/Linguagem-C%23-blue)
![Status](https://img.shields.io/badge/Status-Concluído-green)

## Descrição do Projeto

Este projeto tem como objetivo **modelar um sistema de celulares utilizando Programação Orientada a Objetos (POO)**.  
O sistema permite que diferentes marcas e modelos de celulares tenham seus próprios comportamentos, possibilitando **reuso de código, escalabilidade e modularidade**.

No projeto, é possível:
- Ligar e desligar celulares.
- Tirar fotos com diferentes modos, de acordo com a marca/modelo.
- Enviar mensagens via plataformas específicas (iMessage, SMS, etc.).
- Instalar e utilizar aplicativos através de **interfaces (IApp)**.
- Demonstrar **polimorfismo e herança**, permitindo que cada modelo implemente funcionalidades únicas.

---

## Estrutura do Projeto

- `Celular` (Classe abstrata): Define os métodos e propriedades que todo celular deve ter.
- `IApp` (Interface): Representa aplicativos que podem ser instalados em qualquer celular.
- `Iphone` / `Samsung` (Classes concretas): Implementam comportamentos específicos de cada marca.
- `Apps` (Ex: WhatsApp, Instagram): Implementam a interface `IApp`, podendo ser instalados e utilizados nos celulares.
- `Program.cs`: Arquivo principal que demonstra o funcionamento do sistema.

---

## Funcionalidades Implementadas

1. **Ligar/Desligar Celular**  
   Todos os celulares podem ligar e desligar, com mensagens customizadas por marca e modelo.

2. **Tirar Fotos**  
   Cada celular possui modos de câmera diferentes, demonstrando **polimorfismo**.

3. **Enviar Mensagens**  
   Implementação de envio de mensagens de acordo com a plataforma da marca.

4. **Instalar e Usar Apps**  
   - Uso de interfaces para permitir instalação de múltiplos aplicativos.
   - Cada app possui métodos `Abrir()` e `Fechar()`.

5. **Modularidade e Extensibilidade**  
   - Facilidade para adicionar novos modelos de celular ou novos aplicativos.
   - Código limpo e escalável.

---

## Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/SeuUsuario/POO_Celulares.git
Abra o projeto no Visual Studio ou em qualquer IDE C#.

Compile e execute Program.cs.

Observe a interação entre diferentes modelos de celulares e aplicativos.

Exemplos de Saída
less
Copiar código
Apple 14 Pro está ligando...
Apple 14 Pro: Tirando foto em Modo Retrato.
Apple 14 Pro: Enviando via iMessage: Olá, galera!
Apple 14 Pro instalou WhatsApp
Abrindo WhatsApp...
Apple 14 Pro não tem Facebook instalado.
Apple 14 Pro está desligando...
Tecnologias Utilizadas
C# (.NET Core)

Conceitos de POO:

Abstração

Herança

Polimorfismo

Interfaces

Conceitos de modularidade e escalabilidade

Próximos Passos / Melhorias Futuras
Adicionar bateria, memória e armazenamento nos celulares.

Implementar notificações de apps.

Criar interação entre múltiplos celulares (chamadas, mensagens internas).

Adicionar interface gráfica (ex: WPF ou Blazor) para melhor visualização.

Autor
Dione Castro Alves – Founder InNovaIdeia ®
Portfólio

Licença
Projeto aberto para aprendizado e portfólio pessoal.
© 2025 Dione Castro Alves | InNovaIdeia ®

yaml
Copiar código

---

Se você quiser, posso preparar também uma **versão visual do README**, com **GIF animado demonstrando a execução do código** e **badges de skills**, que deixa o portfólio ainda mais atrativo para recrutadores e clientes.  

Quer que eu faça essa versão visual top?






