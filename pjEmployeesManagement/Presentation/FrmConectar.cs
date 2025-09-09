using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using pjEmployeesManagement.Data;

namespace pjEmployeesManagement.Presentation
{
    public partial class FrmConectar : Form
    {
        public FrmConectar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConectar_Load(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();

            SqlCon = Conexion.crearInstancia().CreateConnection();  

            try
            {
                SqlCon.Open();
                MessageBox.Show("Conexión exitosa!!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Conexión fallida :("); 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
