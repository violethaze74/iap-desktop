using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.projectList1.Loading = true;

            this.projectList1.AddColumn("Foo", 50);
            this.projectList1.AddColumn("Bar", 100);

        }

        
    }

    public class Item
    {

    }
}
