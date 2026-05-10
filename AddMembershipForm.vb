Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class AddMembershipForm
    Private Function ValidateInputs(rfid As String, cc As String, plan As String) As Boolean
        If rfid.Length <> 9 OrElse Not rfid.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("RFID must be exactly 9 digits.")
            Return False
        End If

        If cc.Length <> 4 OrElse Not cc.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Credit Card last four digits only")
            Return False
        End If

        If String.IsNullOrEmpty(plan) Then
            MessageBox.Show("Please select a plan")
            Return False
        End If

        Return True

    End Function

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CarwashDB").ConnectionString
    Dim conn As New MySqlConnection(connectionString)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbPlanType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a plan type")
            Exit Sub
        End If

        Dim rfidNumber As String = txtRFID.Text
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim ccLast4 As String = txtCCLast4.Text
        Dim planType As String = cmbPlanType.SelectedItem.ToString()
        Dim licensePlate As String = txtLicensePlate.Text


        If Not ValidateInputs(rfidNumber, ccLast4, planType) Then Exit Sub

        ' MessageBox.Show(rfidNumber & " " & firstName & " " & lastName & " " & ccLast4)
        Try
            conn.Open()
            Dim insertCustomerCmd As String = ("INSERT INTO Customer (FirstName, LastName, CCLast4, PlanType, LastPayment, NextPayment) " &
                                           "VALUES (@firstName, @lastName, @ccLast4, @planType, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 1 MONTH))")

            Dim customerCmd As New MySqlCommand(insertCustomerCmd, conn)
            customerCmd.Parameters.AddWithValue("@firstName", firstName)
            customerCmd.Parameters.AddWithValue("@lastName", lastName)
            customerCmd.Parameters.AddWithValue("@ccLast4", ccLast4)
            customerCmd.Parameters.AddWithValue("@planType", planType)
            customerCmd.ExecuteNonQuery()
            Dim newCustomerID As Long = customerCmd.LastInsertedId                  'insert customer first to get customrid generated

            Dim insertMembershipsCmd As String = ("INSERT INTO Memberships (RFIDNumber, CustomerId, LicensePlate) " &
                                             "VALUES (@rfidNumber, @customerId, @licensePlate)")
            Dim membershipCmd As New MySqlCommand(insertMembershipsCmd, conn)
            membershipCmd.Parameters.AddWithValue("@rfidNumber", rfidNumber)
            membershipCmd.Parameters.AddWithValue("@customerId", newCustomerID)
            membershipCmd.Parameters.AddWithValue("@licensePlate", licensePlate)
            membershipCmd.ExecuteNonQuery()

            MessageBox.Show("Membership Successfully Added")
            Me.Close()
            conn.Close()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class