namespace SQL_Teste1
{
    partial class CadastroFuncionário
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
            this.lblCadastroFuncionario = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCPFFuncionario = new System.Windows.Forms.Label();
            this.lblSexoFuncionario = new System.Windows.Forms.Label();
            this.lblCargoFuncionario = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblDataAdm = new System.Windows.Forms.Label();
            this.lblNascimentoFuncionario = new System.Windows.Forms.Label();
            this.lblEnderecoFuncionario = new System.Windows.Forms.Label();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.boxCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.boxNascimentoFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.boxSexoFuncionario = new System.Windows.Forms.ComboBox();
            this.boxCargo = new System.Windows.Forms.ComboBox();
            this.boxSetor = new System.Windows.Forms.ComboBox();
            this.boxDataAdm = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.lblDataDem = new System.Windows.Forms.Label();
            this.boxDataDem = new System.Windows.Forms.MaskedTextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.boxSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTelaManutencao
            // 
            this.btnTelaManutencao.Location = new System.Drawing.Point(829, 690);
            this.btnTelaManutencao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaManutencao.Name = "btnTelaManutencao";
            this.btnTelaManutencao.Size = new System.Drawing.Size(133, 64);
            this.btnTelaManutencao.TabIndex = 32;
            this.btnTelaManutencao.Text = "Manutenção";
            this.btnTelaManutencao.UseVisualStyleBackColor = true;
            this.btnTelaManutencao.Click += new System.EventHandler(this.btnTelaManutencao_Click);
            // 
            // btnTelaFinanceiro
            // 
            this.btnTelaFinanceiro.Location = new System.Drawing.Point(696, 690);
            this.btnTelaFinanceiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaFinanceiro.Name = "btnTelaFinanceiro";
            this.btnTelaFinanceiro.Size = new System.Drawing.Size(133, 64);
            this.btnTelaFinanceiro.TabIndex = 31;
            this.btnTelaFinanceiro.Text = "Financeiro";
            this.btnTelaFinanceiro.UseVisualStyleBackColor = true;
            this.btnTelaFinanceiro.Click += new System.EventHandler(this.btnTelaFinanceiro_Click);
            // 
            // btnTelaFrota
            // 
            this.btnTelaFrota.Location = new System.Drawing.Point(563, 690);
            this.btnTelaFrota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaFrota.Name = "btnTelaFrota";
            this.btnTelaFrota.Size = new System.Drawing.Size(133, 64);
            this.btnTelaFrota.TabIndex = 30;
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
            this.btnTelaLocar.TabIndex = 29;
            this.btnTelaLocar.Text = "Locar veículo";
            this.btnTelaLocar.UseVisualStyleBackColor = true;
            this.btnTelaLocar.Click += new System.EventHandler(this.btnTelaLocar_Click_1);
            // 
            // btnTelaFuncionario
            // 
            this.btnTelaFuncionario.Location = new System.Drawing.Point(297, 690);
            this.btnTelaFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaFuncionario.Name = "btnTelaFuncionario";
            this.btnTelaFuncionario.Size = new System.Drawing.Size(133, 64);
            this.btnTelaFuncionario.TabIndex = 28;
            this.btnTelaFuncionario.Text = "Cadastrar Funcionário";
            this.btnTelaFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnTelaVeiculo
            // 
            this.btnTelaVeiculo.Location = new System.Drawing.Point(163, 690);
            this.btnTelaVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaVeiculo.Name = "btnTelaVeiculo";
            this.btnTelaVeiculo.Size = new System.Drawing.Size(133, 64);
            this.btnTelaVeiculo.TabIndex = 27;
            this.btnTelaVeiculo.Text = "Cadastrar Veículo";
            this.btnTelaVeiculo.UseVisualStyleBackColor = true;
            this.btnTelaVeiculo.Click += new System.EventHandler(this.btnTelaVeiculo_Click);
            // 
            // btnTelaUsuario
            // 
            this.btnTelaUsuario.Location = new System.Drawing.Point(30, 690);
            this.btnTelaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTelaUsuario.Name = "btnTelaUsuario";
            this.btnTelaUsuario.Size = new System.Drawing.Size(133, 64);
            this.btnTelaUsuario.TabIndex = 26;
            this.btnTelaUsuario.Text = "Cadastrar Usuário";
            this.btnTelaUsuario.UseVisualStyleBackColor = true;
            this.btnTelaUsuario.Click += new System.EventHandler(this.btnTelaUsuario_Click);
            // 
            // lblCadastroFuncionario
            // 
            this.lblCadastroFuncionario.AutoSize = true;
            this.lblCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroFuncionario.Location = new System.Drawing.Point(260, 24);
            this.lblCadastroFuncionario.Name = "lblCadastroFuncionario";
            this.lblCadastroFuncionario.Size = new System.Drawing.Size(390, 39);
            this.lblCadastroFuncionario.TabIndex = 33;
            this.lblCadastroFuncionario.Text = "Cadastro de Funcionário";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(72, 120);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(153, 25);
            this.lblNomeFuncionario.TabIndex = 34;
            this.lblNomeFuncionario.Text = "Nome Completo";
            // 
            // lblCPFFuncionario
            // 
            this.lblCPFFuncionario.AutoSize = true;
            this.lblCPFFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFFuncionario.Location = new System.Drawing.Point(184, 180);
            this.lblCPFFuncionario.Name = "lblCPFFuncionario";
            this.lblCPFFuncionario.Size = new System.Drawing.Size(52, 25);
            this.lblCPFFuncionario.TabIndex = 35;
            this.lblCPFFuncionario.Text = "CPF";
            // 
            // lblSexoFuncionario
            // 
            this.lblSexoFuncionario.AutoSize = true;
            this.lblSexoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoFuncionario.Location = new System.Drawing.Point(175, 300);
            this.lblSexoFuncionario.Name = "lblSexoFuncionario";
            this.lblSexoFuncionario.Size = new System.Drawing.Size(58, 25);
            this.lblSexoFuncionario.TabIndex = 36;
            this.lblSexoFuncionario.Text = "Sexo";
            // 
            // lblCargoFuncionario
            // 
            this.lblCargoFuncionario.AutoSize = true;
            this.lblCargoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFuncionario.Location = new System.Drawing.Point(170, 360);
            this.lblCargoFuncionario.Name = "lblCargoFuncionario";
            this.lblCargoFuncionario.Size = new System.Drawing.Size(66, 25);
            this.lblCargoFuncionario.TabIndex = 37;
            this.lblCargoFuncionario.Text = "Cargo";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(175, 420);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(59, 25);
            this.lblSetor.TabIndex = 38;
            this.lblSetor.Text = "Setor";
            // 
            // lblDataAdm
            // 
            this.lblDataAdm.AutoSize = true;
            this.lblDataAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAdm.Location = new System.Drawing.Point(57, 480);
            this.lblDataAdm.Name = "lblDataAdm";
            this.lblDataAdm.Size = new System.Drawing.Size(172, 25);
            this.lblDataAdm.TabIndex = 39;
            this.lblDataAdm.Text = "Data de Admissão";
            // 
            // lblNascimentoFuncionario
            // 
            this.lblNascimentoFuncionario.AutoSize = true;
            this.lblNascimentoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimentoFuncionario.Location = new System.Drawing.Point(36, 240);
            this.lblNascimentoFuncionario.Name = "lblNascimentoFuncionario";
            this.lblNascimentoFuncionario.Size = new System.Drawing.Size(188, 25);
            this.lblNascimentoFuncionario.TabIndex = 40;
            this.lblNascimentoFuncionario.Text = "Data de Nascimento";
            // 
            // lblEnderecoFuncionario
            // 
            this.lblEnderecoFuncionario.AutoSize = true;
            this.lblEnderecoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoFuncionario.Location = new System.Drawing.Point(132, 537);
            this.lblEnderecoFuncionario.Name = "lblEnderecoFuncionario";
            this.lblEnderecoFuncionario.Size = new System.Drawing.Size(96, 25);
            this.lblEnderecoFuncionario.TabIndex = 41;
            this.lblEnderecoFuncionario.Text = "Endereço";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(391, 580);
            this.btnCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(156, 40);
            this.btnCadastrarFuncionario.TabIndex = 42;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(275, 120);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(259, 22);
            this.txtNomeFuncionario.TabIndex = 43;
            // 
            // boxCPFFuncionario
            // 
            this.boxCPFFuncionario.Location = new System.Drawing.Point(275, 180);
            this.boxCPFFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCPFFuncionario.Mask = "000.000.000-00";
            this.boxCPFFuncionario.Name = "boxCPFFuncionario";
            this.boxCPFFuncionario.Size = new System.Drawing.Size(133, 22);
            this.boxCPFFuncionario.TabIndex = 44;
            // 
            // boxNascimentoFuncionario
            // 
            this.boxNascimentoFuncionario.Location = new System.Drawing.Point(275, 240);
            this.boxNascimentoFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNascimentoFuncionario.Mask = "00/00/0000";
            this.boxNascimentoFuncionario.Name = "boxNascimentoFuncionario";
            this.boxNascimentoFuncionario.Size = new System.Drawing.Size(133, 22);
            this.boxNascimentoFuncionario.TabIndex = 45;
            this.boxNascimentoFuncionario.ValidatingType = typeof(System.DateTime);
            // 
            // boxSexoFuncionario
            // 
            this.boxSexoFuncionario.FormattingEnabled = true;
            this.boxSexoFuncionario.Location = new System.Drawing.Point(275, 300);
            this.boxSexoFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSexoFuncionario.Name = "boxSexoFuncionario";
            this.boxSexoFuncionario.Size = new System.Drawing.Size(149, 24);
            this.boxSexoFuncionario.TabIndex = 46;
            // 
            // boxCargo
            // 
            this.boxCargo.FormattingEnabled = true;
            this.boxCargo.Location = new System.Drawing.Point(275, 360);
            this.boxCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCargo.Name = "boxCargo";
            this.boxCargo.Size = new System.Drawing.Size(149, 24);
            this.boxCargo.TabIndex = 47;
            // 
            // boxSetor
            // 
            this.boxSetor.FormattingEnabled = true;
            this.boxSetor.Location = new System.Drawing.Point(275, 420);
            this.boxSetor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSetor.Name = "boxSetor";
            this.boxSetor.Size = new System.Drawing.Size(149, 24);
            this.boxSetor.TabIndex = 48;
            // 
            // boxDataAdm
            // 
            this.boxDataAdm.Location = new System.Drawing.Point(275, 480);
            this.boxDataAdm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxDataAdm.Mask = "00/00/0000";
            this.boxDataAdm.Name = "boxDataAdm";
            this.boxDataAdm.Size = new System.Drawing.Size(133, 22);
            this.boxDataAdm.TabIndex = 49;
            this.boxDataAdm.ValidatingType = typeof(System.DateTime);
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(275, 537);
            this.txtEnderecoFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(259, 22);
            this.txtEnderecoFuncionario.TabIndex = 50;
            // 
            // lblDataDem
            // 
            this.lblDataDem.AutoSize = true;
            this.lblDataDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDem.Location = new System.Drawing.Point(545, 476);
            this.lblDataDem.Name = "lblDataDem";
            this.lblDataDem.Size = new System.Drawing.Size(162, 25);
            this.lblDataDem.TabIndex = 51;
            this.lblDataDem.Text = "Data de Demisão";
            this.lblDataDem.Click += new System.EventHandler(this.lblDataDem_Click);
            // 
            // boxDataDem
            // 
            this.boxDataDem.Location = new System.Drawing.Point(731, 476);
            this.boxDataDem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxDataDem.Mask = "00/00/0000";
            this.boxDataDem.Name = "boxDataDem";
            this.boxDataDem.Size = new System.Drawing.Size(133, 22);
            this.boxDataDem.TabIndex = 52;
            this.boxDataDem.ValidatingType = typeof(System.DateTime);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(627, 419);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(73, 25);
            this.lblSalario.TabIndex = 53;
            this.lblSalario.Text = "Salário";
            // 
            // boxSalario
            // 
            this.boxSalario.Location = new System.Drawing.Point(731, 423);
            this.boxSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(133, 22);
            this.boxSalario.TabIndex = 54;
            // 
            // CadastroFuncionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.boxSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.boxDataDem);
            this.Controls.Add(this.lblDataDem);
            this.Controls.Add(this.txtEnderecoFuncionario);
            this.Controls.Add(this.boxDataAdm);
            this.Controls.Add(this.boxSetor);
            this.Controls.Add(this.boxCargo);
            this.Controls.Add(this.boxSexoFuncionario);
            this.Controls.Add(this.boxNascimentoFuncionario);
            this.Controls.Add(this.boxCPFFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.lblEnderecoFuncionario);
            this.Controls.Add(this.lblNascimentoFuncionario);
            this.Controls.Add(this.lblDataAdm);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblCargoFuncionario);
            this.Controls.Add(this.lblSexoFuncionario);
            this.Controls.Add(this.lblCPFFuncionario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lblCadastroFuncionario);
            this.Controls.Add(this.btnTelaManutencao);
            this.Controls.Add(this.btnTelaFinanceiro);
            this.Controls.Add(this.btnTelaFrota);
            this.Controls.Add(this.btnTelaLocar);
            this.Controls.Add(this.btnTelaFuncionario);
            this.Controls.Add(this.btnTelaVeiculo);
            this.Controls.Add(this.btnTelaUsuario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroFuncionário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFuncionário";
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
        private System.Windows.Forms.Label lblCadastroFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCPFFuncionario;
        private System.Windows.Forms.Label lblSexoFuncionario;
        private System.Windows.Forms.Label lblCargoFuncionario;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblDataAdm;
        private System.Windows.Forms.Label lblNascimentoFuncionario;
        private System.Windows.Forms.Label lblEnderecoFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox boxCPFFuncionario;
        private System.Windows.Forms.MaskedTextBox boxNascimentoFuncionario;
        private System.Windows.Forms.ComboBox boxSexoFuncionario;
        private System.Windows.Forms.ComboBox boxCargo;
        private System.Windows.Forms.ComboBox boxSetor;
        private System.Windows.Forms.MaskedTextBox boxDataAdm;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.Label lblDataDem;
        private System.Windows.Forms.MaskedTextBox boxDataDem;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox boxSalario;
    }
}