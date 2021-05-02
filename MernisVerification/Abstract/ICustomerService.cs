using MernisVerification.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerification.Abstract
{
   public interface ICustomerService
    {
        public void Add(Customer customer);
    }
}
