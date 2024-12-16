using System;
using System.Windows.Forms;
using System.Drawing;

namespace RPG_GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public partial class Form1 : Form
    {
        private Personagem jogador;
        private Personagem inimigo;
        private Random random = new Random();
        private bool jogadorDefendendo = false;

        public Form1()
        {
            InitializeComponent();
            InicializarJogo();
        }

        private void InicializarJogo()
        {
            // Inicializa personagens
            jogador = new Personagem("Herói", 100, 15, 5);
            inimigo = new Personagem("Goblin", 80, 10, 3);

            picJogador.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "heroi.png");
            picInimigo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "globin.png");


            AtualizarStatus();
            AdicionarLog("Bem-vindo ao Simulador de RPG!");
            AdicionarLog($"Você é {jogador.Nome}. Prepare-se para enfrentar {inimigo.Nome}!\n");
        }

        private void AtualizarStatus()
        {
            lblJogador.Text = $"{jogador.Nome} - HP: {jogador.PontosDeVida}";
            lblInimigo.Text = $"{inimigo.Nome} - HP: {inimigo.PontosDeVida}";
        }

        private void AdicionarLog(string mensagem)
        {
            txtLog.AppendText(mensagem + Environment.NewLine);
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            // Turno do jogador
            int dadoJogador = jogador.RolarDado();
            int dano = jogador.Atacar() + dadoJogador;
            AdicionarLog($"Você atacou {inimigo.Nome}, dado caiu {dadoJogador}, causando {dano} de dano!");
            inimigo.ReceberDano(dano);

            if (inimigo.PontosDeVida <= 0)
            {
                AdicionarLog("Parabéns! Você venceu a batalha!");
                FinalizarJogo();
                return;
            }

            TurnoInimigo();
        }

        private void btnDefender_Click(object sender, EventArgs e)
        {
            jogadorDefendendo = true;
            AdicionarLog("Você escolheu defender! O próximo ataque será reduzido se você vencer a rolagem de dado.");
            TurnoInimigo();
        }

        private void TurnoInimigo()
        {
            int dadoInimigo = inimigo.RolarDado();
            int danoInimigo = inimigo.Atacar() + dadoInimigo;

            if (jogadorDefendendo)
            {
                int dadoJogador = jogador.RolarDado();
                AdicionarLog($"Defesa! Você rolou {dadoJogador} e {inimigo.Nome} rolou {dadoInimigo}.");

                if (dadoJogador > dadoInimigo)
                {
                    AdicionarLog("Você bloqueou completamente o ataque!");
                }
                else if (dadoJogador == dadoInimigo)
                {
                    danoInimigo /= 2;
                    jogador.ReceberDano(danoInimigo);
                    AdicionarLog($"Ataque parcialmente bloqueado! Você recebeu {danoInimigo} de dano.");
                }
                else
                {
                    jogador.ReceberDano(danoInimigo);
                    AdicionarLog($"{inimigo.Nome} atacou e você não conseguiu defender. Recebeu {danoInimigo} de dano.");
                }

                jogadorDefendendo = false;
            }
            else
            {
                jogador.ReceberDano(danoInimigo);
                AdicionarLog($"{inimigo.Nome} atacou você, dado caiu {dadoInimigo}, causando {danoInimigo} de dano!");
            }

            if (jogador.PontosDeVida <= 0)
            {
                AdicionarLog("Você foi derrotado... Tente novamente!");
                FinalizarJogo();
            }

            AtualizarStatus();
        }

        private void FinalizarJogo()
        {
            btnAtacar.Enabled = false;
            btnDefender.Enabled = false;
        }
    }

    public class Personagem
    {
        public string Nome { get; private set; }
        public int PontosDeVida { get; private set; }
        public int Ataque { get; private set; }
        public int Defesa { get; private set; }

        private Random random = new Random();

        public Personagem(string nome, int pontosDeVida, int ataque, int defesa)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            Ataque = ataque;
            Defesa = defesa;
        }

        public int Atacar()
        {
            return random.Next(Ataque - 2, Ataque + 3);
        }

        public int RolarDado()
        {
            return random.Next(1, 11);
        }

        public void ReceberDano(int dano)
        {
            PontosDeVida -= Math.Max(dano - Defesa, 0);
            if (PontosDeVida < 0) PontosDeVida = 0;
        }
    }
}
