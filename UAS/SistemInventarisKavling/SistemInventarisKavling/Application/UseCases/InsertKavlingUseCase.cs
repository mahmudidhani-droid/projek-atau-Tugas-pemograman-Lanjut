using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class InsertKavlingUseCase
    {
        private readonly IKavlingRepository repository;

        public InsertKavlingUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(Kavling kavling)
        {
            repository.Insert(kavling);
        }
    }
}