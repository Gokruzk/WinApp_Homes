﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinApp_Homes
{
    public partial class VentaForm : Form
    {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        DataRow dataInmuebleVenta;

        DataRow[] dataInmuebles;
        DataRow[] dataClientes;
        List<string> clientes = new List<string>();
        List<string> clientesNom = new List<string>();


        public VentaForm()
        {
            InitializeComponent();
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");
            dataInmuebles = dataSetVenta1.TblInmueble.Select();
            foreach (DataRow inmu in dataInmuebles)
            {
                if (inmu["EstadoVenta"].ToString() == "DISPONIBLE")
                    CbxInmueble.Items.Add(inmu["NombreInmueble"]);
            }
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "clientes.xml");
            dataClientes = dataSetVenta1.TblCliente.Select();
            foreach (DataRow cliente in dataClientes)
            {
                CbxCliente.Items.Add(cliente["Nombre"] + " " + cliente["Apellido"]);
                clientes.Add(cliente["Cedula"].ToString());
                clientesNom.Add(cliente["Nombre"].ToString() + " " + cliente["Apellido"].ToString());
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LeerInmueble();

            string nomInmu = dataInmuebleVenta["NombreInmueble"].ToString();

            string ced = clientes[CbxCliente.SelectedIndex];
            string nomCli = clientesNom[CbxCliente.SelectedIndex];
            string precio = dataInmuebleVenta["Precio"].ToString();

            dataSetVenta1.Clear();
            dataSetVenta1.Tables["TblVenta"].ReadXml(PathFile + "ventas.xml");
            object[] dataVenta = new object[7];

            dataVenta[0] = nomInmu.Substring(0,3) + nomCli.Substring(0,3) + "_" + ced[3];
            dataVenta[1] = TxtMensualidad.Text;
            dataVenta[2] = ced;
            dataVenta[3] = TxtMeses.Text;
            dataVenta[4] = nomCli;
            dataVenta[5] = nomInmu;
            dataVenta[6] = precio;

            dataSetVenta1.TblVenta.Rows.Add(dataVenta);
            dataSetVenta1.Tables["TblVenta"].WriteXml(PathFile + "ventas.xml");

            LeerInmueble();
            DataRow vector = dataInmuebleVenta;

            vector["Codigo"] = dataInmuebleVenta["Codigo"];
            vector["Tipo"] = dataInmuebleVenta["Tipo"];
            vector["Precio"] = dataInmuebleVenta["Precio"];
            vector["Descripcion"] = dataInmuebleVenta["Descripcion"];
            vector["Ubicacion"] = dataInmuebleVenta["Ubicacion"];
            vector["NombreInmueble"] = dataInmuebleVenta["NombreInmueble"];
            vector["EstadoVenta"] = "VENDIDO";

            vector.AcceptChanges();
            dataSetVenta1.WriteXml(PathFile + "inmuebles.xml");

            MessageBox.Show("Venta generada correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtMensualidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int meses = int.Parse(Math.Round(double.Parse(dataInmuebleVenta["Precio"].ToString()) / double.Parse(TxtMensualidad.Text)).ToString());
                TxtMeses.Text = meses.ToString();
            }
            catch
            {

            }
        }

        private void LeerInmueble()
        {
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");

            dataInmuebleVenta = dataSetVenta1.TblInmueble.Select("NombreInmueble='" + CbxInmueble.SelectedItem.ToString() + "'")[0];
        }

        private void CbxInmueble_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LeerInmueble();
            LblPrecio.Text = "Precio: $" + dataInmuebleVenta["Precio"].ToString();
        }
    }
}
