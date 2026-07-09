using System.Collections.Generic;
using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class FilterKavlingUseCase
    {
        private readonly IKavlingRepository repository;

        public FilterKavlingUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public List<Kavling> Execute(string filter, int currentPage, int pageSize)
        {
            return repository.Filter(filter, currentPage, pageSize);
        }
    }
}