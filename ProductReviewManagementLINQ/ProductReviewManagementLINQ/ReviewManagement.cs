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
            Console.WriteLine();
            foreach (var review in productReviews)
            {
                Console.WriteLine($"Product ID: {review.ProductId}, User ID: {review.UserId}, Rating: {review.Rating}, Review: {review.Review}, IsLike: {review.isLike}");
            }
        }
        public void RetriveTop3Records(List<ProductReviewModel> productReviewModels)
        {
            List<ProductReviewModel> result = productReviewModels.OrderByDescending(x => x.Rating).Take(3).ToList();
            DisplayReviews(result.ToList());
        }
    }
}
