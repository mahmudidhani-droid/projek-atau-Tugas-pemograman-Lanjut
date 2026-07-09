using System.Collections.Generic;
using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class SortLuasUseCase
    {
        private readonly IKavlingRepository repository;

        public SortLuasUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public List<Kavling> Execute()
        {
            return repository.SortLuas();
        }
    }
}