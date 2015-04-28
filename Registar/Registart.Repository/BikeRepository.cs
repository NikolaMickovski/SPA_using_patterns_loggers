using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common;
using Registar.DataLayer;
using Registar.Repository.Interfaces;
using Registar.DataLayer.Interfaces;
using Registar.DomainModel;
using Autofac;

namespace Registar.Repository
{
    internal class BikeRepository:IBikeRepository
    {
        private IContainer container;

        public BikeRepository()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DbContextFactory>().As<IDbContextFactory>();
            container = builder.Build();
        }

        public IList<Bike> SearchBikes_Autofac()
        {
            List<Bike> bikes = new List<Bike>();
            using(var scope = container.BeginLifetimeScope())
            {
                var context = scope.Resolve<IDbContextBikes>();
                context.Bikes.OrderBy(p => p.Colour).Take(2).ToList();
            }
            return bikes;
        }

        public IList<DomainModel.Bike> SearchBikes()
        {
            List<Bike> bikes = new List<Bike>();
            Logging.LogInfo("===============StarSearchBike=============");
            using (var context =  DbContextManager.CreateRepository<IDbContextBikes>())               
            {//Sega tuka ke dojde Query-to sto go pisuvavme vo Business Layer                
                bikes = context.Bikes.OrderBy(p => p.Colour).Take(2).ToList();                
            }
            Logging.LogInfo("===============EndSearchBike===============");
            return bikes;
        }
    }
}
