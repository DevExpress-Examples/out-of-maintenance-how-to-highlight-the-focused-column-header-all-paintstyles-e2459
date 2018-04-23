Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)

		End Sub

		Private Sub advBandedGridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles advBandedGridView1.FocusedColumnChanged
			advBandedGridView1.InvalidateColumnHeader(e.PrevFocusedColumn)
			advBandedGridView1.InvalidateColumnHeader(e.FocusedColumn)
		End Sub

		Private Sub advBandedGridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawColumnHeader
			If e.Column Is advBandedGridView1.FocusedColumn Then
				e.Info.State = DevExpress.Utils.Drawing.ObjectState.Hot
			End If
		End Sub
	End Class
End Namespace