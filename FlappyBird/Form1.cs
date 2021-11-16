using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        // PHU ZONE
        void init()
        {
            // made a picture box for bird
            picBird.Parent = picDesktop;
            picBird.BackColor = Color.Transparent;
            
        }
        // END PHU ZONE

        // TU ZONE  
        // END TU ZONE
    }
}
