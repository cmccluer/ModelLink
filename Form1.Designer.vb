<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Links"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(204, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(467, 134)
        Me.ListBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(467, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Select highlighted file to copy as new model file and attach to .dft file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(142, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 29)
        Me.TextBox3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "New P/N"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(369, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(280, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Accept Displayed Path and Create New .dft File"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ModelLink.My.MySettings.Default, "LastPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox6.HideSelection = False
        Me.TextBox6.Location = New System.Drawing.Point(369, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(278, 20)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = Global.ModelLink.My.MySettings.Default.LastPath
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(68, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Call GetAsmInfo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(200, 16)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(464, 82)
        Me.ListBox2.TabIndex = 15
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(200, 104)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(467, 26)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Save selected file as new model, attach to .asm, attach .asm to .dft"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 75)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Step 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Step 2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(755, 204)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 171)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 25)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Step 3 (if .asm)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(200, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(467, 26)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Attach .asm to .dft with no changes to parts"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(19, 477)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Quit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(653, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 23)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Change Path"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 501)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ModelLink"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Main()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call GetSelected()
    End Sub
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Call CreateNewModelFile()
    'End Sub
    Friend WithEvents Button4 As Button

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClassGV.PathOK = "Accept"
        Call folderChoose()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ClassGV.PathOK = "Change"
        Call folderChoose()
    End Sub
    Friend WithEvents Button5 As Button

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call GetAsmInfo()
    End Sub

    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button6 As Button

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call GetSelectedPartFromAsm()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call addNewAsmtoDft()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Friend WithEvents GroupBox1 As GroupBox

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label8.Click, Label9.Click, Label10.Click

    End Sub

    Friend WithEvents Label8 As Label

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CreateObject("WScript.Shell").Popup("Closing Application", 2, "Status")
        Application.Exit() '8/27/18
        'Me.Close()
    End Sub

    Public WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button8 As Button
End Class
