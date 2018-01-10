Public Class EmployeeBase
    Sub AddNewEmployee()
        MsgBox("New employee added")
    End Sub


    'Added by: Benedict Kabahar
    'START - BK
    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property
    'END - BK


End Class
