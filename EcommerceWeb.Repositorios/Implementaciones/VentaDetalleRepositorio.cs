using EcommerceWeb.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Implementaciones
{
    public class VentaDetalleRepositorio : RepositorioBase<VentaDetalle>
    {
        public VentaDetalleRepositorio(DbContext context) : base(context)
        {
        }
    }
}
