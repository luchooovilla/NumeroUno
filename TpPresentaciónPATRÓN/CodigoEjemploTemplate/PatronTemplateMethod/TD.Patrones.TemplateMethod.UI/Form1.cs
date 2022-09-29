using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TD.PatronesTemplateMethod.Core;

namespace TD.Patrones.TemplateMethod.UI
{

   public partial class Form1 : Form
    {
        List<Cliente> _clientes;
        List<String> _prestamos;
        public Form1()
        {
            InitializeComponent();

            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente() { Nombre = "Cliente 1" });
            _clientes.Add(new Cliente() { Nombre = "Cliente 2" });
            _clientes.Add(new Cliente() { Nombre = "Cliente 3" });
            this.cboClientes.DataSource = _clientes;

            _prestamos = new List<String>();
            _prestamos.Add("Personal");
            _prestamos.Add("Hipotecario");
            this.cboCreditos.DataSource = _prestamos;

        }

        private void cmdSolicitar_Click(object sender, EventArgs e)
        {
          
            var credito = this.cboCreditos.SelectedItem.ToString();
            var cliente = (Cliente) this.cboClientes.SelectedItem;

            try
            {
                if (credito == null) throw new Exception("Debe seleccionar un cliente");

                Prestamo c;

                switch (credito)
                {
                    case "Hipotecario":
                        c = new PrestamoHipotecario(cliente);
                        break;
                    case "Personal":
                        c = new PrestamoPersonal(cliente);
                        break;
                    default:
                        throw new Exception("Debe seleccionar un crédito");
                }
                this.resultado.Clear();
                this.resultado.Lines = c.Verificar();

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }

         
        }
    }
}
