using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class XeMaytRepository : IXeMaytRepository
    {
        public void Delete(XeMay xeMay)
        {
            using (FinalassFpolyNetJavaSm22Bl2Context db = new FinalassFpolyNetJavaSm22Bl2Context())
            {
                db.XeMays.Attach(xeMay);
                db.XeMays.Remove(xeMay);
                db.SaveChanges();
            }
        }

        public List<XeMay> GetAll()
        {
            using (FinalassFpolyNetJavaSm22Bl2Context db = new FinalassFpolyNetJavaSm22Bl2Context())
            {
                return db.XeMays.ToList();
            }
        }

        public XeMay GetById(int id)
        {
            throw new NotImplementedException();
        }

        public XeMay Insert(XeMay xeMay)
        {
            using (FinalassFpolyNetJavaSm22Bl2Context db = new FinalassFpolyNetJavaSm22Bl2Context())
            {
                db.XeMays.Add(xeMay);
                db.SaveChanges();
                return xeMay;
            }
        }

        public void Update(XeMay xeMay)
        {

            using (FinalassFpolyNetJavaSm22Bl2Context db = new FinalassFpolyNetJavaSm22Bl2Context())
            {
                db.XeMays.Attach(xeMay);
                db.XeMays.Update(xeMay);
                db.SaveChanges();
            }
        }
    }
}

