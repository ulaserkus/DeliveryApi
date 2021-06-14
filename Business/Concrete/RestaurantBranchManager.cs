using DeliveryAPI.Business.Abstract;
using DeliveryAPI.Core.Utilities.Results.Abstract;
using DeliveryAPI.Core.Utilities.Results.Concrete;
using DeliveryAPI.DataAccess.Abstract;
using DeliveryAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Business.Concrete
{
    public class RestaurantBranchManager:IRestaurantBranchService
    {
        private IRestaurantBranchDal _restaurantBranchDal;


        public RestaurantBranchManager(IRestaurantBranchDal restaurantBranchDal)
        {
            _restaurantBranchDal = restaurantBranchDal;
        }

        public IDataResult<List<RestaurantBranches>> GetClosestLocation(double Latitude, double Longtitude)
        {
            return new SuccessDataResult<List<RestaurantBranches>>(_restaurantBranchDal.GetClosestLocation(Latitude,Longtitude));
        }

        public IDataResult<List<RestaurantBranches>> GetList()
        {
            return new SuccessDataResult<List<RestaurantBranches>>(_restaurantBranchDal.GetList(null).ToList());
        }

    }
}
