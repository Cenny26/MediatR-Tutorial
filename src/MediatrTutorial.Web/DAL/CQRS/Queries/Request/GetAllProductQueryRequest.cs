using DAL.CQRS.Queries.Response;
using MediatR;

namespace DAL.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
