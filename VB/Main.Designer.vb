Namespace DXSample
    Partial Public Class Main
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
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colParentID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colText = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colInfo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colState = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colImage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDetail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.recordBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(714, 459)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(DXSample.Record)
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            ' 
            ' colParentID
            ' 
            Me.colParentID.FieldName = "ParentID"
            Me.colParentID.Name = "colParentID"
            Me.colParentID.RowIndex = 1
            Me.colParentID.Visible = True
            Me.colParentID.Width = 225
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            ' 
            ' colInfo
            ' 
            Me.colInfo.FieldName = "Info"
            Me.colInfo.Name = "colInfo"
            Me.colInfo.Visible = True
            Me.colInfo.Width = 213
            ' 
            ' colValue
            ' 
            Me.colValue.FieldName = "Value"
            Me.colValue.Name = "colValue"
            Me.colValue.Visible = True
            ' 
            ' colDt
            ' 
            Me.colDt.FieldName = "Dt"
            Me.colDt.Name = "colDt"
            Me.colDt.RowIndex = 2
            Me.colDt.Visible = True
            Me.colDt.Width = 225
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.RowIndex = 1
            Me.colState.Visible = True
            Me.colState.Width = 213
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.RowIndex = 2
            Me.colImage.Visible = True
            Me.colImage.Width = 213
            ' 
            ' colDetail
            ' 
            Me.colDetail.FieldName = "Detail"
            Me.colDetail.Name = "colDetail"
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Key Information"
            Me.gridBand1.Columns.Add(Me.colID)
            Me.gridBand1.Columns.Add(Me.colText)
            Me.gridBand1.Columns.Add(Me.colValue)
            Me.gridBand1.Columns.Add(Me.colDetail)
            Me.gridBand1.Columns.Add(Me.colParentID)
            Me.gridBand1.Columns.Add(Me.colDt)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 225
            ' 
            ' gridBand2
            ' 
            Me.gridBand2.Caption = "Additional Information"
            Me.gridBand2.Columns.Add(Me.colInfo)
            Me.gridBand2.Columns.Add(Me.colState)
            Me.gridBand2.Columns.Add(Me.colImage)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 213
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(714, 459)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Main"
            Me.Text = "Form1"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Private recordBindingSource As System.Windows.Forms.BindingSource
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colText As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDetail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colParentID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colDt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colInfo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colState As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colImage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    End Class
End Namespace

