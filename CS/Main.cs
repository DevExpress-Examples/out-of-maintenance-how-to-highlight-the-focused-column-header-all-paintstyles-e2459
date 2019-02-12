using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DXSample
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recordBindingSource.DataSource = DataHelper.GetData(10);
        }

        private void advBandedGridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            AdvBandedGridView view = sender as AdvBandedGridView;
            view.InvalidateColumnHeader(e.PrevFocusedColumn);
            view.InvalidateColumnHeader(e.FocusedColumn);
        }

        private void advBandedGridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            AdvBandedGridView view = sender as AdvBandedGridView;
            if (e.Column == view.FocusedColumn)
                e.Info.State = ObjectState.Hot;
        }
    }
}