using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoAplication.Functions
{
    class DrawCalendar
    {
        public void Draw()
        {
            Button btn = new Button();

            btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Location = new System.Drawing.Point(20, 115);
            btn.Name = "btn";
            btn.Size = new System.Drawing.Size(85, 50);
            btn.TabIndex = 4;
            btn.Text = "1";
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn.UseVisualStyleBackColor = true;
        }
    }
}
