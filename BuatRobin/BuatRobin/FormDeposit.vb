Imports System.Data.SqlClient
Public Class FormDeposit

    Private Sub FormDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isicombo()
        Call isigeneralledger()

    End Sub
    Private Sub isicombo()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select namaBank from BANK", cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr("namaBank").ToString.Trim)
        End While
    End Sub
    Private Sub isigeneralledger()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select namaAkun from AKUN", cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox2.Items.Add(dr("namaAkun").ToString.Trim)
        End While
    End Sub
    Private Sub isikodetext()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("select kodeBank from BANK where namaBank = @namabank", cn)
        Dim dr As SqlDataReader
        'cmd = New SqlCommand("select kodeBank from BANK where namaBank = '" + ComboBox1.SelectedValue.ToString + "'", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@namabank", SqlDbType.NVarChar).Value = ComboBox1.SelectedItem.ToString
        'cmd.Parameters("@namabank").Value = ComboBox1.SelectedItem.ToString
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox1.Text = String.Format(dr("kodeBank").ToString)
        End While
    End Sub
    Private Sub isikodegl()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("select noAkun from AKUN where namaAkun = @namaakun", cn)
        Dim dr As SqlDataReader
        'cmd = New SqlCommand("select kodeBank from BANK where namaBank = '" + ComboBox1.SelectedValue.ToString + "'", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@namaakun", SqlDbType.NVarChar).Value = ComboBox2.SelectedItem.ToString
        'cmd.Parameters("@namaakun").Value = ComboBox2.SelectedItem.ToString
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox2.Text = String.Format(dr("noAkun").ToString)
        End While
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call isikodetext()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call isikodegl()
    End Sub
End Class
