using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatisSistemi.Entity;
using SatisSistemi.Utility;
namespace SatisSistemi.Bll
{
    public class tblkasamanager: ICRUD<tblkasa>
    {
        private dbmusteriEntities _context;

        public tblkasamanager() {
            _context = new dbmusteriEntities();
        }
        public void Add(tblkasa t)
        {
            _context.tblkasa.Add(t);
            _context.SaveChanges();
        }

        public void Delete(tblkasa t)
        {
            throw new NotImplementedException();
        }

        public void Update(tblkasa t)
        {
            throw new NotImplementedException();
        }

        public tblkasa Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<tblkasa> MyList()
        {
            throw new NotImplementedException();
        }
    }
}
