using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEmployeesManagement.Data
{
    internal class D_Departamentos
    {
        public DataTable Listar_departamentos()
        {

            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CreateConnection();
                SqlCommand comando = new SqlCommand("SP_LISTAR_DEPARTAMENTOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                SqlCon.Open();

                resultado = comando.ExecuteReader();
                table.Load(resultado);

                return table;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw ex;

            }
            finally
            {

                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }
    }
}
