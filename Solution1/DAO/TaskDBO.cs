using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class TaskDBO
    {
        //Create Crud Operations for Worker 
        TASK_MANAGEMENTEntities _DB = new TASK_MANAGEMENTEntities();

        //Create Operation 
        public void Create(TASK obj)
        {
            _DB.TASKs.Add(obj);
            _DB.SaveChanges();
        }

        //Read Operation 
        public TASK Read(int id)
        {

            return _DB.TASKs.Find(id);
        }

        //Update Operation 
        public void Update(TASK obj)
        {
            TASK std = _DB.TASKs.Find(obj.ID);
            std = obj;
            _DB.SaveChanges();
        }

        //Delete Operation 
        public void Delete(int id)
        {
            TASK obj = new TASK();
            obj = _DB.TASKs.Find(id);
            _DB.TASKs.Remove(obj);
            _DB.SaveChanges();
        }

        //List Operation 
        public List<TASK> List()
        {
            List<TASK> lst = new List<TASK>();
            lst = _DB.TASKs.ToList();
            return lst;
        }
    }
}
