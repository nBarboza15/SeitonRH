using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using BLL;
using System.Data;

namespace DAL
{
    public class Conexion
    {
        private SqlConnection conection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;

        //contenedor de datos
        private DataSet dataSet;

        //variable para almacenar el string de conexion
        private string strConexion;

        //constructor de la clase
        public Conexion(string strCnx)
        {
            this.strConexion = strCnx;
        }
    }//fin de public class
}//fin de namespace
