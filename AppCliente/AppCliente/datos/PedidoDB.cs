using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace AppCliente.datos
{
    class PedidoDB
    {
        OracleConnection miConexion = new OracleConnection(@"Data Source=localhost;Persist Security Info=True;User ID=userP;Password=oracle;");
        public DataSet consulPedido(int prmId)
        {
            miConexion.Open();
            OracleCommand miComando = new OracleCommand("userP.pq_Consultas.prc_consulPedxId", miConexion);
            miComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            miComando.Parameters.Add("v_id", OracleDbType.Decimal,prmId,ParameterDirection.Input);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.ExecuteNonQuery();
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "Pedido");
            miConexion.Close();
            return ds;
        }
        public bool agregarPed(int prmClid,int prmEmpid,int prmSucid)
        {
            try
            {
                miConexion.Open();
                OracleCommand miComando = new OracleCommand("userP.pq_gestion_pedidos.ped_crear", miConexion);
                miComando.Parameters.Add("v_clid", OracleDbType.Decimal, prmClid, ParameterDirection.Input);
                miComando.Parameters.Add("v_empid", OracleDbType.Decimal,prmEmpid, ParameterDirection.Input);
                miComando.Parameters.Add("v_sucid", OracleDbType.Decimal, prmSucid, ParameterDirection.Input);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.ExecuteNonQuery();
                OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
                miConexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool agregarPro(int prmId,int prmCanti)
        {
            try
            {
                miConexion.Open();
                OracleCommand miComando = new OracleCommand("userP.pq_gestion_pedidos.pro_pendientes", miConexion);
                miComando.Parameters.Add("v_cant", OracleDbType.Decimal, prmCanti, ParameterDirection.Input);
                miComando.Parameters.Add("v_proid", OracleDbType.Decimal, prmId, ParameterDirection.Input);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.ExecuteNonQuery();
                OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
                miConexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool eliminarPed(int prmId)
        {
            try
            {
                miConexion.Open();
                OracleCommand miComando = new OracleCommand("userP.pq_gestion_pedidos.prc_eliminarped", miConexion);
                miComando.Parameters.Add("v_pedid", OracleDbType.Decimal, prmId, ParameterDirection.Input);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.ExecuteNonQuery();
                OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
                DataSet ds = new DataSet();
                miAdaptador.Fill(ds, "Pedido");
                miConexion.Close();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public bool actPed(int prmPedid, int prmProid, int prmCanti)
        {
            try
            {
                miConexion.Open();
                OracleCommand miComando = new OracleCommand("userP.pq_gestion_pedidos.prc_actualizarCant", miConexion);
                miComando.Parameters.Add("v_proId", OracleDbType.Decimal, prmProid, ParameterDirection.Input);
                miComando.Parameters.Add("v_canti", OracleDbType.Decimal, prmCanti, ParameterDirection.Input);
                miComando.Parameters.Add("v_pedid", OracleDbType.Decimal, prmPedid, ParameterDirection.Input);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.ExecuteNonQuery();
                OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
                miConexion.Close();
                return true;
            }

            catch (Exception)
            {
                return false;

            }
        }
        public bool agregarMas(int prmPedid, int prmProid, int prmCanti)
        {
            try
            {
                miConexion.Open();
                OracleCommand miComando = new OracleCommand("userP.pq_gestion_pedidos.prc_agregarMasPro", miConexion);
                miComando.Parameters.Add("v_proid", OracleDbType.Decimal, prmProid, ParameterDirection.Input);
                miComando.Parameters.Add("v_canti", OracleDbType.Decimal, prmCanti, ParameterDirection.Input);
                miComando.Parameters.Add("v_pedid", OracleDbType.Decimal, prmPedid, ParameterDirection.Input);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.ExecuteNonQuery();
                OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
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
