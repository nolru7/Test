using System;
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
    public partial class Form4 : Form
    {
        public bool status;
        public string sr;
        public string roomName;
        public string tbname;
      
        public Form4()
        {
            InitializeComponent();
            Load += Form4_Load;
        }
        private Button btn;
        private void Form4_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(350, 200);
            BackColor = Color.DimGray;
            Class1 c1 = new Class1(this);
            c1.btn(new BtnBean(this, "NOR", "normal", 150, 100, 20, 50,click_event));
            c1.btn(new BtnBean(this, "RAID", "mmorpg", 150, 100, 190, 50, click_event));
            Controls.Add(tb());
            Controls.Add(lb());
            
        }
        
        private void click_event(object o,EventArgs e)
        {
            btn = (Button)o;
            if (btn.Text == "normal")
            {
                
              //  Form2 f2 =new Form2();
              //  f2.Show();
                   
                sr = "노말";
                roomName = "NOR";
                status = true;
                this.Close();
            }
            else if(btn.Text == "mmorpg")
            {
                
               // Form3 f3 = new Form3();
               // f3.Show();

                sr = "레이드";
                roomName = "RAID";
                status = true;
                this.Close();
            }
            else
            {
                status = false;
                this.Close();
            }
        }
        private Label lb()
        {
            Label lb = new Label();
            lb.Size = new Size(60, 30);
            lb.Location = new Point(40, 165);
            lb.Text = "방이름:";
            return lb;
        }
        private TextBox tb()
        {
            
            TextBox tb = new TextBox();
            tb.Size = new Size(200,0);
            tb.Location = new Point(85, 160);
            tb.Text = "점검중..";
            return tb;
        }
    }
}
