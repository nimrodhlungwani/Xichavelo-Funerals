using System.Collections.Generic;

namespace Xichavelo.Web.Models
{
    public class PlanViewModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int MembersCovered { get; set; }
        public List<string> Features { get; set; } = new();
        public string HighlightedFeature { get; set; } = string.Empty;
        public decimal CashPayoutBackup { get; set; }
        public bool IsPopular { get; set; }
        public string BadgeClass => IsPopular ? "bg-gold text-dark" : "bg-dark text-light";
    }
}