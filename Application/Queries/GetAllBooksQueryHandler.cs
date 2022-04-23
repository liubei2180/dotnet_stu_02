using MediatR;

namespace Application.Queries.Handlers
{
    public class
    getAllBooksQueryHandler
    : IRequestHandler<GetAllBooksQuery, IEnumerable<string>>
    {
        public async Task<IEnumerable<string>>
        Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new [] { "Book m1", "Book m2" });
        }
    }
}