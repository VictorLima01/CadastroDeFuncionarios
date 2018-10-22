namespace ProjetoLPOO_UI
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
            this.UsuarioOBJ = new System.Windows.Forms.TextBox();
            this.SenhaOBJ = new System.Windows.Forms.TextBox();
            this.ConfSenhaOBJ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // UsuarioOBJ
            // 
            this.UsuarioOBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.UsuarioOBJ.Location = new System.Drawing.Point(20, 36);
            this.UsuarioOBJ.Name = "UsuarioOBJ";
            this.UsuarioOBJ.Size = new System.Drawing.Size(237, 38);
            this.UsuarioOBJ.TabIndex = 0;
            this.UsuarioOBJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsuarioOBJ.TextChanged += new System.EventHandler(this.UsuarioOBJ_TextChanged);
            // 
            // SenhaOBJ
            // 
            this.SenhaOBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SenhaOBJ.Location = new System.Drawing.Point(20, 105);
            this.SenhaOBJ.Name = "SenhaOBJ";
            this.SenhaOBJ.PasswordChar = '*';
            this.SenhaOBJ.Size = new System.Drawing.Size(237, 38);
            this.SenhaOBJ.TabIndex = 1;
            this.SenhaOBJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SenhaOBJ.TextChanged += new System.EventHandler(this.SenhaOBJ_TextChanged);
            // 
            // ConfSenhaOBJ
            // 
            this.ConfSenhaOBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ConfSenhaOBJ.Location = new System.Drawing.Point(20, 174);
            this.ConfSenhaOBJ.Name = "ConfSenhaOBJ";
            this.ConfSenhaOBJ.PasswordChar = '*';
            this.ConfSenhaOBJ.Size = new System.Drawing.Size(237, 38);
            this.ConfSenhaOBJ.TabIndex = 2;
            this.ConfSenhaOBJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(125, 259);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ESQUECI MINHA SENHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(278, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfSenhaOBJ);
            this.Controls.Add(this.SenhaOBJ);
            this.Controls.Add(this.UsuarioOBJ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioOBJ;
        private System.Windows.Forms.TextBox SenhaOBJ;
        private System.Windows.Forms.TextBox ConfSenhaOBJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

