using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class TexBoxSoloNum : UserControl
    {
        public TexBoxSoloNum()
        {
            InitializeComponent();
        }

        //creo propiedad publica para obtener lo que el usuario ingreso en la caja de texto
        public String Ingreso
        {
            get { return TxtIngreso.Text; }
            set
            {
                try
                {
                    Convert.ToInt64(value);
                    TxtIngreso.Text = value;
                }
                catch (Exception ex)
                {
                    throw new Exception("Solo se puede asignar números al control" + ex.Message);
                }
            }
        }

        //capturo evento de cuando se digita una tecla
        private void TxtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
