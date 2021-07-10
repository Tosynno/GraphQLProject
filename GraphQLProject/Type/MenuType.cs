using GraphQL.Types;
using GraphQLProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.ImageUrl);
        }
    }
}
