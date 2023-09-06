Public Class RoomsAvailable
    Private Sub RoomsAvailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayInfo("select * from rooms_available", dgvRoom)
    End Sub
End Class