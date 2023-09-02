using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Context.Repositories
{
	public class CarDal : GenericRepository<Car>, ICarDal
	{
		public CarDal(ProjectContext projectContext) : base(projectContext)
		{
		}
	}
}
