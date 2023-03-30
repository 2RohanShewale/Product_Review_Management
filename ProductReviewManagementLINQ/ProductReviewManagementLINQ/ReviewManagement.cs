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
        public void RetriveTopThreeRecords(List<ProductReviewModel> productReviewModels)
        {
            List<ProductReviewModel> result = productReviewModels.OrderByDescending(x => x.Rating).Take(3).ToList();
            DisplayReviews(result.ToList());
        }
        public void GetReviewsRatingGreaterThenThree(List<ProductReviewModel> productReviewModels)
        {
            List<ProductReviewModel> result = productReviewModels.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).ToList();
            DisplayReviews(result);
        }
        public void countOFReviewForProductID(List<ProductReviewModel> productReviews)
        {
            var result = (productReviews.GroupBy(product => product.ProductId).Select(p => new { ProductID = p.Key, Count = p.Count() }));
            Console.WriteLine("Product ID Count");
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductID + " " + item.Count);
            }
        }
        public void GetProductIDAndReview(List<ProductReviewModel> productReviewModels)
        {
            var products = productReviewModels.Select(p => new { p.ProductId, p.Review }).ToList();

            foreach ( var product in products)
                Console.WriteLine("Id: " + product.ProductId + " " + product.Review);
        }

    }
}
