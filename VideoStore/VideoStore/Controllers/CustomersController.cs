using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;
using System.Data.Entity;
using VideoStore.ViewModels;

namespace VideoStore.Controllers
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
        
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(), // Podczas wypisywania listy błędów nie będzie informacji o błędnym Id użytkownika(
                                            //id wtedy jest pustym stringiem, mvc nie wie wiec jak to traktować 
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }

        [HttpPost]           // Zawsze gdy zapisujemy do bazy                                        
        public ActionResult Save(Customer customer) //Model binding. 
        {
            if(!ModelState.IsValid)     //validation
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()

                };
                return View("CustomerForm", viewModel);

            }
            if(customer.Id == 0 )
                _context.Customers.Add(customer); //Nie dodaje do bazy , jest tylko w pamięci
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                //Za pomocą mappera byla by to jedna linia zamiast 4 Mapper.Map(customer, customerInDb)
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges(); //To już zapisuje
            return RedirectToAction("Index", "Customers");
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); // eager loading 
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
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
            return View("CustomerForm", viewModel);
        }
      /*  private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
        */
    }
}