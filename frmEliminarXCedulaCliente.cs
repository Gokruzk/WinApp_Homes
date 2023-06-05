﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes
{
    public partial class frmEliminarXCedulaCliente : Form
    {
        string buscarCedula;
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        public frmEliminarXCedulaCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscarCedula = txtCedulaBuscar.Text;
                dataSetVenta1.ReadXml(PathFile + "clientes.xml");
                System.Data.DataRow[] vecDatosCliente;

                vecDatosCliente = dataSetVenta1.TblCliente.Select("Cedula ='" + txtCedulaBuscar.Text + "'");

                if (vecDatosCliente.Length > 0)
                {

                    frmEliminarCliente objMostarEliminarCliente = new frmEliminarCliente(vecDatosCliente);
                    if (objMostarEliminarCliente.ShowDialog() == DialogResult.OK)
                    {
                        vecDatosCliente[0].Delete();
                        dataSetVenta1.WriteXml(PathFile + "clientes.xml");
                    }
                    else
                    {
                        MessageBox.Show($"No existe el cliente con la cédula '{buscarCedula}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCedulaBuscar.Clear();
                    }

                }
                else
                {
                    MessageBox.Show($"No existe el cliente con la cédula '{buscarCedula}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCedulaBuscar.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Existen valores inválidos" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedulaBuscar.Clear();
            }
        }

        private void txtCedulaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            try
            {
                btnBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                throw;
            }
        }
    }
}
