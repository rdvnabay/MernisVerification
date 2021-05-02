using MernisVerification.Abstract;
using MernisVerification.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerification.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
