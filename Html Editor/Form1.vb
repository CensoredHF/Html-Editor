Public Class Form1
    Dim Temp As String = "C:\Users\" & Environment.UserName.ToString & "\AppData\Local\Temp\index.htm"
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Text = My.Settings.NewText
        LoadColors()
        Dim loc As Int16
        If RichTextBox1.Text.Contains("// Code here") Then
            loc = RichTextBox1.Find("// Code here")
            RichTextBox1.Select(loc, 12)
            RichTextBox1.SelectionColor = Color.White
        End If
    End Sub
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        My.Computer.FileSystem.WriteAllText(Temp, RichTextBox1.Text, False)
        Compile.Show()
    End Sub
    Private Sub LoadColors()
        Dim loc As Int16
        If RichTextBox1.Text.Contains("<!DOCTYPE") Then
            loc = RichTextBox1.Find("<!DOCTYPE")
            RichTextBox1.Select(loc, 9)
            RichTextBox1.SelectionColor = Color.IndianRed
        End If
        Dim wordslist As New List(Of String)
        wordslist.Add("<html>")
        wordslist.Add(" html>")
        wordslist.Add("</html>")
        wordslist.Add("<body>")
        wordslist.Add("</body>")
        Dim len As Integer = RichTextBox1.TextLength
        For Each word As String In wordslist
            Dim lastindex = RichTextBox1.Text.LastIndexOf(word)
            Dim index As Integer = 0
            While index < lastindex
                RichTextBox1.Find(word, index, len, RichTextBoxFinds.None)
                RichTextBox1.SelectionColor = Color.OrangeRed
                index = RichTextBox1.Text.IndexOf(word, index) + 1
            End While
        Next
        NextColor()
    End Sub
    Private Sub NextColor()
        Dim wordslist As New List(Of String)
        wordslist.Add("<h1>")
        wordslist.Add("</h1>")
        wordslist.Add("<p>")
        wordslist.Add("</p>")
        Dim len As Integer = RichTextBox1.TextLength
        For Each word As String In wordslist
            Dim lastindex = RichTextBox1.Text.LastIndexOf(word)
            Dim index As Integer = 0
            While index < lastindex
                RichTextBox1.Find(word, index, len, RichTextBoxFinds.None)
                RichTextBox1.SelectionColor = Color.LightSalmon
                index = RichTextBox1.Text.IndexOf(word, index) + 1
            End While
        Next
        Dim loc As Int16
        If RichTextBox1.Text.Contains("<!-- Comment -->") Then
            Loc = RichTextBox1.Find("<!-- Comment -->")
            RichTextBox1.Select(loc, 16)
            RichTextBox1.SelectionColor = Color.Lime
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadColors()
        Dim loc As Int16
        If RichTextBox1.Text.Contains("// Code here") Then
            loc = RichTextBox1.Find("// Code here")
            RichTextBox1.Select(loc, 12)
        End If
    End Sub
#Region "ContentMenu"
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<b>" & RichTextBox1.SelectedText & "</b>"
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<i>" & RichTextBox1.SelectedText & "</i>"
    End Sub

    Private Sub EmphasizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmphasizeToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<em>" & RichTextBox1.SelectedText & "</em>"
    End Sub

    Private Sub MarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<del>" & RichTextBox1.SelectedText & "</del>"
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<ins>" & RichTextBox1.SelectedText & "</ins>"
    End Sub

    Private Sub LinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<a href=" & RichTextBox1.SelectedText & ">" & RichTextBox1.SelectedText & "</a>"
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<img src=""url""" + " alt=""some_text""" + "" + ">"
    End Sub

    Private Sub TableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem.Click
        '
        RichTextBox1.SelectedText = "<table style=" + """" + "width:100%" + """" + "> " + "" + "<tr> <td>Jill</td> </tr> </table>" & RichTextBox1.SelectedText
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        RichTextBox1.SelectedText = " <ul><li>Coffee</li><li>Tea</li><li>Milk</li></ul>  " & RichTextBox1.SelectedText

    End Sub

    Private Sub TextboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextboxToolStripMenuItem.Click
        RichTextBox1.SelectedText = My.Settings.Login & RichTextBox1.SelectedText
    End Sub

    Private Sub RadioButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioButtonToolStripMenuItem.Click
        RichTextBox1.SelectedText = My.Settings.RadioButton & RichTextBox1.SelectedText
    End Sub

    Private Sub SubmitButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitButtonToolStripMenuItem.Click
        RichTextBox1.SelectedText = My.Settings.SubmitButton & RichTextBox1.SelectedText
    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeToolStripMenuItem.Click
        RichTextBox1.SelectedText = My.Settings.Youtube & RichTextBox1.SelectedText
    End Sub
#End Region
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt | Html Files (*.htm*)|*.htm"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            Dim sw As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            For Each sLine As String In RichTextBox1.Lines
                sw.WriteLine(sLine)
            Next
            sw.Close()
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt | Html Files (*.htm*)|*.htm"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            Me.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
    Private Sub HeadingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeadingToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<h1>" + "Heading" & RichTextBox1.SelectedText & "</h1>"
    End Sub
    Private Sub ParagraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParagraphToolStripMenuItem.Click
        RichTextBox1.SelectedText = "<p>" + "Paragraph" & RichTextBox1.SelectedText & "</p>"
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim sw As New System.IO.StreamWriter(OpenFileDialog1.FileName)
            For Each sLine As String In RichTextBox1.Lines
                sw.WriteLine(sLine)
            Next
            sw.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
