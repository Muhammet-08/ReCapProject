using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
        //                                                                _carDal.Add(car);         
        //iş sınıflarında koşul kodlarını yazarken sadece return new SuccesResult(Messages.CarAdded) yazmak yeterli olur doğru değer döndüren koşulun içine

    }
}
