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
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        
        private Button btn;
        private ArrayList arr;
        private Panel pl;
        private void Form1_Load(object sender, EventArgs e)
        {

            arr = new ArrayList();
            Text = "DISCORD";
            ClientSize = new Size(200, 489);
            Class1 c1 = new Class1(this);

            BackColor = Color.DimGray;
            Controls.Add(Ls());
            Controls.Add(lb());
            Controls.Add(pn());

            arr.Add(new BtnBean2(this, "button1", "뉴스", 100, 30, 100, 0));
            arr.Add(new BtnBean2(this, "button1", "라이브러리", 100, 30, 100, 40));
            arr.Add(new BtnBean2(this, "button1", "스토어", 100, 30, 100, 80));
            arr.Add(new BtnBean2(this, "button1", "검색", 50, 30, 5, 420));
            arr.Add(new BtnBean(this, "button2", "+", 50, 50, 5, 50, btn_click3));
            
            for (int i = 0; i < arr.Count; i++)
            {
                if (typeof(BtnBean) == arr[i].GetType())
                {
                    BtnBean bt2 = (BtnBean)arr[i];
                    c1.btn((BtnBean)arr[i]);
                }

                else if (typeof(BtnBean2) == arr[i].GetType())
                {
                    c1.btn((BtnBean2)arr[i]);
                }
            }
        }
        Form4 f4;
       /* private Form4 checkForm4()
        {
            if (Application.OpenForms["form4"] is Form4 f4)
            {
                f4.Dispose();
            }
            return new Form4();
        }
        */
        private void btn_click3(object o, EventArgs e)
        {
            //f4 = checkForm4();
            f4 = new Form4();
            f4.ShowDialog();
            
            if (f4.status)
            {
                int num = (count + 1);
                count++;

                Button btn2 = new Button();
                btn = (Button)o;
                btn.Location = new Point(5, (btn.Location.Y + 50));

                int btnY = 50 + (50 * (num - 1));
                btn2.Name = f4.roomName;
                btn2.Text = f4.sr;
                btn2.DialogResult = DialogResult.OK;
                btn2.Cursor = Cursors.Hand;
                btn2.BackColor = Color.LightSlateGray;
                btn2.ForeColor = Color.Black;
                btn2.Size = new Size(50, 50);
                btn2.Location = new Point(5, btnY);
               // btn2.TabStop = false;

               // btn2.FlatStyle = FlatStyle.Flat;

               // btn2.FlatAppearance.BorderSize = 0;
                btn2.Click += click_event2;
                
                Controls.Add(btn2);
                
                if (num > 5)
                {
                    btn.Visible = false;
                    MessageBox.Show("채널 수 초과입니다.");
                }
            }

            else
            {
                MessageBox.Show("다시 눌러주세요");
            }
            //
        }
        private Panel pn()
        {
            Panel pn = new Panel();
            pn.Size = new Size(2, 489);
            pn.Location = new Point(75, 0);
            pn.BackColor = Color.FromArgb(40,0,0);
            return pn;
        }

        private void click_event2(object o, EventArgs e)
        {
            btn = (Button)o;
            if (f4.roomName == "NOR")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else if (f4.roomName == "RAID")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        private Button Back_color()
        {
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Size = new Size(60,480);
            btn.Location = new Point(0, 0);
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Color.AliceBlue;
            Controls.Add(btn);
            return btn;
        }
        private Label lb()
        {
            Label lb = new Label();
            lb.Text = "채널";
            lb.Size = new Size(30, 30);
            lb.Location =new Point(15, 5);
            return lb;
        }
        private ListView Ls()   //리스트
        {
            ListView listView = new ListView();
            ColumnHeader columnHeader1 = new ColumnHeader();

            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            columnHeader1.Text = "친구목록";
            columnHeader1.Width = 95;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            listView.GridLines = true;
            listView.Location = new Point(100, 130);
            listView.Name = "listView1";
            listView.Size = new Size(100, 355);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.BackColor = Color.Gray;
            listView.Items.Add("이석훈");
            listView.Items.Add("홍마태");
            
            return listView;

        }
    }
}
