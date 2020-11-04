using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaCafe
{

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable tbBeb = new DataTable("TB_BEB");
            //tbBeb.Columns.Add("Bebida", typeof(String));
            //tbBeb.Columns.Add("Preco", typeof(Double));

            foreach (KeyValuePair<string, double> Bebida in clBebidas.Bebidas)
            {
                grdBebidas.Rows.Add(Bebida.Key, Bebida.Value);
            }
        }

        private void img1c_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moeda de 1 centavo regeitada", "ALERTA");
        }

        private void img5c_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moeda de 5 centavos regeitada", "ALERTA");
        }

        private void img10c_Click(object sender, EventArgs e)
        {
            double Total = Convert.ToDouble(lblValor.Text);
            Total += 0.10;
            lblValor.Text = Total.ToString("0.00");
        }

        private void img25c_Click(object sender, EventArgs e)
        {
            double Total = Convert.ToDouble(lblValor.Text);
            Total += 0.25;
            lblValor.Text = Total.ToString("0.00");
        }

        private void img50c_Click(object sender, EventArgs e)
        {
            double Total = Convert.ToDouble(lblValor.Text);
            Total += 0.50;
            lblValor.Text = Total.ToString("0.00");
        }

        private void img1r_Click(object sender, EventArgs e)
        {
            double Total = Convert.ToDouble(lblValor.Text);
            Total += 1.00;
            lblValor.Text = Total.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lblValor.Text) != 0.00)
            {
                MessageBox.Show(clDinheiro.CalcTroco(Convert.ToDouble(lblValor.Text)), "ALERTA");
                lblValor.Text = "0,00";
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (grdBebidas.SelectedRows.Count > 0)
            {
                string BebSelec = grdBebidas.SelectedRows[0].Cells["Bebida"].Value.ToString();
                double PrecoSelec = Convert.ToDouble(grdBebidas.SelectedRows[0].Cells["Preco"].Value);

                if (Convert.ToDouble(lblValor.Text) >= PrecoSelec)
                {
                    Double Troco = Convert.ToDouble(lblValor.Text) - PrecoSelec;
                    MessageBox.Show(string.Format("Bebida: {0} \nTroco: {1}", BebSelec, clDinheiro.CalcTroco(Troco)));
                    lblValor.Text = "0,00";
                }
                else
                {
                    MessageBox.Show("Quantia inserida insuficiente para o produto selecionado!", "ALERTA");
                }

            }

        }
    }
}
