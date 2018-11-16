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
        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load;
            //this.count = count;
        }
        

        private int count;
        private void Form3_Load(object sender, EventArgs e)
        {
            func();
        }
        private Button btn;
        private ArrayList arr;
        private void func()
        {
            arr = new ArrayList();
            Text = "DISCORD";
            Class1 c1 = new Class1(this);
            BackColor = Color.DimGray;
            Controls.Add(btn_mic());
            Controls.Add(btn_head());
            Controls.Add(btn_setting());
            arr.Add(new BtnBean2(this, "button3", "전송", 40, 22, 210, 420));
            

            for(int i = 0; i < arr.Count; i++)
            {
                if (typeof(BtnBean)==arr[i].GetType())
                {
                    BtnBean bt2 = (BtnBean)arr[i];
                    c1.btn((BtnBean)arr[i]);
                }
                else if (typeof(BtnBean2) == arr[i].GetType())
                {
                    c1.btn((BtnBean2)arr[i]);
                }
              //  else if(typeof(LbBean)==arr[i].GetType())
               // {
               //     c1.lb((LbBean)arr[i]);
               // }
               // else if (typeof(PnBean) == arr[i].GetType())
               // {
               //     c1.pn((PnBean)arr[i]);
              //  }
            }
            //Controls.Add(panel_view());

            Controls.Add(list_view());
            Controls.Add(userlist_status());
            Controls.Add(chatbox_create());

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Controls.Add(user_item(i, j));
                    if (i == 0 && j == 2)
                    {
                        btn.Text = "홍마태";
                    }
                    else if (i == 0 && j == 1)
                    {
                        btn.Text = "이석훈";
                    }
                    else if (i == 0 && j == 0)
                    {
                        btn.Text = "김상록";
                    }
                }
            }
        }
        private void btn_click3(object o, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();

            if (f4.status)
            {
                int num = (count + 1);
                count++;

                Button btn2 = new Button();
                btn = (Button)o;
                btn.Location = new Point(5, (btn.Location.Y + 50));

                int btnY = 50 + (50 * (num - 1));
                btn2.Name = string.Format("bt{0}", num);
                btn2.Text = string.Format("채널{0}", num);
                btn2.DialogResult = DialogResult.OK;
                btn2.Cursor = Cursors.Hand;
                btn2.BackColor = Color.White;
                btn2.Size = new Size(50, 50);
                btn2.Location = new Point(5, btnY);
                Controls.Add(btn2);

                if (num > 5)
                {
                    btn.Visible = false;
                    MessageBox.Show("채널 수 초과입니다.");
                }
            }
            else
            {
                MessageBox.Show("잘못누르셨습니다.");
            }
            f4.Dispose();
            /*
            for (int i = 0; i < count; i++)
            {

                Button btn2 = new Button();
                
                btn = (Button)o;
                btn.Location = new Point(5, (btn.Location.Y + 50));
                //int num = (count + 1);

                int btnY = 50 + (50 * (i - 1));
                btn2.Name = string.Format("bt{0}", i);
                btn2.Text = string.Format("채널{0}", i);
                btn2.DialogResult = DialogResult.OK;
                btn2.Cursor = Cursors.Hand;
                btn2.BackColor = Color.LightGray;
                btn2.Size = new Size(50, 50);
                btn2.Location = new Point(5, btnY);
                Controls.Add(btn2);
            }
            count++;
            
            //countclass cc = new countclass(count);
            //Form4 f4 = new Form4(cc.CT);
            //f4.Show();
            this.Visible = false;
            if (count > 5)
            {
                btn.Visible = false;
                MessageBox.Show("채널 수 초과입니다.");
            }*/

        }

        
        private TextBox chatbox_create()
        {
            TextBox tb = new TextBox();

            tb.Name = "message send";
            tb.BackColor = Color.LightYellow;
            tb.Size = new Size(250, 0);
            tb.Location = new Point(0, 420);
            return tb;
        }//채팅입력창
        
        private Button user_item(int i, int j)
        {
            btn = new Button();
            btn.Name = string.Format("user");
            btn.Text = string.Format("");
            btn.Size = new Size(65, 30);
            btn.Location = new Point(275 + (i * 67), 5 + (j * 40));
            if (j % 5 == 0)
            {
                btn.BackColor = Color.LightGray;
            }
            return btn;
        } // 테이블 모양 버튼

        private ListView list_view()
        {
            ListView lv = new ListView();
            ColumnHeader columnHeader1 = new ColumnHeader();
            lv.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            columnHeader1.Text = "                        채팅방";
            columnHeader1.Width = 245;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            lv.Name = "listview1";
            lv.Size = new Size(250, 420);
            lv.Location = new Point(0, 0);
            lv.BackColor = Color.DimGray;
            lv.View = View.Details;
            lv.GridLines = true;
            lv.Items.Add("김상록 : 안녕하세요 힐러할게요");
            lv.Items.Add("이석훈 : 난 탱");
            lv.Items.Add("홍마태 : 나는 딜러할게");
            /*
            ColumnHeader columnHeader1 = new ColumnHeader();
            lv.Columns.Add(columnHeader1);
           
            ListViewItem item = new ListViewItem(chat);
            lv.Items.Add(item);*/

            return lv;

        }//채팅창

       /* private Panel panel_view()
        {
            Panel pn = new Panel();
            pn.Size = new Size(60,489);
            pn.Location = new Point(0,0);
            pn.BackColor = Color.LightSlateGray;
            return pn;
        }*/

        private ListView userlist_status()
        {
            ListView lv = new ListView();
            ColumnHeader columnHeader1 = new ColumnHeader();
            lv.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            columnHeader1.Text = "        접속 유저 리스트  ";
            columnHeader1.Width = 165;
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            
            lv.Items.Add("과장님 : 월드오브 워크레프트");
            lv.Items.Add("김상록 : 월드오브 워크레프트");
            lv.Items.Add("이석훈 : 월드오브 워크레프트");
            lv.Items.Add("홍마태 : 월드오브 워크레프트");
            lv.Name = "listview2";
            lv.Size = new Size(170, 450);
            lv.Location = new Point(630, 0);
            lv.BackColor = Color.DimGray;
            lv.View = View.Details;
            lv.GridLines = true;
            return lv;
        }//유저상태 리스트.

        bool btn4 = true;
        bool btn5 = true;
        private void btn_click4(object o, EventArgs a) //마이크
        {
            btn = (Button)o;
            if (btn4)
            {
                btn.Image = Properties.Resources.mic3off1;
            }
            else
            {
                btn.Image = Properties.Resources.mic31;
            }
            btn4 = !btn4;
        }
        private void btn_click5(object o, EventArgs a) //소리
        {
            btn = (Button)o;
            if (btn5)
            {
                btn.Image = Properties.Resources.head1;
            }
            else
            {
                btn.Image = Properties.Resources.head31;
            }
            btn5 = !btn5;
        }
        private Button btn_mic()
        {
            Button btn4 = new Button();
            btn4.DialogResult = DialogResult.OK;
            btn4.Cursor = Cursors.Hand;
            btn4.BackColor = Color.White;
            btn4.Image = Properties.Resources.mic31;
            btn4.Size =new Size(30, 40);
            btn4.Location = new Point(520, 400);
            btn4.Click += btn_click4;
           
            return btn4;
        }
        
        private Button btn_head()
        {
            Button btn5 = new Button();
            btn5.DialogResult = DialogResult.OK;
            btn5.Cursor = Cursors.Hand;
            btn5.BackColor = Color.White;
            btn5.Image = Properties.Resources.head1;
            btn5.Size = new Size(30, 40);
            btn5.Location = new Point(550, 400);
            btn5.Click += btn_click5;
            return btn5;
        }
        private Button btn_setting()
        {
            Button btn6 = new Button();
            btn6.DialogResult = DialogResult.OK;
            btn6.Cursor = Cursors.Hand;
            btn6.BackColor = Color.White;
            btn6.Image = Properties.Resources.setting1;
            btn6.Size = new Size(30, 40);
            btn6.Location = new Point(580, 400);
            return btn6;
        }
    }
}
