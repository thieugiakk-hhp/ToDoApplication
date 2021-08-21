using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAplication.DataModels;

namespace ToDoAplication.Functions
{
    class FillToListView
    {
        public void FillListViewTaskList(ListView listView, List<tblTaskList> list, string userID)
        {
            foreach (var item in list)
            {
                if (String.Compare(item.UserID.ToString(), userID, false) == 0)
                {
                    listView.Items.Add(item.Name.ToString());
                }
            }
        }

        public void FillListViewTasks(ListView listView, List<tblTask> list)
        {
            foreach (var item in list)
            {
                listView.Items.Add(item.Title);
            }
        }
    }
}
