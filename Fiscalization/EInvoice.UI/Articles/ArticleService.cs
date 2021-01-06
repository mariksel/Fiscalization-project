using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInvoice.UI.Articles
{
    public class ArticleService
    {
        public static IList<Article> Articles = new List<Article>();
        static ArticleService()
        {
            Articles.Add(new()
            {
                Id = 1,
                Name = "Article 1",
                Price = 10
            });
            Articles.Add(new()
            {
                Id = 2,
                Name = "Article 2",
                Price = 20
            });
            Articles.Add(new()
            {
                Id = 3,
                Name = "Article 3",
                Price = 30
            });
            Articles.Add(new()
            {
                Id = 4,
                Name = "Article 4",
                Price = 40
            });
        }

    }
}
