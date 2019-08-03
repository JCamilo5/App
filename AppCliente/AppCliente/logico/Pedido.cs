using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppCliente.datos;

namespace AppCliente.logico
{
    class Pedido
    {
        PedidoDB ped = new PedidoDB();
        public DataSet consulPedido(int prmPedid)
        {
            return ped.consulPedido(prmPedid);
        }

        public bool agregarPro(int prmId,int prmCanti)
        {
            return ped.agregarPro(prmId, prmCanti);
        }
        public bool agregarPed(int prmCli,int prmEmp,int prmSuc )
        {
            return ped.agregarPed(prmCli, prmEmp, prmSuc);
        }
        public bool eliminarPed(int prmId)
        {
            return ped.eliminarPed(prmId);
        }
        public bool actPed(int prmPedid,int prmProid,int prmCanti)
        {
            return ped.actPed(prmPedid, prmProid, prmCanti);
        }
        public bool agragarMas(int prmPedid, int prmProid, int prmCanti)
        {
            return ped.agregarMas(prmPedid, prmProid, prmCanti);
        }
    }
}
