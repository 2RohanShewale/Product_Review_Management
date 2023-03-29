using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReviewModel> productReviews = new List<ProductReviewModel>()
            {
                new ProductReviewModel() { ProductId = 1, UserId = 1, Rating = 2, Review = "Average", isLike = true },
                new ProductReviewModel() { ProductId = 2, UserId = 2, Rating = 1, Review = "Bad", isLike = false },
                new ProductReviewModel() { ProductId = 3, UserId = 3, Rating = 3, Review = "Nice", isLike = true },
                new ProductReviewModel() { ProductId = 4, UserId = 4, Rating = 4, Review = "Good", isLike = false },
                new ProductReviewModel() { ProductId = 5, UserId = 5, Rating = 5, Review = "Excelent", isLike = false },
                new ProductReviewModel() { ProductId = 6, UserId = 10, Rating = 3, Review = "Nice", isLike = true },
                new ProductReviewModel() { ProductId = 7, UserId = 6, Rating = 2, Review = "Average", isLike = true },
                new ProductReviewModel() { ProductId = 8, UserId = 5, Rating = 1, Review = "Bad", isLike = true },
                new ProductReviewModel() { ProductId = 9, UserId = 10, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 10, UserId = 41, Rating = 5, Review = "Excelent", isLike = false },
                new ProductReviewModel() { ProductId = 11, UserId = 5, Rating = 4, Review = "Nice", isLike = false },
                new ProductReviewModel() { ProductId = 12, UserId = 4, Rating = 1, Review = "Very Bad", isLike = true },
                new ProductReviewModel() { ProductId = 13, UserId = 48, Rating = 5, Review = "Excelent", isLike = false },
                new ProductReviewModel() { ProductId = 14, UserId =41, Rating = 2, Review = "Average", isLike = true },
                new ProductReviewModel() { ProductId = 15, UserId = 51, Rating = 3, Review = "Nice", isLike = true },
                new ProductReviewModel() { ProductId = 16, UserId = 8, Rating = 1, Review = "Very Bad", isLike = false },
                new ProductReviewModel() { ProductId = 17, UserId = 18, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReviewModel() { ProductId = 18, UserId = 9, Rating = 4, Review = "Good", isLike = true },
                new ProductReviewModel() { ProductId = 19, UserId = 10, Rating = 3, Review = "Nice", isLike = false },
                new ProductReviewModel() { ProductId = 20, UserId = 7, Rating = 2, Review = "Average", isLike = true },
                new ProductReviewModel() { ProductId = 21, UserId = 6, Rating = 1, Review = "Bad", isLike = true },
                new ProductReviewModel() { ProductId = 22, UserId = 5, Rating = 1, Review = "Very Bad", isLike = false },
                new ProductReviewModel() { ProductId = 23, UserId = 10, Rating = 4, Review = "Good", isLike = false },
                new ProductReviewModel() { ProductId = 24, UserId = 8, Rating = 1, Review = "Bad", isLike = true },
                new ProductReviewModel() { ProductId = 25, UserId = 12, Rating = 2, Review = "Average", isLike = false },
            };

            ReviewManagement reviewManagement = new ReviewManagement();
            reviewManagement.DisplayReviews(productReviews);
            Console.ReadKey();
        }
    }
}
