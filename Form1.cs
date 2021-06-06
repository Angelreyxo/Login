using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        ClassLibrary_E.Class1 objetoE = new ClassLibrary_E.Class1();
        ClassLibrary_N.Class1 objetoN = new ClassLibrary_N.Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            objetoE.usuario = txtUsuario.Text.ToLower();
            objetoE.clave = txtClave.Text.ToLower();
            dt = objetoN.N_login(objetoE);

            if(dt.Rows.Count > 0)
            {
                objetoE.usuario = dt.Rows[0][0].ToString();
                objetoE.clave = dt.Rows[0][1].ToString();
                MessageBox.Show("Inicio de sesión correcto");
                this.Hide();

                Principal pantallaPrincipal = new Principal();
                pantallaPrincipal.Show();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
