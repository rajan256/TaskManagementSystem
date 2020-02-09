using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class WorkerDBO
    {
       TASK_MANAGEMENTEntities _DB = new TASK_MANAGEMENTEntities();
        public void Create(WORKER obj)
        {
            _DB.WORKERs.Add(obj);
            _DB.SaveChanges();
        }

        public WORKER Read(int id)
        {
            return _DB.WORKERs.Find(id);
        }
        public void Update(WORKER obj)
        {
            WORKER std = _DB.WORKERs.Find(obj.ID);
            std = obj;
            _DB.SaveChanges();
        }
        public void Delete(int id)
        {
            WORKER obj = new WORKER();
            obj = _DB.WORKERs.Find(id);
            _DB.WORKERs.Remove(obj);
            _DB.SaveChanges();
        }
        public List<WORKER> List()
        {
            List<WORKER> lst = new List<WORKER>();
            lst = _DB.WORKERs.Where(O => O.IS_ACTIVE == true).ToList(); 
            return lst;
        }
    }
}
