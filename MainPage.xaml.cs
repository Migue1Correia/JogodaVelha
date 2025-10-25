namespace JogodaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X"; // Controla quem joga
        int jogadas = 0;  // Contador de jogadas para detectar empate

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Preenche o botão com X ou O
            button.Text = vez;
            button.IsEnabled = false;

            jogadas++;

            // Alterna o jogador
            vez = (vez == "X") ? "O" : "X";

            // Verifica vencedor
            if (VerificarVitoria("X"))
            {
                DisplayAlert("Fim de Jogo", "Jogador X venceu!", "OK");
                Zerar();
            }
            else if (VerificarVitoria("O"))
            {
                DisplayAlert("Fim de Jogo", "Jogador O venceu!", "OK");
                Zerar();
            }
            else if (jogadas == 9)
            {
                DisplayAlert("Empate", "Ninguém venceu!", "OK");
                Zerar();
            }
        }

        // Método que verifica se o jogador ganhou
        bool VerificarVitoria(string jogador)
        {
            return
                // Linhas
                (button10.Text == jogador && button11.Text == jogador && button12.Text == jogador) ||
                (button20.Text == jogador && button21.Text == jogador && button22.Text == jogador) ||
                (button30.Text == jogador && button31.Text == jogador && button32.Text == jogador) ||

                // Colunas
                (button10.Text == jogador && button20.Text == jogador && button30.Text == jogador) ||
                (button11.Text == jogador && button21.Text == jogador && button31.Text == jogador) ||
                (button12.Text == jogador && button22.Text == jogador && button32.Text == jogador) ||

                // Diagonais
                (button10.Text == jogador && button21.Text == jogador && button32.Text == jogador) ||
                (button12.Text == jogador && button21.Text == jogador && button30.Text == jogador);
        }

        // Reinicia o jogo
        void Zerar()
        {
            jogadas = 0;
            vez = "X";

            foreach (var child in mainGrid.Children) // mainGrid = grid do seu XAML
            {
                if (child is Button botao)
                {
                    botao.Text = "";
                    botao.IsEnabled = true;
                }
            }
        }
    }
}
