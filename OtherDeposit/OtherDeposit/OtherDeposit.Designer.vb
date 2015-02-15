<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherDeposit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NamaBank = New System.Windows.Forms.ComboBox()
        Me.NomorBank = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVoucher = New System.Windows.Forms.TextBox()
        Me.DepositTime = New System.Windows.Forms.DateTimePicker()
        Me.rtbMemo = New System.Windows.Forms.RichTextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DbrobindatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_robindataset = New WindowsApplication1.db_robindataset()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KodeLedger = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NamaLedger = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DepositGrid = New System.Windows.Forms.DataGridView()
        Me.DEPOSITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPOSITTableAdapter = New WindowsApplication1.db_robindatasetTableAdapters.DEPOSITTableAdapter()
        Me.IdBankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoAkunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAkunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DbrobindatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_robindataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DepositGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPOSITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(21, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Other Deposit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(58, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Deposit To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(25, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Voucher No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(25, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(25, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Memo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(24, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Salmon
        Me.Label7.Location = New System.Drawing.Point(80, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(351, 56)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cash and Bank"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.NamaBank)
        Me.Panel1.Controls.Add(Me.NomorBank)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 100)
        Me.Panel1.TabIndex = 8
        '
        'NamaBank
        '
        Me.NamaBank.FormattingEnabled = True
        Me.NamaBank.Location = New System.Drawing.Point(262, 64)
        Me.NamaBank.Name = "NamaBank"
        Me.NamaBank.Size = New System.Drawing.Size(175, 21)
        Me.NamaBank.TabIndex = 9
        '
        'NomorBank
        '
        Me.NomorBank.BackColor = System.Drawing.Color.Salmon
        Me.NomorBank.Location = New System.Drawing.Point(139, 65)
        Me.NomorBank.Name = "NomorBank"
        Me.NomorBank.ReadOnly = True
        Me.NomorBank.Size = New System.Drawing.Size(100, 20)
        Me.NomorBank.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Moccasin
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(469, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 100)
        Me.Panel2.TabIndex = 0
        '
        'txtVoucher
        '
        Me.txtVoucher.BackColor = System.Drawing.Color.Salmon
        Me.txtVoucher.Location = New System.Drawing.Point(160, 133)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(206, 20)
        Me.txtVoucher.TabIndex = 10
        '
        'DepositTime
        '
        Me.DepositTime.Location = New System.Drawing.Point(160, 168)
        Me.DepositTime.Name = "DepositTime"
        Me.DepositTime.Size = New System.Drawing.Size(136, 20)
        Me.DepositTime.TabIndex = 11
        '
        'rtbMemo
        '
        Me.rtbMemo.Location = New System.Drawing.Point(160, 221)
        Me.rtbMemo.Name = "rtbMemo"
        Me.rtbMemo.Size = New System.Drawing.Size(240, 61)
        Me.rtbMemo.TabIndex = 12
        Me.rtbMemo.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(160, 310)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(206, 20)
        Me.txtAmount.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.DepositGrid)
        Me.Panel3.Location = New System.Drawing.Point(0, 352)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(945, 153)
        Me.Panel3.TabIndex = 14
        '
        'DbrobindatasetBindingSource
        '
        Me.DbrobindatasetBindingSource.DataSource = Me.Db_robindataset
        Me.DbrobindatasetBindingSource.Position = 0
        '
        'Db_robindataset
        '
        Me.Db_robindataset.DataSetName = "db_robindataset"
        Me.Db_robindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KodeLedger)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NamaLedger)
        Me.GroupBox1.Location = New System.Drawing.Point(469, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 180)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Ledger"
        '
        'KodeLedger
        '
        Me.KodeLedger.BackColor = System.Drawing.Color.Salmon
        Me.KodeLedger.Location = New System.Drawing.Point(170, 107)
        Me.KodeLedger.Name = "KodeLedger"
        Me.KodeLedger.ReadOnly = True
        Me.KodeLedger.Size = New System.Drawing.Size(261, 20)
        Me.KodeLedger.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 30)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "No. Ledger"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(6, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "General Ledger"
        '
        'NamaLedger
        '
        Me.NamaLedger.FormattingEnabled = True
        Me.NamaLedger.Location = New System.Drawing.Point(170, 41)
        Me.NamaLedger.Name = "NamaLedger"
        Me.NamaLedger.Size = New System.Drawing.Size(261, 21)
        Me.NamaLedger.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(771, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(852, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Tutup"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(690, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DepositGrid
        '
        Me.DepositGrid.AutoGenerateColumns = False
        Me.DepositGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepositGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBankDataGridViewTextBoxColumn, Me.NamabankDataGridViewTextBoxColumn, Me.NoAkunDataGridViewTextBoxColumn, Me.NamaAkunDataGridViewTextBoxColumn, Me.VoucherNumberDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.MemoDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DepositGrid.DataSource = Me.DEPOSITBindingSource
        Me.DepositGrid.Location = New System.Drawing.Point(-9, 0)
        Me.DepositGrid.Name = "DepositGrid"
        Me.DepositGrid.Size = New System.Drawing.Size(951, 150)
        Me.DepositGrid.TabIndex = 0
        '
        'DEPOSITBindingSource
        '
        Me.DEPOSITBindingSource.DataMember = "DEPOSIT"
        Me.DEPOSITBindingSource.DataSource = Me.DbrobindatasetBindingSource
        '
        'DEPOSITTableAdapter
        '
        Me.DEPOSITTableAdapter.ClearBeforeFill = True
        '
        'IdBankDataGridViewTextBoxColumn
        '
        Me.IdBankDataGridViewTextBoxColumn.DataPropertyName = "Id_Bank"
        Me.IdBankDataGridViewTextBoxColumn.HeaderText = "No Bank"
        Me.IdBankDataGridViewTextBoxColumn.Name = "IdBankDataGridViewTextBoxColumn"
        '
        'NamabankDataGridViewTextBoxColumn
        '
        Me.NamabankDataGridViewTextBoxColumn.DataPropertyName = "Nama_bank"
        Me.NamabankDataGridViewTextBoxColumn.HeaderText = "Nama bank"
        Me.NamabankDataGridViewTextBoxColumn.Name = "NamabankDataGridViewTextBoxColumn"
        '
        'NoAkunDataGridViewTextBoxColumn
        '
        Me.NoAkunDataGridViewTextBoxColumn.DataPropertyName = "No_Akun"
        Me.NoAkunDataGridViewTextBoxColumn.HeaderText = "No Akun"
        Me.NoAkunDataGridViewTextBoxColumn.Name = "NoAkunDataGridViewTextBoxColumn"
        '
        'NamaAkunDataGridViewTextBoxColumn
        '
        Me.NamaAkunDataGridViewTextBoxColumn.DataPropertyName = "Nama_Akun"
        Me.NamaAkunDataGridViewTextBoxColumn.HeaderText = "Nama Akun"
        Me.NamaAkunDataGridViewTextBoxColumn.Name = "NamaAkunDataGridViewTextBoxColumn"
        '
        'VoucherNumberDataGridViewTextBoxColumn
        '
        Me.VoucherNumberDataGridViewTextBoxColumn.DataPropertyName = "Voucher_Number"
        Me.VoucherNumberDataGridViewTextBoxColumn.HeaderText = "Voucher Number"
        Me.VoucherNumberDataGridViewTextBoxColumn.Name = "VoucherNumberDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'MemoDataGridViewTextBoxColumn
        '
        Me.MemoDataGridViewTextBoxColumn.DataPropertyName = "Memo"
        Me.MemoDataGridViewTextBoxColumn.HeaderText = "Memo"
        Me.MemoDataGridViewTextBoxColumn.Name = "MemoDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 250
        '
        'OtherDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(942, 503)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.rtbMemo)
        Me.Controls.Add(Me.DepositTime)
        Me.Controls.Add(Me.txtVoucher)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "OtherDeposit"
        Me.Text = "OtherDeposit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DbrobindatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_robindataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DepositGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPOSITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NamaBank As System.Windows.Forms.ComboBox
    Friend WithEvents NomorBank As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents DepositTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents rtbMemo As System.Windows.Forms.RichTextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DbrobindatasetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_robindataset As WindowsApplication1.db_robindataset
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NamaLedger As System.Windows.Forms.ComboBox
    Friend WithEvents KodeLedger As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DepositGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DEPOSITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEPOSITTableAdapter As WindowsApplication1.db_robindatasetTableAdapters.DEPOSITTableAdapter
    Friend WithEvents IdBankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamabankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoAkunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAkunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
