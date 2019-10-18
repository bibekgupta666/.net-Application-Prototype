using Model.MediaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.MediaDataSet;

namespace Controller
{
    public class UserValidationImpl : iUserValidation
    {
        public bool UserValiadtion(string userName, string password)
        {
            bool isUserValid = false;
            try
            {
                TabUserDataTable userDataTable = new TabUserDataTable();
                TabUserTableAdapter userTableAdapter = new TabUserTableAdapter();

                userTableAdapter.ValidateUser(userDataTable, userName, password);

                if(userDataTable.Rows.Count > 0)
                {
                    isUserValid = true;
                }
                else
                {
                    isUserValid = false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message: " + e.Message);
            }
            return isUserValid;
        }
    }
}
