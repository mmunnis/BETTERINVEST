using System.ComponentModel.DataAnnotations;

namespace BETTERINVEST.SHARED
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
    }
}
