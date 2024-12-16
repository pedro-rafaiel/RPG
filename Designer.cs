using System;
using System.Drawing;
using System.Windows.Forms;


namespace RPG_GUI
{
    partial class Form1
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblInimigo = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnDefender = new System.Windows.Forms.Button();
            this.picJogador = new System.Windows.Forms.PictureBox();
            this.picInimigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInimigo)).BeginInit();
            this.SuspendLayout();

            // Configuração do formulário
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = Color.FromArgb(34, 31, 31); // Fundo escuro, estilo medieval
            this.Text = "RPG Simulador";
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // lblJogador
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new Font("Papyrus", 14F, FontStyle.Bold);
            this.lblJogador.ForeColor = Color.Gold;
            this.lblJogador.Location = new System.Drawing.Point(50, 20);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(150, 40);
            this.lblJogador.Text = "Jogador";

            // lblInimigo
            this.lblInimigo.AutoSize = true;
            this.lblInimigo.Font = new Font("Papyrus", 14F, FontStyle.Bold);
            this.lblInimigo.ForeColor = Color.Red;
            this.lblInimigo.Location = new System.Drawing.Point(600, 20);
            this.lblInimigo.Name = "lblInimigo";
            this.lblInimigo.Size = new System.Drawing.Size(120, 40);
            this.lblInimigo.Text = "Inimigo";

            // txtLog
            this.txtLog.Location = new System.Drawing.Point(200, 300);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(400, 120);
            this.txtLog.Font = new Font("Courier New", 10F, FontStyle.Regular);
            this.txtLog.BackColor = Color.Beige;
            this.txtLog.ForeColor = Color.DarkSlateGray;
            this.txtLog.ReadOnly = true;

            // btnAtacar
            this.btnAtacar.Location = new System.Drawing.Point(200, 250);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(100, 40);
            this.btnAtacar.Font = new Font("Papyrus", 10F, FontStyle.Bold);
            this.btnAtacar.BackColor = Color.DarkGreen;
            this.btnAtacar.ForeColor = Color.White;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);

            // btnDefender
            this.btnDefender.Location = new System.Drawing.Point(320, 250);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.Size = new System.Drawing.Size(100, 40);
            this.btnDefender.Font = new Font("Papyrus", 10F, FontStyle.Bold);
            this.btnDefender.BackColor = Color.DarkBlue;
            this.btnDefender.ForeColor = Color.White;
            this.btnDefender.Text = "Defender";
            this.btnDefender.UseVisualStyleBackColor = false;
            this.btnDefender.Click += new System.EventHandler(this.btnDefender_Click);

            // picJogador
            this.picJogador.Location = new System.Drawing.Point(50, 80);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(150, 150);
            this.picJogador.SizeMode = PictureBoxSizeMode.StretchImage;

            // picInimigo
            this.picInimigo.Location = new System.Drawing.Point(600, 80);
            this.picInimigo.Name = "picInimigo";
            this.picInimigo.Size = new System.Drawing.Size(150, 150);
            this.picInimigo.SizeMode = PictureBoxSizeMode.StretchImage;

            // Form1
            this.Controls.Add(this.picInimigo);
            this.Controls.Add(this.picJogador);
            this.Controls.Add(this.btnDefender);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblInimigo);
            this.Controls.Add(this.lblJogador);
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInimigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblInimigo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnDefender;
        private System.Windows.Forms.PictureBox picJogador;
        private System.Windows.Forms.PictureBox picInimigo;
    }
}
