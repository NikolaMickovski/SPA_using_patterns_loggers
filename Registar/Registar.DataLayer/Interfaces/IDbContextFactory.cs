using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer.Interfaces
{
    /// <summary>
    /// Factory Interface koj ke vrakja context nasleden od IDbContext
    /// </summary>
    public interface IDbContextFactory
    {
        TContext CreateContext<TContext>() where TContext:IDbContext;
    }
}
