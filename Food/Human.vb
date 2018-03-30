Public Class Human
    '宣告一個買午餐函數，引數是一個"函數"及"錢"
    '因為函數無法當做引數代入函數內，這時就可以用委派來代替
    '委派就可以將函數連同引數格式整個以一個變數名稱做代表

    Public Function GetLunch(restaurant As D2C, money As Double)
        Dim lunch As String = restaurant.Invoke(money)
        Return lunch
    End Function
End Class
