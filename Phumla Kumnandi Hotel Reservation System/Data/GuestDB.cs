using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kumnandi_Hotel_Reservation_System.Business;

namespace Phumla_Kumnandi_Hotel_Reservation_System.Data
{
    public class GuestDB : DB
    {

        #region instance variables 
        private string guestTable = "guests";
        private string sqlLocal1 = "SELECT * FROM guests";
        private Collection<Guest> guests;

        #endregion


        #region constructor
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal1, guestTable);
            AddToCollection(guestTable);
        }
        #endregion
        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dataSet;
        }

        private void AddToCollection(string table)
        {
            DataRow myRow = null;
            Guest guest;

            foreach (DataRow row in dataSet.Tables[table].Rows)
            {
                myRow = row;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    guest = new Guest();

                    guest.IdNumber = Convert.ToString(myRow["idNumber"]).TrimEnd();
                    guest.Title = Convert.ToString(myRow["title"]).TrimEnd();
                    guest.FirstName = Convert.ToString(myRow["firstName"]).TrimEnd();
                    guest.LastName = Convert.ToString(myRow["lastName"]).TrimEnd();
                    guest.Email = Convert.ToString(myRow["email"]).TrimEnd();
                    guest.Telephone = Convert.ToString(myRow["telephone"]).TrimEnd();
                    guest.Address = Convert.ToString(myRow["address"]).TrimEnd();
                    guests.Add(guest);

                }
            }
        }

        private void FillRow(DataRow row, Guest guest, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {


                row["idNumber"] = guest.IdNumber;


            }
            row["title"] = guest.Title;
            row["firstName"] = guest.FirstName;
            row["lastName"] = guest.LastName;
            row["email"] = guest.Email;
            row["telephone"] = guest.Telephone;
            row["address"] = guest.Address;
        }
        private int FindRow(Guest guest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow row in dataSet.Tables[table].Rows)
            {
                myRow = row;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (guest.IdNumber == Convert.ToString(dataSet.Tables[table].Rows[rowIndex]["idNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }

            return returnValue;
        }
        #endregion
        #region CRUD operataions
        public void DataSetChange(Guest guest, DB.DBOperation operation)
        {

            DataRow row = null;
            string dataTable = guestTable;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    row = dataSet.Tables[dataTable].NewRow();
                    FillRow(row, guest, operation);
                    dataSet.Tables[dataTable].Rows.Add(row);
                    break;
                case DB.DBOperation.Edit:
                    row = dataSet.Tables[dataTable].Rows[FindRow(guest, dataTable)];
                    FillRow(row, guest, operation);
                    break;
                case DB.DBOperation.Delete:
                    int rowIndexToDelete = FindRow(guest, dataTable);
                    if (rowIndexToDelete != -1)
                    {
                        dataSet.Tables[dataTable].Rows.RemoveAt(rowIndexToDelete);
                    }
                    break;

            }
        }

        #endregion

        #region build parameters, create commands and update database

        private void Create_INSERT_Parameters(Guest guest)
        {
            dataAdapter.InsertCommand = new SqlCommand(
                "INSERT INTO guests (idNumber,title, firstName, lastName, email, telephone , address) values(@idNumber,@title,  @firstName, @lastName ,@email, @telephone, @address)", connection
                );

            Build_INSERT_Parameters(guest);
        }
        private void Build_INSERT_Parameters(Guest guest)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@idNumber", SqlDbType.NChar, 13, "idNumber");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@title", SqlDbType.NChar, 5, "title");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@firstName", SqlDbType.NVarChar, 50, "firstName");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@lastName", SqlDbType.NVarChar, 50, "lastName");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.NVarChar, 255, "email");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@telephone", SqlDbType.NChar, 10, "telephone");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@address", SqlDbType.NVarChar, 255, "address");
            dataAdapter.InsertCommand.Parameters.Add(param);
        }




        public bool UpdateDataSource(Guest guest)
        {
            bool sucess = true;
            Create_INSERT_Parameters(guest);


            sucess = UpdateDataSource(sqlLocal1, guestTable);

            return sucess;
        }
        #endregion


        #region getters and setters
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion
    }

}

