<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bankreconcile
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbNamaBank = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeBank = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewBalance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtReconcile = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCalculatedBalance = New System.Windows.Forms.TextBox()
        Me.txtOutBalance = New System.Windows.Forms.TextBox()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReconcileGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ReconcileGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmbNamaBank)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKodeBank)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 87)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Coral
        Me.Label12.Location = New System.Drawing.Point(23, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(331, 41)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Bank Reconciliation"
        '
        'cmbNamaBank
        '
        Me.cmbNamaBank.FormattingEnabled = True
        Me.cmbNamaBank.Location = New System.Drawing.Point(313, 54)
        Me.cmbNamaBank.Name = "cmbNamaBank"
        Me.cmbNamaBank.Size = New System.Drawing.Size(536, 21)
        Me.cmbNamaBank.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(26, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bank Account:"
        '
        'txtKodeBank
        '
        Me.txtKodeBank.BackColor = System.Drawing.Color.Salmon
        Me.txtKodeBank.Location = New System.Drawing.Point(124, 55)
        Me.txtKodeBank.Name = "txtKodeBank"
        Me.txtKodeBank.ReadOnly = True
        Me.txtKodeBank.Size = New System.Drawing.Size(143, 20)
        Me.txtKodeBank.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(28, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Statement Balance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(26, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Calculated  Statement Balance"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(28, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Out of Balance :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(477, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Currency"
        '
        'txtNewBalance
        '
        Me.txtNewBalance.BackColor = System.Drawing.Color.Salmon
        Me.txtNewBalance.Location = New System.Drawing.Point(274, 120)
        Me.txtNewBalance.Name = "txtNewBalance"
        Me.txtNewBalance.Size = New System.Drawing.Size(143, 20)
        Me.txtNewBalance.TabIndex = 9
        Me.txtNewBalance.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(477, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Reconcile Bank"
        '
        'dtReconcile
        '
        Me.dtReconcile.Location = New System.Drawing.Point(650, 160)
        Me.dtReconcile.Name = "dtReconcile"
        Me.dtReconcile.Size = New System.Drawing.Size(200, 20)
        Me.dtReconcile.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(767, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(767, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Moccasin
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(1, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 68)
        Me.Panel2.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(821, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(740, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(659, 24)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Salmon
        Me.Label13.Location = New System.Drawing.Point(11, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(351, 56)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Cash and Bank"
        '
        'txtCalculatedBalance
        '
        Me.txtCalculatedBalance.Location = New System.Drawing.Point(316, 164)
        Me.txtCalculatedBalance.Name = "txtCalculatedBalance"
        Me.txtCalculatedBalance.ReadOnly = True
        Me.txtCalculatedBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtCalculatedBalance.TabIndex = 18
        Me.txtCalculatedBalance.Text = "0"
        '
        'txtOutBalance
        '
        Me.txtOutBalance.Location = New System.Drawing.Point(316, 205)
        Me.txtOutBalance.Name = "txtOutBalance"
        Me.txtOutBalance.ReadOnly = True
        Me.txtOutBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtOutBalance.TabIndex = 19
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Items.AddRange(New Object() {"USD", "IDR"})
        Me.cmbCurrency.Location = New System.Drawing.Point(683, 123)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(167, 21)
        Me.cmbCurrency.TabIndex = 13
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(650, 200)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 38)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(477, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Description"
        '
        'ReconcileGrid
        '
        Me.ReconcileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReconcileGrid.Location = New System.Drawing.Point(1, 244)
        Me.ReconcileGrid.Name = "ReconcileGrid"
        Me.ReconcileGrid.Size = New System.Drawing.Size(899, 150)
        Me.ReconcileGrid.TabIndex = 23
        '
        'bankreconcile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(899, 460)
        Me.Controls.Add(Me.ReconcileGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.cmbCurrency)
        Me.Controls.Add(Me.txtOutBalance)
        Me.Controls.Add(Me.txtCalculatedBalance)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtReconcile)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNewBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "bankreconcile"
        Me.Text = "BankReconciliation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ReconcileGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbNamaBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBank As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtReconcile As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCalculatedBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtOutBalance As System.Windows.Forms.TextBox
    Friend WithEvents cmbCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents ReconcileGrid As System.Windows.Forms.DataGridView
End Class
