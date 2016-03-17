Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class GameSelector
    Dim Games As New BindingList(Of Games)
    Dim randomNum As New Random

    Dim currentGame As New Games
    Dim currentSystem As New Games
    Dim path As String

    Private Sub GameSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the datasource for the list boxes, assigns the Game Name to Game List, Game System to System List
        lbxGameList.DataSource = Games
        lbxGameList.DisplayMember = "Name"

        lbxSystem.DataSource = Games
        lbxSystem.DisplayMember = "System"

        'Begin try catch to error check the DB connection
        Try
            Dim dbConnection = openDbConnection()

            Dim selectCommand As New SqlCommand("SELECT * FROM GameInfo", dbConnection)

            Dim reader As SqlDataReader = selectCommand.ExecuteReader

            'While there are more rows the reader continues...reading 
            If reader.HasRows Then
                While reader.Read
                    populateGameFromDB(reader)
                End While
            End If

            dbConnection.Close()
            dbConnection.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Values from the given columns
    Private Sub populateGameFromDB(reader As SqlDataReader)
        Dim newDbGame As New Games()

        newDbGame.Id = CInt(reader.Item("Id"))
        newDbGame.Name = reader.Item("Name").ToString
        newDbGame.System = reader.Item("System").ToString

        Games.Add(newDbGame)
    End Sub

    'Keeps the two list boxes selected items together
    Private Sub lbxGameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxGameList.SelectedIndexChanged
        currentGame = CType(lbxGameList.SelectedItem, Games)
        lblGame.Text = currentGame.Name

        currentSystem = CType(lbxSystem.SelectedItem, Games)
        lblSystem.Text = currentSystem.System
    End Sub

    'Seperate form for if the user wishes to add games, opens it and closes Game Selector so it may refresh its data
    Private Sub btnAddGame_Click(sender As Object, e As EventArgs) Handles btnAddGame.Click
        AddGame.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Startup.Close()
    End Sub



    Private Function openDbConnection() As SqlConnection
        Dim connectionString As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=C:\Users\Andrew\Desktop\Afrideres_Final\Afrideres_Final\Games.mdf"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()
        Return dbConnection
    End Function

    Private Function randomGame() As Integer
        'Checks the list box count
        Dim numOfGames = lbxGameList.Items.Count

        'Only runs if the list box has items
        If lbxGameList.Items.Count > 0 Then
            Return randomNum.Next(0, numOfGames)
        Else
            Return MessageBox.Show("Enter some games!")
        End If
    End Function

    Private Sub btnGameSelect_Click(sender As Object, e As EventArgs) Handles btnGameSelect.Click
        lbxGameList.SelectedIndex = randomGame()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (Not lbxGameList.SelectedItem Is Nothing) Then
            If Not currentGame.Id = 0 Then

                Dim dbConnection = openDbConnection()
                Dim sqlString = "DELETE FROM GameInfo WHERE Id = @Id"
                Dim deleteCommand As New SqlCommand(sqlString, dbConnection)

                deleteCommand.Parameters.AddWithValue("@Id", currentGame.Id)

                Try
                    Dim rowsAffected = deleteCommand.ExecuteNonQuery()

                    If rowsAffected = 1 Then
                        MessageBox.Show(currentGame.Name + " was successfully deleted")
                    Else
                        MessageBox.Show(currentGame.Name + " was Not deleted")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                dbConnection.Close()
                dbConnection.Dispose()
            End If

            Games.Remove(CType(lbxGameList.SelectedItem, Games))

        End If
    End Sub
End Class
