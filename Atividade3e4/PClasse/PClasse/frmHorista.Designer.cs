namespace PClasse
{
    partial class frmHorista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(233, 43);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            this.lblMatricula.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(233, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(233, 134);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(124, 20);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário por Hora";
            this.lblSalario.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(233, 178);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(134, 20);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Número de Horas";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(233, 224);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(195, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data Entrada na Empresa";
            this.lblData.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Location = new System.Drawing.Point(233, 273);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(103, 20);
            this.lblFaltas.TabIndex = 5;
            this.lblFaltas.Text = "Dias de Falta";
            this.lblFaltas.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(456, 43);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(109, 26);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(456, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 26);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(456, 134);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(109, 26);
            this.txtSalario.TabIndex = 8;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(456, 221);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(122, 26);
            this.txtData.TabIndex = 9;
            this.txtData.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(456, 178);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 26);
            this.txtHora.TabIndex = 10;
            this.txtHora.TextChanged += new System.EventHandler(this.TxtHora_TextChanged);
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(456, 273);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 26);
            this.txtFaltas.TabIndex = 11;
            this.txtFaltas.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(305, 319);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(213, 105);
            this.btnInstanciar.TabIndex = 12;
            this.btnInstanciar.Text = "Instanciar Horista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Button btnInstanciar;
    }
}