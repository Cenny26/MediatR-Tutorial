using MediatR;

namespace MediatrTutorial.Web.MediatR.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Set products to repositories, unit of works:

            return Task.FromResult(Guid.NewGuid());
        }
    }
}
