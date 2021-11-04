Public Class Praktikum5
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles hslDiskon.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNama.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        hslHarga.Text = ""
        hslDiskon.Text = ""
        hslBayar.Text = ""
        hslBonus.Text = ""
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String

        harga = txtHarga.Text
        jumlah = txtJumlah.Text

        total = harga * jumlah

        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Tas Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Cangkir"
        Else
            diskon = 0
            bonus = "Tidak ada"
        End If

        bayar = total - diskon

        hslHarga.Text = total
        hslDiskon.Text = diskon
        hslBayar.Text = bayar
        hslBonus.Text = bonus
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class