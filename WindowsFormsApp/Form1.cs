using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(200, 489);

            Class1 c1 = new Class1(this);
            ArrayList arr = new ArrayList();

            arr.Add(new BtnBean(this, "button1", "검색", 50, 30, 5, 420));
            arr.Add(new BtnBean(this, "button2", "+", 50, 30, 5, 30));
            arr.Add(new LbBean(this, "label1", "채널", 30, 20, 15, 0));
            arr.Add(new PnBean(this, "pnname1", 60, 489, 0, 0));
            for (int i = 0; i < arr.Count; i++)
            {
                if (typeof(BtnBean) == arr[i].GetType())
                {
                    c1.btn((BtnBean)arr[i]);
                }
                else if (typeof(LbBean) == arr[i].GetType())
                {
                    c1.lb((LbBean)arr[i]);

                }
                else if (typeof(PnBean) == arr[i].GetType())
                {
                    c1.pn((PnBean)arr[i]);
                }
            }
        }

    
    }
}
