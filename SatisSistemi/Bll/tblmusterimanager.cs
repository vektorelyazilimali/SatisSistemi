using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatisSistemi.Utility;
using SatisSistemi.Entity;
namespace SatisSistemi.Bll
{
    public class tblmusterimanager: ICRUD<tblmusteri>
    {

        dbmusteriEntities _context;

        public tblmusterimanager() {
            _context = new dbmusteriEntities();
        }

        public void Add(tblmusteri t)
        {
            _context.tblmusteri.Add(t);
            _context.SaveChanges();
        }

        public void Delete(tblmusteri t)
        {
            _context.tblmusteri.Remove(t);
            _context.SaveChanges();
        }

        public void Update(tblmusteri t)
        {
            //???
        }

        public tblmusteri Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<tblmusteri> MyList()
        {
            return _context.tblmusteri.ToList();
        }
    }
}
