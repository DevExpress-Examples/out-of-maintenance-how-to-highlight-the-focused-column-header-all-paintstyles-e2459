using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

        }

        private void advBandedGridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            advBandedGridView1.InvalidateColumnHeader(e.PrevFocusedColumn);
            advBandedGridView1.InvalidateColumnHeader(e.FocusedColumn);
        }

        private void advBandedGridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == advBandedGridView1.FocusedColumn)
                e.Info.State = DevExpress.Utils.Drawing.ObjectState.Hot;
        }
    }
}