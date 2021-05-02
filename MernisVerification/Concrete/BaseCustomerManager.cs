using MernisVerification.Abstract;
using MernisVerification.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerification.Concrete
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Save to Database: "+customer.FirstName);
        }
    }
}
