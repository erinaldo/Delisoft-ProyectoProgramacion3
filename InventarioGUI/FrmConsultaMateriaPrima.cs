using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioGUI
{
    public partial class FrmConsultaMateriaPrima : MetroFramework.Forms.MetroForm
    {
        CategoriaService categoriaService;
        MateriaPrimaService materiaPrimaService;
        public FrmConsultaMateriaPrima()
        {
            InitializeComponent();

            categoriaService = new CategoriaService(ConfigConnection.connectionString);
            materiaPrimaService = new MateriaPrimaService(ConfigConnection.connectionString);


            LlenarCategorias();
        }

        private void LlenarCategorias()
        {
            RespuestaConsultaCategorias respuesta = categoriaService.Consultar();
            if (respuesta.Error == false)
            {
                CmbCategoria.Items.Add("TODAS");
                foreach (var categoria in respuesta.Categorias)
                {
                    CmbCategoria.Items.Add(categoria.Nombre);
                }
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            RespuestaConsultarMateriaPrima respuesta;


            DgvMateriaPrima.DataSource = null;
            respuesta = materiaPrimaService.ConsultarCategoria(CmbCategoria.Text);

            if (respuesta.ErrorMateriaPrima == false)
            {
                DgvMateriaPrima.DataSource = null;
               DgvMateriaPrima.DataSource = respuesta.MateriasPrimas;
               // DgvMateriaPrima.DataSource = materiaPrimaService.ConsultarCategoria(CmbCategoria.Text);

                MessageBox.Show(respuesta.MensajeMateriaPrima, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta.MensajeMateriaPrima, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CmbCategoria.Text.Equals("TODAS"))
            {
                DgvMateriaPrima.DataSource = null;
                respuesta = materiaPrimaService.Consultar();

                if (respuesta.ErrorMateriaPrima == false)
                {
                    DgvMateriaPrima.DataSource = respuesta.MateriasPrimas;

                    MessageBox.Show(respuesta.MensajeMateriaPrima, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.MensajeMateriaPrima, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            
        }

        private void FrmConsultaMateriaPrima_Load(object sender, EventArgs e)
        {

        }
    }
}
