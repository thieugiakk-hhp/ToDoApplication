using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.DataAccessLayer.DataModels;

namespace ToDoAplication.Functions
{
    class FillToListView
    {
        public void FillListViewTaskList(ListView listView, List<tblTaskList> list, string userID)
        {
            foreach (var item in list)
            {
                if (item.UserID.ToString() == userID)
                {
                    listView.Items.Add(item.Name.ToString());
                }
            }
        }

        public void FillListViewTasks(ListView listView, List<tblTask> list, string userID)
        {
            foreach (var item in list)
            {
                if (item.UserID.ToString() == userID)
                {
                    listView.Items.Add(item.Title.ToString());
                }
            }
        }
    }
}
