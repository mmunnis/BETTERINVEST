using BETTERINVEST.SHARED.Models;
using Heroic.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace BETTERINVEST.SHARED
{
    public class Stock
    {
        [Key]
        public int ID { get; set; }
        public string Symbol { get; set; }
        public decimal Shares { get; set; }
        public decimal TotalCost { get; set; }
        public decimal Dividend { get; set; }
        public int Frequency { get; set; }
        public bool Month01 { get; set; }
        public bool Month02 { get; set; }
        public bool Month03 { get; set; }
        public bool Month04 { get; set; }
        public bool Month05 { get; set; }
        public bool Month06 { get; set; }
        public bool Month07 { get; set; }
        public bool Month08 { get; set; }
        public bool Month09 { get; set; }
        public bool Month10 { get; set; }
        public bool Month11 { get; set; }
        public bool Month12 { get; set; }
    }
}
