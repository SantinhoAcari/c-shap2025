namespace DOGAO2025
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNrestaurar = new System.Windows.Forms.Button();
            this.BTNicon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNmaximizar = new System.Windows.Forms.Button();
            this.BTNfechar = new System.Windows.Forms.Button();
            this.PANELconteudo = new System.Windows.Forms.Panel();
            this.BTNcaixa = new System.Windows.Forms.Button();
            this.BTNdelivery = new System.Windows.Forms.Button();
            this.BTNclientes = new System.Windows.Forms.Button();
            this.BTNpedidos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PANELconteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.BTNfechar);
            this.panel1.Controls.Add(this.BTNrestaurar);
            this.panel1.Controls.Add(this.BTNicon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTNmaximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNrestaurar
            // 
            this.BTNrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNrestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNrestaurar.BackgroundImage")));
            this.BTNrestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNrestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNrestaurar.FlatAppearance.BorderSize = 0;
            this.BTNrestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNrestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNrestaurar.Location = new System.Drawing.Point(714, 0);
            this.BTNrestaurar.Name = "BTNrestaurar";
            this.BTNrestaurar.Size = new System.Drawing.Size(40, 40);
            this.BTNrestaurar.TabIndex = 0;
            this.BTNrestaurar.UseVisualStyleBackColor = true;
            this.BTNrestaurar.Click += new System.EventHandler(this.BTNrestaurar_Click);
            // 
            // BTNicon
            // 
            this.BTNicon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BTNicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNicon.BackgroundImage")));
            this.BTNicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNicon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNicon.FlatAppearance.BorderSize = 0;
            this.BTNicon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNicon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNicon.Location = new System.Drawing.Point(-2, 2);
            this.BTNicon.Margin = new System.Windows.Forms.Padding(0);
            this.BTNicon.Name = "BTNicon";
            this.BTNicon.Size = new System.Drawing.Size(44, 39);
            this.BTNicon.TabIndex = 0;
            this.BTNicon.UseVisualStyleBackColor = true;
            this.BTNicon.Click += new System.EventHandler(this.BTNrestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dogao - O Melhor App da A3 - Prof. Wanfranklin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNmaximizar
            // 
            this.BTNmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNmaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNmaximizar.BackgroundImage")));
            this.BTNmaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNmaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNmaximizar.FlatAppearance.BorderSize = 0;
            this.BTNmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNmaximizar.Location = new System.Drawing.Point(714, 0);
            this.BTNmaximizar.Name = "BTNmaximizar";
            this.BTNmaximizar.Size = new System.Drawing.Size(40, 40);
            this.BTNmaximizar.TabIndex = 0;
            this.BTNmaximizar.TabStop = false;
            this.BTNmaximizar.UseVisualStyleBackColor = true;
            this.BTNmaximizar.Click += new System.EventHandler(this.BTNmaximizar_Click);
            // 
            // BTNfechar
            // 
            this.BTNfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNfechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNfechar.BackgroundImage")));
            this.BTNfechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNfechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNfechar.FlatAppearance.BorderSize = 0;
            this.BTNfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNfechar.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfechar.Location = new System.Drawing.Point(760, 0);
            this.BTNfechar.Name = "BTNfechar";
            this.BTNfechar.Size = new System.Drawing.Size(40, 40);
            this.BTNfechar.TabIndex = 0;
            this.BTNfechar.UseVisualStyleBackColor = true;
            this.BTNfechar.Click += new System.EventHandler(this.BTNfechar_Click);
            // 
            // PANELconteudo
            // 
            this.PANELconteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PANELconteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PANELconteudo.Controls.Add(this.BTNcaixa);
            this.PANELconteudo.Controls.Add(this.BTNdelivery);
            this.PANELconteudo.Controls.Add(this.BTNclientes);
            this.PANELconteudo.Controls.Add(this.BTNpedidos);
            this.PANELconteudo.Location = new System.Drawing.Point(-2, 0);
            this.PANELconteudo.Name = "PANELconteudo";
            this.PANELconteudo.Size = new System.Drawing.Size(201, 450);
            this.PANELconteudo.TabIndex = 2;
            // 
            // BTNcaixa
            // 
            this.BTNcaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNcaixa.BackgroundImage")));
            this.BTNcaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNcaixa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNcaixa.FlatAppearance.BorderSize = 0;
            this.BTNcaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNcaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BTNcaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcaixa.ForeColor = System.Drawing.Color.White;
            this.BTNcaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNcaixa.Location = new System.Drawing.Point(5, 245);
            this.BTNcaixa.Name = "BTNcaixa";
            this.BTNcaixa.Size = new System.Drawing.Size(198, 64);
            this.BTNcaixa.TabIndex = 3;
            this.BTNcaixa.Text = "Caixa    ";
            this.BTNcaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNcaixa.UseVisualStyleBackColor = true;
            // 
            // BTNdelivery
            // 
            this.BTNdelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNdelivery.BackgroundImage")));
            this.BTNdelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNdelivery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNdelivery.FlatAppearance.BorderSize = 0;
            this.BTNdelivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNdelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BTNdelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNdelivery.ForeColor = System.Drawing.Color.White;
            this.BTNdelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNdelivery.Location = new System.Drawing.Point(0, 315);
            this.BTNdelivery.Name = "BTNdelivery";
            this.BTNdelivery.Size = new System.Drawing.Size(198, 64);
            this.BTNdelivery.TabIndex = 3;
            this.BTNdelivery.Text = " Delivery";
            this.BTNdelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNdelivery.UseVisualStyleBackColor = true;
            // 
            // BTNclientes
            // 
            this.BTNclientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNclientes.BackgroundImage")));
            this.BTNclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNclientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNclientes.FlatAppearance.BorderSize = 0;
            this.BTNclientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BTNclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNclientes.ForeColor = System.Drawing.Color.White;
            this.BTNclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNclientes.Location = new System.Drawing.Point(5, 165);
            this.BTNclientes.Name = "BTNclientes";
            this.BTNclientes.Size = new System.Drawing.Size(198, 64);
            this.BTNclientes.TabIndex = 3;
            this.BTNclientes.Text = "Clientes";
            this.BTNclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNclientes.UseVisualStyleBackColor = true;
            // 
            // BTNpedidos
            // 
            this.BTNpedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNpedidos.BackgroundImage")));
            this.BTNpedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNpedidos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNpedidos.FlatAppearance.BorderSize = 0;
            this.BTNpedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNpedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BTNpedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNpedidos.ForeColor = System.Drawing.Color.White;
            this.BTNpedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNpedidos.Location = new System.Drawing.Point(0, 85);
            this.BTNpedidos.Name = "BTNpedidos";
            this.BTNpedidos.Size = new System.Drawing.Size(198, 64);
            this.BTNpedidos.TabIndex = 3;
            this.BTNpedidos.Text = "Pedidos";
            this.BTNpedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNpedidos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PANELconteudo);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dogao - O Melhor App da A3 - Prof. Wanfranklin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PANELconteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNfechar;
        private System.Windows.Forms.Button BTNrestaurar;
        private System.Windows.Forms.Button BTNmaximizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PANELconteudo;
        private System.Windows.Forms.Button BTNpedidos;
        private System.Windows.Forms.Button BTNcaixa;
        private System.Windows.Forms.Button BTNdelivery;
        private System.Windows.Forms.Button BTNclientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTNicon;
    }
}