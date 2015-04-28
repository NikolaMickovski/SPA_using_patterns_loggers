using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer.Interfaces
{
    /// <summary>
    /// Interface koj nasleduva od IDisposable
    /// Ovoj interface ke bide BASE Interface
    /// od koj ponatamu so Factory pattern ke se pravat contexts
    /// </summary>
    public interface IDbContext : IDisposable
    {
    }
}
