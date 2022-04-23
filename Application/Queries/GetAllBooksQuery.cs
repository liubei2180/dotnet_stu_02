using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.Queries
{
    public class GetAllBooksQuery : IRequest<IEnumerable<string>> { }
}