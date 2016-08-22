Imports System.Data.OleDb

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Panel1.Visible = False

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

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonNoteSql As String = "SELECT * FROM [Lessons] WHERE LessonId=1"
        Dim LessonNoteCmd As OleDbCommand = New OleDbCommand(LessonNoteSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonNoteAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonNoteData As New DataSet
        LessonNoteAdapter.SelectCommand = LessonNoteCmd
        LessonNoteAdapter.Fill(LessonNoteData)

        'create variables to store specific DataBase data
        Dim Notes = LessonNoteData.Tables(0).Rows(0).Item("LessonNotes").ToString

        'Close database connection
        oleDbCon.Close()

        NotesLabel.Text = Notes

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

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True


        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonNoteSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=2"
        Dim LessonNoteCmd As OleDbCommand = New OleDbCommand(LessonNoteSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonNoteAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonNoteData As New DataSet
        LessonNoteAdapter.SelectCommand = LessonNoteCmd
        LessonNoteAdapter.Fill(LessonNoteData)

        'create variables to store specific DataBase data
        Dim Notes = LessonNoteData.Tables(0).Rows(0).Item("LessonNotes").ToString

        'Close database connection
        oleDbCon.Close()

        NotesLabel.Text = Notes

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

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True

        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonNoteSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=3"
        Dim LessonNoteCmd As OleDbCommand = New OleDbCommand(LessonNoteSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonNoteAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonNoteData As New DataSet
        LessonNoteAdapter.SelectCommand = LessonNoteCmd
        LessonNoteAdapter.Fill(LessonNoteData)

        'create variables to store specific DataBase data
        Dim Notes = LessonNoteData.Tables(0).Rows(0).Item("LessonNotes").ToString

        'Close database connection
        oleDbCon.Close()

        NotesLabel.Text = Notes

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

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = True


        'create connection to database
        Dim oleDbCon As New OleDbConnection(ConfigurationManager.ConnectionStrings("ASPNetDB").ConnectionString)

        'Get the user's first and last name from the database using the user's username.
        'open database connection
        oleDbCon.Open()

        'creates SQL statement to obtain records
        Dim LessonNoteSql As String = "SELECT * FROM [Lessons]  WHERE LessonId=4"
        Dim LessonNoteCmd As OleDbCommand = New OleDbCommand(LessonNoteSql, oleDbCon)

        'create Adapter that grabs data from DB
        Dim LessonNoteAdapter As New OleDbDataAdapter

        'creates DataSet that stores captured DB data
        Dim LessonNoteData As New DataSet
        LessonNoteAdapter.SelectCommand = LessonNoteCmd
        LessonNoteAdapter.Fill(LessonNoteData)

        'create variables to store specific DataBase data
        Dim Notes = LessonNoteData.Tables(0).Rows(0).Item("LessonNotes").ToString

        'Close database connection
        oleDbCon.Close()

        NotesLabel.Text = Notes

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