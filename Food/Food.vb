Public Delegate Function D2C(money As Double) As String '宣告函數的委派。引數與回傳值與餐廳類別中的函數一致

Public Class Food
    Dim i As New Human
    Dim McDonald As New Fastfood
    Dim Kakumaru As New Ramen


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(i.GetLunch(AddressOf McDonald.Meal_1st, 170))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(i.GetLunch(AddressOf Kakumaru.tonkotu, 170))
    End Sub
End Class


