namespace JoKenPo
{
    partial class Form1
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPC = new System.Windows.Forms.Label();
            this.labelVoce = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultado.Location = new System.Drawing.Point(676, 221);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(26, 29);
            this.labelResultado.TabIndex = 26;
            this.labelResultado.Text = "?";
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(588, 354);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(200, 200);
            this.btnTesoura.TabIndex = 25;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(303, 354);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(200, 200);
            this.btnPapel.TabIndex = 24;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(12, 354);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(200, 200);
            this.btnPedra.TabIndex = 23;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // picResultado
            // 
            this.picResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResultado.Location = new System.Drawing.Point(588, 135);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(200, 200);
            this.picResultado.TabIndex = 22;
            this.picResultado.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(534, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(245, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "x";
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPC.Location = new System.Drawing.Point(371, 221);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(48, 29);
            this.labelPC.TabIndex = 19;
            this.labelPC.Text = "PC";
            // 
            // labelVoce
            // 
            this.labelVoce.AutoSize = true;
            this.labelVoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoce.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelVoce.Location = new System.Drawing.Point(75, 221);
            this.labelVoce.Name = "labelVoce";
            this.labelVoce.Size = new System.Drawing.Size(72, 29);
            this.labelVoce.TabIndex = 18;
            this.labelVoce.Text = "Você";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(13, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(775, 100);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "Escolha: Pedra, Papel ou Tesoura...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(303, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPC);
            this.Controls.Add(this.labelVoce);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, Papel ou Tesoura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Label labelVoce;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

