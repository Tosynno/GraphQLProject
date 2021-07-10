using GraphQL.Types;
using GraphQLProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProject.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Description);
            Field(c => c.ImageUrl);
            Field(c => c.Price);
            Field(c => c.MenuId);
        }
    }
}
