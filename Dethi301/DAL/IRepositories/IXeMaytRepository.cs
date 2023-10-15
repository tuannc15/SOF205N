using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IXeMaytRepository
    {
        List<XeMay> GetAll();
        XeMay GetById(int id);
        XeMay Insert(XeMay xeMay);
        void Delete(XeMay xeMay);
        void Update(XeMay xeMay);
    }
}
