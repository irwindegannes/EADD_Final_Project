Imports System.Data.OleDb

Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'on postback pages return to the scroll position they were at
        Page.MaintainScrollPositionOnPostBack = True

        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)
        oleDbCon.Open()
        Dim NameSql As String = "SELECT * FROM [mySQLTUser] WHERE UserName=@UserName"
        Dim NameCmd As OleDbCommand = New OleDbCommand(NameSql, oleDbCon)
        NameCmd.Parameters.AddWithValue("@UserName", Context.User.Identity.Name)
        Dim NameAdapter As New OleDbDataAdapter
        Dim NameData As New DataSet
        NameAdapter.SelectCommand = NameCmd
        NameAdapter.Fill(NameData)

        'variable to store user's full name
        Dim FullName = NameData.Tables(0).Rows(0).Item("FirstName").ToString & " " & NameData.Tables(0).Rows(0).Item("LastName").ToString
        'assign user's full name to the name label
        NameLabel.Text = FullName.ToString
    End Sub

End Class