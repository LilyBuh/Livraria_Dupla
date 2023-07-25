namespace Livraria_Dupla.View
{
    partial class Buscar_Livro
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlivro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Livro no Acervo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(156, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o código";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(156, 96);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(128, 23);
            this.txtcod.TabIndex = 2;
            this.txtcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(302, 220);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(128, 23);
            this.txtpreco.TabIndex = 4;
            this.txtpreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço";
            // 
            // txteditora
            // 
            this.txteditora.Location = new System.Drawing.Point(156, 220);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(128, 23);
            this.txteditora.TabIndex = 6;
            this.txteditora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(189, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Editora";
            // 
            // txtlivro
            // 
            this.txtlivro.Location = new System.Drawing.Point(7, 220);
            this.txtlivro.Name = "txtlivro";
            this.txtlivro.Size = new System.Drawing.Size(128, 23);
            this.txtlivro.TabIndex = 8;
            this.txtlivro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Livro";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(179, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscar_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(434, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txteditora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Buscar_Livro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcod;
        private TextBox txtpreco;
        private Label label3;
        private TextBox txteditora;
        private Label label4;
        private TextBox txtlivro;
        private Label label5;
        private Button button1;
    }
}