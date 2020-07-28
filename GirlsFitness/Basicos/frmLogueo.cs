using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EntidadesCompartidas;
using Logica;

namespace GirlsFitness.Basicos
{
    public partial class frmLogueo : Form
    {
        public frmLogueo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    LblError.Text = "ATENCIÓN!!! Debe ingresar un nombre de usuario.";
                }
                else if (txtPassword.Text == "")
                {
                    LblError.Text = "ATENCIÓN!!! Debe ingresar una contraseña.";
                }
                else
                {
                    lblBienvenido.Visible = true;
                    lblNombre.Visible = true;
                    lblCuponera.Visible = true;
                    lblRestan.Visible = true;
                    lblAccesos1.Visible = true;
                    lblAccesos2.Visible = true;
                    lblCant1.Visible = true;
                    lblCant2.Visible = true;
                    timer1.Start();
                    //ILogicaUsuario _uns = FabricaLogica.getLogicaUsuario();                    
                    //Usuario _unEmpleado = _uns.BuscarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim());

                    //if (_unEmpleado == null)
                    //{
                    //    LblError.Text = "No existe el usuario";
                    //    txtUsuario.Focus();
                    //}
                    //else if (_unEmpleado.Password == txtPassword.Text.Trim())
                    //{
                    //    //codigo de logueo
                    //}
                    //else
                    //{
                    //    LblError.Text = "Password incorrecta";
                    //    txtPassword.Focus();
                    //}
                }
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
                MessageBox.Show(ex.Message, "Logueo de Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblBienvenido.Visible = false;
            lblNombre.Visible = false;
            lblCuponera.Visible = false;
            lblRestan.Visible = false;
            lblAccesos1.Visible = false;
            lblAccesos2.Visible = false;
            lblCant1.Visible = false;
            lblCant2.Visible = false;
            txtPassword.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }
    }
}
