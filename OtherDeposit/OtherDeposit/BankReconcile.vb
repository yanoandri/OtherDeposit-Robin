Imports System.Data.SqlClient
Public Class bankreconcile
    Private Sub isinamabank()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select namaBank from BANK", cn)
        cmd.CommandType = CommandType.Text
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            cmbNamaBank.Items.Add(dr("namaBank").ToString.Trim)
        End While
    End Sub
    Private Sub isikodebank()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("select kodeBank from BANK where namaBank = @namabank", cn)
        Dim dr As SqlDataReader
        'cmd = New SqlCommand("select kodeBank from BANK where namaBank = '" + ComboBox1.SelectedValue.ToString + "'", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@namabank", SqlDbType.NVarChar).Value = cmbNamaBank.SelectedItem.ToString
        'cmd.Parameters("@namabank").Value = ComboBox1.SelectedItem.ToString
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            txtKodeBank.Text = String.Format(dr("kodeBank").ToString)
        End While
    End Sub
    Private Sub tampilgrid()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM dbo.DEPOSIT d INNER JOIN dbo.PAYMENT p ON d.Nama_bank = p.Nama_bank where d.Nama_bank = @namabank and p.Nama_bank = @namabank ", cn)
        Dim dt = New DataTable
        'Dim dr As SqlDataReader
        'cmd = New SqlCommand("select * from DEPOSIT order by Voucher_Number asc", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@namabank", SqlDbType.NVarChar).Value = cmbNamaBank.SelectedItem.ToString
        cn.Open()
        dt.Load(cmd.ExecuteReader)
        ReconcileGrid.AutoGenerateColumns = True
        ReconcileGrid.DataSource = dt
        'DepositGrid.Refresh()
    End Sub

    Private Sub cmbNamaBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaBank.SelectedIndexChanged
        Call isikodebank()
        Call tampilgrid()
    End Sub

    Private Sub bankreconcile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_robindataset.RECONCILE' table. You can move, or remove it, as needed.
        'Me.RECONCILETableAdapter.Fill(Me.Db_robindataset.RECONCILE)
        Call isinamabank()
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As String = "SELECT d.Id_Bank AS 'Kode Bank',d.Nama_bank AS 'Nama Bank',d.No_Akun AS 'Nomor Akun', d.Nama_Akun AS 'Nama Akun', d.Voucher_Number AS 'Nomor Voucher', d.Amount AS 'Deposit Dr', d.Memo, d. Date, p.Id_Bank AS 'Kode Bank',p.Nama_bank AS 'Nama Bank',p.No_Akun AS 'Nomor Akun', p.Nama_Akun AS 'Nama Akun', p.Voucher_Number AS 'Nomor Voucher', p.Amount AS 'Withdrawal Cr', p.Memo, p.Date  FROM dbo.DEPOSIT d INNER JOIN dbo.PAYMENT p ON d.Nama_bank = p.Nama_bank"
        Dim da As New SqlDataAdapter(cmd, cn)
        Dim ds As New DataSet()
        cn.Open()
        da.Fill(ds, "reconcile")
        ReconcileGrid.DataSource = ds
        ReconcileGrid.DataMember = "reconcile"
        ReconcileGrid.Refresh()

        Dim chk As New DataGridViewCheckBoxColumn()
        ReconcileGrid.Columns.Add(chk)
        chk.HeaderText = "Clear"
        chk.Name = "chk"
    End Sub

    Private Sub cmbCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
        If cmbCurrency.SelectedItem.ToString = "USD" Then
            Dim hasil As Integer
            txtCalculatedBalance.Text = 9200
            hasil = Convert.ToInt64(txtNewBalance.Text) * Convert.ToInt64(txtCalculatedBalance.Text)
            txtOutBalance.Text = hasil
        Else
            Dim hasil As Integer
            txtCalculatedBalance.Text = 0
            hasil = Convert.ToInt64(txtNewBalance.Text) - Convert.ToInt64(txtCalculatedBalance.Text)
            txtOutBalance.Text = hasil
        End If
        'Call hitung()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO dbo.RECONCILE(Id_Bank, Nama_bank, Deskripsi, Currency, New_Balance, Rate, Amount, Date) VALUES(@idbank, @namabank, @deskripsi, @currency, @newbalance, @rate, @amount, @date)", cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@idbank", SqlDbType.VarChar).Value = txtKodeBank.Text.ToString
        cmd.Parameters.Add("@namabank", SqlDbType.VarChar).Value = cmbNamaBank.SelectedItem.ToString
        cmd.Parameters.Add("@deskripsi", SqlDbType.VarChar).Value = RichTextBox1.Text.ToString
        cmd.Parameters.Add("@currency", SqlDbType.VarChar).Value = cmbCurrency.SelectedItem.ToString
        cmd.Parameters.Add("@newbalance", SqlDbType.BigInt).Value = Val(txtNewBalance.Text)
        cmd.Parameters.Add("@rate", SqlDbType.BigInt).Value = Val(txtCalculatedBalance.Text)
        cmd.Parameters.Add("@amount", SqlDbType.BigInt).Value = Val(txtOutBalance.Text)
        cmd.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = dtReconcile.Value.ToLongDateString
        Dim dt As New DataTable
        cn.Open()
        dt.Load(cmd.ExecuteReader())
        MessageBox.Show("Data tersimpan!")
        'Call tampilgrid()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim row As New DataGridViewRow
        'Dim cn As New SqlConnection(My.MySettings.Default.db_robinConnectionString)
        For i As Integer = ReconcileGrid.Rows.Count - 1 To 0 Step -1
            If ReconcileGrid.Rows(i).Cells("chk").Value = True Then
                ReconcileGrid.Rows.Remove(ReconcileGrid.Rows(i))
            End If
        Next

    End Sub
End Class