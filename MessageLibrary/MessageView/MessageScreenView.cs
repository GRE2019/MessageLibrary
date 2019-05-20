using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageView
{
    public partial class MessageScreenView : Form
    {
        public MessageScreenView()
        {
            InitializeComponent();

            ActiveControl = lbl_Title;
        }
    }
}
