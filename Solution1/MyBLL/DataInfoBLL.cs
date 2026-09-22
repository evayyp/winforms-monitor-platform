using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEntity;
using MyDAL;
using ClassLibrary1;

namespace MyBLL
{
    public class DataInfoBLL
    {
        DataInfoDAL dal = new DataInfoDAL();
        public List<DataInfoEntity> SelectAll(string diviceName)
        {
            return dal.SelectAll(diviceName);
        }
        public double MaxTemperature(int diviceId)
        {
            return dal.MaxTemperature(diviceId);
        }
        public double MinTemperature(int diviceId)
        {
            return dal.MinTemperature(diviceId);
        }
        public int MaxHumidity(int diviceId)
        {
            return dal.MaxHumidity(diviceId);
        }
        public int MinHumidity(int diviceId)
        {
            return dal.MinHumidity(diviceId);
        }
        public double MaxPressure(int diviceId)
        {
            return dal.MaxPressure(diviceId);
        }
        public double MinPressure(int diviceId)
        {
            return dal.MinPressure(diviceId);
        }
        public double CurrentTemperature(int diviceId)
        {
            return dal.CurrentTemperature(diviceId);
        }
        public int CurrentHumidity(int diviceId)
        {
            return dal.CurrentHumidity(diviceId);
        }
        public double CurrentPressure(int diviceId)
        {
            return dal.CurrentPressure(diviceId);
        }
    }
}
