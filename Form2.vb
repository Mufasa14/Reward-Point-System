Public Class Form2
    Private Sub PTblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PTblBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PTblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PointsTableDataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PointsTableDataSet1.PTbl' table. You can move, or remove it, as needed.
        Me.PTblTableAdapter.Fill(Me.PointsTableDataSet1.PTbl)

    End Sub

    Private Sub BindingNavigatorPositionItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Click

    End Sub
End Class