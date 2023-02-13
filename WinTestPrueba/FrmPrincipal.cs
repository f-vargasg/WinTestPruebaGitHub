using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestPrueba
{
    public partial class FrmPrincProceso : Form
    {
        List<ClienteBE> clienteList;

        public FrmPrincProceso()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = this.Text + " (" + this.Name + ")";

            clienteList= new List<ClienteBE>();

            clienteList.Add(new ClienteBE()
            {
                IdCliente = 1,
                Nombre = "Cliente1"
            });

            clienteList.Add(new ClienteBE()
            {
                IdCliente = 2,
                Nombre = "Cliente2"
            });

            clienteList.Add(new ClienteBE()
            {
                IdCliente = 3,
                Nombre = "Cliente3"
            });

            testCmb.DataSource= clienteList;
            testCmb.ValueMember= "IdCliente";
            testCmb.DisplayMember= "Nombre";
            testCmb.DropDownStyle= ComboBoxStyle.DropDownList;

            testCmb.SelectedIndex= 0;


           
        }

        private void SetSelectedValueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                testCmb.SelectedValue= Convert.ToInt32(valueCombo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
