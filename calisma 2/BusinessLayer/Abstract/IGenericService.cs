using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T t);
		void TDelete(T t);
		void TUpdate(T t);
		List<T> TGetAll();
		T TGetByID(int id);
	}
}
