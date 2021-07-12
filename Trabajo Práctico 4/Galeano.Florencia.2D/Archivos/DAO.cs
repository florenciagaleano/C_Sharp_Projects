using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using Productos;

namespace Archivos
{
        //CREATE DATABASE[MAKEUP - FACTORY - TP4]
        //GO
        //USE[MAKEUP - FACTORY - TP4]
        //GO
        //SET ANSI_NULLS ON
        //GO
        //SET QUOTED_IDENTIFIER ON
        //GO
        //CREATE TABLE[dbo].[labial]
        //    (
        //[estado][int] NOT NULL,
        //[tipo] [int]
        //    NOT NULL,
        //[color] [int] NOT NULL,
        //[vencimiento] [date],
        //) ON[PRIMARY]
        //GO
        //CREATE TABLE[dbo].[base]
        //    (
        //[estado][int] NOT NULL,
        //[tono] [int]
        //    NOT NULL,
        //[vencimiento] [date],
        //) ON[PRIMARY]
        //GO
        //CREATE TABLE[dbo].[rimel]
        //    (
        //[estado][int] NOT NULL,
        //[efecto] [int]
        //    NOT NULL,
        //[color] [int] NOT NULL,
        //[vencimiento] [date],
        //) ON[PRIMARY]
        //GO

    public static class DAO
    {
        private static string cadenaConexion = "Server = .;Database = MAKEUP-FACTORY-TP4; Trusted_Connection = true;";

        private static List<Labial> LeerLabiales()
        {
            SqlConnection connection = new SqlConnection(DAO.cadenaConexion);
            string consulta = "SELECT estado,tipo,color,vencimiento FROM dbo.labial";
            List<Labial> productos = new List<Labial>();

            connection.Open();


            SqlCommand comando = new SqlCommand(consulta, connection);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Labial aux = new Labial((ConsoleColor)(int)reader["color"], (Labial.Tipo)(int)reader["tipo"]);
                aux.Vencimiento = (DateTime)reader["vencimiento"];
                aux.EstadoActual = (Producto.Estado)(int)reader["estado"];
                productos.Add(aux);

            }

            reader.Close();
            connection.Close();

            return productos;
        }

        private static List<Base> LeerBases()
        {
            SqlConnection connection = new SqlConnection(DAO.cadenaConexion);
            string consulta = "SELECT estado,tono,vencimiento FROM dbo.base";
            List<Base> productos = new List<Base>();

            connection.Open();


            SqlCommand comando = new SqlCommand(consulta, connection);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Base aux = new Base((int)reader["tono"]);
                aux.Vencimiento = (DateTime)reader["vencimiento"];
                aux.EstadoActual = (Producto.Estado)(int)reader["estado"];
                productos.Add(aux);

            }
            reader.Close();
            connection.Close();
            return productos;
        }

        private static List<Rimel> LeerRimels()
        {
            SqlConnection connection = new SqlConnection(DAO.cadenaConexion);
            string consulta = "SELECT estado,efecto,color,vencimiento FROM dbo.rimel";
            List<Rimel> productos = new List<Rimel>();

            connection.Open();


            SqlCommand comando = new SqlCommand(consulta, connection);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Rimel aux = new Rimel((Rimel.Efecto)(int)reader["efecto"], (ConsoleColor)(int)reader["color"]);
                aux.Vencimiento = (DateTime)reader["vencimiento"];
                aux.EstadoActual = (Producto.Estado)(int)reader["estado"];
                productos.Add(aux);
            }
            reader.Close();
            connection.Close();
            return productos;
        }

        /// <summary>
        /// Lee la actividad de las 3 tablas de la base de datos de la fábrica
        /// </summary>
        /// <returns>Lista con todos los productos cargados en la base</returns>
        public static List<Producto> LeerActividad()
        {
            List<Producto> productos = new List<Producto>();
            productos.AddRange(LeerRimels());
            productos.AddRange(LeerBases());
            productos.AddRange(LeerLabiales());

            return productos;
        }

        public static void Guardar(Producto p)
        {
            if (!p.EstaEnSql)
            {
                SqlConnection conexion = new SqlConnection(DAO.cadenaConexion);
                conexion.Open();

                if (p is Base)
                {
                    Base aux = (Base)p;
                    string consultaSql = "INSERT INTO  dbo.base(estado,tono,vencimiento) VALUES(@estado,@tono,@vencimiento)";
                    SqlCommand comando = new SqlCommand(consultaSql, conexion);

                    comando.Parameters.Add("@estado", SqlDbType.Int).Value = (int)aux.EstadoActual;
                    comando.Parameters.Add("@tono", SqlDbType.Int).Value = (int)aux.Tono;
                    comando.Parameters.Add("@vencimiento", SqlDbType.Date).Value = (DateTime)aux.Vencimiento;

                    comando.ExecuteNonQuery();
                }
                else if (p is Labial)
                {
                    Labial aux = (Labial)p;
                    string consultaSql = "INSERT INTO  dbo.labial(estado,tipo,color,vencimiento) VALUES(@estado,@tipo,@color,@vencimiento)";
                    SqlCommand comando = new SqlCommand(consultaSql, conexion);

                    comando.Parameters.Add("@estado", SqlDbType.Int).Value = (int)aux.EstadoActual;
                    comando.Parameters.Add("@tipo", SqlDbType.Int).Value = (int)aux.TipoLabial;
                    comando.Parameters.Add("@color", SqlDbType.Int).Value = (int)aux.Color;
                    comando.Parameters.Add("@vencimiento", SqlDbType.Date).Value = (DateTime)aux.Vencimiento;

                    comando.ExecuteNonQuery();

                }
                else if (p is Rimel)
                {
                    Rimel aux = (Rimel)p;
                    string consultaSql = "INSERT INTO  dbo.rimel(estado,efecto,color,vencimiento) VALUES(@estado,@efecto,@color,@vencimiento)";
                    SqlCommand comando = new SqlCommand(consultaSql, conexion);

                    comando.Parameters.Add("@estado", SqlDbType.Int).Value = (int)aux.EstadoActual;
                    comando.Parameters.Add("@efecto", SqlDbType.Int).Value = (int)aux.EfectoRimel;
                    comando.Parameters.Add("@color", SqlDbType.Int).Value = (int)aux.Color;
                    comando.Parameters.Add("@vencimiento", SqlDbType.Date).Value = (DateTime)aux.Vencimiento;
                    comando.ExecuteNonQuery();

                }

                conexion.Close();
            }
        }
    }
}
