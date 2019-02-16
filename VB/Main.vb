Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            recordBindingSource.DataSource = DataHelper.GetData(10)
        End Sub

        Private Sub advBandedGridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles advBandedGridView1.FocusedColumnChanged
            Dim view As AdvBandedGridView = TryCast(sender, AdvBandedGridView)
            view.InvalidateColumnHeader(e.PrevFocusedColumn)
            view.InvalidateColumnHeader(e.FocusedColumn)
        End Sub

        Private Sub advBandedGridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawColumnHeader
            Dim view As AdvBandedGridView = TryCast(sender, AdvBandedGridView)
            If e.Column = view.FocusedColumn Then
                e.Info.State = ObjectState.Hot
            End If
        End Sub
    End Class
End Namespace