using System.Collections.Generic;
using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class SearchKavlingUseCase
    {
        private readonly IKavlingRepository repository;

        public SearchKavlingUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public List<Kavling> Execute(string keyword)
        {
            return repository.Search(keyword);
        }
    }
}