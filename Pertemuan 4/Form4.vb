Public Class Praktikum6
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtQtyMakanan.Text = ""
        txtQtyMinuman.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        txtHasil.Text = ""
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim totalMakan As Integer, totalMinum As Integer
        Dim hargaMakan As Integer, hargaMinum As Integer

        totalMakan = hargaMakan * txtQtyMakanan.Text
        totalMinum = hargaMinum * txtQtyMinuman.Text

        If ComboBox1.Text = "Nasi Jagung" Then
            hargaMakan = 8000
        ElseIf ComboBox1.Text = "Nasi Pecel" Then
            hargaMakan = 7000
        ElseIf ComboBox1.Text = "Nasi Rames" Then
            hargaMakan = 10000
        ElseIf ComboBox1.Text = "Bakso" Then
            hargaMakan = 8000
        ElseIf ComboBox1.Text = "Mie Ayam" Then
            hargaMakan = 7000
        End If

        If ComboBox2.Text = "Es Teh" Then
            hargaMakan = 2000
        ElseIf ComboBox2.Text = "Es Jeruk" Then
            hargaMakan = 4000
        ElseIf ComboBox2.Text = "Kopi" Then
            hargaMakan = 50000
        ElseIf ComboBox2.Text = "Es Mega" Then
            hargaMakan = 10000
        ElseIf ComboBox2.Text = "Es Dawet" Then
            hargaMakan = 6000
        End If

        txtHasil.Text = totalMakan + totalMinum
    End Sub
End Class