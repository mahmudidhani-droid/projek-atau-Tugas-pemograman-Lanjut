using System.Collections.Generic;
using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Application.UseCases
{
    public class GetAllKavlingUseCase
    {
        private readonly IKavlingRepository repository;

        public GetAllKavlingUseCase(IKavlingRepository repository)
        {
            this.repository = repository;
        }

        public List<Kavling> Execute(int currentPage, int pageSize)
        {
            return repository.GetAll(currentPage, pageSize);
        }
    }
}