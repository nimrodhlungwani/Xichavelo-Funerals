using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xichavelo.Web.Models;

namespace Xichavelo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Dignified Funeral & Financial Services You Can Trust";
            return View();
        }

        public IActionResult ServicePlans()
        {
            ViewData["Title"] = "Affordable Shield Funeral Insurance Plans";
            var plans = GetConfiguredPlans();
            return View(plans);
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Our Vision, Mission, and Compassionate Legacy";
            return View();
        }

        public IActionResult Gallery()
        {
            ViewData["Title"] = "Our Fleet, Sacred Setups & Ceremonies";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Reach Our Support Desk 24/7";
            return View(new ContactViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Validation failed. Please verify submission values.";
                return View(model);
            }
            TempData["SuccessMessage"] = "Your request has reached our operations desk. A consultant will call you back shortly.";
            return RedirectToAction(nameof(Contact));
        }

        public IActionResult JoinNow(string planName = "")
        {
            ViewData["Title"] = "Secure Your Family Policy Application";
            var model = new EnrollmentViewModel { SelectedPlan = planName };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult JoinNow(EnrollmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Please correct all submission form parameters to proceed.";
                return View(model);
            }
            TempData["SuccessMessage"] = "Application registered successfully! Our system is generating your invoice schedule.";
            return RedirectToAction(nameof(Index));
        }

        private List<PlanViewModel> GetConfiguredPlans()
        {
            return new List<PlanViewModel>
            {
                new PlanViewModel
                {
                    Name = "Gold Plan",
                    Price = 200,
                    MembersCovered = 15,
                    IsPopular = false,
                    HighlightedFeature = "All Tombstones & Casket Included",
                    CashPayoutBackup = 2000.00m,
                    Features = new List<string> {
                        "Premium Casket & Hearse Deployment",
                        "2 Luxury Family Transport Cars",
                        "Home Setup (Premium Tent & 100 Comfortable Chairs)",
                        "100 Order of Service Printing (Black & White)",
                        "Free Regional Deceased Collection & Local Burial Transport",
                        "Grave Marker and Standard Decor Layout",
                        "R1,000 Condolences Cash Benefit",
                        "R1,500 Meat/Grocery Voucher",
                        "R150 Dynamic Electricity / Airtime Allocation"
                    }
                },
                new PlanViewModel
                {
                    Name = "Platinum Plan",
                    Price = 300,
                    MembersCovered = 13,
                    IsPopular = true,
                    HighlightedFeature = "Premium Services + Enhanced Cash Cover",
                    CashPayoutBackup = 3000.00m,
                    Features = new List<string> {
                        "Exclusive Selection Casket & Hearse",
                        "3 Premium Family Transport Fleet Vehicles",
                        "Home Setup (Premium Tent & 100 Premium Chairs)",
                        "50 Full-Colour + 70 Crisp Black & White Programs",
                        "Free National Deceased Collection & Burial Transport Support",
                        "Elite Grave Marker & Grand Scale Flower Decor Layout",
                        "R1,500 Direct Condolences Cash Benefit",
                        "R2,000 Premium Grocery Voucher",
                        "R100 Dedicated Electricity + R100 Direct Airtime Top-up"
                    }
                }
            };
        }
    }
}