Imports System.Data.OleDb

Public Class UpdateProfile
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ContinueButton.Visible = False
    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If Page.IsValid = True Then

            'config settings for connection to database table
            Dim oleDbConn As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)
            Dim AddMySQLTUserSql As String = "Insert into mySQLTUser(UserName,FirstName,LastName,Country,ProfilePictureURL) Values(@UserName,@FirstName,@LastName,@Country,@ProfilePictureURL)"
            Dim cmd As OleDbCommand = New OleDbCommand(AddMySQLTUserSql, oleDbConn)

            'assignment of data entered to table paramaters
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
            cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text)
            cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text)
            cmd.Parameters.AddWithValue("@Country", CountryDropDownList.SelectedValue)

            If ProfilePictureFileUpload.HasFile Then

                'checks to see if user uploaded a valid file type for profile picture
                Dim validFileTypes As String() = {"gif", "png", "jpg", "jpeg", "bmp"}
                Dim ext As String = System.IO.Path.GetExtension(ProfilePictureFileUpload.PostedFile.FileName)
                Dim isValidFile As Boolean = False
                For i As Integer = 0 To validFileTypes.Length - 1
                    If ext = "." & validFileTypes(i) Then
                        isValidFile = True
                        Exit For
                    End If
                Next

                If isValidFile = False Then
                    InvalidFileTypeLabel.ForeColor = System.Drawing.Color.Red
                    InvalidFileTypeLabel.Text = "Invalid File Type! Please upload a File with extension " & String.Join(",", validFileTypes)
                Else

                    'save file to solution folder
                    ProfilePictureFileUpload.SaveAs(Request.MapPath("~/UserImages") & "/" & User.Identity.Name & ".ProfilePicture." & DateTime.Now.ToString("ddmmyyhhmm") & ext)

                    'assignment of data entered to table paramaters
                    cmd.Parameters.AddWithValue("@ProfilePictureURL", "~/UserImages" & "/" & User.Identity.Name & ".ProfilePicture." & DateTime.Now.ToString("ddmmyyhhmm") & ext)
                End If

            Else

                cmd.Parameters.AddWithValue("@ProfilePictureURL", "")

            End If

            'opens executes and closes database connection
            oleDbConn.Open()
            cmd.ExecuteNonQuery()
            oleDbConn.Close()

            'this will hide the submit button And show the continue button
            'it will also display a confirmation message about the user's profile being updated
            SubmitButton.Visible = False
            ContinueButton.Visible = True

            ConfirmLabel.ForeColor = System.Drawing.Color.Green
            ConfirmLabel.Text = "Your Profile Has Been Successfully Updated!"

        Else

            ConfirmLabel.ForeColor = System.Drawing.Color.Red
            ConfirmLabel.Text = "Validation Failed, Data Not Saved!"

        End If
    End Sub

    Protected Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        'redirects user to home page upon click
        Response.Redirect("Home.aspx?Identity=New")
    End Sub
End Class