Imports System.Data.SqlClient
Public Class OtherDeposit

    Private Sub OtherDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_robindataset.DEPOSIT' table. You can move, or remove it, as needed.
        Me.DEPOSITTableAdapter.Fill(Me.Db_robindataset.DEPOSIT)
        'TODO: This line of code loads data into the 'Db_robindataset.DEPOSIT' table. You can move, or remove it, as needed.
        'Me.DEPOSITTableAdapter.Fill(Me.Db_robindataset.DEPOSIT)
        Call isinamabank()
        Call isinamaledger()

    End Sub
    Private Sub NamaBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamaBank.SelectedIndexChanged
        Call isikodebank()
    End Sub
    Private Sub NamaLedger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamaLedger.SelectedIndexChanged
        Call isikodeledger()
    End Sub

    Private Sub isinamabank()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select namaBank from BANK", cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            NamaBank.Items.Add(dr("namaBank").ToString.Trim)
        End While
    End Sub
    Private Sub isikodebank()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("select kodeBank from BANK where namaBank = @namabank", cn)
        Dim dr As SqlDataReader
        'cmd = New SqlCommand("select kodeBank from BANK where namaBank = '" + ComboBox1.SelectedValue.ToString + "'", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@namabank", SqlDbType.NVarChar).Value = NamaBank.SelectedItem.ToString
        'cmd.Parameters("@namabank").Value = ComboBox1.SelectedItem.ToString
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            NomorBank.Text = String.Format(dr("kodeBank").ToString)
        End While
    End Sub
    Private Sub isinamaledger()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select namaAkun from AKUN", cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            NamaLedger.Items.Add(dr("namaAkun").ToString.Trim)
        End While
    End Sub
    Private Sub isikodeledger()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("select noAkun from AKUN where namaAkun = @namaakun", cn)
        Dim dr As SqlDataReader
        'cmd = New SqlCommand("select kodeBank from BANK where namaBank = '" + ComboBox1.SelectedValue.ToString + "'", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@namaakun", SqlDbType.NVarChar).Value = NamaLedger.SelectedItem.ToString
        'cmd.Parameters("@namaakun").Value = ComboBox2.SelectedItem.ToString
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            KodeLedger.Text = String.Format(dr("noAkun").ToString)
        End While
    End Sub
    Private Sub tampilgrid()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("select * from DEPOSIT order by Voucher_Number asc", cn)
        Dim dt = New DataTable
        'Dim dr As SqlDataReader
        'cmd = New SqlCommand("select * from DEPOSIT order by Voucher_Number asc", cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        dt.Load(cmd.ExecuteReader)
        DepositGrid.AutoGenerateColumns = True
        DepositGrid.DataSource = dt
        'DepositGrid.Refresh()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO dbo.DEPOSIT(Id_Bank, Nama_bank, No_Akun, Nama_Akun, Voucher_Number, Amount, Memo, Date) VALUES(@idbank, @namabank, @noakun, @namaakun, @novoucher, @amount, @memo, @date)", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@idbank", SqlDbType.VarChar).Value = NomorBank.Text.ToString
        cmd.Parameters.Add("@namabank", SqlDbType.VarChar).Value = NamaBank.SelectedItem.ToString
        cmd.Parameters.Add("@noakun", SqlDbType.VarChar).Value = KodeLedger.Text.ToString
        cmd.Parameters.Add("@namaakun", SqlDbType.VarChar).Value = NamaLedger.SelectedItem.ToString
        cmd.Parameters.Add("@novoucher", SqlDbType.VarChar).Value = txtVoucher.Text.ToString
        cmd.Parameters.Add("@amount", SqlDbType.BigInt).Value = Val(txtAmount.Text)
        cmd.Parameters.Add("@memo", SqlDbType.VarChar).Value = rtbMemo.Text.ToString
        cmd.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = DepositTime.Value.ToLongDateString
        Dim dt As New DataTable
        cn.Open()
        dt.Load(cmd.ExecuteReader())
        MessageBox.Show("Data tersimpan!")
        Call tampilgrid()
    End Sub
End Class
