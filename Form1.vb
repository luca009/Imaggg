Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ofdFile.ShowDialog()
        If Not ofdFile.FileName = "" Then
            picbMain.Image = System.Drawing.Bitmap.FromFile(ofdFile.FileName)
        End If
    End Sub

    Private Sub InvertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertToolStripMenuItem.Click
        If Not ofdFile.FileName = "" Then
            Dim bmap As Bitmap
            Dim x, y As Integer
            Dim pixcolor As Color
            bmap = picbMain.Image
            For x = 0 To bmap.Width - 1
                For y = 0 To bmap.Height - 1
                    pixcolor = bmap.GetPixel(x, y)
                    pixcolor = Color.FromArgb(Not pixcolor.R, Not pixcolor.G, Not pixcolor.B)
                    bmap.SetPixel(x, y, pixcolor)
                Next
            Next
            picbMain.Image = bmap
        Else
            MessageBox.Show("Please open a image first!", "Imaggg", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        If Not ofdFile.FileName = "" Then
            picbMain.Image = System.Drawing.Bitmap.FromFile(ofdFile.FileName)
        Else
            MessageBox.Show("Please open a image first!", "Imaggg", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If ToolStripComboBox1.Text = "Stretch" Then
            picbMain.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            picbMain.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub RandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomToolStripMenuItem.Click
        If Not ofdFile.FileName = "" Then
            Dim bmap As Bitmap
            Dim x, y As Integer
            Dim pixcolor As Color
            Dim randR As Integer
            Dim randG As Integer
            Dim randB As Integer

            bmap = picbMain.Image
            For x = 0 To bmap.Width - 1
                For y = 0 To bmap.Height - 1
                    randR = CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0
                    randG = CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0
                    randB = CInt(Math.Floor((255 - 0 + 1) * Rnd())) + 0
                    pixcolor = bmap.GetPixel(x, y)
                    pixcolor = Color.FromArgb(randR, randG, randB)
                    bmap.SetPixel(x, y, pixcolor)
                Next
            Next
            picbMain.Image = bmap
        Else
            MessageBox.Show("Please open a image first!", "Imaggg", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
