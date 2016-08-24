Imports System.Data.OleDb

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then 'IF THE PAGE LOADS FOR THE FIRST TIME
            LessonContentPanel.Visible = False

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
            LikeButton.Text = "LIKE"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "LIKED"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub IntroButton_Click(sender As Object, e As EventArgs) Handles IntroButton.Click
        LessonContentPanel.Visible = True

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
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

        ContentsLabel.Text = Contents

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
            LikeButton.Text = "LIKE"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "LIKED"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        LessonContentPanel.Visible = True


        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentql As String = "SELECT * FROM [Lessons]  WHERE LessonId=2"
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

        ContentsLabel.Text = Contents

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
            LikeButton.Text = "LIKE"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "LIKED"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        LessonContentPanel.Visible = True

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentql As String = "SELECT * FROM [Lessons]  WHERE LessonId=3"
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

        ContentsLabel.Text = Contents

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
            LikeButton.Text = "LIKE"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "LIKED"
            LikeButton.Enabled = False
        End If
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        LessonContentPanel.Visible = True


        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonContentql As String = "SELECT * FROM [Lessons]  WHERE LessonId=4"
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

        ContentsLabel.Text = Contents

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
            LikeButton.Text = "LIKE"
            LikeButton.Enabled = True
        Else
            LikeButton.Text = "LIKED"
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
            LikeButton.Text = "LIKED"
            LikeButton.Enabled = False
        End If


    End Sub
End Class