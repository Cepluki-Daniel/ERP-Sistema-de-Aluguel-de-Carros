namespace SQL_Teste1
{
    partial class Manutencao
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
            this.btnTelaManutencao = new System.Windows.Forms.Button();
            this.btnTelaFinanceiro = new System.Windows.Forms.Button();
            this.btnTelaFrota = new System.Windows.Forms.Button();
            this.btnTelaLocar = new System.Windows.Forms.Button();
            this.btnTelaFuncionario = new System.Windows.Forms.Button();
            this.btnTelaVeiculo = new System.Windows.Forms.Button();
            this.btnTelaUsuario = new System.Windows.Forms.Button();
            this.lblManutencao = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnTelaManutencao
            // 
            this.btnTelaManutencao.Location = new System.Drawing.Point(829, 690);
            this.btnTelaManutencao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaManutencao.Name = "btnTelaManutencao";
            this.btnTelaManutencao.Size = new System.Drawing.Size(133, 64);
            this.btnTelaManutencao.TabIndex = 46;
            this.btnTelaManutencao.Text = "Manutenção";
            this.btnTelaManutencao.UseVisualStyleBackColor = true;
            // 
            // btnTelaFinanceiro
            // 
            this.btnTelaFinanceiro.Location = new System.Drawing.Point(696, 690);
            this.btnTelaFinanceiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaFinanceiro.Name = "btnTelaFinanceiro";
            this.btnTelaFinanceiro.Size = new System.Drawing.Size(133, 64);
            this.btnTelaFinanceiro.TabIndex = 45;
            this.btnTelaFinanceiro.Text = "Financeiro";
            this.btnTelaFinanceiro.UseVisualStyleBackColor = true;
            this.btnTelaFinanceiro.Click += new System.EventHandler(this.btnTelaFinanceiro_Click_1);
            // 
            // btnTelaFrota
            // 
            this.btnTelaFrota.Location = new System.Drawing.Point(563, 690);
            this.btnTelaFrota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaFrota.Name = "btnTelaFrota";
            this.btnTelaFrota.Size = new System.Drawing.Size(133, 64);
            this.btnTelaFrota.TabIndex = 44;
            this.btnTelaFrota.Text = "Controle da Frota";
            this.btnTelaFrota.UseVisualStyleBackColor = true;
            this.btnTelaFrota.Click += new System.EventHandler(this.btnTelaFrota_Click_1);
            // 
            // btnTelaLocar
            // 
            this.btnTelaLocar.Location = new System.Drawing.Point(430, 690);
            this.btnTelaLocar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaLocar.Name = "btnTelaLocar";
            this.btnTelaLocar.Size = new System.Drawing.Size(133, 64);
            this.btnTelaLocar.TabIndex = 43;
            this.btnTelaLocar.Text = "Locar veículo";
            this.btnTelaLocar.UseVisualStyleBackColor = true;
            this.btnTelaLocar.Click += new System.EventHandler(this.btnTelaLocar_Click);
            // 
            // btnTelaFuncionario
            // 
            this.btnTelaFuncionario.Location = new System.Drawing.Point(297, 690);
            this.btnTelaFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaFuncionario.Name = "btnTelaFuncionario";
            this.btnTelaFuncionario.Size = new System.Drawing.Size(133, 64);
            this.btnTelaFuncionario.TabIndex = 42;
            this.btnTelaFuncionario.Text = "Cadastrar Funcionário";
            this.btnTelaFuncionario.UseVisualStyleBackColor = true;
            this.btnTelaFuncionario.Click += new System.EventHandler(this.btnTelaFuncionario_Click);
            // 
            // btnTelaVeiculo
            // 
            this.btnTelaVeiculo.Location = new System.Drawing.Point(163, 690);
            this.btnTelaVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaVeiculo.Name = "btnTelaVeiculo";
            this.btnTelaVeiculo.Size = new System.Drawing.Size(133, 64);
            this.btnTelaVeiculo.TabIndex = 41;
            this.btnTelaVeiculo.Text = "Cadastrar Veículo";
            this.btnTelaVeiculo.UseVisualStyleBackColor = true;
            this.btnTelaVeiculo.Click += new System.EventHandler(this.btnTelaVeiculo_Click_1);
            // 
            // btnTelaUsuario
            // 
            this.btnTelaUsuario.Location = new System.Drawing.Point(30, 690);
            this.btnTelaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaUsuario.Name = "btnTelaUsuario";
            this.btnTelaUsuario.Size = new System.Drawing.Size(133, 64);
            this.btnTelaUsuario.TabIndex = 40;
            this.btnTelaUsuario.Text = "Cadastrar Usuário";
            this.btnTelaUsuario.UseVisualStyleBackColor = true;
            this.btnTelaUsuario.Click += new System.EventHandler(this.btnTelaUsuario_Click);
            // 
            // lblManutencao
            // 
            this.lblManutencao.AutoSize = true;
            this.lblManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManutencao.Location = new System.Drawing.Point(273, 27);
            this.lblManutencao.Name = "lblManutencao";
            this.lblManutencao.Size = new System.Drawing.Size(389, 39);
            this.lblManutencao.TabIndex = 47;
            this.lblManutencao.Text = "Controle de Manutenção";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(271, 152);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 48;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblManutencao);
            this.Controls.Add(this.btnTelaManutencao);
            this.Controls.Add(this.btnTelaFinanceiro);
            this.Controls.Add(this.btnTelaFrota);
            this.Controls.Add(this.btnTelaLocar);
            this.Controls.Add(this.btnTelaFuncionario);
            this.Controls.Add(this.btnTelaVeiculo);
            this.Controls.Add(this.btnTelaUsuario);
            this.Name = "Manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelaManutencao;
        private System.Windows.Forms.Button btnTelaFinanceiro;
        private System.Windows.Forms.Button btnTelaFrota;
        private System.Windows.Forms.Button btnTelaLocar;
        private System.Windows.Forms.Button btnTelaFuncionario;
        private System.Windows.Forms.Button btnTelaVeiculo;
        private System.Windows.Forms.Button btnTelaUsuario;
        private System.Windows.Forms.Label lblManutencao;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}