using AppPruebaTecnica.Controller;
using AppPruebaTecnica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPruebaTecnica.View
{
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estados estado = new Estados();
            estado.Estado = txtEstado.Text;
            EstadosController cont = new EstadosController();
            if (estado.Estado.Equals(""))
            {
                MessageBox.Show("Estado Obligatorio");
            }else
            {
                if (cont.AddEstado(estado).Equals(true))
                {
                    MessageBox.Show("Se guardo perfectamente el estado");
                }else
                {
                    MessageBox.Show("El Estado no se almaceno");
                }
                
            }
        }

        
    }
}
