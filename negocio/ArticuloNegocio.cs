using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesoDatos;
using dominio;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Codigo,Nombre,a.Descripcion,m.descripcion Color,c.descripcion Categoria,precio Precio,ImagenUrl as 'Link Imagen' from articulos a, marcas m, CATEGORIAS C where idmarca = m.id and IdCategoria = c.id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Color = new Color();
                    aux.Color.Descripcion = (string)datos.Lector["Color"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = (string)datos.Lector["Link Imagen"];

                    listaArticulos.Add(aux);
                }





            return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            } 
        }

        public void cargarImagen(string url)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

       
}

