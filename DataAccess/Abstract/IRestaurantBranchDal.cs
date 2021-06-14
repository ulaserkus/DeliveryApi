using DeliveryAPI.Core.DataAccess;
using DeliveryAPI.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DataAccess.Abstract
{
    public interface IRestaurantBranchDal:IEntityRepository<RestaurantBranches>
    {

        List<RestaurantBranches> GetClosestLocation(double Latitude,double Longtitude);
    }
}
