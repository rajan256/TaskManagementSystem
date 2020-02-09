using BAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaskAssignmentDBO
    {
        //Create Crud Operations for Worker 
        TASK_MANAGEMENTEntities _DB = new TASK_MANAGEMENTEntities();

        //Create Operation 
        public void Create(TASK_ASSIGNMENT obj)
        {
            _DB.TASK_ASSIGNMENT.Add(obj);
            _DB.SaveChanges();
        }

        //Read Operation 
        public TASK_ASSIGNMENT Read(int id)
        {

            return _DB.TASK_ASSIGNMENT.Find(id);
        }

        //Update Operation 
        public void Update(TASK_ASSIGNMENT obj)
        {
            TASK_ASSIGNMENT std = _DB.TASK_ASSIGNMENT.Find(obj.ID);
            std = obj;
            _DB.SaveChanges();
        }

        //Delete Operation 
        public void Delete(int id)
        {
            TASK_ASSIGNMENT obj = new TASK_ASSIGNMENT();
            obj = _DB.TASK_ASSIGNMENT.Find(id);
            _DB.TASK_ASSIGNMENT.Remove(obj);
            _DB.SaveChanges();
        }

        //List Operation 
        public List<TASK_ASSIGNMENT> List()
        {
            List<TASK_ASSIGNMENT> lst = new List<TASK_ASSIGNMENT>();
            lst = _DB.TASK_ASSIGNMENT.ToList();
            return lst;
        }

    }
}
