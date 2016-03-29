using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTests.Models;

namespace AutoMapperTests.AutoMapperResolvers
{
    class UserFormNameResolver : ValueResolver<Customer,string>
    {
        protected override string ResolveCore(Customer source)
        {
            return source.FirstName + " " + source.LastName;
        }
    }
}
