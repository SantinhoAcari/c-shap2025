namespace santinhoMessageShow
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
            this.gbx_alertas = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gbx_alertas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_alertas
            // 
            this.gbx_alertas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_alertas.BackColor = System.Drawing.Color.Gainsboro;
            this.gbx_alertas.BackgroundImage = global::santinhoMessageShow.Properties.Resources.space;
            this.gbx_alertas.Controls.Add(this.button4);
            this.gbx_alertas.Controls.Add(this.button5);
            this.gbx_alertas.Controls.Add(this.button3);
            this.gbx_alertas.Controls.Add(this.button2);
            this.gbx_alertas.Controls.Add(this.button1);
            this.gbx_alertas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbx_alertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_alertas.ForeColor = System.Drawing.Color.Blue;
            this.gbx_alertas.Location = new System.Drawing.Point(24, 24);
            this.gbx_alertas.Name = "gbx_alertas";
            this.gbx_alertas.Size = new System.Drawing.Size(755, 410);
            this.gbx_alertas.TabIndex = 0;
            this.gbx_alertas.TabStop = false;
            this.gbx_alertas.Text = "Tipos de Alertas em C#";
            this.gbx_alertas.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alerta Simples";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Alerta Simples com Título";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 66);
            this.button3.TabIndex = 0;
            this.button3.Text = "Alerta com Sim, Não e Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Alerta com Sim ou Não";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Alerta com Ícone Crítico";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_alertas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx_alertas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_alertas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

