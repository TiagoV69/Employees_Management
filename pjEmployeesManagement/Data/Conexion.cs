using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjEmployeesManagement.Data
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Password;
        private static Conexion Con = null;

        //Constructor de la clase
        private Conexion()
        {
            this.Servidor = "Santiago-Varela\\SQLEXPRESS";
            this.Base = "bd_gestion_empleados";
            this.Usuario = "TiagoVarela";
            this.Password = "Mateito6900@";
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                          "; Database=" + this.Base +
                                          "; User Id=" + this.Usuario +
                                          "; Password=" + this.Password;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion crearInstancia(){
            if (Con == null)
            {

                Con = new Conexion();
            }
            return Con;
        }
    }
}
