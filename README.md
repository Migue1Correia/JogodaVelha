🎮 Jogo da Velha em .NET MAUI

Este é um projeto simples e divertido desenvolvido com .NET MAUI, que simula o clássico Jogo da Velha (Tic-Tac-Toe).
O objetivo é praticar lógica de programação, tratamento de eventos, interface com XAML e estrutura de código limpo (C#).

✅ Funcionalidades

✔ Alternância automática entre os jogadores X e O
✔ Bloqueio do botão após ser clicado
✔ Verificação de vitória nas linhas, colunas e diagonais
✔ Verificação de empate ("Deu Velha")
✔ Reinício automático do jogo após vitória ou empate
✔ Interface estilizada com cores, bordas, gradiente e responsividade

🖼️ Interface (XAML)

O layout utiliza Grid para organizar os 9 botões

Um gradiente de fundo deixa o visual mais agradável

Os botões foram estilizados com bordas, fonte grande e cor destacada


🧠 Lógica de funcionamento (C#)

Cada botão clicado exibe X ou O

O código verifica se existe uma das 8 combinações de vitória

Quando termina, o jogo mostra uma mensagem e chama o método Zerar()


📁 Estrutura do Projeto
📂 JogodaVelha/
 ├── MainPage.xaml          → Interface do jogo
 ├── MainPage.xaml.cs       → Código C# (lógica do jogo)
 ├── App.xaml               → Recursos globais do app
 └── App.xaml.cs            → Configuração inicial

🚀 Como executar o projeto

Clone o repositório:

git clone https://github.com/seu-usuario/jogo-da-velha-maui.git


Abra no Visual Studio 2022 (com suporte .NET MAUI instalado)

Selecione a plataforma:

✅ Windows

✅ Android Emulator

✅ iOS (em Mac)

Clique em F5 (Start)

🔥 Possíveis Melhorias Futuras

⭐ Destaque visual da linha vencedora

⭐ Placar de vitórias (X e O)

⭐ Botão de reiniciar manualmente

⭐ Adicionar modo vs computador (IA)

⭐ Adicionar sons e animações

🤝 Contribuições

Sinta-se à vontade para enviar pull requests, reportar bugs ou sugerir melhorias! 😄
