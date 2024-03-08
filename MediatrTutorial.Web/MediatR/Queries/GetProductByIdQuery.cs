using MediatR;
using MediatrTutorial.Web.Models.ViewModels;

namespace MediatrTutorial.Web.MediatR.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
