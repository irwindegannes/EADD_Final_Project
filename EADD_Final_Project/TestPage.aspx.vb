Imports System.Data.OleDb

Public Class TestPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentql As String = "SELECT * FROM [Lessons] WHERE LessonId=1"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString

        'Close database connection
        oleDbCon.Close()
    End Sub




End Class