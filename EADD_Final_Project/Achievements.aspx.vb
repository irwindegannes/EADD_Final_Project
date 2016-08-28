Imports System.Data.OleDb

Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'connection to database to pull profile picture and user full name
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
        Dim UserCP = NameData.Tables(0).Rows(0).Item("UserCP").ToString

        UserCPLabel.Text = UserCP & " of 20"

        'if user did not upload a profile picture a default image will be displayed
        If NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString = "" Then
            ProfilePicture.ImageUrl = "~/assets/images/profilepicture.png"
        Else
            ProfilePicture.ImageUrl = NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString
        End If


        'used in testing url data pull
        ProfilePictureHiddenField.Value = NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString

        oleDbCon.Close()

    End Sub

End Class