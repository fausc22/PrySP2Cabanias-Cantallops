using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP2CantallopsFausto
{
    public partial class frmReserva : Form
    {
        // constantes para los calculos
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;

        public frmReserva()
        {
            InitializeComponent();
        }

        
       
    


    private void frmReserva_Load(object sender, EventArgs e)
        {
            // cargar los items en el primer control combobox
            LstTipo.Items.Clear();
            LstTipo.Items.Add("Tipo A");
            LstTipo.Items.Add("Tipo B");
            // esta accion provoca el disparo del evento "SelectedIndexCHanged"
            LstTipo.SelectedIndex = 0;
            // se inicializa la cantidad de dias en 1
            txtDias.Text = "1";
            // inicializar los demas controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna solo el qeu debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            //cargar los imtes del combo de tarjetas
            LstTarjetas.Items.Clear();
            LstTarjetas.Items.Add("Card Red");
            LstTarjetas.Items.Add("Card Green");
            LstTarjetas.Items.Add("Card Blue");
            // deshabilitar el boton aceptar
            cmdAceptar.Enabled = false;
        }

        private void LstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando ocurra el evento se debe actualizar el contenido del combo de personas
            int I = 0;
            // limpiar los items de personas
            LstPersonas.Items.Clear();
            // si es tipo de cabaña A >> cargar los items del 1 al 4
            if (LstTipo.SelectedIndex == 0)
            {
                for (I = 1; I <= 4; I++)
                {
                    LstPersonas.Items.Add(I);
                }
            }
            else // si es tipo de cabaña B >> cargar los items del 1 al 8
            {
                for(I = 1; I <= 8; I++)
                {
                    LstPersonas.Items.Add(I);

                }
            } LstPersonas.SelectedIndex = 0; // establecer como preseleccionado el item 0 del combo
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // se deshabilita el combo y no se muestra nada
            LstTarjetas.Enabled = false;
            LstTarjetas.SelectedIndex = -1;

        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // se habilita el combo y se muestra el primer item
            LstTarjetas.Enabled = true;
            LstTarjetas.SelectedIndex = 0;
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el boton "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cmdAceptar.Enabled = true;
            }else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el boton "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }


        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el boton "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }

        }
   

private void cmdAceptar_Click(object sender, EventArgs e)
{
    float PrecioBase;
    float Opcionales;
    float Recargo;
    int Dias;
    float Total;
    //obtener la cantidad de dias ingresados
    Dias = int.Parse(txtDias.Text);
    // controlar el tipo de cabaña para determinar el precio base
    if (LstTipo.SelectedIndex == 0)
    {
        PrecioBase = TIPOA;
    }
    else
    {
        PrecioBase = TIPOB;
    }
    // sumar a precio base el importe extra por persona (US$ 1)
    PrecioBase = PrecioBase + (PORPERSONA * int.Parse(LstPersonas.Text));
    // controlar los adicionales por las opciones
    Opcionales = 0;
    if (chkCocina.Checked == true)
    {
        Opcionales = Opcionales + COCINA;
    }
    if (chkHeladera.Checked == true)
    {
        Opcionales = Opcionales + HELADERA;
    }
    if (chkTelevisor.Checked == true)
    {
        Opcionales = Opcionales + TELEVISOR;
    }
    // determianr el total por la cantidad de dias
    Total = (PrecioBase + Opcionales) * Dias;
    // controlar la forma de pago
    if (optTarjeta.Checked == true)
    {
        if (optTarjeta.Checked == true)
        {
            Recargo = Total * 10 / 100;
        }
        else
        {
            Recargo = Total * 20 / 100;
        }
        Total = Total + Recargo;
    }
    // mostrar el resultado
    MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
    //Inicializar los controles de la interfaz
    LstTipo.SelectedIndex = 0;
    txtDias.Text = "1";
    chkCocina.Checked = false;
    chkHeladera.Checked = false;
    chkTelevisor.Checked = false;
    // en los radiobuttons se asigna solo el que debe quedar en true
    optEfectivo.Checked = true;
    txtNombre.Text = "";
    txtTelefono.Text = "";
}
    }
}

