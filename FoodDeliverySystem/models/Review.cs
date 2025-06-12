using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.modules
{
    class Review
    {
        private int reviewId;
        private string reviewerName;
        private string comment;
        private int rating; // 1 to 5 stars

        // Constructor
        public Review(int reviewId, string reviewerName, string comment, int rating)
        {
            this.reviewId = reviewId;
            this.reviewerName = reviewerName;
            this.comment = comment;
            SetRating(rating); // use setter for validation
        }

        // Getter & Setter for Review ID
        public int GetReviewId()
        {
            return reviewId;
        }

        public void SetReviewId(int value)
        {
            reviewId = value;
        }

        // Getter & Setter for Reviewer Name
        public string GetReviewerName()
        {
            return reviewerName;
        }

        public void SetReviewerName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                reviewerName = name;
            }
            else
            {
                Console.WriteLine("Reviewer name cannot be empty.");
            }
        }

        // Getter & Setter for Comment
        public string GetComment()
        {
            return comment;
        }

        public void SetComment(string value)
        {
            comment = value;
        }

        // Getter & Setter for Rating
        public int GetRating()
        {
            return rating;
        }

        public void SetRating(int value)
        {
            if (value >= 1 && value <= 5)
            {
                rating = value;
            }
            else
            {
                Console.WriteLine("Rating must be between 1 and 5.");
                rating = 1; // default fallback
            }
        }
    }
}
