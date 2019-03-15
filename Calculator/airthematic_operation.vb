Public Class airthematic_operation
    Public Shared Function add(x As Double, y As Double) As Double
        Return (x + y)
    End Function

    Public Shared Function subtract(x As Double, y As Double) As Double
        Return (x - y)
    End Function

    Public Shared Function multiply(x As Double, y As Double) As Double
        Return (x * y)
    End Function

    Public Shared Function divide(x As Double, y As Double) As Double
        If y <> 0 Then
            Return (x / y)
        Else
            Return Double.NaN
        End If
    End Function
End Class
