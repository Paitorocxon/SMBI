Imports System.Environment
Imports System.Text.RegularExpressions

Public Class Form1
    Public config As String = ""
    Public Steampath As String = ""
    Public ScrapMechanicPath As String = ""
    Public BlueprintsPath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Axolot Games\Scrap Mechanic\User\"
    Public UserFolder As String = ""
    Public Dic As New Dictionary(Of String, String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSteamInstallPath As String = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
        Steampath = strSteamInstallPath
        ScrapMechanicPath = Steampath & "\steamapps\common\Scrap Mechanic\"
        scanfiles()
    End Sub

    Public Function scanfiles()
        If (IO.Directory.Exists(Steampath)) Then
            ToolStripStatusLabel1.Text = "Steam Folder found: Yes"
        Else
            ToolStripStatusLabel1.Text = "Steam Folder found: No"
        End If
        If (IO.Directory.Exists(ScrapMechanicPath)) Then
            ToolStripStatusLabel2.Text = "Scrap Mechanic Folder found: Yes"
        Else
            ToolStripStatusLabel2.Text = "Scrap Mechanic found: No"
        End If

        If IO.Directory.Exists(BlueprintsPath) Then
            Dim files() As String = IO.Directory.GetDirectories(BlueprintsPath)
            UserFolder = files(0)
        End If

        'Try

        For Each file As String In IO.Directory.GetDirectories(UserFolder & "\Blueprints\")
            'MsgBox(UserFolder & "\Blueprints\" & file.Substring((UserFolder & "\Blueprints\").Length) & "\description.json")
            Dim tmpdes As String = IO.File.ReadAllText(UserFolder & "\Blueprints\" & file.Substring((UserFolder & "\Blueprints\").Length) & "\description.json")
            Dim tmpd As String() = tmpdes.Split(",")
            Dim si As Integer = 0
            For Each s In tmpd
                If s.Contains("""name""") Then
                    'MsgBox(tmpd(si).Substring(12).Replace("""", ""))
                    Dic.Add(tmpd(si).Substring(12).Replace("""", ""), file.Substring((UserFolder & "\Blueprints\").Length))
                    ListView1.Items.Add(tmpd(si).Substring(12).Replace("""", ""))
                    Exit For
                End If
                si += 1
            Next


            'Dim n As String = tmpd(2).Substring(12).Replace("""", "")

            'Dic.Add(n, file.Substring((UserFolder & "\Blueprints\").Length))
            'ListView1.Items.Add(file.Substring((UserFolder & "\Blueprints\").Length))

            'ListView1.Items.Add(n)
        Next
        'Catch ex As Exception

        'End Try

        Return 0
    End Function

    Private Sub HowDoIUseThisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowDoIUseThisToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ShowenviromentVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowenviromentVariablesToolStripMenuItem.Click
        MsgBox("Folder to Scrap Mechanic: " & UserFolder)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If (ListView1.FocusedItem IsNot Nothing) Then
                PictureBox1.BackgroundImage = Image.FromFile(UserFolder & "\Blueprints\" & Dic(ListView1.Items(ListView1.FocusedItem.Index).Text) & "\icon.png")
            End If
        Catch ex As Exception
            PictureBox1.BackgroundImage = My.Resources.img
        End Try
        If (ListView1.FocusedItem IsNot Nothing) Then

            Dim JsonString As String = " " & IO.File.ReadAllText(UserFolder & "\Blueprints\" & Dic(ListView1.Items(ListView1.FocusedItem.Index).Text) & "\blueprint.json")

            RichTextBox1.Clear()
            'For i = 0 To UBound(Split(JsonString, "childs")) + 1
            'Dim tmpstr As String = extract(JsonString, "{""childs"":[{", "}]}")
            'JsonString = JsonString.Replace("{""childs"":[{" & tmpstr & "}]}", "{""childs"":[{" & tmpstr & "}],""type"":0}")
            'Next
            'For i = 0 To UBound(Split(JsonString, "childs")) + 1
            ' Dim tmpstr As String = extract(JsonString, "{""childs"":[{", "}]}")
            'RichTextBox1.Text &= tmpstr & vbCrLf & "=============" & vbCrLf
            'Next
        End If
    End Sub




    Function extract(source As String, start As String, ending As String)
        Try
            Return source.Substring(InStr(source, start, CompareMethod.Text) + start.Length - 1, InStr(source, ending) - (InStr(source, start, CompareMethod.Text) + start.Length))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function



    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If (ListView1.FocusedItem IsNot Nothing) Then

            Dim JsonString As String = "" & IO.File.ReadAllText(UserFolder & "\Blueprints\" & Dic(ListView1.Items(ListView1.FocusedItem.Index).Text) & "\blueprint.json")

            RichTextBox1.Clear()
            For i = 0 To UBound(Split(JsonString, "childs")) + 1
                Dim tmpstr As String = extract(JsonString, "{""childs"":[{", "}]}")
                JsonString = JsonString.Replace("{""childs"":[{" & tmpstr & "}]}", "{""childs"":[{" & tmpstr & "}],""type"":0}")
            Next
            For i = 0 To UBound(Split(JsonString, "childs")) + 1
                Dim tmpstr As String = extract(JsonString, "{""childs"":[{", "}]}")
                RichTextBox1.Text &= tmpstr & vbCrLf & "=============" & vbCrLf
            Next
            IO.File.WriteAllText(SaveFileDialog1.FileName, JsonString)
            MsgBox("Done! Saved as " & SaveFileDialog1.FileName.Replace(ScrapMechanicPath & "Survival\LocalBlueprints\", "") & vbCrLf & vbCrLf & vbCrLf & "Your import command is:" & vbCrLf & "   /import " & SaveFileDialog1.FileName.Replace(ScrapMechanicPath & "Survival\LocalBlueprints\", "").Replace(".blueprint", ""))
        Else
            MsgBox("Please select a file first!")
        End If


    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        SaveFileDialog1.InitialDirectory = ScrapMechanicPath & "Survival\LocalBlueprints\"
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListView1.Clear()

        If TextBox1.Text.Length > 0 Then
            For Each ITEM In Dic
                If ITEM.Key.ToLower.Contains(TextBox1.Text.ToLower) Then
                    ListView1.Items.Add(ITEM.Key)
                End If
            Next
        Else
            For Each ITEM In Dic
                ListView1.Items.Add(ITEM.Key)
            Next
        End If
    End Sub

    Private Sub CreativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreativeToolStripMenuItem.Click
        Process.Start(UserFolder & "\Blueprints\")
    End Sub

    Private Sub SurvivalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurvivalToolStripMenuItem.Click
        Process.Start(ScrapMechanicPath & "Survival\LocalBlueprints\")
    End Sub
End Class

Public Class SMJson
    Public bodies() As String
    Public childs() As String
End Class


