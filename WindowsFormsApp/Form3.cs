using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        private Label lb;
        private Button btn;

        public Form3()
        {
            InitializeComponent();
           // Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Load += Form3_Load;
        }

        /*
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                     , int nTopRect
                                                     , int nRightRect
                                                     , int nBottomRect
                                                     , int nWidthEllipse
                                                     , int nHeightEllipse);
                                                     */

        private void Form3_Load(object sender, EventArgs e)
        {
            func();
        }

        private void func()
        {
            Class1 c1 = new Class1(this);
            ArrayList arr = new ArrayList();

            arr.Add(new BtnBean(this, "button1", "검색", 50, 30, 5, 420));
            arr.Add(new BtnBean(this, "button2", "+", 50, 30, 5, 30));
            arr.Add(new BtnBean(this, "button3", "전송", 40, 22, 272, 420));
            arr.Add(new LbBean(this, "label1", "채널", 30, 20, 15, 0));
            arr.Add(new PnBean(this, "pnname1", 60, 489, 0, 0));
            for(int i = 0; i < arr.Count; i++)
            {
                if(typeof(BtnBean)==arr[i].GetType())
                {
                    c1.btn((BtnBean)arr[i]);
                }
                else if(typeof(LbBean)==arr[i].GetType())
                {
                    c1.lb((LbBean)arr[i]);

                }
                else if (typeof(PnBean) == arr[i].GetType())
                {
                    c1.pn((PnBean)arr[i]);
                }
            }
            
            Controls.Add(list_view());
     
            Controls.Add(userlist_status());
            Controls.Add(chatbox_create());
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Controls.Add(user_item(i, j));
                }
            }
            BackColor = Color.Gray;

        }
        
        /*private void chatting_func(object o, EventArgs e)
        {
            Item_send itm = new Item_send(chat);
            TextBox tb = new TextBox();
            Button bt = new Button();
            //ArrayList arr = new ArrayList();

            bt = (Button)o;
            if (tb.Name == "message send")
            {
                if (bt.Name == "send button")
                {
                    while (true)
                    {

                    }
                }
            }
        }*/

        private TextBox chatbox_create()
        {
            TextBox tb = new TextBox();

            tb.Name = "message send";
            tb.BackColor = Color.LightYellow;
            tb.Size = new Size(250, 0);
            tb.Location = new Point(61, 420);
            return tb;
        }//채팅입력창
        
        private Button user_item(int i, int j)
        {
            btn = new Button();
            btn.Name = string.Format("user");
            btn.Text = string.Format("");
            btn.Size = new Size(60, 30);
            btn.Location = new Point(325 + (i * 67), 30 + (j * 40));
            if (j % 5 == 0)
            {
                btn.BackColor = Color.LightGray;
            }
            return btn;
        } // 테이블 모양 버튼

        private ListView list_view()
        {
            ListView lv = new ListView();
            lv.Name = "listview1";
            lv.Size = new Size(250, 420);
            lv.Location = new Point(61, 0);
            lv.BackColor = Color.DimGray;
            lv.View = View.Details;
            lv.GridLines = true;
            /*
            ColumnHeader columnHeader1 = new ColumnHeader();
            lv.Columns.Add(columnHeader1);
           
            ListViewItem item = new ListViewItem(chat);
            lv.Items.Add(item);*/
           
            return lv;

        }//채팅창

        private ListView userlist_status()
        {
            ListView lv = new ListView();
            lv.Name = "listview2";
            lv.Size = new Size(150, 450);
            lv.Location = new Point(670, 0);
            lv.BackColor = Color.DimGray;
            lv.View = View.Details;
            lv.GridLines = true;
            return lv;
        }//유저상태 리스트

    }
    /*
    public class Item_send
    {
        private string txt;
        public Item_send(string txt)
        {
            this.txt = txt;
        }

        public string getSEND()
        {
            return txt;
        }

    }*/

    /* public class Items
     {
         private string type;
         private int x;
         private int y;
         private string txt;

         public item(string type, int x, int y, string txt)
         {
             this.type = type;
             this.x = x;
             this.y = y;
             this.txt = txt;
         }
         public string getType()
         {
             return type;
         }
         public int getX()
         {
             return x;
         }
         public int getY()
         {
             return y;
         }
         public string getTxt()
         {
             return txt;
         }
     }*/
}
