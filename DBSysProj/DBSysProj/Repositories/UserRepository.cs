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
        public List<vw_AllUsers> AllUserTable()
        { 
            using(db = new DBSYSPROJEntities()) 
            {
                return db.vw_AllUsers.ToList();
            }
        }

        public ErrorCode InserRoomUsingStoredProf(String rNum, String rType, String rAc, int rBed, int rMin, int rMax, int hId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_InsertRoom1(rNum, rType, rAc, rBed, rMin, rMax, hId);
                    szResponse = "Added";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode UpdateRoomUsingStoredProf(int rId, String rNum, String rType, String rAc, int rBed, int rMin, int rMax, int hId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_UpdateRoom(rId, rNum, rType, rAc, rBed, rMin, rMax, hId);
                    szResponse = "Updated";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode DeleteRoomUsingStoredProf(int? rId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_DeleteRoom1(rId);
                    szResponse = "Deleted";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public Rooms GetRoomByRoomNum(String roomNum)
        {
            using (db = new DBSYSPROJEntities())
            {
                return db.Rooms.Where(s => s.roomNumber == roomNum).FirstOrDefault();
            }
        }
    }
}
