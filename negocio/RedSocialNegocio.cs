using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class RedSocialNegocio
    {
        public List<RedSocial> listar()
        {

            List<RedSocial> lista = new List<RedSocial>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT idRedSocial, nombreRedSocial FROM RRSS");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    RedSocial aux = new RedSocial();
                    aux.IdRedSocial = (int)datos.Lector["IdRedSocial"];
                    aux.nombreRedSocial = (string)datos.Lector["nombreRedSocial"];

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
