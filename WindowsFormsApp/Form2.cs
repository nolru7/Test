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
        public Form2()
        {
            InitializeComponent();
            Load += Form2_Load; // Form 실행 시 기본적으로 실행될 내용 호출
        }

        private Button btn;
        private Label lb;





        private void Form2_Load(object sender, EventArgs e)
        {
            // 가상 데이터 생성
            ArrayList arrList = new ArrayList();
            arrList.Add(new Item("label",  30, 100, "보이스채널"));



            arrList.Add(new Item("button", 30, 150, "채널1"));
            arrList.Add(new Item("button", 30, 200, "채널2"));
            arrList.Add(new Item("button", 30, 250, "채널3"));
            arrList.Add(new Item("button", 30, 300, "+"));



            arrList.Add(new Item("button2", 200, 30, "LOL"));
            arrList.Add(new Item("button2", 200, 190, "PUBG"));
            arrList.Add(new Item("button2", 200, 350, "FIFA"));


            arrList.Add(new Item("label", 700, 30, "채팅창"));


            arrList.Add(new Item("label", 1100, 30, "채널 인원"));
            //리스트뷰
            ListView listView1 = new ListView();

            ColumnHeader columnHeader1 = new ColumnHeader();
            
            listView1.Columns.Add(columnHeader1);
            
            columnHeader1.Text = "user1";
            columnHeader1.Width = 200;
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            
            listView1.GridLines = false;
            listView1.Location = new Point(200, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 20);
            listView1.TabIndex = 0;
            
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;


            for (int i = 0; i < arrList.Count; i++) // 가상 데이터를 이용한 화면 구성하기
            {
                Control ctr = Control_Create((Item)arrList[i]); // 구성될 각 화면 내용 받아오기
                Controls.Add(ctr); // 받아온 Control 정보를 이용하여 화면 구성하기
            }
            Controls.Add(listView1);

        }

        private Control Control_Create(Item item)
        {
            Control ctr = new Control(); // 리턴 객체 만들기

            switch (item.getType())
            {
                case "button": // button 부분 정의 하기
                    Button btn = new Button();
                    btn.DialogResult = DialogResult.OK;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += btn_click;
                    ctr = btn; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(50, 50);
                    break;

                case "label":
                    Label lb = new Label();
                    ctr = lb; // label 객체를 리턴 객체에 변경하기
                    break;

                case "button2": // button 부분 정의 하기
                    Button btn2 = new Button();
                    btn2.DialogResult = DialogResult.OK;
                    btn2.Cursor = Cursors.Hand;
                    btn2.Click += btn_click2;
                    ctr = btn2; // button 객체를 리턴 객체에 변경하기
                    ctr.Size = new Size(200, 50);
                    break;


                default:
                    break;
            }
            // 리턴 객체에 공동으로 적용할 속성 정의하기
            ctr.Name = item.getTxt();
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
            btn.Click += btn_click;
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

        private void btn_click(object o, EventArgs a)
        {
           
          
            foreach (Control ct in Controls)
            {
                
                ct.BackColor = Color.Silver;
            }
          

            btn = (Button)o;
            btn.BackColor = (btn.BackColor == Color.Red) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Red;
           
          

        }
        private void btn_click2(object o, EventArgs a)
        {

            btn = (Button)o;
            btn.BackColor = (btn.BackColor == Color.Blue) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Blue;

        }

        private void btn_click3(object o, EventArgs a)
        {
            MessageBox.Show("확인");


        }

       
    }

    public class Item // Control 객체 생성 시 필요한 속성 정보 담을 객체 생성
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
