using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliverySystem.modules;

namespace FoodDeliverySystem.services
{
    class ReviewService
    {
        private List<Review> reviews = new List<Review>();
        private int nextReviewId = 1;

        // Add a new review
        public void AddReview(string reviewerName, string comment, int rating)
        {
            Review review = new Review(nextReviewId, reviewerName, comment, rating);
            reviews.Add(review);
            nextReviewId++;
        }

        // Show all reviews
        public void ShowReviews()
        {
            if (reviews.Count == 0)
            {
                Console.WriteLine("No reviews available.");
                return;
            }

            Console.WriteLine("\nCustomer Reviews:");
            foreach (Review r in reviews)
            {
                Console.WriteLine($"ID: {r.GetReviewId()}, Name: {r.GetReviewerName()}, Rating: {r.GetRating()}");
                Console.WriteLine($"Comment: {r.GetComment()}\n");
            }
        }

        // Delete a review by ID
        public void DeleteReview(int reviewId)
        {
            Review toDelete = null;

            foreach (Review r in reviews)
            {
                if (r.GetReviewId() == reviewId)
                {
                    toDelete = r;
                    break;
                }
            }

            if (toDelete != null)
            {
                reviews.Remove(toDelete);
                Console.WriteLine("Review deleted.");
            }
            else
            {
                Console.WriteLine("Review not found.");
            }
        }
    }
}
