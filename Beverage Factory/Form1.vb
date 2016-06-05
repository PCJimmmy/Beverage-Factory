Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & Application.ProductVersion


        ProblemNumber = My.Settings.ProblemNumber
        Call TurnOnOff()


    End Sub



    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        Call TurnOnOff()
    End Sub



    Private Sub TurnOnOff()

        ' Turn off all visiblity of controns on the factory floor
        BrewingWaterslabel1.Visible = False
        BrewingWaterslabel2.Visible = False
        BrewingWaterstxt.Visible = False
        BrewingWatersVS.Visible = False

        If ProblemNumber > 0 Then

            BrewingWaterslabel1.Visible = True
            BrewingWaterslabel2.Visible = True
            BrewingWaterstxt.Visible = True
            BrewingWatersVS.Visible = True


        End If



    End Sub

    Private Sub BrewingWatersVS_Scroll(sender As Object, e As ScrollEventArgs) Handles BrewingWatersVS.Scroll
        BrewingWaterstxt.Text = BrewingWatersVS.Value
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Select Case ListBox2.SelectedIndex
            Case 1
                ' salts run chart
                ProblemNumber = 1
                My.Settings.ProblemNumber = ProblemNumber
            Case Else
                ProblemNumber = 0


        End Select

        My.Settings.Save()

    End Sub
End Class
