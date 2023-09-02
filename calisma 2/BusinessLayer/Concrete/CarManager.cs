using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CarManager : ICarManager
	{
		private readonly ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void TDelete(Car t)
		{
			_carDal.Delete(t);
		}

		public List<Car> TGetAll()
		{
			return _carDal.GetAll();
		}

		public Car TGetByID(int id)
		{
			return _carDal.GetByID(id);
		}

		public void TInsert(Car t)
		{
			_carDal.Insert(t);
		}

		public void TUpdate(Car t)
		{
			_carDal.Update(t);
		}
	}
}
