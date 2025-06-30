namespace WMS___Projekt.DataAccess.Repositories
{
    using System.Data;
    using WMS___Projekt.Models;

    public interface ICarRepository
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(int carId);
        DataTable GetAll();
    }
}
