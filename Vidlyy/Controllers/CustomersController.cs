using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidlyy.Models;
using Vidlyy.ViewModels;

namespace Vidlyy.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult CustomerView()
        {
            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View();
        }
        public ActionResult Particular(int id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).Single(c => c.Id == id);
            return View(customers);

        }
        public ActionResult New()
        {
            var membershiptype = _context.MembershipTypes;
            var ViewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershiptype,
                Customer = new Customer()

            };
            return View(ViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("New", viewModel);
            }
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Dob = customer.Dob;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            }
            _context.SaveChanges();
            return RedirectToAction("CustomerView", "Customers");
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("New", viewModel);
        }

    }
}