using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class DeleteKavlingUseCase
    {
        private readonly IKavlingRepository repository;

        public DeleteKavlingUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(string id)
        {
            repository.Delete(id);
        }
    }
}