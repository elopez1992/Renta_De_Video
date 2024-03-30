using Datos;
using Datos.BaseDatos.Modelos;
using Negocio.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NClientes
    {
        private DClientes dClientes;

        public NClientes()
        {
            dClientes = new DClientes();
        }

        public List<Clientes> TodasLasCategorias()
        {
            return dClientes.CategoriaCLientetodas();
        }

        public List<Clientes> CategoriasActivas()
        {
            return dClientes.CategoriaCLientetodas().Where(c => c.Estado == true).ToList();

        }

        public int AgregarCategoria(Clientes clientes)
        {
            return dClientes.GuardarCategoria(clientes);
        }
        public int EditarCategoria(Clientes clientes)
        {
            return dClientes.GuardarCategoria(clientes);
        }
        public int EliminarCategoria(int clienteId)
        {
            return dClientes.EliminarCategoria(clienteId);
        }
        public List<CargarCombos> CargarCombos()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var clientes=CategoriasActivas().Select(c=> new
                                                    { c.Nombres, 
                                                    c.ClienteId, })
                                            .ToList();
            foreach(var item in clientes)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.ClienteId,
                    Nombre = item.Nombres
                });
            
            }
            return Datos;


         }

     }


}
