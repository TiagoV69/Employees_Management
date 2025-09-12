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

            FormatolistaEmpleados();
        }

        private void FormatolistaEmpleados()
        {
            dgvList.Columns[0].Width = 45;
            dgvList.Columns[1].Width = 150;
            dgvList.Columns[2].Width = 190; 
            dgvList.Columns[4].Width = 130;
            dgvList.Columns[5].Width = 120;
            dgvList.Columns[6].Width = 110;
        }

        private void CargarDepartamentos()
        {
            D_Departamentos Datos = new D_Departamentos();
            cmbDepartment.DataSource = Datos.Listar_departamentos();
            cmbDepartment.ValueMember = "id_departamento";
            cmbDepartment.DisplayMember = "nombre_departamento";
        }
        #endregion

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CargarEmpleados(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtSearch.Text);
        }
    }
}
