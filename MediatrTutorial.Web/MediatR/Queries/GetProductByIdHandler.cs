using MediatR;
using MediatrTutorial.Web.Models.ViewModels;

namespace MediatrTutorial.Web.MediatR.Queries
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // Get products from repositories, unit of works:

            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(viewModel);
        }
    }
}
