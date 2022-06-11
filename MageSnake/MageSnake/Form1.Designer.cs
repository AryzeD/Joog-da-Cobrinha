namespace MageSnake
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strpMnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.strpMenuGiveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRuneterra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpMnuRestart,
            this.strpMenuGiveUp});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // strpMnuRestart
            // 
            this.strpMnuRestart.Name = "strpMnuRestart";
            this.strpMnuRestart.Size = new System.Drawing.Size(180, 22);
            this.strpMnuRestart.Text = "Restart";
            this.strpMnuRestart.Click += new System.EventHandler(this.strpMnuRestart_Click);
            // 
            // strpMenuGiveUp
            // 
            this.strpMenuGiveUp.Name = "strpMenuGiveUp";
            this.strpMenuGiveUp.Size = new System.Drawing.Size(180, 22);
            this.strpMenuGiveUp.Text = "Give up";
            this.strpMenuGiveUp.Click += new System.EventHandler(this.strpMenuGiveUp_Click);
            // 
            // pnlRuneterra
            // 
            this.pnlRuneterra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRuneterra.BackgroundImage")));
            this.pnlRuneterra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRuneterra.Location = new System.Drawing.Point(0, 27);
            this.pnlRuneterra.Name = "pnlRuneterra";
            this.pnlRuneterra.Size = new System.Drawing.Size(550, 550);
            this.pnlRuneterra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pontuação:";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(354, 7);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(13, 13);
            this.lblPontuacao.TabIndex = 3;
            this.lblPontuacao.Text = "0";
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 574);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRuneterra);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mage Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clicado);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strpMnuRestart;
        private System.Windows.Forms.ToolStripMenuItem strpMenuGiveUp;
        private System.Windows.Forms.Panel pnlRuneterra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Timer Frame;
    }
}

