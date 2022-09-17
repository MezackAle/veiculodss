namespace project_car
{
    partial class frmcadastro
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
            this.btncar = new System.Windows.Forms.Button();
            this.btncami = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncar
            // 
            this.btncar.BackColor = System.Drawing.Color.CadetBlue;
            this.btncar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncar.Location = new System.Drawing.Point(367, 188);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(294, 70);
            this.btncar.TabIndex = 1;
            this.btncar.Text = "Cadastrar Carro";
            this.btncar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncar.UseVisualStyleBackColor = false;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btncami
            // 
            this.btncami.BackColor = System.Drawing.Color.CadetBlue;
            this.btncami.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncami.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncami.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncami.Location = new System.Drawing.Point(34, 188);
            this.btncami.Name = "btncami";
            this.btncami.Size = new System.Drawing.Size(294, 70);
            this.btncami.TabIndex = 2;
            this.btncami.Text = "Cadastrar Caminhão";
            this.btncami.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncami.UseVisualStyleBackColor = false;
            this.btncami.Click += new System.EventHandler(this.btncami_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsair.Location = new System.Drawing.Point(568, 349);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(93, 55);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = global::project_car.Properties.Resources.remover;
            this.pictureBox3.Location = new System.Drawing.Point(619, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox2.Image = global::project_car.Properties.Resources.frente_do_caminhao_de_entrega;
            this.pictureBox2.Location = new System.Drawing.Point(259, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Image = global::project_car.Properties.Resources.carro_sedan_na_frente1;
            this.pictureBox1.Location = new System.Drawing.Point(580, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncami);
            this.Controls.Add(this.btncar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btncami;
        private System.Windows.Forms.Button btnsair;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

