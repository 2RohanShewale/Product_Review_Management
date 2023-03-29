using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    public class ReviewManagement
    {
        public void DisplayReviews(List<ProductReviewModel>  productReviews)
        {
            foreach (var review in productReviews)
            {
                Console.WriteLine($"Product ID: {review.ProductId}, User ID: {review.UserId}, Rating: {review.Rating}, Review: {review.Review}, IsLike: {review.isLike}");
            }
        }
    }
}
