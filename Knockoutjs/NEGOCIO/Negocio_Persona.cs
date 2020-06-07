using System;
using System.Collections.Generic;
using System.Text;

namespace NEGOCIO
{
    public class Negocio_Persona
    {


        DATOS.Datos_Persona dato = new DATOS.Datos_Persona();
        public int registrar(ENTIDAD.Persona persona)
        {

            return dato.registrar(persona);
        }
        public int modificar(ENTIDAD.Persona persona)
        {

            return dato.modificar(persona);
        }
        public int eliminar(ENTIDAD.Persona persona)
        {

            return dato.eliminar(persona);
        }
        public IEnumerable<ENTIDAD.Persona> listado()
        {
            return dato.listado();
        }
    }
}
