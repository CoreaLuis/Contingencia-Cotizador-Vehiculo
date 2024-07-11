using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contingencia_Cotizador_Vehiculo
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            ShowPcName();
        }
        private void ShowPcName()
        {
            string pcName = Environment.MachineName;
            string userName = Environment.UserName;
            lblPcName.Text = "Pc: " + pcName;
            lblUserName.Text = "Usuario: " + userName;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToLongDateString();
            lblHora.Text=DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
