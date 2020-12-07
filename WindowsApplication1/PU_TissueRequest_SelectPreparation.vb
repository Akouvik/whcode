Public Class PU_TissueRequest_SelectPreparation
    Public returnString As String = ""

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        returnString += IIf(DigitalSlide.Checked, "Digital Slide; ", "")
        returnString += IIf(FixedBlockWet.Checked, "Fixed Block (Wet); ", "")
        returnString += IIf(FixedParafin.Checked, "Fixed Parafin Embedded; ", "")
        returnString += IIf(FixedSlide.Checked, "Fixed Slide; ", "")
        returnString += IIf(FrozenBlock.Checked, "Frozen Block; ", "")
        returnString += IIf(FrozenLiquid.Checked, "Frozen Liquid; ", "")
        returnString += IIf(FrozenPulverized.Checked, "Frozen Pulverized; ", "")
        returnString += IIf(FrozenSlide.Checked, "Frozen Slide; ", "")
        returnString += IIf(FrozenOther.Checked, "Frozen Other; ", "")

        If Len(returnString) > 0 Then
            returnString = returnString.Substring(0, Len(returnString) - 2)
        End If

        Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        returnString = "Cancel"
        Hide()
    End Sub
End Class