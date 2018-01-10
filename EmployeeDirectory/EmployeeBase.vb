Public Class EmployeeBase
    Sub AddNewEmployee()
        MsgBox("New employee added")
    End Sub

    Private _firstName As String
    Public Property firstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

End Class
