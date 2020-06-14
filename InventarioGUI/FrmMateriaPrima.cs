using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmMateriaPrima : MetroFramework.Forms.MetroForm
    {
        CategoriaService categoriaService;
        MateriaPrimaService materiaPrimaService;
        List<Categoria> categorias;
        public FrmMateriaPrima()
        {
            InitializeComponent();

            categoriaService = new CategoriaService(ConfigConnection.connectionString);

            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);

            LlenarCategorias();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = categorias.Find(c => c.Nombre.Equals(CmbCategorias.SelectedItem));

            MateriaPrima materiaPrima = new MateriaPrima()
            {
                Nombre = TxtNombre.Text.Trim(),
                Cantidad = Convert.ToInt32(NumCantidad.Text),
                CantidadEnvase = Convert.ToInt32(NmbCantidadEnvase.Text),
                Precio = Convert.ToDouble(TxtPrecio.Text.Trim()),
                FechaAlmacenamiento = DateTime.Now.ToString("dd/MM/yyyy"),
                Categoria = categoria
            };
            string mensaje = materiaPrimaService.Guardar(materiaPrima);
            MessageBox.Show(mensaje, "error");
        }

        private void LlenarCategorias()
        {
            RespuestaConsultaCategorias respuesta = categoriaService.Consultar();
            categorias = respuesta.Categorias;

            if (respuesta.Error == false)
            {
                foreach (var categoria in respuesta.Categorias)
                {
                    CmbCategorias.Items.Add(categoria.Nombre);
                }

                MessageBox.Show(respuesta.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            new FrmConsultaMateriaPrima().Show();
        }
    }
}
