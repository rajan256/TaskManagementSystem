using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class TaskTypeDBO
    {

        //Create Crud Operations for Worker 
        TASK_MANAGEMENTEntities _DB = new TASK_MANAGEMENTEntities();

        //Create Operation 
        public void Create(TASK_TYPE obj)
        {
            _DB.TASK_TYPE.Add(obj);
            _DB.SaveChanges();
        }

        //Read Operation 
        public TASK_TYPE Read(int id)
        {

            return _DB.TASK_TYPE.Find(id);
        }

        //Update Operation 
        public void Update(TASK_TYPE obj)
        {
            TASK_TYPE std = _DB.TASK_TYPE.Find(obj.ID);
            std = obj;
            _DB.SaveChanges();
        }

        //Delete Operation 
        public void Delete(int id)
        {
            TASK_TYPE obj = new TASK_TYPE();
            obj = _DB.TASK_TYPE.Find(id);
            _DB.TASK_TYPE.Remove(obj);
            _DB.SaveChanges();
        }
        
        //List Operation 
        public List<TASK_TYPE> List()
        {
            List<TASK_TYPE> lst = new List<TASK_TYPE>();
            lst = _DB.TASK_TYPE.Where(O => O.IS_ACTIVE == true).ToList();
            return lst;
        }


    }
}
