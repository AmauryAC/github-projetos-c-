using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_níveis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < 4; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,20));

                this.tableLayoutPanel1.RowStyles.Insert(i, new RowStyle(SizeType.Percent, 20));
                

            }

            //tableLayoutPanel1.RowStyles[0].Height = 20;

            /*foreach (RowStyle style in tableLayoutPanel1.Controls)
            {
                if (style.SizeType == SizeType.Absolute)
                {
                    style.SizeType = SizeType.AutoSize;
                }
                else if (style.SizeType == SizeType.AutoSize)
                {
                    style.SizeType = SizeType.Percent;

                    // Set the row height to be a percentage
                    // of the TableLayoutPanel control's height.
                    style.Height = 33;
                }
                else
                {

                    // Set the row height to 50 pixels.
                    style.SizeType = SizeType.Absolute;
                    style.Height = 50;
                }
            }*/

        }
    }
}
