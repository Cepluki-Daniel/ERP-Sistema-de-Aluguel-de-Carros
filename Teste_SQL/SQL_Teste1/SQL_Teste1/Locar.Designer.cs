namespace SQL_Teste1
{
    partial class Locar
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
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblLocar = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblDataRet = new System.Windows.Forms.Label();
            this.lblDataDev = new System.Windows.Forms.Label();
            this.btnTelaManutencao = new System.Windows.Forms.Button();
            this.btnTelaFinanceiro = new System.Windows.Forms.Button();
            this.btnTelaFrota = new System.Windows.Forms.Button();
            this.btnTelaLocar = new System.Windows.Forms.Button();
            this.btnTelaFuncionario = new System.Windows.Forms.Button();
            this.btnTelaVeiculo = new System.Windows.Forms.Button();
            this.btnTelaUsuario = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rdAr = new System.Windows.Forms.RadioButton();
            this.rdCamera = new System.Windows.Forms.RadioButton();
            this.rdSensor = new System.Windows.Forms.RadioButton();
            this.rdTeto = new System.Windows.Forms.RadioButton();
            this.rdVidro = new System.Windows.Forms.RadioButton();
            this.rdBanco = new System.Windows.Forms.RadioButton();
            this.rdCadeirinha = new System.Windows.Forms.RadioButton();
            this.rdFarol = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.Location = new System.Drawing.Point(49, 120);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(187, 25);
            this.lblCPFCliente.TabIndex = 0;
            this.lblCPFCliente.Text = "CPF / CNPJ Cliente";
            // 
            // lblLocar
            // 
            this.lblLocar.AutoSize = true;
            this.lblLocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocar.Location = new System.Drawing.Point(327, 26);
            this.lblLocar.Name = "lblLocar";
            this.lblLocar.Size = new System.Drawing.Size(224, 39);
            this.lblLocar.TabIndex = 1;
            this.lblLocar.Text = "Locar Veículo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(140, 180);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(97, 25);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(151, 240);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(77, 25);
            this.lblVeiculo.TabIndex = 3;
            this.lblVeiculo.Text = "Veículo";
            // 
            // lblDataRet
            // 
            this.lblDataRet.AutoSize = true;
            this.lblDataRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRet.Location = new System.Drawing.Point(78, 300);
            this.lblDataRet.Name = "lblDataRet";
            this.lblDataRet.Size = new System.Drawing.Size(150, 25);
            this.lblDataRet.TabIndex = 4;
            this.lblDataRet.Text = "Data de retirada";
            // 
            // lblDataDev
            // 
            this.lblDataDev.AutoSize = true;
            this.lblDataDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDev.Location = new System.Drawing.Point(54, 360);
            this.lblDataDev.Name = "lblDataDev";
            this.lblDataDev.Size = new System.Drawing.Size(175, 25);
            this.lblDataDev.TabIndex = 5;
            this.lblDataDev.Text = "Data de devolução";
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
            this.btnTelaManutencao.Click += new System.EventHandler(this.btnTelaManutencao_Click_1);
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
            this.btnTelaFinanceiro.Click += new System.EventHandler(this.btnTelaFinanceiro_Click_1);
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
            this.btnTelaFuncionario.Click += new System.EventHandler(this.btnTelaFuncionario_Click_1);
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
            this.btnTelaVeiculo.Click += new System.EventHandler(this.btnTelaVeiculo_Click_1);
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(277, 120);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(157, 22);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(277, 180);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(277, 240);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 24);
            this.comboBox2.TabIndex = 35;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(277, 300);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(123, 22);
            this.maskedTextBox2.TabIndex = 36;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(277, 360);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(123, 22);
            this.maskedTextBox3.TabIndex = 37;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(312, 612);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(156, 40);
            this.btnReservar.TabIndex = 38;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(484, 612);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(156, 40);
            this.btnRetirar.TabIndex = 39;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(46, 479);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(188, 20);
            this.lblInfo.TabIndex = 40;
            this.lblInfo.Text = "Informações Adicionais:";
            // 
            // rdAr
            // 
            this.rdAr.AutoSize = true;
            this.rdAr.Location = new System.Drawing.Point(97, 522);
            this.rdAr.Name = "rdAr";
            this.rdAr.Size = new System.Drawing.Size(132, 21);
            this.rdAr.TabIndex = 41;
            this.rdAr.TabStop = true;
            this.rdAr.Text = "Ar-condicionado";
            this.rdAr.UseVisualStyleBackColor = true;
            // 
            // rdCamera
            // 
            this.rdCamera.AutoSize = true;
            this.rdCamera.Location = new System.Drawing.Point(268, 522);
            this.rdCamera.Name = "rdCamera";
            this.rdCamera.Size = new System.Drawing.Size(120, 21);
            this.rdCamera.TabIndex = 42;
            this.rdCamera.TabStop = true;
            this.rdCamera.Text = "Câmera de Ré";
            this.rdCamera.UseVisualStyleBackColor = true;
            // 
            // rdSensor
            // 
            this.rdSensor.AutoSize = true;
            this.rdSensor.Location = new System.Drawing.Point(430, 522);
            this.rdSensor.Name = "rdSensor";
            this.rdSensor.Size = new System.Drawing.Size(116, 21);
            this.rdSensor.TabIndex = 43;
            this.rdSensor.TabStop = true;
            this.rdSensor.Text = "Sensor de Ré";
            this.rdSensor.UseVisualStyleBackColor = true;
            // 
            // rdTeto
            // 
            this.rdTeto.AutoSize = true;
            this.rdTeto.Location = new System.Drawing.Point(577, 522);
            this.rdTeto.Name = "rdTeto";
            this.rdTeto.Size = new System.Drawing.Size(95, 21);
            this.rdTeto.TabIndex = 44;
            this.rdTeto.TabStop = true;
            this.rdTeto.Text = "Teto Solar";
            this.rdTeto.UseVisualStyleBackColor = true;
            // 
            // rdVidro
            // 
            this.rdVidro.AutoSize = true;
            this.rdVidro.Location = new System.Drawing.Point(97, 567);
            this.rdVidro.Name = "rdVidro";
            this.rdVidro.Size = new System.Drawing.Size(113, 21);
            this.rdVidro.TabIndex = 45;
            this.rdVidro.TabStop = true;
            this.rdVidro.Text = "Vidro Elétrico";
            this.rdVidro.UseVisualStyleBackColor = true;
            // 
            // rdBanco
            // 
            this.rdBanco.AutoSize = true;
            this.rdBanco.Location = new System.Drawing.Point(268, 567);
            this.rdBanco.Name = "rdBanco";
            this.rdBanco.Size = new System.Drawing.Size(132, 21);
            this.rdBanco.TabIndex = 46;
            this.rdBanco.TabStop = true;
            this.rdBanco.Text = "Banco Aquecido";
            this.rdBanco.UseVisualStyleBackColor = true;
            // 
            // rdCadeirinha
            // 
            this.rdCadeirinha.AutoSize = true;
            this.rdCadeirinha.Location = new System.Drawing.Point(429, 567);
            this.rdCadeirinha.Name = "rdCadeirinha";
            this.rdCadeirinha.Size = new System.Drawing.Size(97, 21);
            this.rdCadeirinha.TabIndex = 47;
            this.rdCadeirinha.TabStop = true;
            this.rdCadeirinha.Text = "Cadeirinha";
            this.rdCadeirinha.UseVisualStyleBackColor = true;
            // 
            // rdFarol
            // 
            this.rdFarol.AutoSize = true;
            this.rdFarol.Location = new System.Drawing.Point(575, 567);
            this.rdFarol.Name = "rdFarol";
            this.rdFarol.Size = new System.Drawing.Size(118, 21);
            this.rdFarol.TabIndex = 48;
            this.rdFarol.TabStop = true;
            this.rdFarol.Text = "Farol de Milha";
            this.rdFarol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Valor final";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(277, 424);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 22);
            this.txtValor.TabIndex = 50;
            // 
            // Locar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdFarol);
            this.Controls.Add(this.rdCadeirinha);
            this.Controls.Add(this.rdBanco);
            this.Controls.Add(this.rdVidro);
            this.Controls.Add(this.rdTeto);
            this.Controls.Add(this.rdSensor);
            this.Controls.Add(this.rdCamera);
            this.Controls.Add(this.rdAr);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnTelaManutencao);
            this.Controls.Add(this.btnTelaFinanceiro);
            this.Controls.Add(this.btnTelaFrota);
            this.Controls.Add(this.btnTelaLocar);
            this.Controls.Add(this.btnTelaFuncionario);
            this.Controls.Add(this.btnTelaVeiculo);
            this.Controls.Add(this.btnTelaUsuario);
            this.Controls.Add(this.lblDataDev);
            this.Controls.Add(this.lblDataRet);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblLocar);
            this.Controls.Add(this.lblCPFCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Locar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.Label lblLocar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblDataRet;
        private System.Windows.Forms.Label lblDataDev;
        private System.Windows.Forms.Button btnTelaManutencao;
        private System.Windows.Forms.Button btnTelaFinanceiro;
        private System.Windows.Forms.Button btnTelaFrota;
        private System.Windows.Forms.Button btnTelaLocar;
        private System.Windows.Forms.Button btnTelaFuncionario;
        private System.Windows.Forms.Button btnTelaVeiculo;
        private System.Windows.Forms.Button btnTelaUsuario;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rdAr;
        private System.Windows.Forms.RadioButton rdCamera;
        private System.Windows.Forms.RadioButton rdSensor;
        private System.Windows.Forms.RadioButton rdTeto;
        private System.Windows.Forms.RadioButton rdVidro;
        private System.Windows.Forms.RadioButton rdBanco;
        private System.Windows.Forms.RadioButton rdCadeirinha;
        private System.Windows.Forms.RadioButton rdFarol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
    }
}