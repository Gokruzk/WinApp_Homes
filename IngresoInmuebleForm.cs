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
    public partial class IngresoInmuebleForm : Form
    {
        ClInmueble InmuebleObj = new ClInmueble();

        readonly string PathImage = Application.StartupPath + "\\assets\\images\\";
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        private List<string> rutasImagenes = new List<string>();

        public IngresoInmuebleForm()
        {
            InitializeComponent();
        }

        private void IngresoDepartamentoForm_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
            CbxTipo.SelectedIndex = 0;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string rutaArchivo in openFileDialog.FileNames)
                {
                    rutasImagenes.Add(rutaArchivo);
                    ListImagenes.Items.Add(Path.GetFileName(rutaArchivo));
                }
            }

            try
            {
                string ruta = rutasImagenes.First();
                PbxImagen.Image = Image.FromFile(ruta);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("No se pudieron procesar todas las imágenes, seleccione menos en cada carga", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            GuardarImagenes();
            GuardarDatosXML();
            GuardarImagenesXML();

            MessageBox.Show("Inmueble guardado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarImagenes()
        {
            PbxImagen.Image = null;

            foreach (string rutaArchivo in rutasImagenes)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                string nuevaRutaCompleta = Path.Combine(PathImage, nombreArchivo);

                File.Copy(rutaArchivo, nuevaRutaCompleta, true);
            }
        }

        private int ContarTipos()
        {
            XmlDocument documento = new XmlDocument();
            documento.Load(PathFile + "departamentos.xml");

            // Obtener los elementos TblInmueble
            XmlNodeList elementosTblInmueble = documento.GetElementsByTagName("TblInmueble");
            int contador = 0;

            // Contar los elementos TblInmueble del tipo deseado
            foreach (XmlNode nodo in elementosTblInmueble)
            {
                // Obtener el nodo Tipo y comparar con el tipo deseado
                XmlNode nodoTipo = nodo.SelectSingleNode("Tipo");
                if (nodoTipo != null && nodoTipo.InnerText == InmuebleObj.tipo)
                    contador++;
            }

            return contador;
        }
        private void GuardarDatosXML()
        {
            InmuebleObj.descripcion = TxtDesc.Text;

            InmuebleObj.ubicacion = TxtUbi.Text;

            dataSetVenta1.Tables["TblInmueble"].ReadXml(PathFile + "inmuebles.xml");
            object[] dataInmu = new object[7];

            InmuebleObj.GenerarCodigo(ContarTipos());

            dataInmu[0] = InmuebleObj.codigo;
            dataInmu[1] = InmuebleObj.tipo;
            dataInmu[2] = InmuebleObj.precio;
            dataInmu[3] = InmuebleObj.descripcion;
            dataInmu[4] = InmuebleObj.ubicacion;
            dataInmu[5] = InmuebleObj.estadoVenta;
            dataInmu[6] = InmuebleObj.nombre;

            dataSetVenta1.TblInmueble.Rows.Add(dataInmu);
            dataSetVenta1.Tables["TblInmueble"].WriteXml(PathFile + "departamentos.xml");
        }

        private void GuardarImagenesXML()
        {
            dataSetVenta1.Tables["TblFoto"].ReadXml(PathFile + "imagenes.xml");

            object[] dataFoto = new object[2];

            foreach (string rutaArchivo in rutasImagenes)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                dataFoto[0] = nombreArchivo;
                dataFoto[1] = InmuebleObj.codigo;

                dataSetVenta1.TblFoto.Rows.Add(dataFoto);
            }
            dataSetVenta1.Tables["TblFoto"].WriteXml(PathFile + "imagenes.xml");
        }

        private void ListImagenes_SelectedValueChanged(object sender, EventArgs e)
        {
            PbxImagen.Image = Image.FromFile(rutasImagenes[ListImagenes.SelectedIndex]);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                InmuebleObj.nombre = TxtNombre.Text;
                CbxTipo.Focus();
            }
        }

        private void CbxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InmuebleObj.tipo = CbxTipo.SelectedItem.ToString();
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    float precio = float.Parse(TxtPrecio.Text);

                    if (precio > 0)
                    {
                        InmuebleObj.precio = precio;
                        TxtUbi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El precio no puede ser 0 o negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtPrecio.Clear();
                    }
                }
                catch 
                {
                    MessageBox.Show("El precio del inmueble debe ser numérico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPrecio.Clear();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string texto = "¿Está seguro de borrar las imágenes cargadas del inmueble?";

            bool opcion = MessageBox.Show(texto, "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (opcion)
            {
                ListImagenes.Items.Clear();
                rutasImagenes.Clear();

                PbxImagen.Image = null;

                MessageBox.Show("Imágenes borradas correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}