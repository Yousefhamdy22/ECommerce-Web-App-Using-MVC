using ECommerce_MVC.Areas.AdminPanel.AdminVM;
using ECommerce_MVC.Areas.AdminPanel.Models;
using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Areas.SellerPanel.Models;
using ECommerce_MVC.Models;
using ECommerce_MVC.RepositoryPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ECommerce_MVC.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        readonly UserManager<ApplicationUser> _userManager;
        readonly RoleManager<IdentityRole> _roleManager;
        readonly IRepository<Order> orderRepo;
        readonly IRepository<Product> productRepo;
        readonly IRepository<Seller> sellerRepo;
        readonly IRepository<Customer> customerRepo;


        public AdminController(
           UserManager<ApplicationUser> userManager,
           RoleManager<IdentityRole> roleManager,
           IRepository<Order> orderRepo,
           IRepository<Product> productRepo,
           IRepository<Seller> sellerRepo,
           IRepository<Customer> customerRepo
           )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            this.orderRepo = orderRepo;
            this.productRepo = productRepo;
            this.sellerRepo = sellerRepo;
            this.customerRepo = customerRepo;
        }

        public async Task<ActionResult> Index()
        {
            var ViewModel = new AdminStatsVM()
            {
                NewOrders = (await orderRepo.GetAllAsync()).Count,
                NewProducts = (await productRepo.GetAllAsync()).Count,
                Sellers = (await sellerRepo.GetAllAsync()).Count,
                Customers = (await customerRepo.GetAllAsync()).Count
            };

            return View(ViewModel);
        }

        public async Task<IActionResult> ManageUserRoles()
        {
            var users = await _userManager.Users.ToListAsync();
            var roles = await _roleManager.Roles.ToListAsync();

            var viewModel = new ManagrmentRoleVM
            {
                Users = users,
                Roles = roles
            };

            return View(viewModel);
        }



        [HttpPost]
        public async Task<IActionResult> SetUserRole(string SelectedUserId, string SelectedRoleId)
        {
            var user = await _userManager.FindByIdAsync(SelectedUserId);
            var role = await _roleManager.FindByIdAsync(SelectedRoleId);

            if (user != null && role != null)
            {
                // Remove user from any existing roles
                var currentRoles = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, currentRoles);

                // Assign user to selected role
                var result = await _userManager.AddToRoleAsync(user, role.Name);

                if (result.Succeeded)
                {
                    // Role assignment was successful
                    TempData["SuccessMessage"] = $"Role assigned successfully to user {user.UserName}.";
                }
                else
                {
                    // Handle errors
                    TempData["ErrorMessage"] = $"An error occurred while assigning role to user {user.UserName}.";
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Invalid user or role selected.";
            }

            return RedirectToAction("ManageUserRoles");
        }











    }
}
