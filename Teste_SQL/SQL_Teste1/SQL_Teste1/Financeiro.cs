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
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
            btnTelaFinanceiro.BackColor = Color.Aquamarine;
        }

        private void btnTelaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroUsuário telaUsuario = new CadastroUsuário();
            telaUsuario.ShowDialog();
        }

        private void btnTelaVeiculo_Click_1(object sender, EventArgs e)
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

        private void btnTelaManutencao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manutencao telaManutencao = new Manutencao();
            telaManutencao.ShowDialog();
        }
    }
}
