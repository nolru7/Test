using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class Class1
    {
        Form form;
        public Class1(Form form)
        {
            this.form = form;
        }

        public void btn(BtnBean bb)
        {
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Name = bb.Name;
            btn.Text = bb.Txt;
            btn.Size = new Size(bb.SizeX, bb.SizeY);
            btn.Location = new Point(bb.PX, bb.PY);
            btn.Cursor = Cursors.Hand;
            form.Controls.Add(btn);
        }
        public void btn(BtnBean2 bb)
        {
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Name = bb.Name;
            btn.Text = bb.Txt;
            btn.Size = new Size(bb.SizeX, bb.SizeY);
            btn.Location = new Point(bb.PX, bb.PY);
            btn.Cursor = Cursors.Hand;
            form.Controls.Add(btn);
        }

        public void lb(LbBean lb)
        {
            Label label = new Label();
            label.Name = lb.Name;
            label.Text = lb.Txt;
            label.Size = new Size(lb.SizeX, lb.SizeY);
            label.Location = new Point(lb.PX, lb.PY);
            label.Cursor = Cursors.Hand;
            form.Controls.Add(label);
        }

        public void pn(PnBean pa)
        {
            Panel pn = new Panel();
            pn.Size = new Size(pa.SizeX, pa.SizeY);
            pn.Location = new Point(pa.PX, pa.PY);
            pn.BackColor = Color.LightSlateGray;
        }
    }
}
