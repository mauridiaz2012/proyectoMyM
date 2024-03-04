using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ColorCollarNegocio
    {
        public List<ColorCollar> listar()
        {
            List<ColorCollar> lista = new List<ColorCollar>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT  idColor, color FROM ColoresCollares");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    ColorCollar aux = new ColorCollar();
                    aux.IdColor = (int)datos.Lector["idColor"];
                    aux.Color = (string)datos.Lector["color"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
