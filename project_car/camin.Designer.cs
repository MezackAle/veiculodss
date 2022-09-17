namespace project_car
{
    partial class frmcami
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbau = new System.Windows.Forms.TextBox();
            this.txtcarga = new System.Windows.Forms.TextBox();
            this.txtrodas = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtcha = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.btnexibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAMENTO CAMINHÃO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade de carga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de rodas:";
            // 
            // txtbau
            // 
            this.txtbau.Location = new System.Drawing.Point(593, 143);
            this.txtbau.Multiline = true;
            this.txtbau.Name = "txtbau";
            this.txtbau.Size = new System.Drawing.Size(126, 34);
            this.txtbau.TabIndex = 7;
            // 
            // txtcarga
            // 
            this.txtcarga.Location = new System.Drawing.Point(593, 207);
            this.txtcarga.Multiline = true;
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.Size = new System.Drawing.Size(126, 30);
            this.txtcarga.TabIndex = 8;
            // 
            // txtrodas
            // 
            this.txtrodas.Location = new System.Drawing.Point(593, 74);
            this.txtrodas.Multiline = true;
            this.txtrodas.Name = "txtrodas";
            this.txtrodas.Size = new System.Drawing.Size(126, 35);
            this.txtrodas.TabIndex = 10;
            this.txtrodas.TextChanged += new System.EventHandler(this.txtrodas_TextChanged);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(44, 510);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(133, 50);
            this.btncadastrar.TabIndex = 11;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(404, 510);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(133, 50);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(655, 509);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(133, 50);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Modelo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chassi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quilometragem:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ano:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Placa:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(205, 149);
            this.txtmarca.Multiline = true;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(125, 28);
            this.txtmarca.TabIndex = 21;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(205, 82);
            this.txtmodel.Multiline = true;
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(125, 27);
            this.txtmodel.TabIndex = 22;
            // 
            // txtcha
            // 
            this.txtcha.Location = new System.Drawing.Point(205, 207);
            this.txtcha.Multiline = true;
            this.txtcha.Name = "txtcha";
            this.txtcha.Size = new System.Drawing.Size(125, 29);
            this.txtcha.TabIndex = 23;
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(205, 437);
            this.txtkm.Multiline = true;
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(125, 29);
            this.txtkm.TabIndex = 24;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(205, 322);
            this.txtcor.Multiline = true;
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(125, 31);
            this.txtcor.TabIndex = 25;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(205, 376);
            this.txtano.Multiline = true;
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(125, 32);
            this.txtano.TabIndex = 26;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(205, 264);
            this.txtplaca.Multiline = true;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(125, 33);
            this.txtplaca.TabIndex = 27;
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.Location = new System.Drawing.Point(220, 510);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(133, 49);
            this.btnexibir.TabIndex = 28;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // frmcami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtcha);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtrodas);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.txtbau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastramento do Caminhão";
            this.Load += new System.EventHandler(this.frmcami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbau;
        private System.Windows.Forms.TextBox txtcarga;
        private System.Windows.Forms.TextBox txtrodas;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtcha;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btnexibir;
    }
}