namespace Dogao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNicon = new System.Windows.Forms.Button();
            this.BTNminimizar = new System.Windows.Forms.Button();
            this.BTNmaximizar = new System.Windows.Forms.Button();
            this.BTNrestaurar = new System.Windows.Forms.Button();
            this.BTNfechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.BTNicon);
            this.panel1.Controls.Add(this.BTNminimizar);
            this.panel1.Controls.Add(this.BTNmaximizar);
            this.panel1.Controls.Add(this.BTNrestaurar);
            this.panel1.Controls.Add(this.BTNfechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // BTNicon
            // 
            this.BTNicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNicon.BackgroundImage")));
            this.BTNicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNicon.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTNicon.Location = new System.Drawing.Point(0, 0);
            this.BTNicon.Name = "BTNicon";
            this.BTNicon.Size = new System.Drawing.Size(51, 54);
            this.BTNicon.TabIndex = 4;
            this.BTNicon.UseVisualStyleBackColor = true;
            // 
            // BTNminimizar
            // 
            this.BTNminimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNminimizar.BackgroundImage")));
            this.BTNminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNminimizar.Location = new System.Drawing.Point(500, 0);
            this.BTNminimizar.Name = "BTNminimizar";
            this.BTNminimizar.Size = new System.Drawing.Size(75, 54);
            this.BTNminimizar.TabIndex = 3;
            this.BTNminimizar.UseVisualStyleBackColor = true;
            // 
            // BTNmaximizar
            // 
            this.BTNmaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNmaximizar.BackgroundImage")));
            this.BTNmaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNmaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNmaximizar.Location = new System.Drawing.Point(575, 0);
            this.BTNmaximizar.Name = "BTNmaximizar";
            this.BTNmaximizar.Size = new System.Drawing.Size(75, 54);
            this.BTNmaximizar.TabIndex = 2;
            this.BTNmaximizar.UseVisualStyleBackColor = true;
            this.BTNmaximizar.Click += new System.EventHandler(this.BTNmaximizar_Click);
            // 
            // BTNrestaurar
            // 
            this.BTNrestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNrestaurar.BackgroundImage")));
            this.BTNrestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNrestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNrestaurar.Location = new System.Drawing.Point(650, 0);
            this.BTNrestaurar.Name = "BTNrestaurar";
            this.BTNrestaurar.Size = new System.Drawing.Size(75, 54);
            this.BTNrestaurar.TabIndex = 1;
            this.BTNrestaurar.UseVisualStyleBackColor = true;
            this.BTNrestaurar.Click += new System.EventHandler(this.BTNrestaurar_Click);
            // 
            // BTNfechar
            // 
            this.BTNfechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNfechar.BackgroundImage")));
            this.BTNfechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNfechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNfechar.Location = new System.Drawing.Point(725, 0);
            this.BTNfechar.Name = "BTNfechar";
            this.BTNfechar.Size = new System.Drawing.Size(75, 54);
            this.BTNfechar.TabIndex = 0;
            this.BTNfechar.UseVisualStyleBackColor = true;
            this.BTNfechar.Click += new System.EventHandler(this.BTNfechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 396);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 396);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNicon;
        private System.Windows.Forms.Button BTNminimizar;
        private System.Windows.Forms.Button BTNmaximizar;
        private System.Windows.Forms.Button BTNrestaurar;
        private System.Windows.Forms.Button BTNfechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

