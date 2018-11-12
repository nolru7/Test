using System;
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
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Load += Form3_Load;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                     , int nTopRect
                                                     , int nRightRect
                                                     , int nBottomRect
                                                     , int nWidthEllipse
                                                     , int nHeightEllipse);

        private void Form3_Load(object sender, EventArgs e)
        {
            func();
        }

        private void func()
        {
            Controls.Add(label_create());
            Controls.Add(btn_create());
            Controls.Add(search_btn());
            Controls.Add(back_color());
            Controls.Add(list_view());
            for(int j = 0; j < 10; j++)
            for (int i=0; i<5;i++)
            Controls.Add(user_item(i,j));

            BackColor = Color.Gray;
        }

        private Label label_create()
        {
            lb = new Label();
            lb.Name = string.Format("voice channel");
            lb.Text = string.Format("채널");
            lb.Size = new Size(30, 20);
            lb.Location = new Point(10, 0);
            lb.BackColor = Color.LightSlateGray;
            return lb;
        }
        
        private Button user_item(int i,int j)
        {
            btn = new Button();
            btn.Name = string.Format("user");
            btn.Text = string.Format("");
            btn.Size = new Size(60, 30);
            btn.Location = new Point(325+(i*70),30+(j*40));
            if (j % 5 == 0)
            {
                btn.BackColor = Color.LightGray;
            }
                return btn; 
        } // 테이블 모양 버튼

        private ListView list_view()
        {
            ListView lv = new ListView();
            lv.Size = new Size(250, 489);
            lv.Location = new Point(61, 0);
            lv.BackColor = Color.BlanchedAlmond;
            
            return lv;
        }//채팅창

        private Button back_color()
        {
            btn = new Button();
            btn.Size = new Size(60, 489);
            btn.Location =new Point(0,0);
            btn.BackColor = Color.LightSlateGray;
            btn.FlatStyle = FlatStyle.Flat;
            btn.TabStop = false;
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }//채널 카테고리 컬러

        private Button btn_create()
        {
            btn = new Button();
            btn.Name = string.Format("button1");
            btn.Text = string.Format("+");
            btn.Size = new Size(50, 30);
            btn.Location = new Point(5, 50);
            btn.BackColor = Color.Silver;
            return btn;
        }//채널 버튼
      
        private Button search_btn()
        {
            btn = new Button();
            btn.Name = string.Format("button1");
            btn.Text = string.Format("검색");
            btn.Size = new Size(50, 30);
            btn.Location = new Point(5,420);
            return btn;
        }//검색버튼
    }

    public class Item
    {
        private string type;
        private int x;
        private int y;
        private string txt;

        public Item(string type, int x, int y, string txt)
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
    }
}
