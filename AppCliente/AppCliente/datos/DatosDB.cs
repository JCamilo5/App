using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace AppCliente.datos
{
    class DatosDB
    {
        OracleConnection miConexion = new OracleConnection(@"Data Source=localhost;Persist Security Info=True;User ID=userP;Password=oracle;");
   
        public DataSet consuSuc()
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_consulSuc", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Sucursales");
            miConexion.Close();
            return ds;
        }
        public DataSet consulCli()
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_consulCli", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Clientes");
            miConexion.Close();
            return ds;
        }
        public DataSet consulEmp(int prmId)
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_consulEmp", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.Parameters.Add("v_sucID",OracleDbType.Decimal, prmId, ParameterDirection.Input);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Empleados");
            miConexion.Close();
            return ds;
        }
        public DataSet consulPro()
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_consulProduct", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Productos");
            miConexion.Close();
            return ds;
        }
        public DataSet consulPedAct()
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_consulPedAct", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Pedidos");
            miConexion.Close();
            return ds;
        }
        public DataSet consulProPed(int prmPedId)
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_proPed", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.Parameters.Add("v_pedId", OracleDbType.Decimal, prmPedId, ParameterDirection.Input);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Producto");
            miConexion.Close();
            return ds;
        }
        public bool conectar()
        {
            try
            {
                miConexion.Open();
                miConexion.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool desconectar()
        {
            try
            {
                miConexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
