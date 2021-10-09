using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VY.GraphQLCrud.Dal.Context;
using VY.GraphQLCrud.Models;

namespace VY.GraphQLCrud.UI.Query
{
    public class Query
    {
        public IQueryable<User> GetUsers([Service] AppDbContext context)
        {
            return context.Users;
        }
    }
}
