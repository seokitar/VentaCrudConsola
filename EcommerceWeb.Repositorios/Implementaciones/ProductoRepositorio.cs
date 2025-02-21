using EcommerceWeb.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Implementaciones
{
    public class ProductoRepositorio : RepositorioBase<Producto>
    {
        public ProductoRepositorio(DbContext context) : base(context)
        {
        }
    }
}
