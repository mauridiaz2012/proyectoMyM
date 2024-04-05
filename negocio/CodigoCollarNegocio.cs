using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CodigoCollarNegocio
    {
        public List<CodigoCollar> listar()
        {
            List<CodigoCollar> lista = new List<CodigoCollar>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT codigoCollar, largo FROM CodigosCollares");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    CodigoCollar aux    = new CodigoCollar();
                    aux.IdCodigoCollar = (int)datos.Lector["codigoCollar"];
                    aux.Largo = (string)datos.Lector["largo"];

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
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
