Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class AddGame
    Dim Games As New Games

    Dim currentGame As New Games
    Dim lastId As Integer

    Private Sub btnAddGame_Click(sender As Object, e As EventArgs) Handles btnAddGame.Click
        'Checking input, is nothing doesn't seem to work?
        If (Not txtGame.Text = "" And Not txtSystem.Text = "") Then
            Dim dbConnection = openDbConnection()
            Dim insertGame = prepareInsert(dbConnection)

            Try
                Dim rowsAffected = insertGame.ExecuteNonQuery()

                If rowsAffected = 1 Then
                    currentGame.Id = lastId
                    lastId += 1
                    MessageBox.Show(txtGame.Text & " was successfully saved")
                Else
                    MessageBox.Show(txtGame.Text & " was not saved")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            dbConnection.Close()
            dbConnection.Dispose()
        Else
            MessageBox.Show("Insert a game and system!")
        End If
    End Sub

    Private Function prepareInsert(dbConnection As SqlConnection) As SqlCommand
        Dim sqlString As String = "INSERT INTO GameInfo (Name, System) VALUES (@Name, @System)"
        Dim insertGame As New SqlCommand(sqlString, dbConnection)

        insertGame.Parameters.AddWithValue("Name", txtGame.Text)
        insertGame.Parameters.AddWithValue("System", txtSystem.Text)

        Return insertGame
    End Function

    Private Function openDbConnection() As SqlConnection
        Dim connectionString As String = "Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Games.mdf;Integrated Security=True"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()
        Return dbConnection
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Refreshes and opens other form
        MessageBox.Show("Adding Games...")
        GameSelector.Show()
        Me.Close()
    End Sub
End Class