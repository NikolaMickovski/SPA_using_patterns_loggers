using Registar.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    public static class DbContextManager
    {
        private static IDbContextFactory context;

        public static TContext CreateRepository<TContext>() where TContext : IDbContext
        {
            TContext result = context.CreateContext<TContext>();
            return result; 
        }

        public static void RegisterContext(IDbContextFactory context_out)
        {
            context = context_out;
        }
    }
}
