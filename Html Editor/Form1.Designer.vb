<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmphasizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.HeadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        Me.NewToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(600, 358)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "<!DOCTYPE html>" & Global.Microsoft.VisualBasic.ChrW(10) & "<html>" & Global.Microsoft.VisualBasic.ChrW(10) & "<body>" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "<!-- Comment -->" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "<h1>My First Heading</h1>" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "// Co" & _
    "de here" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "<p>My first paragraph.</p>" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "</body>" & Global.Microsoft.VisualBasic.ChrW(10) & "</html>"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoldToolStripMenuItem, Me.ItalicToolStripMenuItem, Me.EmphasizeToolStripMenuItem, Me.MarkToolStripMenuItem, Me.InsertToolStripMenuItem, Me.LinkToolStripMenuItem, Me.ImageToolStripMenuItem, Me.TableToolStripMenuItem, Me.ListToolStripMenuItem, Me.TextboxToolStripMenuItem, Me.RadioButtonToolStripMenuItem, Me.SubmitButtonToolStripMenuItem, Me.YoutubeToolStripMenuItem, Me.HeadingToolStripMenuItem, Me.ParagraphToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 334)
        '
        'BoldToolStripMenuItem
        '
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'ItalicToolStripMenuItem
        '
        Me.ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem"
        Me.ItalicToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ItalicToolStripMenuItem.Text = "Italic"
        '
        'EmphasizeToolStripMenuItem
        '
        Me.EmphasizeToolStripMenuItem.Name = "EmphasizeToolStripMenuItem"
        Me.EmphasizeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EmphasizeToolStripMenuItem.Text = "Emphasize"
        '
        'MarkToolStripMenuItem
        '
        Me.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem"
        Me.MarkToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.MarkToolStripMenuItem.Text = "Strike"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'LinkToolStripMenuItem
        '
        Me.LinkToolStripMenuItem.Name = "LinkToolStripMenuItem"
        Me.LinkToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LinkToolStripMenuItem.Text = "Link"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.TableToolStripMenuItem.Text = "Table"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'TextboxToolStripMenuItem
        '
        Me.TextboxToolStripMenuItem.Name = "TextboxToolStripMenuItem"
        Me.TextboxToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.TextboxToolStripMenuItem.Text = "Textbox"
        '
        'RadioButtonToolStripMenuItem
        '
        Me.RadioButtonToolStripMenuItem.Name = "RadioButtonToolStripMenuItem"
        Me.RadioButtonToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RadioButtonToolStripMenuItem.Text = "RadioButton"
        '
        'SubmitButtonToolStripMenuItem
        '
        Me.SubmitButtonToolStripMenuItem.Name = "SubmitButtonToolStripMenuItem"
        Me.SubmitButtonToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SubmitButtonToolStripMenuItem.Text = "Submit Button"
        '
        'YoutubeToolStripMenuItem
        '
        Me.YoutubeToolStripMenuItem.Name = "YoutubeToolStripMenuItem"
        Me.YoutubeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.YoutubeToolStripMenuItem.Text = "Youtube"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HeadingToolStripMenuItem
        '
        Me.HeadingToolStripMenuItem.Name = "HeadingToolStripMenuItem"
        Me.HeadingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.HeadingToolStripMenuItem.Text = "Heading"
        '
        'ParagraphToolStripMenuItem
        '
        Me.ParagraphToolStripMenuItem.Name = "ParagraphToolStripMenuItem"
        Me.ParagraphToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ParagraphToolStripMenuItem.Text = "Paragraph"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 382)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Html Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItalicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmphasizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextboxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButtonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubmitButtonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HeadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
