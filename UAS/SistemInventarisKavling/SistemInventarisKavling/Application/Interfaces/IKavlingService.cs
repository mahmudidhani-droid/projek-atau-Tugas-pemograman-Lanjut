using System.Collections.Generic;
using SistemInventarisKavling.Domain;

namespace SistemInventarisKavling.Application.Interfaces
{
    public interface IKavlingService
    {
        List<Kavling> GetAll(int currentPage, int pageSize);

        void Insert(Kavling kavling);

        void Update(Kavling kavling);

        void Delete(string id);

        List<Kavling> Search(string keyword);

        List<Kavling> SortHarga();

        List<Kavling> SortLuas();

        List<Kavling> Filter(string filter, int currentPage, int pageSize);

        int GetTotalData();
    }
}