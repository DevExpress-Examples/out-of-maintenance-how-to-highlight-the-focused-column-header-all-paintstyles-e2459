namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication1.nwindDataSet();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.colCustomerID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRegion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCountry = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.customersTableAdapter = new WindowsApplication1.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.customersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(714, 459);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colCustomerID,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colPhone,
            this.colFax});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            this.advBandedGridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.advBandedGridView1_FocusedColumnChanged);
            this.advBandedGridView1.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.advBandedGridView1_CustomDrawColumnHeader);
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.RowIndex = 1;
            this.colCompanyName.Visible = true;
            this.colCompanyName.Width = 188;
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.RowIndex = 2;
            this.colContactName.Visible = true;
            this.colContactName.Width = 100;
            // 
            // colContactTitle
            // 
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.RowIndex = 2;
            this.colContactTitle.Visible = true;
            this.colContactTitle.Width = 88;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.RowIndex = 1;
            this.colAddress.Visible = true;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.RowIndex = 1;
            this.colCity.Visible = true;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.RowIndex = 1;
            this.colRegion.Visible = true;
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.RowIndex = 2;
            this.colPhone.Visible = true;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.RowIndex = 2;
            this.colFax.Visible = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Key Information";
            this.gridBand1.Columns.Add(this.colCustomerID);
            this.gridBand1.Columns.Add(this.colCompanyName);
            this.gridBand1.Columns.Add(this.colContactName);
            this.gridBand1.Columns.Add(this.colContactTitle);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 188;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Contact Information";
            this.gridBand2.Columns.Add(this.colPostalCode);
            this.gridBand2.Columns.Add(this.colCountry);
            this.gridBand2.Columns.Add(this.colCity);
            this.gridBand2.Columns.Add(this.colAddress);
            this.gridBand2.Columns.Add(this.colRegion);
            this.gridBand2.Columns.Add(this.colFax);
            this.gridBand2.Columns.Add(this.colPhone);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 225;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 459);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private WindowsApplication1.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomerID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompanyName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactTitle;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRegion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPostalCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCountry;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFax;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}

