using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTests.Models;

namespace AutoMapperTests.AutoMapperResolvers
{
    public class AddressResolver : ValueResolver<BillingInfo, string>
    {
        protected override string ResolveCore(BillingInfo source)
        {
            return source.Country + " " + source.City + " " + source.Street;
        }
    }
}
