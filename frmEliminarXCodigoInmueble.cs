﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinApp_Homes
{
    public partial class frmEliminarXCodigoInmueble : Form
    {
        string buscarCod;
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";
        string PathImages = Application.StartupPath + "\\assets\\images\\";
        public frmEliminarXCodigoInmueble()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    buscarCod = txtCodigoImbBuscar.Text;
                    dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");
                    //dataSetVenta1.ReadXml(PathImages + "imagenes.xml");
                    System.Data.DataRow[] vecDatosInmueble;
                    //System.Data.DataRow[] vecFotosInmueble;

                    vecDatosInmueble = dataSetVenta1.TblInmueble.Select("Codigo ='" + txtCodigoImbBuscar.Text + "'");
                    //vecFotosInmueble = dataSetVenta1.TblFoto.Select("CodigoInmueble ='" + txtCodigoImbBuscar.Text + "'");

                    if (vecDatosInmueble.Length > 0)
                    {

                        frmEliminarInmueble objMostarEliminar = new frmEliminarInmueble(vecDatosInmueble, buscarCod);
                        
                        if (objMostarEliminar.ShowDialog() == DialogResult.OK)
                        {
                            vecDatosInmueble[0].Delete();
                            dataSetVenta1.WriteXml(PathFile + "inmuebles.xml");
                            //dataSetVenta1.WriteXml(PathFile + "imagenes.xml");
                            //vecFotosInmueble[0].Delete();
                            //dataSetVenta1.WriteXml(PathImages + "imagenes.xml");

                            BorrarFotos();
                            //foreach (DataRow row in vecFotosInmueble)
                            //{
                            //    MessageBox.Show(row["NombreFoto"].ToString(),"HOLA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //    string nombreFoto = row["NombreFoto"].ToString();
                            //    string pathImagen = PathImages + nombreFoto;

                            //    if (File.Exists(pathImagen))
                            //    {
                            //        File.Delete(pathImagen);
                            //        MessageBox.Show("Foto eliminada'");

                            //    }
                            //    else
                            //    {
                            //        MessageBox.Show("Foto NO eliminada'");
                            //    }
                            //}

                        }
                        else
                        {
                            MessageBox.Show($"No existe el inmueble con el código '{buscarCod}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCodigoImbBuscar.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show($"No existe el inmueble con el código '{buscarCod}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoImbBuscar.Clear();
                    }
                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoImbBuscar.Clear();
                }
            }
        }

        public void BorrarFotos()
        {
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "imagenes.xml");

            DataRow[] vectorFotos = dataSetVenta1.TblFoto.Select("CodigoInmueble ='" + txtCodigoImbBuscar.Text + "'");
        
            foreach (DataRow row in vectorFotos) {
                File.Delete(PathImages + row["NombreFoto"]);
            }

            vectorFotos[0].Delete();
            dataSetVenta1.WriteXml(PathFile + "imagenes.xml");
        }
    }
}
