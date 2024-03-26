using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace winform_app
{
    public partial class frmInicio : Form
    {
        private List<Articulo> listaArticulo;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            listaArticulo = negocio.listar();

            if(listaArticulo != null)
            {
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                
            }
            pbxArticulos.Load("https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png");





        }
    }
}
