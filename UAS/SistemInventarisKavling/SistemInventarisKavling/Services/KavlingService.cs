using System.Collections.Generic;
using SistemInventarisKavling.Application.Interfaces;
using SistemInventarisKavling.Application.UseCases;
using SistemInventarisKavling.Domain;
using SistemInventarisKavling.Repository;

namespace SistemInventarisKavling.Services
{
    public class KavlingService : IKavlingService
    {
        private readonly GetAllKavlingUseCase getAllUseCase;
        private readonly InsertKavlingUseCase insertUseCase;
        private readonly UpdateKavlingUseCase updateUseCase;
        private readonly DeleteKavlingUseCase deleteUseCase;
        private readonly SearchKavlingUseCase searchUseCase;
        private readonly SortHargaUseCase sortHargaUseCase;
        private readonly SortLuasUseCase sortLuasUseCase;
        private readonly FilterKavlingUseCase filterUseCase;
        private readonly GetTotalDataUseCase totalDataUseCase;

        public KavlingService(IKavlingRepository repository)
        {
            getAllUseCase = new GetAllKavlingUseCase(repository);
            insertUseCase = new InsertKavlingUseCase(repository);
            updateUseCase = new UpdateKavlingUseCase(repository);
            deleteUseCase = new DeleteKavlingUseCase(repository);
            searchUseCase = new SearchKavlingUseCase(repository);
            sortHargaUseCase = new SortHargaUseCase(repository);
            sortLuasUseCase = new SortLuasUseCase(repository);
            filterUseCase = new FilterKavlingUseCase(repository);
            totalDataUseCase = new GetTotalDataUseCase(repository);
        }

        public List<Kavling> GetAll(int currentPage, int pageSize)
        {
            return getAllUseCase.Execute(currentPage, pageSize);
        }

        public void Insert(Kavling kavling)
        {
            insertUseCase.Execute(kavling);
        }

        public void Update(Kavling kavling)
        {
            updateUseCase.Execute(kavling);
        }

        public void Delete(string id)
        {
            deleteUseCase.Execute(id);
        }

        public List<Kavling> Search(string keyword)
        {
            return searchUseCase.Execute(keyword);
        }

        public List<Kavling> SortHarga()
        {
            return sortHargaUseCase.Execute();
        }

        public List<Kavling> SortLuas()
        {
            return sortLuasUseCase.Execute();
        }

        public List<Kavling> Filter(string filter, int currentPage, int pageSize)
        {
            return filterUseCase.Execute(filter, currentPage, pageSize);
        }

        public int GetTotalData()
        {
            return totalDataUseCase.Execute();
        }
    }
}