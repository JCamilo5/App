using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCliente.datos;
using System.Data;

namespace AppCliente.logico
{
    class Datos
    {
        DatosDB datos = new DatosDB();
      
     
        public DataSet consulSuc()
        {
            return datos.consuSuc();
        }
        public DataSet consulCli()
        {
            return datos.consulCli();
        }
        public DataSet consulEmp(int prmId)
        {
            return datos.consulEmp(prmId);
        }
        public DataSet consulPro()
        {
            return datos.consulPro();
        }
        public DataSet consulPedAct()
        {
            return datos.consulPedAct();
        }
        public DataSet consulPro(int prmPedId)
        {
            return datos.consulProPed(prmPedId);
        }
        public bool conectar()
        {
            return datos.conectar();
        }
        public bool desconectar()
        {
            return datos.desconectar();
        }
    }
}
