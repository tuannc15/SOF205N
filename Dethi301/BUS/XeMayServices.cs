using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class XeMayServices
    {
        static IXeMaytRepository repository;
        static XeMayServices()
        {
            repository = new XeMaytRepository();
        }
        public static List<XeMay> GetAll()
        {
            return repository.GetAll();
        }
        public static XeMay GetById(int id)
        {
            return repository.GetById(id);
        }
        public static XeMay Insert(XeMay obj)
        {
            return repository.Insert(obj);
        }
        public static void Update(XeMay obj)
        {
            repository.Update(obj);
        }
        public static void Delete(XeMay obj)
        {
            repository.Delete(obj);
        }
    }
}
