Imports Guna.UI2.WinForms

Public Class SettingsInterface
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        AdminInterface.TopLevel = False
        Guna2Panel1.Controls.Add(AdminInterface)
        AdminInterface.Show()
        AdminInterface.BringToFront()

        Guna2Button2.FillColor = Color.White
        Guna2Button2.ForeColor = Color.FromArgb(43, 78, 116)

        Guna2Button1.FillColor = Color.FromArgb(43, 78, 116)
        Guna2Button1.ForeColor = Color.White
    End Sub
End Class