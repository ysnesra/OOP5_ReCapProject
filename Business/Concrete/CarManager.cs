using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Dependency Injection
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();    //ICarDal'daki GetAll()'ı çağırır
        }

        public List<Car> GetByBrands(int brandid)    //Marka id si verilen aynı marka arabaları getirir 
        {     
            return _carDal.GetByBrandId(brandid);        
        }

        public List<Car> GetByColors(int colorid)
        {
            return _carDal.GetByColorId(colorid);
        }

        public void Add(Car car)
        {
            if(car.CarName.Length <= 2)
            {
                throw new Exception("Araba ismi 2 karakterden az olamaz!");
            }
            else
            {
                _carDal.Add(car);
            }
            
        }

        public void Update(Car car)
        {
            if(car.UnitInStock>1)
            {
                _carDal.Update(car);
            }
            else
            {
                throw new Exception("Araba stokda 1 den fazla varsa güncellenebilir");
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        
    }
}
