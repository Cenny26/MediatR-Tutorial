using MediatR;
using MediatrTutorial.Web.Models.ViewModels;

namespace MediatrTutorial.Web.MediatR.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductViewModel>>
    {
    }
}
