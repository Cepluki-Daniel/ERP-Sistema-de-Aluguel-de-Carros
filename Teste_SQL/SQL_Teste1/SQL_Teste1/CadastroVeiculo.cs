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
    public partial class CadastroVeiculo : Form
    {
        public CadastroVeiculo()
        {
            InitializeComponent();
            Set_Anos();
            btnTelaVeiculo.BackColor = Color.Aquamarine;
        }

        public void Set_Anos()
        {
            int I = 2000;
            int AnoAtual = DateTime.Now.Year + 1;
            while (I <= AnoAtual)
            {
                boxAnoCarro.Items.Add(I);
                I++;
            }
        }

        public void SelecionaCarro()
        {
            string Marca = boxMarca.SelectedItem.ToString();
            boxModelo.Items.Clear();
            switch (Marca)
            {
                case "Audi":
                    boxModelo.Items.Add("A4");
                    boxModelo.Items.Add("A3");
                    boxModelo.Items.Add("A6");
                    boxModelo.Items.Add("Q3");
                    boxModelo.Items.Add("Q5");
                    boxModelo.Items.Add("R8");
                    boxModelo.Items.Add("Q7");
                    break;
                case "BMW":
                    boxModelo.Items.Add("I8");
                    boxModelo.Items.Add("Série 1");
                    boxModelo.Items.Add("Série 3");
                    boxModelo.Items.Add("Série 5");
                    boxModelo.Items.Add("X3");
                    boxModelo.Items.Add("X6");
                    boxModelo.Items.Add("I3");
                    boxModelo.Items.Add("Z4");
                    break;
                case "Chevrolet":
                    boxModelo.Items.Add("Blazer");
                    boxModelo.Items.Add("Camaro");
                    boxModelo.Items.Add("Captiva");
                    boxModelo.Items.Add("Cobalt");
                    boxModelo.Items.Add("Cruze");
                    boxModelo.Items.Add("Onix");
                    boxModelo.Items.Add("Prisma");
                    break;
                case "Citroen":
                    boxModelo.Items.Add("C3");
                    boxModelo.Items.Add("C4");
                    boxModelo.Items.Add("C5");
                    boxModelo.Items.Add("DS3");
                    boxModelo.Items.Add("DS5");
                    boxModelo.Items.Add("Picasso");
                    break;
                case "Ferrari":
                    boxModelo.Items.Add("California");
                    break;
                case "Fiat":
                    boxModelo.Items.Add("Bravo");
                    boxModelo.Items.Add("Siena");
                    boxModelo.Items.Add("Idea");
                    boxModelo.Items.Add("Palio");
                    boxModelo.Items.Add("Punto");             
                    break;
                case "Ford":
                    boxModelo.Items.Add("Focus");
                    boxModelo.Items.Add("EcoSport");
                    boxModelo.Items.Add("Ranger");
                    boxModelo.Items.Add("Fusion");
                    boxModelo.Items.Add("Fiesta");
                    boxModelo.Items.Add("Edge");
                    break;
                case "Honda":
                    boxModelo.Items.Add("Civic");
                    boxModelo.Items.Add("City");
                    boxModelo.Items.Add("Fit");
                    boxModelo.Items.Add("CR-V");
                    boxModelo.Items.Add("WR-V");
                    break;
                case "Hyundai":
                    boxModelo.Items.Add("HB20");
                    boxModelo.Items.Add("HB20S");
                    boxModelo.Items.Add("Tucson");
                    boxModelo.Items.Add("Veloster");
                    boxModelo.Items.Add("i30");
                    break;
                case "Jac":
                    boxModelo.Items.Add("J3");
                    boxModelo.Items.Add("J3 Turin");
                    boxModelo.Items.Add("J4");
                    boxModelo.Items.Add("J5");
                    boxModelo.Items.Add("T6");
                    break;
                case "Jeep":
                    boxModelo.Items.Add("Cherokee");
                    boxModelo.Items.Add("Renegade");
                    boxModelo.Items.Add("Wrangler");
                    break;
                case "Land Rover":
                    boxModelo.Items.Add("Defender");
                    boxModelo.Items.Add("Rover Evoque");
                    boxModelo.Items.Add("Rover Sport");
                    break;
                case "Mercedes-Benz":
                    boxModelo.Items.Add("Classe A");
                    boxModelo.Items.Add("Classe B");
                    boxModelo.Items.Add("Classe C");
                    boxModelo.Items.Add("Classe A");
                    boxModelo.Items.Add("Classe S");
                    break;
                case "Mitsubishi":
                    boxModelo.Items.Add("Lancer Evolution X");
                    boxModelo.Items.Add("Outlander");
                    boxModelo.Items.Add("Pajero TR4");
                    break;
                case "Nissan":
                    boxModelo.Items.Add("Frontier");
                    boxModelo.Items.Add("March");
                    boxModelo.Items.Add("Sentra");
                    boxModelo.Items.Add("Versa");
                    break;
                case "Renault":
                    boxModelo.Items.Add("Clio");
                    boxModelo.Items.Add("Fluence");
                    boxModelo.Items.Add("Sandero");
                    boxModelo.Items.Add("Symbol");
                    break;
                case "Toyota":
                    boxModelo.Items.Add("Corolla");
                    boxModelo.Items.Add("Etios");
                    boxModelo.Items.Add("Hilux");
                    break;
                case "Volkswagen":
                    boxModelo.Items.Add("Amarok");
                    boxModelo.Items.Add("Fox");
                    boxModelo.Items.Add("Golf");
                    boxModelo.Items.Add("Jetta");
                    boxModelo.Items.Add("Polo");
                    boxModelo.Items.Add("Tiguan");
                    boxModelo.Items.Add("Up");
                    break;
            }
        }

        private void BoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxModelo.Items.Clear();
            boxModelo.Text = "";
            SelecionaCarro();
        }

        private void btnTelaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroUsuário telaUsuario = new CadastroUsuário();
            telaUsuario.ShowDialog();
        }

        private void btnTelaFuncionario_Click(object sender, EventArgs e)
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

        private void btnTelaFrota_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ControleFrota telaFrota = new ControleFrota();
            telaFrota.ShowDialog();
        }

        private void btnTelaFinanceiro_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Financeiro telaFinanceiro = new Financeiro();
            telaFinanceiro.ShowDialog();
        }

        private void btnTelaManutencao_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manutencao telaManutencao = new Manutencao();
            telaManutencao.ShowDialog();
        }
    }
}
