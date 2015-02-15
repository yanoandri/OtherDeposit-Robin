<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherPayment
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVoucher = New System.Windows.Forms.TextBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.checkVoid = New System.Windows.Forms.CheckBox()
        Me.dtPayment = New System.Windows.Forms.DateTimePicker()
        Me.rbPayee = New System.Windows.Forms.RichTextBox()
        Me.rbMemo = New System.Windows.Forms.RichTextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PaymentGrid = New System.Windows.Forms.DataGridView()
        Me.IdBankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoAkunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAkunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoidChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_robindataset = New WindowsApplication1.db_robindataset()
        Me.PAYMENTTableAdapter = New WindowsApplication1.db_robindatasetTableAdapters.PAYMENTTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNamaBank = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtKodebank = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbNamaAkun = New System.Windows.Forms.ComboBox()
        Me.txtKodeakun = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PaymentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAYMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_robindataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(8, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Voucher No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cheque No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(12, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(12, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Memo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(13, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Payee"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(537, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Amount"
        '
        'txtVoucher
        '
        Me.txtVoucher.BackColor = System.Drawing.Color.Salmon
        Me.txtVoucher.Location = New System.Drawing.Point(97, 113)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(205, 20)
        Me.txtVoucher.TabIndex = 8
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(97, 146)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(208, 20)
        Me.txtCheque.TabIndex = 9
        '
        'checkVoid
        '
        Me.checkVoid.AutoSize = True
        Me.checkVoid.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkVoid.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.checkVoid.Location = New System.Drawing.Point(325, 112)
        Me.checkVoid.Name = "checkVoid"
        Me.checkVoid.Size = New System.Drawing.Size(109, 25)
        Me.checkVoid.TabIndex = 10
        Me.checkVoid.Text = "Void Cheque"
        Me.checkVoid.UseVisualStyleBackColor = True
        '
        'dtPayment
        '
        Me.dtPayment.CalendarMonthBackground = System.Drawing.Color.Salmon
        Me.dtPayment.Location = New System.Drawing.Point(97, 181)
        Me.dtPayment.Name = "dtPayment"
        Me.dtPayment.Size = New System.Drawing.Size(140, 20)
        Me.dtPayment.TabIndex = 11
        '
        'rbPayee
        '
        Me.rbPayee.Location = New System.Drawing.Point(97, 278)
        Me.rbPayee.Name = "rbPayee"
        Me.rbPayee.Size = New System.Drawing.Size(337, 47)
        Me.rbPayee.TabIndex = 13
        Me.rbPayee.Text = ""
        '
        'rbMemo
        '
        Me.rbMemo.Location = New System.Drawing.Point(97, 220)
        Me.rbMemo.Name = "rbMemo"
        Me.rbMemo.Size = New System.Drawing.Size(337, 52)
        Me.rbMemo.TabIndex = 15
        Me.rbMemo.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.Salmon
        Me.txtAmount.Location = New System.Drawing.Point(617, 220)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(140, 20)
        Me.txtAmount.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Moccasin
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(533, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 94)
        Me.Panel2.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Salmon
        Me.Label11.Location = New System.Drawing.Point(166, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 38)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Bank"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Salmon
        Me.Label10.Location = New System.Drawing.Point(77, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 38)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "and"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Salmon
        Me.Label9.Location = New System.Drawing.Point(7, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 38)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cash"
        '
        'PaymentGrid
        '
        Me.PaymentGrid.AutoGenerateColumns = False
        Me.PaymentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBankDataGridViewTextBoxColumn, Me.NamabankDataGridViewTextBoxColumn, Me.NoAkunDataGridViewTextBoxColumn, Me.NamaAkunDataGridViewTextBoxColumn, Me.VoucherNumberDataGridViewTextBoxColumn, Me.ChequeNumberDataGridViewTextBoxColumn, Me.VoidChequeDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.MemoDataGridViewTextBoxColumn, Me.PayeeDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.PaymentGrid.DataSource = Me.PAYMENTBindingSource
        Me.PaymentGrid.Location = New System.Drawing.Point(1, 342)
        Me.PaymentGrid.Name = "PaymentGrid"
        Me.PaymentGrid.Size = New System.Drawing.Size(846, 151)
        Me.PaymentGrid.TabIndex = 18
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
        Me.NamabankDataGridViewTextBoxColumn.HeaderText = "Bank"
        Me.NamabankDataGridViewTextBoxColumn.Name = "NamabankDataGridViewTextBoxColumn"
        '
        'NoAkunDataGridViewTextBoxColumn
        '
        Me.NoAkunDataGridViewTextBoxColumn.DataPropertyName = "No_Akun"
        Me.NoAkunDataGridViewTextBoxColumn.HeaderText = "No Account"
        Me.NoAkunDataGridViewTextBoxColumn.Name = "NoAkunDataGridViewTextBoxColumn"
        '
        'NamaAkunDataGridViewTextBoxColumn
        '
        Me.NamaAkunDataGridViewTextBoxColumn.DataPropertyName = "Nama_Akun"
        Me.NamaAkunDataGridViewTextBoxColumn.HeaderText = "Account Name"
        Me.NamaAkunDataGridViewTextBoxColumn.Name = "NamaAkunDataGridViewTextBoxColumn"
        '
        'VoucherNumberDataGridViewTextBoxColumn
        '
        Me.VoucherNumberDataGridViewTextBoxColumn.DataPropertyName = "Voucher_Number"
        Me.VoucherNumberDataGridViewTextBoxColumn.HeaderText = "Voucher Number"
        Me.VoucherNumberDataGridViewTextBoxColumn.Name = "VoucherNumberDataGridViewTextBoxColumn"
        '
        'ChequeNumberDataGridViewTextBoxColumn
        '
        Me.ChequeNumberDataGridViewTextBoxColumn.DataPropertyName = "Cheque_Number"
        Me.ChequeNumberDataGridViewTextBoxColumn.HeaderText = "Cheque Number"
        Me.ChequeNumberDataGridViewTextBoxColumn.Name = "ChequeNumberDataGridViewTextBoxColumn"
        '
        'VoidChequeDataGridViewTextBoxColumn
        '
        Me.VoidChequeDataGridViewTextBoxColumn.DataPropertyName = "Void_Cheque"
        Me.VoidChequeDataGridViewTextBoxColumn.HeaderText = "Void Cheque"
        Me.VoidChequeDataGridViewTextBoxColumn.Name = "VoidChequeDataGridViewTextBoxColumn"
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
        'PayeeDataGridViewTextBoxColumn
        '
        Me.PayeeDataGridViewTextBoxColumn.DataPropertyName = "Payee"
        Me.PayeeDataGridViewTextBoxColumn.HeaderText = "Payee"
        Me.PayeeDataGridViewTextBoxColumn.Name = "PayeeDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'PAYMENTBindingSource
        '
        Me.PAYMENTBindingSource.DataMember = "PAYMENT"
        Me.PAYMENTBindingSource.DataSource = Me.Db_robindataset
        '
        'Db_robindataset
        '
        Me.Db_robindataset.DataSetName = "db_robindataset"
        Me.Db_robindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAYMENTTableAdapter
        '
        Me.PAYMENTTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Other Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Paid From"
        '
        'cmbNamaBank
        '
        Me.cmbNamaBank.FormattingEnabled = True
        Me.cmbNamaBank.Location = New System.Drawing.Point(269, 51)
        Me.cmbNamaBank.Name = "cmbNamaBank"
        Me.cmbNamaBank.Size = New System.Drawing.Size(201, 21)
        Me.cmbNamaBank.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.cmbNamaBank)
        Me.Panel1.Controls.Add(Me.txtKodebank)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 98)
        Me.Panel1.TabIndex = 1
        '
        'txtKodebank
        '
        Me.txtKodebank.BackColor = System.Drawing.Color.Salmon
        Me.txtKodebank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKodebank.Location = New System.Drawing.Point(85, 52)
        Me.txtKodebank.Name = "txtKodebank"
        Me.txtKodebank.ReadOnly = True
        Me.txtKodebank.Size = New System.Drawing.Size(168, 20)
        Me.txtKodebank.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtKodeakun)
        Me.GroupBox1.Controls.Add(Me.cmbNamaAkun)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 100)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Ledger"
        '
        'cmbNamaAkun
        '
        Me.cmbNamaAkun.FormattingEnabled = True
        Me.cmbNamaAkun.Location = New System.Drawing.Point(96, 28)
        Me.cmbNamaAkun.Name = "cmbNamaAkun"
        Me.cmbNamaAkun.Size = New System.Drawing.Size(201, 21)
        Me.cmbNamaAkun.TabIndex = 20
        '
        'txtKodeakun
        '
        Me.txtKodeakun.BackColor = System.Drawing.Color.Salmon
        Me.txtKodeakun.Location = New System.Drawing.Point(136, 65)
        Me.txtKodeakun.Name = "txtKodeakun"
        Me.txtKodeakun.ReadOnly = True
        Me.txtKodeakun.Size = New System.Drawing.Size(161, 20)
        Me.txtKodeakun.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(4, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 21)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Account : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(6, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 21)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Account Code :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(761, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(599, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OtherPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(848, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PaymentGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.rbMemo)
        Me.Controls.Add(Me.rbPayee)
        Me.Controls.Add(Me.dtPayment)
        Me.Controls.Add(Me.checkVoid)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.txtVoucher)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OtherPayment"
        Me.Text = "OtherPayment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PaymentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAYMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_robindataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents checkVoid As System.Windows.Forms.CheckBox
    Friend WithEvents dtPayment As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbPayee As System.Windows.Forms.RichTextBox
    Friend WithEvents rbMemo As System.Windows.Forms.RichTextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PaymentGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Db_robindataset As WindowsApplication1.db_robindataset
    Friend WithEvents PAYMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAYMENTTableAdapter As WindowsApplication1.db_robindatasetTableAdapters.PAYMENTTableAdapter
    Friend WithEvents IdBankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamabankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoAkunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAkunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoidChequeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNamaBank As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtKodebank As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKodeakun As System.Windows.Forms.TextBox
    Friend WithEvents cmbNamaAkun As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
