using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pjEmployeesManagement.Data
{
    public class D_Empleados
    {
      public DataTable Listar_empleados(string cBusqueda) {

            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CreateConnection();
                SqlCommand comando = new SqlCommand("SP_LISTAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cBusqueda", SqlDbType.VarChar).Value = cBusqueda;
                SqlCon.Open();

                resultado = comando.ExecuteReader();
                table.Load(resultado);

                return table;

            }
            catch (Exception ex) { 
               
                MessageBox.Show(ex.Message);
                throw ex;

            }
            finally {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }
        
    }
}
