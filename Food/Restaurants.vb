'以類別定義兩種餐廳
Public Class Ramen
    Public Function tonkotu(money As Double) As String
        If money >= 200 Then
            Return "tonkotu ramen"
        Else Return "cyotto..." '200元以上就回傳"豚骨拉麵"
        End If
    End Function
End Class

Public Class Fastfood
    Public Function Meal_1st(money As Double) As String
        If money >= 140 Then
            Return "big mac+coke+frenchfies"
        Else Return "No money? Seriously?" '140元以上就回傳"1號餐"
        End If
    End Function
End Class
