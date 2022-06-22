
namespace CadastroDesktop
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
            this.contextoView1 = new CadastroDesktop.Views.ContextoView.ContextoView();
            this.SuspendLayout();
            // 
            // contextoView1
            // 
            this.contextoView1.Appearance.BackColor = System.Drawing.Color.White;
            this.contextoView1.Appearance.Options.UseBackColor = true;
            this.contextoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contextoView1.Location = new System.Drawing.Point(0, 0);
            this.contextoView1.Name = "contextoView1";
            this.contextoView1.Size = new System.Drawing.Size(800, 450);
            this.contextoView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contextoView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.ContextoView.ContextoView contextoView1;
    }
}

