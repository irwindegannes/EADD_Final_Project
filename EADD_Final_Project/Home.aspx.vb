Imports System.Data.OleDb

Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CheckIdentityHF.Value = Request.Params("Identity")

        If String.Equals(CheckIdentityHF.Value, "New") Then
            CheckIdentityHF.Value = "Existing"


        End If

        'connection to database to pull profile picture and user full name
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        oleDbCon.Open()

        Dim NameSql As String = "SELECT * FROM [mySQLTUser] WHERE UserName=@UserName"
        Dim NameCmd As OleDbCommand = New OleDbCommand(NameSql, oleDbCon)
        NameCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        Dim NameAdapter As New OleDbDataAdapter
        Dim NameData As New DataSet
        NameAdapter.SelectCommand = NameCmd
        NameAdapter.Fill(NameData)

        'variable to store user's full name
        Dim FullName = NameData.Tables(0).Rows(0).Item("FirstName").ToString & " " & NameData.Tables(0).Rows(0).Item("LastName").ToString

        'if user did not upload a profile picture a default image will be displayed
        If NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString = "" Then
            ProfilePicture.ImageUrl = "~/assets/profilepicture.png"
        Else
            ProfilePicture.ImageUrl = NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString
        End If

        'used in testing url data pull
        ProfilePictureHiddenField.Value = NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString

        oleDbCon.Close()

    End Sub

End Class