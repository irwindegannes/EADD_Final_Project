Imports System.Data.OleDb

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'connection to database to pull profile picture and user full name
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'open the connection to the db
        oleDbCon.Open()

        Dim NameSql As String = "SELECT * FROM [mySQLTUser] WHERE UserName=@UserName"
        Dim NameCmd As OleDbCommand = New OleDbCommand(NameSql, oleDbCon)
        NameCmd.Parameters.AddWithValue("@UserName", Context.User.Identity.Name)
        Dim NameAdapter As New OleDbDataAdapter
        Dim NameData As New DataSet
        NameAdapter.SelectCommand = NameCmd
        NameAdapter.Fill(NameData)

        'variable to store user's progress
        Dim UserProgress = NameData.Tables(0).Rows(0).Item("UserProgress").ToString

        'if user did not upload a profile picture a default image will be displayed
        If NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString = "" Then
            ProfilePicture.ImageUrl = "~/assets/images/profilepicture.png"
        Else
            ProfilePicture.ImageUrl = NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString
        End If

        'used in testing url data pull
        ProfilePictureHiddenField.Value = NameData.Tables(0).Rows(0).Item("ProfilePictureURL").ToString

        'close the connection to the db
        oleDbCon.Close()

        'calls the method used to get the user's progress
        getprogress()

        'assigns the progress to the user progress in the db
        UserProgress = Session("progress")

        'label used to display progress on the page
        ProgressLabel.Text = "<div class=""progress-bar progress-bar-info active"" role=""progressbar"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width:" & UserProgress & "%; min-width:" & "20px" & """>" & UserProgress & "% </div>"

        'likes repeater control that connects the repeater control to the Data
        oleDbCon.Open()

        'define SQL statement
        Dim likesSql As String = "SELECT * FROM [LessonsLiked] WHERE UserName=@UserName ORDER BY DateLiked DESC"
        'define the command
        Dim likesCmd As OleDbCommand = New OleDbCommand(likesSql, oleDbCon)
        likesCmd.Parameters.AddWithValue("@UserName", Context.User.Identity.Name)
        Dim likesAdapter As New OleDbDataAdapter
        Dim likesData As New DataSet
        likesAdapter.SelectCommand = likesCmd
        likesAdapter.Fill(likesData)

        'creating the connection between the repeater and the dataset
        ActivityRepeater.DataSource = likesData.Tables(0)
        ActivityRepeater.DataBind()

        oleDbCon.Close()

        'show attempted, completed and unattempted
        LessonActALabel.Text = Session("completed") & " out of 4"
        LessonActCLabel.Text = Session("completed") & " out of 4"
        LessonActULabel.Text = Session("unattempted") & " out of 4"

    End Sub

    Protected Sub LikeSub(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs)
        'create variables for Front End items
        Dim LikeInfoLabel As Label = CType(e.Item.FindControl("LikeInfoLabel"), Label)
        Dim LessonIdLabel As Label = CType(e.Item.FindControl("LessonIdLabel"), Label)
        Dim DateLikedLabel As Label = CType(e.Item.FindControl("DateLikedLabel"), Label)

        'define thet variables for the data items
        Dim row As DataRowView = CType(e.Item.DataItem, DataRowView)
        Dim lessonIdDB As String = row("LessonId").ToString()
        Dim dateLikedDB As String = row("DateLiked").ToString()

        'process the date value into a statement and join with the label
        Dim DateLikedValue = DateDiff(DateInterval.Minute, row("DateLiked"),
        System.DateTime.Now)
        If DateLikedValue > 1439 Then
            DateLikedLabel.Text = DateLikedValue \ 1440 & " days ago"
        ElseIf DateLikedValue > 60 Then
            DateLikedLabel.Text = DateLikedValue \ 60 & " hours ago"
        Else
            DateLikedLabel.Text = DateLikedValue & " minutes ago"
        End If

        'join data values with the front end items
        LikeInfoLabel.Text = "You Liked Lesson " & lessonIdDB.ToString

    End Sub

    Protected Sub getprogress()
        'out of all courses available, check how much is completed as a percentage
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)
        Dim ResponsesSql As String = "select * from LessonActivities where UserName = @UserName"
        Dim cmd As OleDbCommand = New OleDb.OleDbCommand(ResponsesSql, oleDbCon)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@UserName", User.Identity.Name)

        oleDbCon.Open()
        Dim datareader As OleDbDataReader = cmd.ExecuteReader
        Dim count As Integer = 0

        While datareader.Read
            count += 1
        End While

        If (count > 4) Then
            count = 4
        End If

        Session("completed") = count
        Session("unattempted") = 4 - count
        count = (count / 4) * 100
        Session("progress") = count

        oleDbCon.Close()
    End Sub
End Class