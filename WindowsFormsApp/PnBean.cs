using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class PnBean
    {
        Form form;
        string name;
        int sizeX;
        int sizeY;
        int pX;
        int pY;
        
        public PnBean(Form form, string name, int sizeX, int sizeY, int pX, int pY)
        {
            this.form = form;
            this.name = name;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pX = pX;
            this.pY = pY;
        }

        public Form Form
        {
            get
            {
                return form;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int SizeX
        {
            get
            {
                return sizeX;
            }
        }
        public int SizeY
        {
            get
            {
                return sizeY;
            }
        }
        public int PX
        {
            get
            {
                return pX;
            }
        }
        public int PY
        {
            get
            {
                return pY;
            }
        }
    }
}
