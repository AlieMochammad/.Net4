<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.hslHarga = New System.Windows.Forms.TextBox()
        Me.hslDiskon = New System.Windows.Forms.TextBox()
        Me.hslBayar = New System.Windows.Forms.TextBox()
        Me.hslBonus = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bonus"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(111, 36)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(220, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(111, 63)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(220, 20)
        Me.txtHarga.TabIndex = 8
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(111, 91)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(220, 20)
        Me.txtJumlah.TabIndex = 9
        '
        'hslHarga
        '
        Me.hslHarga.Location = New System.Drawing.Point(111, 167)
        Me.hslHarga.Name = "hslHarga"
        Me.hslHarga.Size = New System.Drawing.Size(220, 20)
        Me.hslHarga.TabIndex = 10
        '
        'hslDiskon
        '
        Me.hslDiskon.Location = New System.Drawing.Point(111, 194)
        Me.hslDiskon.Name = "hslDiskon"
        Me.hslDiskon.Size = New System.Drawing.Size(220, 20)
        Me.hslDiskon.TabIndex = 11
        '
        'hslBayar
        '
        Me.hslBayar.Location = New System.Drawing.Point(111, 222)
        Me.hslBayar.Name = "hslBayar"
        Me.hslBayar.Size = New System.Drawing.Size(220, 20)
        Me.hslBayar.TabIndex = 12
        '
        'hslBonus
        '
        Me.hslBonus.Location = New System.Drawing.Point(111, 250)
        Me.hslBonus.Name = "hslBonus"
        Me.hslBonus.Size = New System.Drawing.Size(220, 20)
        Me.hslBonus.TabIndex = 13
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(111, 121)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 26)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(228, 121)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(103, 26)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(228, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 26)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Praktikum5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 337)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.hslBonus)
        Me.Controls.Add(Me.hslBayar)
        Me.Controls.Add(Me.hslDiskon)
        Me.Controls.Add(Me.hslHarga)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Praktikum5"
        Me.Text = "Praktikum 5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents hslHarga As TextBox
    Friend WithEvents hslDiskon As TextBox
    Friend WithEvents hslBayar As TextBox
    Friend WithEvents hslBonus As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnExit As Button
End Class
