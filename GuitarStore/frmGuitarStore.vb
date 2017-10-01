' Program Name: Guitar Store
' Developer:    Tu Tong
' Date:         September 26, 2017
' Purpose:      This application displays three guitar types
'               (classical, steel-string, and electric).
'               The user can select a guitar type and purchase it.

Public Class frmGuitarStore

    Private Sub rdoClassicalAcoustic_CheckedChanged(sender As Object, e As EventArgs) Handles rdoClassicalAcoustic.CheckedChanged
        ' This code is executed when user taps or clicks 
        ' the Classical acoustic radio button.
        ' It displays the Classical guitar picture, 
        ' and enables Purchase button.

        picGuitar.Image = My.Resources.classical
        btnPurchase.Enabled = True

    End Sub

    Private Sub rdoSteelStringAcoustic_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSteelStringAcoustic.CheckedChanged
        ' This code is executed when user taps or clicks 
        ' the Steel - String  Acoustic radio button.
        ' It displays the Steel-string guitar picture,
        ' and enables Purchase button.
        picGuitar.Image = My.Resources.steel_string
        btnPurchase.Enabled = True

    End Sub

    Private Sub rdoElectricGuitar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoElectricGuitar.CheckedChanged
        ' This code is executed when user taps or clicks
        ' the Electric Guitar radio button.
        ' It displays the Eletric guitar picture,
        ' and enables Purchase button.

        picGuitar.Image = My.Resources.eletric
        btnPurchase.Enabled = True

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        ' This code is executed when user taps or clicks
        ' the Purchase button. It disables Purchase button,
        ' disable Guitar Choice group,
        ' displays the Enjoy label, and enables Exit button.

        btnPurchase.Enabled = False
        grpGuitarChoices.Enabled = False
        lblEnjoy.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when users taps or clicks the Exit button.
        ' It close the window and terminates the program execution.

        Close()

    End Sub

End Class
