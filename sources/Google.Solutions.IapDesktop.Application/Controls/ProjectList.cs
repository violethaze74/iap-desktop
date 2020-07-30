using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Google.Apis.Compute.v1.Data;

namespace Google.Solutions.IapDesktop.Application.Controls
{
    public partial class ProjectList : UserControl
    {
        public event EventHandler LoadingChanged;

        public ProjectList()
        {
            InitializeComponent();

        }

        public bool Loading 
        {
            get => this.progressBar.Enabled;
            set
            {
                this.progressBar.Enabled = value;
                this.LoadingChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void BindItems(ObservableCollection<Project> model)
        {
            this.list.BindCollection(model);
        }

        public void BindSelectedItems(ObservableCollection<Project> model)
        {
            throw new NotImplementedException();
        }

        //---------------------------------------------------------------------
        // Window events.
        //---------------------------------------------------------------------

        private void list_Layout(object sender, LayoutEventArgs e)
        {
            this.nameColumnHeader.Width = (int)(this.Width/2);
            this.idColumnHeader.Width = this.Width - 
                this.nameColumnHeader.Width - 
                SystemInformation.VerticalScrollBarWidth;
        }
    }

    internal class ProjectsListView : BindableListView<Project>
    {
    }

}
