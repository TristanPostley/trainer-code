using Models;
using System.Collections.Generic;
using DL;
using System.Threading.Tasks;

namespace RRBL
{
    //this is an interface for all business logics i may or may not create
    //interface is a contract, all classes that implements an interface
    //must have the methods listed in the interface
    public interface IBL
    {
        List<Restaurant> GetAllRestaurants();

        Task<Restaurant> AddRestaurantAsync(Restaurant resto);

        Restaurant UpdateRestaurant(Restaurant restaurantToUpdate);

        List<Restaurant> SearchRestaurant(string quertStr);

        Review AddAReview(Review review);

        Restaurant GetOneRestaurantById(int id);

        void DeleteRestaurant(int id);
    }
}