using GraphQL.Types;
using GraphQLProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Phone);
            Field(c => c.Time);
            Field(c => c.TotalPeople);
            Field(c => c.Email);
            Field(c => c.Date);
        }
    }
}
