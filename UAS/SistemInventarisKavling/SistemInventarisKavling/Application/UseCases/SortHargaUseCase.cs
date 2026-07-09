using System.Collections.Generic;
using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class SortHargaUseCase
    {
        private readonly IKavlingRepository repository;

        public SortHargaUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public List<Kavling> Execute()
        {
            return repository.SortHarga();
        }
    }
}