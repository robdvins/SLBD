﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class AnalyzeCC {
        public DataTable LoadDatoMayor(string instanceName, string dbname, string tbname, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT MAX({clname}) FROM {dbname}.dbo.{tbname};";
            return oCN.ExecuteQuery(oSQLC);
        }

        public DataTable LoadDatoMenor(string instanceName, string dbname, string tbname, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT MIN({clname}) FROM {dbname}.dbo.{tbname};";
            return oCN.ExecuteQuery(oSQLC);
        }

        public DataTable LoadTotalDatos(string instanceName, string dbname, string tbname, string clname) {
            Connection oCN = new Connection(instanceName);
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = $"SELECT COUNT({clname}) FROM {dbname}.dbo.{tbname};";
            return oCN.ExecuteQuery(oSQLC);
        }
    }
}