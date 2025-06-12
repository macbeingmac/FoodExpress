using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.services;
using FoodDeliverySystem.modules;

namespace FoodDeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ReviewService reviewService = new ReviewService();

            // 1. Add reviews
            reviewService.AddReview("Alice", "Amazing food and fast delivery!", 5);
            reviewService.AddReview("Bob", "Good but delivery was late.", 3);
            reviewService.AddReview("Charlie", "Food was cold, not happy.", 2);

            // 2. Show all reviews
            Console.WriteLine("📝 All Customer Reviews:");
            reviewService.ShowReviews();

            // 3. Delete a review
            Console.WriteLine("\n❌ Deleting review with ID = 2...");
            reviewService.DeleteReview(2);

            // 4. Show updated reviews
            Console.WriteLine("\n✅ Updated Reviews:");
            reviewService.ShowReviews();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }

}


