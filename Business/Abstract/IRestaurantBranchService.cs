using DeliveryAPI.Core.Utilities.Results.Abstract;
using DeliveryAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Business.Abstract
{
    public interface IRestaurantBranchService
    {

         IDataResult<List<RestaurantBranches>> GetList();

         IDataResult<List<RestaurantBranches>> GetClosestLocation(double Latitude, double Longtitude);

    }
}
