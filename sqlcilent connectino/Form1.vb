Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_testconnDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.New_testconnDataSet.Table)

    End Sub
End Class
