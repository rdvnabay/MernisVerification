using MernisServiceReference;
using MernisVerification.Abstract;
using MernisVerification.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerification.Concrete
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                Convert.ToInt64(customer.NationalIdentity), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
