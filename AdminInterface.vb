Public Class AdminInterface
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SettingsFrm.TopLevel = False
        Guna2Panel1.Controls.Add(SettingsFrm)
        SettingsFrm.Show()
        SettingsFrm.BringToFront()

        Guna2Button1.FillColor = Color.White
        Guna2Button1.ForeColor = Color.FromArgb(43, 78, 116)

        Guna2Button2.FillColor = Color.FromArgb(43, 78, 116)
        Guna2Button2.ForeColor = Color.White
    End Sub
End Class