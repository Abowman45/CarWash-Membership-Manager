Imports MySql.Data.MySqlClient
Imports System.Configuration


Public Class Edit
    Private Function ValidateInputs(cc As String, planType As String) As Boolean
        If cc.Length <> 4 OrElse Not cc.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("CC Last 4 must be exactly 4 digits.")
            Return False
        End If

        If planType Is Nothing Then
            MessageBox.Show("Please select a plan type.")
            Return False
        End If

        Return True
    End Function

    Public CustomerID As Integer
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CarwashDB").ConnectionString
    Dim conn As New MySqlConnection(connectionString)

    Private Sub LoadRFIDs()
        Dim rfidQuery As String = ("SELECT RFIDNumber, LicensePlate FROM Memberships WHERE CustomerID = @CustomerID")
        Dim rfidQueryCmd As New MySqlCommand(rfidQuery, conn)
        rfidQueryCmd.Parameters.AddWithValue("@CustomerID", CustomerID)
        Dim adapter As New MySqlDataAdapter(rfidQueryCmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvRFID.DataSource = table

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim fillQuery As String = ("SELECT FirstName, LastName, CCLast4, Plantype FROM Customer WHERE CustomerID = @CustomerID")
            Dim fillQueryCmd As New MySqlCommand(fillQuery, conn)
            fillQueryCmd.Parameters.AddWithValue("@CustomerID", CustomerID)

            Dim reader = fillQueryCmd.ExecuteReader()
            If reader.Read() Then
                txtFirstName.Text = reader("FirstName").ToString()
                txtLastName.Text = reader("LastName").ToString()
                txtCCLast4.Text = reader("CCLast4").ToString()
                cbPlanType.Text = reader("PlanType").ToString()
            End If
            reader.Close()

            LoadRFIDs()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        Dim editFrm As New Edit()
        AddVehicle.CustomerID = CustomerID
        AddVehicle.ShowDialog()
        LoadRFIDs()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim ccLast4 As String = txtCCLast4.Text
        Dim planType As String = cbPlanType.Text
        If Not ValidateInputs(ccLast4, planType) Then Exit Sub

        Try
            conn.Open()
            Dim saveQuery As String = ("UPDATE Customer SET FirstName = @firstName, LastName = @lastName, CCLast4 = @ccLast4, PlanType = @planType WHERE CustomerID = @CustomerID")
            Dim saveQueryCmd As New MySqlCommand(saveQuery, conn)
            saveQueryCmd.Parameters.AddWithValue("@firstName", firstName)
            saveQueryCmd.Parameters.AddWithValue("@lastName", lastName)
            saveQueryCmd.Parameters.AddWithValue("@ccLast4", ccLast4)
            saveQueryCmd.Parameters.AddWithValue("@planType", planType)
            saveQueryCmd.Parameters.AddWithValue("@CustomerId", CustomerID)
            saveQueryCmd.ExecuteNonQuery()
            MessageBox.Show("Customer updated successfully")
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnRemoveVehicle_Click(sender As Object, e As EventArgs) Handles btnRemoveVehicle.Click
        Dim rfidNumber As String = dgvRFID.SelectedRows(0).Cells("RFIDNumber").Value.ToString()

        Try
            conn.Open()
            Dim removeQuery As String = ("DELETE FROM Memberships WHERE RFIDNumber = @rfidNumber")
            Dim removeQueryCmd As New MySqlCommand(removeQuery, conn)
            removeQueryCmd.Parameters.AddWithValue("@rfidNumber", rfidNumber)
            removeQueryCmd.ExecuteNonQuery()
            MessageBox.Show("Vehicle Removed")
            LoadRFIDs()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        Try
            conn.Open()
            Dim renewQuery As New String("UPDATE Customer SET LastPayment = CURDATE(), NextPayment = DATE_ADD(CURDATE(), INTERVAL 1 MONTH) WHERE CustomerID = @customerID")
            Dim renewQueryCmd As New MySqlCommand(renewQuery, conn)
            renewQueryCmd.Parameters.AddWithValue("@customerID", CustomerID)
            renewQueryCmd.ExecuteNonQuery()
            MessageBox.Show("Membership renewed")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class