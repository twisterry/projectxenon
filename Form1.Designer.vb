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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Game Server", "Partner Server", "eingesendete Server"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bitte eine Liste wählen:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(8, 340)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(341, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Alle Server löschen!"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(201, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 22)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Englisch"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(8, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 22)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Deutsch"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(9, 108)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 230)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 204)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(326, 198)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(284, 204)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(278, 198)
        Me.WebBrowser2.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 78)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(340, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(231, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 20)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Listen aktualisieren"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(278, 396)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 21)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Beenden"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(361, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
End Class
