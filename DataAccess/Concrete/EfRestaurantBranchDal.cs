using DeliveryAPI.Core.DataAccess.EntityFrameWork;
using DeliveryAPI.Core.Helpers;
using DeliveryAPI.DataAccess.Concrete;
using DeliveryAPI.DataAccess.Concrete.EntityFramework.Contexts;
using DeliveryAPI.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DataAccess.Abstract
{
    public class EfRestaurantBranchDal : EfEntityRepositoryBase<RestaurantBranches, DataContext>, IRestaurantBranchDal
    {
       

        public List<RestaurantBranches> GetClosestLocation(double Latitude, double Longtitude)
        {
            
            
            using (var context = new DataContext())
            {
                List<RestaurantBranches> branches = new List<RestaurantBranches>();


                foreach (var branch in context.RestaurantBranches)
                {
                    double TetaValue = branch.Longitude - Longtitude;
                    double mil = Math.Sin(Helper.DegreeToRad(branch.Latitude)) * Math.Sin(Helper.DegreeToRad(Latitude)) +
                                 Math.Cos(Helper.DegreeToRad(branch.Latitude)) * Math.Cos(Helper.DegreeToRad(Latitude))* Math.Cos(Helper.DegreeToRad(TetaValue));
                    mil = Math.Acos(mil);
                    mil = Helper.RadToDegree(mil) * 60 * 1.1515;
                    double km = mil * 1.609344;

                    if (km <= 10)
                    {
                        branches.Add(branch);
                    }

                }

                var list = (from x in branches
                            orderby x.Latitude, x.Longitude 
                            select x).Take(5).ToList();

                return list;

            }
        }
    }
}
