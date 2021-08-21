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
        public void FillListViewTaskList(ListView listView, List<tblTaskList> list)
        {
            foreach (var item in list)
            {
                if (item.UserID == "admin")
                {
                    listView.Items.Add(item.Name);
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
