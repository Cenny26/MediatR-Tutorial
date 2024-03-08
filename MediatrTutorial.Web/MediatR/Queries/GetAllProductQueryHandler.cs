using MediatR;
using MediatrTutorial.Web.Models.ViewModels;

namespace MediatrTutorial.Web.MediatR.Queries
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            // Get products from repositories, unit of works:

            var viewModelBook = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            var viewModelPencil = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Pencil"
            };

            return Task.FromResult(new List<GetProductViewModel> { viewModelBook, viewModelPencil });
        }
    }
}
