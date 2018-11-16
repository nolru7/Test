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
    public partial class Form2 : Form
    {
        public ArrayList label_arry;
        private Label label_ob;

        public Form2()
        {
            InitializeComponent();
            Load += Form2_Load;
        }

        private Button btn;
        private Label lb;
        private int btn_sX = 50;   //버튼크기
        private int btn_sY = 50;   //버튼크기
        private int btn_pX = 5;
        private ArrayList arrList;
        private Panel pn;
        //private int btn_cnt = 3;
        private int btn_cnt = 1;


        private void Form2_Load(object sender, EventArgs e)
        {
            label_arry = new ArrayList();

            ClientSize = new Size(816, 489);
            // 가상 데이터 생성
            arrList = new ArrayList();
            //arrList.Add(new Item("label", "lb1", 0, 100, "보이스채널"));

            BackColor = Color.DimGray;

            //arrList.Add(new Item("button", "bt1", btn_pX, 150, "채널1"));
            //arrList.Add(new Item("button", "bt2", btn_pX, 200, "채널2"));
            //arrList.Add(new Item("button", "bt3", btn_pX, 250, "채널3"));
            //arrList.Add(new Item("button3", "btp", btn_pX, 200, "+"));



            arrList.Add(new Item("button2", "btg1", 30, 40, "LOL"));
            arrList.Add(new Item("button2", "btg2", 30, 170, "PUBG"));
            arrList.Add(new Item("button2", "btg3", 30, 300, "FIFA"));
            arrList.Add(new Item("button3", "btg4", 569, 469, "전송"));

            arrList.Add(new Item("button4", "btg4", 250, 429, "")); //마이크
            arrList.Add(new Item("button5", "btg4", 280, 429, "")); //헤드셋
            arrList.Add(new Item("button6", "btg4", 310, 429, "")); //설정

            //arrList.Add(new Item("label2", "lb3", 600, 30, "채널 인원"));
            //arrList.Add(new Item("label3", "lb2", 450, 30, "채팅창"));









            //리스트뷰============================================
            //ListView listView1 = new ListView();

            //ColumnHeader columnHeader1 = new ColumnHeader();

            //listView1.Columns.Add(columnHeader1);

            //columnHeader1.Text = "user1";
            //columnHeader1.Width = 200;
            //columnHeader1.TextAlign = HorizontalAlignment.Left;

            //listView1.GridLines = false;
            //listView1.Location = new Point(200, 80);
            //listView1.Name = "listView1";
            //listView1.Size = new Size(200, 20);
            //listView1.TabIndex = 0;

            //listView1.UseCompatibleStateImageBehavior = false;
            //listView1.View = View.Details;
            //Controls.Add(listView1);
            //===================================================
            Controls.Add(chatbox_create());
            Controls.Add(list_view());
            Controls.Add(userlist_status());

            //Controls.Add(panel_view());
            for (int i = 0; i < arrList.Count; i++) // 가상 데이터를 이용한 화면 구성하기
            {
                Item item = (Item)arrList[i];
                Control ctr = Control_Create(item); // 구성될 각 화면 내용 받아오기

                //if (item.getType() == "button" || item.getType() == "button3" || item.getType() == "label")
                //{
                //    pn.Controls.Add(ctr); // 받아온 Control 정보를 이용하여 화면 구성하기
                //}

                Controls.Add(ctr); // 받아온 Control 정보를 이용하여 화면 구성하기


            }


        }
        private ListView userlist_status()
        {
            ListView lv = new ListView();
            ColumnHeader columnHeader1 = new ColumnHeader();

            lv.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            columnHeader1.Text = "   접속 유저 리스트  ";
            columnHeader1.Width = 250;
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            lv.Name = "listview2";
            lv.Size = new Size(200, 489);
            lv.Location = new Point(646, 0);
            lv.BackColor = Color.DimGray;
            lv.View = View.Details;
            lv.GridLines = true;
            return lv;
        }//유저상태 리스트


        private TextBox chatbox_create()
        {
            TextBox tb = new TextBox();

            tb.Name = "message send";
            tb.BackColor = Color.LightYellow;
            tb.Size = new Size(220, 0);
            tb.Location = new Point(350, 469);

            return tb;
        }//채팅입력창
        private ListView list_view()
        {
            ListView lv = new ListView();
            ColumnHeader columnHeader1 = new ColumnHeader();

            lv.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            columnHeader1.Text = "채팅창";
            columnHeader1.Width = 270;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            lv.Name = "listview1";
            lv.Size = new Size(270, 470);
            lv.Location = new Point(350, 0);
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

        private Panel panel_view()
        {
            pn = new Panel();
            pn.Size = new Size(80, 1000);
            pn.Location = new Point(0, 0);
            pn.BackColor = Color.LightSlateGray;
            pn.Dock = DockStyle.Left;
            return pn;
        }



        private Control Control_Create(Item item)
        {
            Control ctr = new Control(); // 리턴 객체 만들기

            switch (item.getType())
            {
                //case "button": // button 부분 정의 하기
                //    Button btn = new Button();
                //    btn.DialogResult = DialogResult.OK;
                //    btn.Cursor = Cursors.Hand;
                //    btn.BackColor = Color.Gray;
                //    btn.Click += btn_click;
                //    ctr = btn; // button 객체를 리턴 객체에 변경하기
                //    ctr.Size = new Size(btn_sX, btn_sY);
                //    break;

                case "label":
                    Label lb = new Label();
                    lb.BackColor = Color.Gray;
                    lb.ForeColor = Color.Black;
                    lb.Font = new Font(lb.Font, FontStyle.Bold);
                    lb.Size = new Size(78, 20);
                    ctr = lb; // label 객체를 리턴 객체에 변경하기
                    break;
                case "label2":
                    Label lb2 = new Label();
                    lb2.BackColor = Color.LightSlateGray;
                    lb2.Size = new Size(150, 30);
                    lb2.TextAlign = ContentAlignment.MiddleCenter;
                    ctr = lb2; // label 객체를 리턴 객체에 변경하기
                    break;
                case "label3":
                    Label lb3 = new Label();
                    lb3.BackColor = Color.LightSlateGray;
                    lb3.Size = new Size(180, 30);
                    lb3.ForeColor = Color.White;
                    lb3.Font = new Font(lb3.Font, FontStyle.Bold);

                    lb3.TextAlign = ContentAlignment.MiddleCenter;
                    ctr = lb3; // label 객체를 리턴 객체에 변경하기

                    label_arry.Add(ctr);

                    break;
                case "label4":
                    Label lb4 = new Label();
                    lb4.BackColor = Color.DimGray;
                    lb4.Size = new Size(180, 30);

                    ctr = lb4; // label 객체를 리턴 객체에 변경하기

                    break;



                case "button2": // button 부분 정의 하기
                    Button btn2 = new Button();
                    btn2.DialogResult = DialogResult.OK;
                    btn2.Cursor = Cursors.Hand;
                    btn2.BackColor = Color.Gray;
                    btn2.Click += btn_click2;
                    ctr = btn2; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(200, 30);
                    break;
                case "button3":
                    Button btn3 = new Button();
                    btn3.DialogResult = DialogResult.OK;
                    btn3.Cursor = Cursors.Hand;
                    btn3.BackColor = Color.White;
                    //btn3.Click += btn_click2;
                    ctr = btn3; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(52, 20);
                    break;
                case "button4": //마이크
                    Button btn4 = new Button();
                    btn4.DialogResult = DialogResult.OK;
                    btn4.Cursor = Cursors.Hand;
                    btn4.BackColor = Color.White;
                    btn4.Image = Properties.Resources.mic3;
                    btn4.Click += btn_click4;
                    ctr = btn4; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(30, 60);
                    break;
                case "button5": //헤드셋
                    Button btn5 = new Button();
                    btn5.DialogResult = DialogResult.OK;
                    btn5.Cursor = Cursors.Hand;
                    btn5.BackColor = Color.White;
                    btn5.Image = Properties.Resources.head;
                    btn5.Click += btn_click5;
                    ctr = btn5; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(30, 60);
                    break;
                case "button6": //설정
                    Button btn6 = new Button();
                    btn6.DialogResult = DialogResult.OK;
                    btn6.Cursor = Cursors.Hand;
                    btn6.BackColor = Color.White;
                    btn6.Image = Properties.Resources.setting;
                    //btn3.Click += btn_click2;
                    ctr = btn6; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(30, 60);
                    break;
                //case "button3": // button 부분 정의 하기
                //    Button btn3 = new Button();
                //    btn3.DialogResult = DialogResult.OK;
                //    btn3.Cursor = Cursors.Hand;
                //    btn3.BackColor = Color.Gray;
                //    btn3.Click += btn_click3;
                //    ctr = btn3; // button 객체를 리턴 객체에 변경하기
                //    ctr.Size = new Size(btn_sX, btn_sY);
                //    break;


                default:
                    break;
            }
            // 리턴 객체에 공동으로 적용할 속성 정의하기
            ctr.Name = item.Getname();
            ctr.Text = item.getTxt();

            ctr.Location = new Point(item.getX(), item.getY());

            return ctr; // 정의 한 Control 보내기
        }

        private Button btn_create(int i) // button 객체 정의하기
        {
            btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Name = string.Format("btn_{0}", (i + 1));
            btn.Text = string.Format("확인 : {0}", (i + 1));

            btn.Location = new Point((100 * i) + 30, 30);
            btn.Cursor = Cursors.Hand;
            btn.Click += btn_click2;
            return btn;
        }
        private Label lb_create(int i) // label 객체 정의하기
        {
            lb = new Label();
            lb.Name = string.Format("lb_{0}", (i + 1));
            lb.Text = string.Format("확인 : {0}", (i + 1));
            lb.Size = new Size(100, 50);
            lb.Location = new Point((100 * i) + 30, 30);
            return lb;
        }


        //private void btn_click(object o, EventArgs a)
        //{


        //    foreach (Control ct in pn.Controls)
        //    {

        //        if (ct.Name.IndexOf("bt") > -1)
        //        {
        //            ct.BackColor = Color.Gray;
        //        }
        //    }


        //    btn = (Button)o;
        //    btn.BackColor = (btn.BackColor == Color.Salmon) ? btn.BackColor = Color.Gray : btn.BackColor = Color.Salmon;



        //}
        private void btn_click2(object o, EventArgs a)
        {

            foreach (Control ct in Controls)
            {
                if (ct.Name.IndexOf("btg") > -1)
                {
                    ct.BackColor = Color.Gray;
                }
            }

            btn = (Button)o;



            btn.BackColor = (btn.BackColor == Color.DeepSkyBlue) ? btn.BackColor = Color.Gray : btn.BackColor = Color.DeepSkyBlue;
            Form2 f2 = new Form2();
            if (btn.Name == "btg1")
            {

                Controls.Add(Control_Create(new Item("label3", "lb5", 40, 70, "user1")));
                for (int i = 0; i < label_arry.Count; i++)
                {
                    label_ob = (Label)label_arry[i];

                    if (label_ob.Name == "lb6" || label_ob.Name == "lb7")
                    {
                        label_ob.Visible = false;
                    }
                }
                // btn.BringToFront
            }
            else if (btn.Name == "btg2")
            {

                Controls.Add(Control_Create(new Item("label3", "lb6", 40, 200, "user1")));

                for (int i = 0; i < label_arry.Count; i++)
                {
                    label_ob = (Label)label_arry[i];

                    if (label_ob.Name == "lb5" || label_ob.Name == "lb7")
                    {
                        label_ob.Visible = false;
                    }
                }




            }
            else if (btn.Name == "btg3")
            {

                Controls.Add(Control_Create(new Item("label3", "lb7", 40, 330, "user1")));

                for (int i = 0; i < label_arry.Count; i++)
                {
                    label_ob = (Label)label_arry[i];

                    if (label_ob.Name == "lb5" || label_ob.Name == "lb6")
                    {
                        label_ob.Visible = false;
                    }
                }
            }

            //arrList.Add(new Item("label", "lb1", 0, 100, "보이스채널"));

        }

        //private void btn_click3(object o, EventArgs a)
        //{
        //    btn = (Button)o;
        //    btn.Location = new Point(btn_pX, (btn.Location.Y + btn_sY));

        //    int num = (btn_cnt + 1);

        //    //int num = 1;
        //    btn_cnt++;

        //    string name = string.Format("bt{0}", num);
        //    string text = string.Format("채널{0}", num);
        //    int btnY = 150 + (btn_sY * (num - 1));

        //    pn.Controls.Add(Control_Create(new Item("button", name, btn_pX, btnY, text))); // 받아온 Control 정보를 이용하여 화면 구성하기

        //    if (num > 14)
        //    {
        //        btn.Visible = false;
        //        MessageBox.Show("상록이에게 문의하세요!");
        //    }
        //}
        bool btn4 = true;
        bool btn5 = true;
        private void btn_click4(object o, EventArgs a) //마이크
        {
            btn = (Button)o;
            if (btn4)
            {
                btn.Image = Properties.Resources.mic3off;
            }
            else
            {
                btn.Image = Properties.Resources.mic3;
            }
            btn4 = !btn4;
        }
        private void btn_click5(object o, EventArgs a) //마이크
        {
            btn = (Button)o;
            if (btn5)
            {
                btn.Image = Properties.Resources.head;
            }
            else
            {
                btn.Image = Properties.Resources.headoff;
            }
            btn5 = !btn5;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class Item // Control 객체 생성 시 필요한 속성 정보 담을 객체 생성
    {
        private string type;
        private int x;
        private int y;
        private string txt;
        private string name;
        public Item(string type, string name, int x, int y, string txt)
        {
            this.type = type;
            this.name = name;
            this.x = x;
            this.y = y;
            this.txt = txt;
        }
        public string getType()
        {
            return type;
        }
        public string Getname()
        {
            return name;
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