Imports System.Data.OleDb

Public Class Lessons
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then 'IF THE PAGE LOADS FOR THE FIRST TIME
            LessonContentPanel.Visible = False
            IntroFooterPanel.Visible = False

        End If

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub IntroButton_Click(sender As Object, e As EventArgs) Handles IntroButton.Click
        LessonContentPanel.Visible = True
        LessonIntroPanel.Visible = False

        If ActivityPanel.Visible = True Then
            ActivityPanel.Visible = False
        End If

        If IntroFooterPanel.Visible = False Then
            IntroFooterPanel.Visible = True
        End If

        If FooterPanel.Visible = True Then
            FooterPanel.Visible = False
        End If

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentSql As String = "SELECT * FROM [Lessons] WHERE LessonId=1"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString

        'create variables to store specific DataBase data
        Dim VideoURL = LessonContentData.Tables(0).Rows(0).Item("LessonVideoURL").ToString

        'Close database connection
        oleDbCon.Close()

        LessonContentsLabel.Text = Contents
        LessonVideoLabel.Text = VideoURL

        LessonIdHF.Value = 1

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        LessonContentPanel.Visible = True
        LessonIntroPanel.Visible = False

        If ActivityPanel.Visible = False Then
            ActivityPanel.Visible = True
        End If

        If IntroFooterPanel.Visible = True Then
            IntroFooterPanel.Visible = False
        End If

        If FooterPanel.Visible = False Then
            FooterPanel.Visible = True
        End If

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=2"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString
        Dim VideoURL = LessonContentData.Tables(0).Rows(0).Item("LessonVideoURL").ToString
        Dim ActivityName = LessonContentData.Tables(0).Rows(0).Item("ActivityName").ToString
        Dim ActivityTask = LessonContentData.Tables(0).Rows(0).Item("ActivityTask").ToString
        Dim ActivitySolution = LessonContentData.Tables(0).Rows(0).Item("ActivitySolution").ToString

        'Close database connection
        oleDbCon.Close()

        LessonContentsLabel.Text = Contents
        LessonVideoLabel.Text = VideoURL
        ActivityNameLabel.Text = ActivityName
        ActivityTaskLabel.Text = ActivityTask
        ActivitySolutionLabel.ToolTip = ActivitySolution
        ActivityAnswerHF.Value = ActivitySolution


        LessonIdHF.Value = 2

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub WhereButton_Click(sender As Object, e As EventArgs) Handles WhereButton.Click
        LessonContentPanel.Visible = True
        LessonIntroPanel.Visible = False
        IntroFooterPanel.Visible = False

        If FooterPanel.Visible = False Then
            FooterPanel.Visible = True
        End If

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=3"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString
        Dim VideoURL = LessonContentData.Tables(0).Rows(0).Item("LessonVideoURL").ToString
        Dim ActivityName = LessonContentData.Tables(0).Rows(0).Item("ActivityName").ToString
        Dim ActivityTask = LessonContentData.Tables(0).Rows(0).Item("ActivityTask").ToString
        Dim ActivitySolution = LessonContentData.Tables(0).Rows(0).Item("ActivitySolution").ToString

        'Close database connection
        oleDbCon.Close()

        LessonContentsLabel.Text = Contents
        LessonVideoLabel.Text = VideoURL
        ActivityNameLabel.Text = ActivityName
        ActivityTaskLabel.Text = ActivityTask
        ActivitySolutionLabel.ToolTip = ActivitySolution
        ActivityAnswerHF.Value = ActivitySolution

        LessonIdHF.Value = 3

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        LessonContentPanel.Visible = True
        LessonIntroPanel.Visible = False
        IntroFooterPanel.Visible = False

        If FooterPanel.Visible = False Then
            FooterPanel.Visible = True
        End If

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=4"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString
        Dim VideoURL = LessonContentData.Tables(0).Rows(0).Item("LessonVideoURL").ToString
        Dim ActivityName = LessonContentData.Tables(0).Rows(0).Item("ActivityName").ToString
        Dim ActivityTask = LessonContentData.Tables(0).Rows(0).Item("ActivityTask").ToString
        Dim ActivitySolution = LessonContentData.Tables(0).Rows(0).Item("ActivitySolution").ToString

        'Close database connection
        oleDbCon.Close()

        LessonContentsLabel.Text = Contents
        LessonVideoLabel.Text = VideoURL
        ActivityNameLabel.Text = ActivityName
        ActivityTaskLabel.Text = ActivityTask
        ActivitySolutionLabel.ToolTip = ActivitySolution
        ActivityAnswerHF.Value = ActivitySolution

        LessonIdHF.Value = 4

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        LessonContentPanel.Visible = True
        LessonIntroPanel.Visible = False
        IntroFooterPanel.Visible = False

        If FooterPanel.Visible = False Then
            FooterPanel.Visible = True
        End If


        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=5"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString
        Dim VideoURL = LessonContentData.Tables(0).Rows(0).Item("LessonVideoURL").ToString
        Dim ActivityName = LessonContentData.Tables(0).Rows(0).Item("ActivityName").ToString
        Dim ActivityTask = LessonContentData.Tables(0).Rows(0).Item("ActivityTask").ToString
        Dim ActivitySolution = LessonContentData.Tables(0).Rows(0).Item("ActivitySolution").ToString

        'Close database connection
        oleDbCon.Close()

        LessonContentsLabel.Text = Contents
        LessonVideoLabel.Text = VideoURL
        ActivityNameLabel.Text = ActivityName
        ActivityTaskLabel.Text = ActivityTask
        ActivitySolutionLabel.ToolTip = ActivitySolution
        ActivityAnswerHF.Value = ActivitySolution

        LessonIdHF.Value = 5

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Open database connection
        oleDbCon.Open()

        Dim StoreDownloadSql As String = "Insert into Downloads(UserName,LessonID,DateDownloaded) Values(@UserName,@LessonID,@DateDownloaded)"
        Dim StoreDownloadcmd As OleDbCommand = New OleDbCommand(StoreDownloadSql, oleDbCon)

        StoreDownloadcmd.CommandType = CommandType.Text
        'parameters point to actual values stored in front end controls
        StoreDownloadcmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        StoreDownloadcmd.Parameters.AddWithValue("@LessonID", LessonIdHF.Value)
        StoreDownloadcmd.Parameters.AddWithValue("@DateDownloaded", System.DateTime.Now())

        StoreDownloadcmd.ExecuteNonQuery()
        oleDbCon.Close()
    End Sub

    Protected Sub LikeButton_Click(sender As Object, e As EventArgs) Handles LikeButton.Click

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)


        '=========================== LOCKING CONTENTS ==========
        ''read rows from database
        'Dim variable = ""
        'oleDbCon.Open() 'open connent
        'Dim reader As OleDbDataReader = LessonLikedCmd.ExecuteReader

        'If reader.HasRows = False Then 'if i'm looking for something in the database and i get results
        '    Response.Redirect("default") 'go back to home page
        'End If

        'oleDbCon.Close()
        '==================================================================

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            'Open database connection
            oleDbCon.Open()

            Dim StoreDownloadSql As String = "Insert into LessonsLiked(UserName,LessonID,DateLiked) Values(@UserName,@LessonID,@DateLiked)"
            Dim StoreDownloadcmd As OleDbCommand = New OleDbCommand(StoreDownloadSql, oleDbCon)

            StoreDownloadcmd.CommandType = CommandType.Text
            'parameters point to actual values stored in front end controls
            StoreDownloadcmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
            StoreDownloadcmd.Parameters.AddWithValue("@LessonID", LessonIdHF.Value)
            StoreDownloadcmd.Parameters.AddWithValue("@DateLiked", System.DateTime.Now())

            StoreDownloadcmd.ExecuteNonQuery()
            oleDbCon.Close()
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If


    End Sub

    Protected Sub IntroContinueButton_Click(sender As Object, e As EventArgs) Handles IntroContinueButton.Click
        Page.MaintainScrollPositionOnPostBack = False

        LessonContentPanel.Visible = True
        LessonIntroPanel.Visible = False

        If ActivityPanel.Visible = False Then
            ActivityPanel.Visible = True
        End If

        If IntroFooterPanel.Visible = True Then
            IntroFooterPanel.Visible = False
        End If

        If FooterPanel.Visible = False Then
            FooterPanel.Visible = True
        End If

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=2"
        Dim LessonContentCmd As OleDbCommand = New OleDbCommand(LessonContentSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonContentAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonContentData As New DataSet
        LessonContentAdapter.SelectCommand = LessonContentCmd
        LessonContentAdapter.Fill(LessonContentData)

        'create variables to store specific DataBase data
        Dim Contents = LessonContentData.Tables(0).Rows(0).Item("LessonContent").ToString
        Dim VideoURL = LessonContentData.Tables(0).Rows(0).Item("LessonVideoURL").ToString
        Dim ActivityName = LessonContentData.Tables(0).Rows(0).Item("ActivityName").ToString
        Dim ActivityTask = LessonContentData.Tables(0).Rows(0).Item("ActivityTask").ToString
        Dim ActivitySolution = LessonContentData.Tables(0).Rows(0).Item("ActivitySolution").ToString

        'Close database connection
        oleDbCon.Close()

        LessonContentsLabel.Text = Contents
        LessonVideoLabel.Text = VideoURL
        ActivityNameLabel.Text = ActivityName
        ActivityTaskLabel.Text = ActivityTask
        ActivitySolutionLabel.ToolTip = ActivitySolution
        ActivityAnswerHF.Value = ActivitySolution


        LessonIdHF.Value = 2

        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonLikedSql As String = "SELECT * FROM [LessonsLiked]  WHERE UserName = @UserName AND LessonId = @LessonId"
        Dim LessonLikedCmd As OleDbCommand = New OleDbCommand(LessonLikedSql, oleDbCon)
        LessonLikedCmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        LessonLikedCmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)

        'create Adapter that grabs data from DB
        Dim LessonLikedAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonLikedData As New DataSet
        LessonLikedAdapter.SelectCommand = LessonLikedCmd
        LessonLikedAdapter.Fill(LessonLikedData)

        'Close database connection
        oleDbCon.Close()


        If LessonLikedData.Tables(0).Rows.Count = 0 Then
            LikeButton.Text = "Like this Lesson"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "You Liked this Lesson"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        'this will take the user's response and remove all spacing and foreign characters to be used to compare against the correct answer
        'there are some inheient flaws, such as if the user enters 'SEL ECT' vs 'SELECT' they will still get the answer correct when infact it would be wrong
        Dim UserResponse As String = Regex.Replace(ActivityTextBox.Text, "[^A-Za-z0-9\-='*,/]+?", "")

        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)


        If (String.Compare(UserResponse.Replace(" ", ""), ActivityAnswerHF.Value.Replace(" ", ""), True) = 0) Then
            'point = 1
            ActivityResponseLabel.Text = "Great Job! <br /> Your Answer is Correct"
            ActivityIsCorrectHF.Value = "Yes"
            updateGrid(ActivityAnswerHF.Value)
        Else
            ActivityResponseLabel.Text = "Your Answer is Incorrect. <br /> Don't Give Up! Please Try Again!"
            updateGrid("")
        End If


        Dim ResponsesSql As String = "INSERT INTO LessonAttempts(UserName, LessonId, DateAttempted, UserResposne, IsCorrect) VALUES (@UserName, @LessonId, @DateAttempted, @UserResposne, @IsCorrect)"
        Dim cmd As OleDbCommand = New OleDb.OleDbCommand(ResponsesSql, oleDbCon)
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@UserName", User.Identity.Name)
        cmd.Parameters.AddWithValue("@LessonId", LessonIdHF.Value)
        cmd.Parameters.AddWithValue("@DateAttempted", System.DateTime.Now())
        cmd.Parameters.AddWithValue("@UserResponse", UserResponse)
        'cmd.Parameters.AddWithValue("@IsCorrect", point)

        oleDbCon.Open()
        'cmd.ExecuteNonQuery()
        oleDbCon.Close()

    End Sub

    Protected Sub updateGrid(sql As String)
        ActivitySqlDataSource.DataSourceMode = SqlDataSourceMode.DataReader
        ActivitySqlDataSource.SelectCommand = sql 'new query to run
        ActivityResultsGridView.DataSource = ActivitySqlDataSource
        ActivityResultsGridView.AutoGenerateColumns = True
        ActivityResultsGridView.DataBind()
    End Sub
End Class