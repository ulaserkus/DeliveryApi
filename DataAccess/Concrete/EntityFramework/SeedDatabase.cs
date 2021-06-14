using DeliveryAPI.DataAccess.Concrete.EntityFramework.Contexts;
using DeliveryAPI.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DataAccess.Concrete.EntityFramework
{
    public class SeedDatabase
    {
         public static void Seed()
        {
            var context = new DataContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.RestaurantBranches.Count() == 0)
                {
                    context.RestaurantBranches.AddRange(branches);
                }
            }

            context.SaveChanges();

        }


        private static RestaurantBranches[] branches =
        {
                  new RestaurantBranches{Name="restaurant1",Latitude=0.99,Longitude=1},
                  new RestaurantBranches{Name="restaurant2",Latitude=0.98,Longitude=1},
                  new RestaurantBranches{Name="restaurant3",Latitude=0.97,Longitude=1},
                  new RestaurantBranches{Name="restaurant4",Latitude=0.96,Longitude=1},
                  new RestaurantBranches{Name="restaurant5",Latitude=0.95,Longitude=1},
                  new RestaurantBranches{Name="restaurant6",Latitude=1,Longitude=0.99},
                  new RestaurantBranches{Name="restaurant7",Latitude=1,Longitude=0.98},
                  new RestaurantBranches{Name="restaurant8",Latitude=1,Longitude=0.97},
                  new RestaurantBranches{Name="restaurant9",Latitude=1,Longitude=0.96},
                  new RestaurantBranches{Name="restaurant10",Latitude=1,Longitude=0.95},
                  new RestaurantBranches{Name="restaurant11",Latitude=1.99,Longitude=2},
                  new RestaurantBranches{Name="restaurant12",Latitude=1.98,Longitude=2},
                  new RestaurantBranches{Name="restaurant13",Latitude=1.97,Longitude=1},
                  new RestaurantBranches{Name="restaurant14",Latitude=1.96,Longitude=1},
                  new RestaurantBranches{Name="restaurant15",Latitude=1.95,Longitude=1},
                  new RestaurantBranches{Name="restaurant16",Latitude=2,Longitude=1.99},
                  new RestaurantBranches{Name="restaurant17",Latitude=2,Longitude=1.98},
                  new RestaurantBranches{Name="restaurant18",Latitude=2,Longitude=1.97},
                  new RestaurantBranches{Name="restaurant19",Latitude=2,Longitude=1.96},
                  new RestaurantBranches{Name="restaurant20",Latitude=2,Longitude=1.95},

        };
    }
}
