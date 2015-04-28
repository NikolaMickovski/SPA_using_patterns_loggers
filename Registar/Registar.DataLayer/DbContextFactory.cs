using Registar.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    /// <summary>
    /// Klasa koja go implementira IDbContextFactory
    /// </summary>
    public class DbContextFactory : Interfaces.IDbContextFactory
    {
        public TContext CreateContext<TContext>() where TContext : Interfaces.IDbContext
        {
            if (typeof(TContext) == typeof(IDbContextBikes))
            {
                return (TContext) (object) new RegistarDbContext ();
            }
            return default(TContext);
        }
    }
}
