Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports System.Configuration
Imports System.Windows.Forms.Design

Public Class MembershipSearchForm

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CarwashDB").ConnectionString

    Dim conn As New MySqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            MessageBox.Show("Connected successfully!")
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Try

            conn.Open()
            Dim query As String = "SELECT *, CASE WHEN NextPayment < CURDATE() THEN 'Canceled' ELSE 'Active' END AS Status FROM Customer"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvMemberhipsTable.DataSource = table
            dgvMemberhipsTable.Columns("CustomerID").Visible = False


            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnAddMembership_Click(sender As Object, e As EventArgs) Handles btnAddMembership.Click
        Dim addFrm As New AddMembershipForm()
        addFrm.ShowDialog()
    End Sub

    Private Sub dgvMemberhipsTable_DoubleClick(sender As Object, e As EventArgs) Handles dgvMemberhipsTable.DoubleClick
        Dim editFrm As New Edit()
        editFrm.CustomerID = dgvMemberhipsTable.SelectedRows(0).Cells("CustomerID").Value
        editFrm.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = ""
        Dim search = txtSearch.Text

        Try
            conn.Open()

            Dim searchQueryCmd As MySqlCommand = Nothing
            If cbSearchBy.SelectedItem Is Nothing Then
                searchQuery = ("SELECT *, CASE WHEN NextPayment < CURDATE() THEN 'Canceled' ELSE 'Active' END AS Status FROM Customer")
                searchQueryCmd = New MySqlCommand(searchQuery, conn)
            Else
                Select Case cbSearchBy.SelectedItem.ToString()
                    Case "RFID"
                        searchQuery = ("SELECT *, CASE WHEN NextPayment < CURDATE() THEN 'Canceled' ELSE 'Active' END AS Status FROM Customer cu JOIN Memberships me ON cu.CustomerID = me.CustomerID WHERE me.RFIDNumber = @search")
                        searchQueryCmd = New MySqlCommand(searchQuery, conn)
                        searchQueryCmd.Parameters.AddWithValue("@search", search)
                    Case "First Name"
                        searchQuery = ("SELECT *, CASE WHEN NextPayment < CURDATE() THEN 'Canceled' ELSE 'Active' END AS Status FROM Customer WHERE FirstName LIKE @search")
                        searchQueryCmd = New MySqlCommand(searchQuery, conn)
                        searchQueryCmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    Case "Last Name"
                        searchQuery = ("SELECT *, CASE WHEN NextPayment < CURDATE() THEN 'Canceled' ELSE 'Active' END AS Status FROM Customer WHERE LastName LIKE @search")
                        searchQueryCmd = New MySqlCommand(searchQuery, conn)
                        searchQueryCmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    Case "CC Last 4"
                        searchQuery = ("SELECT *, CASE WHEN NextPayment < CURDATE() THEN 'Canceled' ELSE 'Active' END AS Status FROM Customer WHERE CCLast4 = @search")
                        searchQueryCmd = New MySqlCommand(searchQuery, conn)
                        searchQueryCmd.Parameters.AddWithValue("@search", search)
                End Select
            End If

            Dim adapter As New MySqlDataAdapter(searchQueryCmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvMemberhipsTable.DataSource = table
            dgvMemberhipsTable.Columns("CustomerID").Visible = False

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
End Class
