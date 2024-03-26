﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace accesoDatos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server = .\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");

        }

        public void setearConsulta(string consulta)
        {
            comando = new SqlCommand(consulta);
            comando.CommandType = System.Data.CommandType.Text;
        }

        public void ejecutarLectura()
        { 
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
