using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory_sahte_veritabanı_;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {

            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length>2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                 return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                 return new ErrorResult(Messages.CarNotAdded);
            }
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult< List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
            
        }

        public IDataResult< List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(c=>c.CarId==id),Messages.CarByIdListed);
        }

        public IDataResult< List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails(),Messages.CarDetailListed);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }
    }
}
