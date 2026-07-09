using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class GetTotalDataUseCase
    {
        private readonly IKavlingRepository repository;

        public GetTotalDataUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public int Execute()
        {
            return repository.GetTotalData();
        }
    }
}