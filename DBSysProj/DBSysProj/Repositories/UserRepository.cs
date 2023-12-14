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
        public List<vw_AllRooms> AllRoomTable()
        {
            using (db = new DBSYSPROJEntities())
            {
                return db.vw_AllRooms.ToList();
            }
        }
        public List<vw_AllUsers> AllUsersTable()
        {
            using (db = new DBSYSPROJEntities())
            { 
                return db.vw_AllUsers.ToList();
            }
        }
        public List<sp_YourCarts_Result> AllCartTable(int uId)
        {
            using (db = new DBSYSPROJEntities())
            {           
                   return db.sp_YourCarts(uId).ToList();
            }
        }
        public List<sp_CheckOutTable_Result> UserCheckOutTable(int uId)
        {
            using (db = new DBSYSPROJEntities())
            {
                return db.sp_CheckOutTable(uId).ToList();
            }
        }
        public List<vw_CheckOutTable> AdminCheckOutTable()
        {
            using (db = new DBSYSPROJEntities())
            {
                return db.vw_CheckOutTable.ToList();
            }
        }
        public ErrorCode InserRoomUsingStoredProf(String rNum, String rType, String rAc, int rBed, int rMin, int rMax, int rPrice, int hId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_AddRooms(rNum, rType, rAc, rBed, rMin, rMax, rPrice, hId);
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
        public ErrorCode UpdateRoomUsingStoredProf(int rId, String rNum, String rType, String rAc, int rBed, int rMin, int rMax, int rPrice, int hId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_UpdateRooms(rId, rNum, rType, rAc, rBed, rMin, rMax, rPrice, hId);
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
        public ErrorCode UpdateCheckOutUsingStoredProf(int coId, int rId, String coA, DateTime coCI, DateTime coCO, int coP, int coB, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_UpdateCheckOut(coId, rId, coA, coCI, coCO, coP, coB);
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
        public ErrorCode DeleteCheckOutUsingStoredProf(int cId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities()) 
            {
                try
                {
                    db.sp_DeleteCheckOut(cId);
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

        public ErrorCode InsertUserUsingStoredProf(String lName, String fName, String mInitial, String address, String email, String pNum, String uName, String pass, int rId, String cB, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_AddUsers(lName, fName, mInitial, address, email, pNum, uName, pass, rId, cB);
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
        public ErrorCode UpdateUserUsingStoredProf(int? uId,String lName, String fName, String mInitial, String address, String email, String pNum, String uName, String pass, ref String szResponse)
        { 
            using (db = new DBSYSPROJEntities()) 
            {
                try
                {
                    db.sp_UpdateUser(uId, lName, fName, mInitial, address, email, pNum, uName, pass);
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
        public ErrorCode DeleteUserUsingStoredProf(int? uId, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_DeleteUserAccount(uId);
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
        public ErrorCode AddToCartUsingStoredProf(int rId, int hId, int bBy, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_AddToCart(rId, hId, bBy);
                    szResponse = "Added to you cart!";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {

                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode InsertCheckoutUsingStoredProf(int rId, String coFN, String coLN, String coA, String coE, String coP, DateTime coCI, DateTime coCO, int coPay, int coB, int coBB, ref String szResponse)
        {
            using (db = new DBSYSPROJEntities())
            {
                try
                {
                    db.sp_CheckOut(rId, coFN, coLN, coA, coE, coP, coCI, coCO, coPay, coB, coBB);
                    szResponse = "Successful!";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
    }
}
