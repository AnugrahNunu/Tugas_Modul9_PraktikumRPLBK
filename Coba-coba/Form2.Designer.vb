<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Add = New Button()
        Update = New Button()
        Delete = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox7 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Add
        ' 
        Add.Location = New Point(630, 60)
        Add.Name = "Add"
        Add.Size = New Size(75, 23)
        Add.TabIndex = 0
        Add.Text = "Add"
        Add.UseVisualStyleBackColor = True
        ' 
        ' Update
        ' 
        Update.Location = New Point(630, 114)
        Update.Name = "Update"
        Update.Size = New Size(75, 23)
        Update.TabIndex = 1
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = True
        ' 
        ' Delete
        ' 
        Delete.Location = New Point(630, 176)
        Delete.Name = "Delete"
        Delete.Size = New Size(75, 23)
        Delete.TabIndex = 2
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(192, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(355, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(192, 115)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(355, 115)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 7
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(192, 177)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 10
        Label1.Text = "Username Baru"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(355, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 11
        Label2.Text = "Password Baru"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(355, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 12
        Label3.Text = "Ubah Username"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(493, 115)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(493, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 14
        Label4.Text = "Ubah Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(192, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 15
        Label5.Text = "ID Target"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(192, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 16
        Label6.Text = "ID Target"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(234, 269)
        Label9.Name = "Label9"
        Label9.Size = New Size(359, 37)
        Label9.TabIndex = 17
        Label9.Text = "Tugas Modul 9 Kelompok 18"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Add)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Add As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
