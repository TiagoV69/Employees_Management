using pjEmployeesManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEmployeesManagement.Presentation
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        #region "Métodos"
        private void CargarEmpleados(string cBusqueda)
        {

            D_Empleados Datos = new D_Empleados();
            dgvList.DataSource = Datos.Listar_empleados(cBusqueda);
        }

        #endregion

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
        }
    }
}
