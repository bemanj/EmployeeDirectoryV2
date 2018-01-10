Public Class EmployeeBase
    Sub AddNewEmployee()
        MsgBox("New employee added")
    End Sub

<<<<<<< HEAD
    Private _firstName As String
    Public Property firstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property
=======

    Private Function EmployeeName() As String
        Return 0
    End Function

>>>>>>> c03bb7f5780e5f1a4a843bc8dbede00f741190e2

End Class
