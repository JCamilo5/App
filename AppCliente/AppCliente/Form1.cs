using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCliente.logico;

namespace AppCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenarComboBox(cbxSucid,   1);
            llenarComboBox(cbxClId,    2);          
            llenarComboBox(cbxProduct, 4);
            llenarComboBox(cbxPedid, 5);
            llenarComboBox(cbxElimPed, 8);
            
        }
        Pedido ped = new Pedido();
        Datos datos = new Datos();
        private void llenarComboBox(ComboBox c, int prmOpcion)
        {
           
            DataSet ds = new DataSet();
            switch (prmOpcion)
            {
                case 1:
                    ds = datos.consulSuc();
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "sucNombre";
                    c.ValueMember = "sucid";
                    break;
                case 2:
                    ds = datos.consulCli();
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "cliId";
                    c.ValueMember = "cliId";
                    break;

                case 3:
                    DataRowView dv = (DataRowView)cbxSucid.SelectedItem;
                    int id = int.Parse(dv.Row["sucid"].ToString());
                    ds = datos.consulEmp(id);
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "empnombrecompleto";
                    c.ValueMember = "empId";
                    break;

                case 4:
                    ds = datos.consulPro();
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "pronombre";
                    c.ValueMember = "proid";
                    break;
                case 5:
                    ds = datos.consulPedAct();
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "pedid";
                    c.ValueMember = "pedid";
                    break;
                case 6:
                    DataRowView d = (DataRowView)cbxPedid.SelectedItem;
                    int pedid = int.Parse(d.Row["pedid"].ToString());
                    ds = datos.consulPro(pedid);
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "pronombre";
                    c.ValueMember = "proid";
                    break;
                case 7:
                    ds = datos.consulPro();
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "pronombre";
                    c.ValueMember = "proid";
                    break;
                case 8:
                    ds = datos.consulPedAct();
                    c.DataSource = ds.Tables[0];
                    c.DisplayMember = "pedid";
                    c.ValueMember = "pedid";
                    break;
            }

        }

        private void btnSucEmp_Click(object sender, EventArgs e)
        {

            llenarComboBox(cbxEmpId, 3);
            pnlIngresarEmp.Visible = true;

        }

        private void btnConsulPed_Click(object sender, EventArgs e)
        {
            if (txtConsulPed.Text.Length > 0)
            {
                
                
                    int varPedId;
                    varPedId = int.Parse(txtConsulPed.Text);
                    DataSet conjuntoDatos;
                    conjuntoDatos = ped.consulPedido(varPedId);
                    //indico a la grilla cuales son sus datos
                    
                    dgvPedido.DataSource = conjuntoDatos;
                    dgvPedido.DataMember = "Pedido";
                
               
            }
            else
            {
                MessageBox.Show("Digite un valor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngreProduct_Click(object sender, EventArgs e)
        {
            //Saco los valores del combobox ya que el dataset esta devolviendo objetos de tipo datarow
            DataRowView auxCli = (DataRowView)cbxClId.SelectedItem;
            DataRowView auxSuc = (DataRowView)cbxSucid.SelectedItem;
            DataRowView auxEmp = (DataRowView)cbxEmpId.SelectedItem;
            int varClid, varEmpId, varSucid;
            varClid = int.Parse(auxCli.Row["cliId"].ToString());
            varSucid = int.Parse(auxSuc.Row["sucid"].ToString());
            varEmpId = int.Parse(auxEmp.Row["empId"].ToString());
            if (ped.agregarPed(varClid, varEmpId, varSucid))
            {
                MessageBox.Show("Pedido registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarComboBox(cbxElimPed, 8);
                llenarComboBox(cbxPedid, 5);
            }
            else
            {
                MessageBox.Show("Un error ha ocurrido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtCantiProduct.Text.Length > 0)
            {
                DataRowView auxPro = (DataRowView)cbxProduct.SelectedItem;
                int varProId, varCantidad;
                varProId = int.Parse(auxPro.Row["proId"].ToString());
                varCantidad = int.Parse(txtCantiProduct.Text);
                if (ped.agregarPro(varProId, varCantidad))
                {
                    MessageBox.Show("Producto registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantiProduct.Text = " ";
                }
                else
                {
                    MessageBox.Show("Un error ha ocurrido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Digite una cantidad valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActPed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelectPedAct_Click(object sender, EventArgs e)
        {
            pnlActPro.Visible = true;
            llenarComboBox(cbxProAct, 6);
        }

        private void btnAgrProAct_Click(object sender, EventArgs e)
        {
            pnlAgreProAct.Visible = true;
        }

        private void btnEliminarPed_Click(object sender, EventArgs e)
        {
            DataRowView auxPed = (DataRowView)cbxElimPed.SelectedItem;
            int varPedId;
            varPedId=int.Parse(auxPed.Row["pedid"].ToString());
           if (ped.eliminarPed(varPedId))
            {
                MessageBox.Show("Producto Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarComboBox(cbxElimPed, 8);
                llenarComboBox(cbxPedid, 5);
            }
            else
            {
                MessageBox.Show("Error al elimianr producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActPed_Click_1(object sender, EventArgs e)
        {
            DataRowView auxPro = (DataRowView)cbxProAct.SelectedItem;
            DataRowView auxPed = (DataRowView)cbxPedid.SelectedItem;
            int varProId,varCanti,varPedId;
            varProId = int.Parse(auxPro.Row["proid"].ToString());
            varCanti = int.Parse(txtCantiProAct.Text);
            varPedId = int.Parse(auxPed.Row["pedid"].ToString());
            if (ped.actPed(varPedId, varProId, varCanti))
            {
                MessageBox.Show("Cantidad  Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al  Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            txtCantiProAct.Text = " ";
        }

        private void btnAgrePro_Click(object sender, EventArgs e)
        {
            int varProId = int.Parse(txtIdProductAdd.Text);
            int varcanti = int.Parse(txtCantiProActAdd.Text);
            DataRowView auxPed = (DataRowView)cbxPedid.SelectedItem;
            int varPedid = int.Parse(auxPed.Row["pedid"].ToString());
            if (ped.agragarMas(varPedid, varProId, varcanti))
            {
                MessageBox.Show("Producto Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (datos.conectar())
            {
                tpcCrudPedido.Enabled = true;
                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erro al conectar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (datos.desconectar())
            {
                tpcCrudPedido.Enabled = false;
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al desconectar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
