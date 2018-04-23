Imports System.Data.OleDb

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not IsPostBack Then
            Load_FAQ()
        End If
    End Sub

    Public Sub Load_FAQ()
        Dim SQL As String = "SELECT [Sort], [Question], [Answer] FROM [FAQ] ORDER BY [Sort], [Question]"
        Dim Question As String = Nothing
        Dim Answer As String = Nothing
        Dim i As Integer = 0
        Dim conn As New OleDbConnection(ConfigurationManager.ConnectionStrings("DB_Conn_FAQ").ConnectionString)
        Dim SelectCommand As New OleDbCommand(SQL, conn)
        Try
            conn.Open()
            Dim Reader As OleDbDataReader = SelectCommand.ExecuteReader()
            Do While Reader.Read()
                If Reader.HasRows Then
                    Question = Reader("Question").ToString()
                    Answer = Reader("Answer").ToString()
                    navFAQ.Groups.Add(Question)
                    navFAQ.Groups(i).Items.Add(Answer)
                End If
                i += 1
            Loop
        Catch ex As Exception
        Finally
            conn.Close()
            conn.Dispose()
            SelectCommand.Dispose()
        End Try
    End Sub
End Class
