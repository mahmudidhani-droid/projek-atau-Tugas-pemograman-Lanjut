using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class UpdateKavlingUseCase
    {
        private readonly IKavlingRepository repository;

        public UpdateKavlingUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(Kavling kavling)
        {
            repository.Update(kavling);
        }
    }
}