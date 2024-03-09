using DAL.CQRS.Queries.Response;
using MediatR;

namespace DAL.CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
