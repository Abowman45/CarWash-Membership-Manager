Imports System.Configuration
Imports System.Drawing.Drawing2D
Imports Microsoft.Win32.SafeHandles
Imports MySql.Data.MySqlClient

Public Class AddVehicle

    Private Function ValidateInputs(rfid As String) As Boolean
        If rfid.Length <> 9 OrElse Not rfid.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("RFID must be exactly 9 digits.")
            Return False
        End If

        Return True
    End Function

    Public customerID As Integer
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CarwashDB").ConnectionString
    Dim conn As New MySqlConnection(connectionString)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rfidNumber As String = txtRfidNumber.Text
        Dim licensePlate As String = txtLicensePlate.Text

        If Not ValidateInputs(rfidNumber) Then Exit Sub

        Try
            conn.Open()
            Dim addQuery As String = ("INSERT INTO Memberships (RFIDNumber, LicensePlate, CustomerID) Values(@rfidNumber, @licensePlate, @customerID)")
            Dim addQueryCmd As New MySqlCommand(addQuery, conn)
            addQueryCmd.Parameters.AddWithValue("@rfidNumber", rfidNumber)
            addQueryCmd.Parameters.AddWithValue("@licensePlate", licensePlate)
            addQueryCmd.Parameters.AddWithValue("@customerID", customerID)
            addQueryCmd.ExecuteNonQuery()

            MessageBox.Show("Vehicle added")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class