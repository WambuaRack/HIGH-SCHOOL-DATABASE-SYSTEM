<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admission
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.exp_datepicker = New System.Windows.Forms.DateTimePicker()
        Me.combo_dorm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.text_firstsname = New System.Windows.Forms.TextBox()
        Me.txt_sur = New System.Windows.Forms.TextBox()
        Me.text_form = New System.Windows.Forms.TextBox()
        Me.text_stream = New System.Windows.Forms.TextBox()
        Me.text_phonenumber = New System.Windows.Forms.TextBox()
        Me.txt_adm = New System.Windows.Forms.TextBox()
        Me.txt_firstname = New System.Windows.Forms.Label()
        Me.txt_surname = New System.Windows.Forms.Label()
        Me.txt_form = New System.Windows.Forms.Label()
        Me.txt_stream = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.Label()
        Me.txt_dorm = New System.Windows.Forms.Label()
        Me.txt_adm_no = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(3, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 649)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HIGH_SCHOOL_DATABASE.My.Resources.Resources._7749968
        Me.PictureBox1.Location = New System.Drawing.Point(20, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1324, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column7, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(538, 248)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(806, 364)
        Me.DataGridView1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.exp_datepicker)
        Me.Panel2.Controls.Add(Me.combo_dorm)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_reset)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.text_firstsname)
        Me.Panel2.Controls.Add(Me.txt_sur)
        Me.Panel2.Controls.Add(Me.text_form)
        Me.Panel2.Controls.Add(Me.text_stream)
        Me.Panel2.Controls.Add(Me.text_phonenumber)
        Me.Panel2.Controls.Add(Me.txt_adm)
        Me.Panel2.Controls.Add(Me.txt_firstname)
        Me.Panel2.Controls.Add(Me.txt_surname)
        Me.Panel2.Controls.Add(Me.txt_form)
        Me.Panel2.Controls.Add(Me.txt_stream)
        Me.Panel2.Controls.Add(Me.txt_phone)
        Me.Panel2.Controls.Add(Me.txt_dorm)
        Me.Panel2.Controls.Add(Me.txt_adm_no)
        Me.Panel2.Location = New System.Drawing.Point(13, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 464)
        Me.Panel2.TabIndex = 26
        '
        'exp_datepicker
        '
        Me.exp_datepicker.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exp_datepicker.Location = New System.Drawing.Point(248, 301)
        Me.exp_datepicker.Name = "exp_datepicker"
        Me.exp_datepicker.Size = New System.Drawing.Size(138, 22)
        Me.exp_datepicker.TabIndex = 42
        '
        'combo_dorm
        '
        Me.combo_dorm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_dorm.FormattingEnabled = True
        Me.combo_dorm.Items.AddRange(New Object() {"MULEI", "BUFFALO", "TIGER", "SIMBA", "GIRAFFE", "RHINO"})
        Me.combo_dorm.Location = New System.Drawing.Point(3, 304)
        Me.combo_dorm.Name = "combo_dorm"
        Me.combo_dorm.Size = New System.Drawing.Size(121, 23)
        Me.combo_dorm.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Date"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Maroon
        Me.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_reset.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(49, 385)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(135, 46)
        Me.btn_reset.TabIndex = 39
        Me.btn_reset.Text = "EXIT"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Maroon
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(273, 382)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(135, 49)
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "ADMIT"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'text_firstsname
        '
        Me.text_firstsname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_firstsname.Location = New System.Drawing.Point(137, 77)
        Me.text_firstsname.Margin = New System.Windows.Forms.Padding(4)
        Me.text_firstsname.Name = "text_firstsname"
        Me.text_firstsname.Size = New System.Drawing.Size(175, 22)
        Me.text_firstsname.TabIndex = 37
        '
        'txt_sur
        '
        Me.txt_sur.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sur.Location = New System.Drawing.Point(321, 77)
        Me.txt_sur.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sur.Name = "txt_sur"
        Me.txt_sur.Size = New System.Drawing.Size(175, 22)
        Me.txt_sur.TabIndex = 36
        '
        'text_form
        '
        Me.text_form.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_form.Location = New System.Drawing.Point(7, 192)
        Me.text_form.Margin = New System.Windows.Forms.Padding(4)
        Me.text_form.Name = "text_form"
        Me.text_form.Size = New System.Drawing.Size(96, 22)
        Me.text_form.TabIndex = 35
        '
        'text_stream
        '
        Me.text_stream.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_stream.Location = New System.Drawing.Point(137, 192)
        Me.text_stream.Margin = New System.Windows.Forms.Padding(4)
        Me.text_stream.Name = "text_stream"
        Me.text_stream.Size = New System.Drawing.Size(96, 22)
        Me.text_stream.TabIndex = 34
        '
        'text_phonenumber
        '
        Me.text_phonenumber.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_phonenumber.Location = New System.Drawing.Point(285, 196)
        Me.text_phonenumber.Margin = New System.Windows.Forms.Padding(4)
        Me.text_phonenumber.Name = "text_phonenumber"
        Me.text_phonenumber.Size = New System.Drawing.Size(224, 22)
        Me.text_phonenumber.TabIndex = 33
        '
        'txt_adm
        '
        Me.txt_adm.BackColor = System.Drawing.SystemColors.Window
        Me.txt_adm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adm.Location = New System.Drawing.Point(14, 77)
        Me.txt_adm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_adm.Name = "txt_adm"
        Me.txt_adm.Size = New System.Drawing.Size(96, 22)
        Me.txt_adm.TabIndex = 32
        '
        'txt_firstname
        '
        Me.txt_firstname.AutoSize = True
        Me.txt_firstname.BackColor = System.Drawing.Color.Crimson
        Me.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_firstname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstname.Location = New System.Drawing.Point(171, 46)
        Me.txt_firstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(84, 17)
        Me.txt_firstname.TabIndex = 31
        Me.txt_firstname.Text = "FIRST NAME"
        '
        'txt_surname
        '
        Me.txt_surname.AutoSize = True
        Me.txt_surname.BackColor = System.Drawing.Color.Crimson
        Me.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_surname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname.Location = New System.Drawing.Point(369, 46)
        Me.txt_surname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(70, 17)
        Me.txt_surname.TabIndex = 30
        Me.txt_surname.Text = "SURNAME"
        '
        'txt_form
        '
        Me.txt_form.AutoSize = True
        Me.txt_form.BackColor = System.Drawing.Color.DarkSalmon
        Me.txt_form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_form.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_form.Location = New System.Drawing.Point(14, 154)
        Me.txt_form.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_form.Name = "txt_form"
        Me.txt_form.Size = New System.Drawing.Size(46, 17)
        Me.txt_form.TabIndex = 29
        Me.txt_form.Text = "FORM"
        '
        'txt_stream
        '
        Me.txt_stream.AutoSize = True
        Me.txt_stream.BackColor = System.Drawing.Color.DarkSalmon
        Me.txt_stream.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_stream.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stream.Location = New System.Drawing.Point(157, 154)
        Me.txt_stream.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_stream.Name = "txt_stream"
        Me.txt_stream.Size = New System.Drawing.Size(61, 17)
        Me.txt_stream.TabIndex = 28
        Me.txt_stream.Text = "STREAM"
        '
        'txt_phone
        '
        Me.txt_phone.AutoSize = True
        Me.txt_phone.BackColor = System.Drawing.Color.DarkSalmon
        Me.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_phone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(285, 154)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(230, 17)
        Me.txt_phone.TabIndex = 27
        Me.txt_phone.Text = "PARENT/GUARDIAN PHONE NUMBER"
        '
        'txt_dorm
        '
        Me.txt_dorm.AutoSize = True
        Me.txt_dorm.BackColor = System.Drawing.Color.DarkSalmon
        Me.txt_dorm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_dorm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dorm.Location = New System.Drawing.Point(15, 273)
        Me.txt_dorm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_dorm.Name = "txt_dorm"
        Me.txt_dorm.Size = New System.Drawing.Size(87, 17)
        Me.txt_dorm.TabIndex = 26
        Me.txt_dorm.Text = "DORMITORY"
        '
        'txt_adm_no
        '
        Me.txt_adm_no.AutoSize = True
        Me.txt_adm_no.BackColor = System.Drawing.Color.Crimson
        Me.txt_adm_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_adm_no.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adm_no.Location = New System.Drawing.Point(30, 46)
        Me.txt_adm_no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_adm_no.Name = "txt_adm_no"
        Me.txt_adm_no.Size = New System.Drawing.Size(60, 17)
        Me.txt_adm_no.TabIndex = 25
        Me.txt_adm_no.Text = "ADM.NO"
        '
        'Column1
        '
        Me.Column1.HeaderText = "ADM .NO"
        Me.Column1.Name = "Column1"
        '
        'Column7
        '
        Me.Column7.HeaderText = "FIRST NAME"
        Me.Column7.Name = "Column7"
        '
        'Column2
        '
        Me.Column2.HeaderText = "SURNAME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PARENT PHONE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "STREAM"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "FORM"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DORMITORY"
        Me.Column6.Name = "Column6"
        '
        'admission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 659)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "admission"
        Me.Text = "admissio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents exp_datepicker As DateTimePicker
    Friend WithEvents combo_dorm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents text_firstsname As TextBox
    Friend WithEvents txt_sur As TextBox
    Friend WithEvents text_form As TextBox
    Friend WithEvents text_stream As TextBox
    Friend WithEvents text_phonenumber As TextBox
    Friend WithEvents txt_adm As TextBox
    Friend WithEvents txt_firstname As Label
    Friend WithEvents txt_surname As Label
    Friend WithEvents txt_form As Label
    Friend WithEvents txt_stream As Label
    Friend WithEvents txt_phone As Label
    Friend WithEvents txt_dorm As Label
    Friend WithEvents txt_adm_no As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
