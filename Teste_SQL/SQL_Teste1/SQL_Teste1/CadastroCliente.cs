using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Teste1
{

    public partial class CadastroUsuário : Form
    {
        
        class Usuario
        {
            public int ID_Cliente;
            public string Nome;
            public string CPF_CNPJ;
            public DateTime Nascimento;
            public string CNH;
            public string Endereco;
            public string Telefone;
            public string Email;
        }

        public CadastroUsuário()
        {
            InitializeComponent();
            //SetSize();
            btnTelaUsuario.BackColor = Color.Aquamarine;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;

        }

        private void btnTelaVeiculo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroVeiculo telaVeiculo = new CadastroVeiculo();
            telaVeiculo.ShowDialog();
        }

        private void btnTelaFuncionario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CadastroFuncionário telaFuncionario = new CadastroFuncionário();
            telaFuncionario.ShowDialog();
        }

        private void btnTelaLocar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Locar telalocar = new Locar();
            telalocar.ShowDialog();
        }

        private void btnTelaFrota_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControleFrota telaFrota = new ControleFrota();
            telaFrota.ShowDialog();
        }

        private void btnTelaFinanceiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Financeiro telaFinanceiro = new Financeiro();
            telaFinanceiro.ShowDialog();
        }

        private void btnTelaManutencao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manutencao telaManutencao = new Manutencao();
            telaManutencao.ShowDialog();
        }

        public void SetSize()
        {
            CadastroUsuário telaUsuario = new CadastroUsuário();
            int larguraTelaUsuario = telaUsuario.Width;
            int larguraBotoes = larguraTelaUsuario / 7;
            int posX = 1;
            int posY = telaUsuario.Height - btnTelaUsuario.Height;
            int IncX = larguraBotoes + 1;
            btnTelaUsuario.Width = larguraBotoes;
            btnTelaVeiculo.Width = larguraBotoes;
            btnTelaFuncionario.Width = larguraBotoes;
            btnTelaLocar.Width = larguraBotoes;
            btnTelaFrota.Width = larguraBotoes;
            btnTelaFinanceiro.Width = larguraBotoes;
            btnTelaManutencao.Width = larguraBotoes;
            btnTelaUsuario.Location = new Point(posX, posY);
            posX = posX + IncX;
            btnTelaVeiculo.Location = new Point(posX, posY);
            posX = posX + IncX;
            btnTelaFuncionario.Location = new Point(posX, posY);
            posX = posX + IncX;
            btnTelaLocar.Location = new Point(posX, posY);
            posX = posX + IncX;
            btnTelaFrota.Location = new Point(posX, posY);
            posX = posX + IncX;
            btnTelaFinanceiro.Location = new Point(posX, posY);
            posX = posX + IncX;
            btnTelaManutencao.Location = new Point(posX, posY);

        }

        
    }
}
