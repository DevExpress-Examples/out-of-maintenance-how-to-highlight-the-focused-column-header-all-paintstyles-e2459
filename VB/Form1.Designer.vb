Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colFax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.customersTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(714, 459)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
'			Me.advBandedGridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.advBandedGridView1_FocusedColumnChanged);
'			Me.advBandedGridView1.CustomDrawColumnHeader += New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawColumnHeader);
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			' 
			' colCompanyName
			' 
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.RowIndex = 1
			Me.colCompanyName.Visible = True
			Me.colCompanyName.Width = 188
			' 
			' colContactName
			' 
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.RowIndex = 2
			Me.colContactName.Visible = True
			Me.colContactName.Width = 100
			' 
			' colContactTitle
			' 
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			Me.colContactTitle.RowIndex = 2
			Me.colContactTitle.Visible = True
			Me.colContactTitle.Width = 88
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.RowIndex = 1
			Me.colAddress.Visible = True
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.RowIndex = 1
			Me.colCity.Visible = True
			' 
			' colRegion
			' 
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.RowIndex = 1
			Me.colRegion.Visible = True
			' 
			' colPostalCode
			' 
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.Visible = True
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.RowIndex = 2
			Me.colPhone.Visible = True
			' 
			' colFax
			' 
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			Me.colFax.RowIndex = 2
			Me.colFax.Visible = True
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Key Information"
			Me.gridBand1.Columns.Add(Me.colCustomerID)
			Me.gridBand1.Columns.Add(Me.colCompanyName)
			Me.gridBand1.Columns.Add(Me.colContactName)
			Me.gridBand1.Columns.Add(Me.colContactTitle)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 188
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Contact Information"
			Me.gridBand2.Columns.Add(Me.colPostalCode)
			Me.gridBand2.Columns.Add(Me.colCountry)
			Me.gridBand2.Columns.Add(Me.colCity)
			Me.gridBand2.Columns.Add(Me.colAddress)
			Me.gridBand2.Columns.Add(Me.colRegion)
			Me.gridBand2.Columns.Add(Me.colFax)
			Me.gridBand2.Columns.Add(Me.colPhone)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 225
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(714, 459)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.CustomersTableAdapter
		Private colCustomerID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCompanyName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colContactName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colContactTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colRegion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPostalCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCountry As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colFax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	End Class
End Namespace

