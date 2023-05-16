using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPersonas
{
    public partial class FrmJuego : Form
    {
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (String.IsNullOrEmpty(nombre) == false)
            //if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                Munieco oMunieco = new Munieco(nombre);
                lstMuñecos.Items.Add(oMunieco);
                txtNombre.Text = String.Empty; //Esto deja la caja en blanco nuevamente para una próx entrada
                txtNombre.Focus(); //Esto deja el curso sobre el componente
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para el muñeco!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
           // lstMuñecos.Items.Clear(); esto es un obviedad porque cuando se carga a memoria ya esta vacío

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstMuñecos.SelectedItem != null)
            {
                Munieco muniecoSeleccionado = (Munieco)lstMuñecos.SelectedItem;
                lstMuñecos.Items.Remove(muniecoSeleccionado);

            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (lstMuñecos.SelectedItem != null)
            {
                int aux = int.Parse(TxtJugarSegs.Text);
                if (TxtJugarSegs.Text != null)
                {
                    Munieco muniecoSeleccionado = (Munieco)lstMuñecos.SelectedItem;

                    int indice = lstMuñecos.Items.IndexOf(muniecoSeleccionado);
                    muniecoSeleccionado.Jugar(aux);
                    lstMuñecos.Items[indice] = muniecoSeleccionado;
                    
                }

            }
            
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            if (lstMuñecos.SelectedItem != null)
            {
                Munieco muniecoSeleccionado = (Munieco)lstMuñecos.SelectedItem;

                int indice = lstMuñecos.Items.IndexOf(muniecoSeleccionado);
                muniecoSeleccionado.Comer();
                lstMuñecos.Items[indice] = muniecoSeleccionado;

            }
        }
    }
}
