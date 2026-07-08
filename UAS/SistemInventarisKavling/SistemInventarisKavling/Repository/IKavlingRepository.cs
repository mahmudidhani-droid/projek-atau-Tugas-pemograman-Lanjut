using SistemInventarisKavling.Domain;
using System.Collections.Generic;

namespace SistemInventarisKavling.Repository
{
    public interface IKavlingRepository
    {
        List<Kavling> GetAll();

        void Insert(Kavling kavling);

        void Update(Kavling kavling);

        void Delete(string id);

        Kavling GetById(string id);

        List<Kavling> Search(string keyword);

        List<Kavling> GetAll(int page, int pageSize);

        int GetTotalData();

        List<Kavling> Filter(string filter, int page, int pageSize);
        List<Kavling> SortLuas();
        List<Kavling> SortHarga();
    }
}