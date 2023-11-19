using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBSysProj.AppData;
using System.Windows.Forms;
using DBSysProj.Utils;

namespace DBSysProj.Repositories
{  
    public class UserRepository
    {
        private DBSYSPROJEntities db;

        public UserRepository()
        { 
            db = new DBSYSPROJEntities();
        }

        public UserAccount GetUserByUsername(String username)
        {
            using (db = new DBSYSPROJEntities())
            { 
                return db.UserAccount.Where(m => m.userName == username).FirstOrDefault();
            }
        }
        public List<vw_RoomTable> AllRoomTable()
        {
            using (db = new DBSYSPROJEntities())
            {
                return db.vw_RoomTable.ToList();
            }
        }
    }
}
