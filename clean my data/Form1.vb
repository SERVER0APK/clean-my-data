Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1
    Private WithEvents fileCreationTimer As Timer
    Private randomFile As FileStream
    Private randomFilePath As String
    Private totalFreeSpace As Long
    Private elapsedSeconds As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True

        For Each drive As DriveInfo In DriveInfo.GetDrives()
            If drive.IsReady Then
                ComboBoxDrives.Items.Add(drive.Name)
            End If
        Next
    End Sub

    Private Sub ComboBoxDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDrives.SelectedIndexChanged
        Dim selectedDrive As DriveInfo = New DriveInfo(ComboBoxDrives.SelectedItem.ToString())

        LabelTotalSize.Text = $"Total Size: {FormatBytes(selectedDrive.TotalSize)}"
        LabelUsedSize.Text = $"Used Space: {FormatBytes(selectedDrive.TotalSize - selectedDrive.AvailableFreeSpace)}"
        LabelFreeSize.Text = $"Free Space: {FormatBytes(selectedDrive.AvailableFreeSpace)}"

        totalFreeSpace = selectedDrive.AvailableFreeSpace
        ProgressBar1.Value = 0
        LabelProgressPercentage.Text = "Progress: 0%"
    End Sub

    Private Sub ButtonCreateFile_Click(sender As Object, e As EventArgs) Handles ButtonCreateFile.Click
        If totalFreeSpace <= 0 Then
            MessageBox.Show("No free space available!")
            Return
        End If

        randomFilePath = Path.Combine(ComboBoxDrives.SelectedItem.ToString(), "random_file.tmp")
        randomFile = New FileStream(randomFilePath, FileMode.Create, FileAccess.Write, FileShare.None)

        fileCreationTimer = New Timer With {.Interval = 1000}
        fileCreationTimer.Start()
        elapsedSeconds = 0
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim buffer(1048576) As Byte
        Dim bytesWritten As Long = 0
        Dim progress As Integer

        While bytesWritten < totalFreeSpace
            If BackgroundWorker1.CancellationPending Then Exit While

            randomFile.Write(buffer, 0, buffer.Length)
            bytesWritten += buffer.Length
            progress = CInt((bytesWritten / totalFreeSpace) * 100)

            BackgroundWorker1.ReportProgress(progress, bytesWritten)
        End While

        randomFile.Close()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        LabelProgressPercentage.Text = $"Progress: {e.ProgressPercentage}%"

        Dim bytesWritten As Long = CLng(e.UserState)
        Dim estimatedTotalSeconds As Double = (elapsedSeconds / bytesWritten) * totalFreeSpace
        Dim remainingSeconds As Integer = CInt(estimatedTotalSeconds - elapsedSeconds)

        LabelTime.Text = $"Estimated Time Remaining: {FormatTime(remainingSeconds)}"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        fileCreationTimer.Stop()
        MessageBox.Show("File creation completed. Do you want to delete the file?", "Completion", MessageBoxButtons.YesNo)
        If DialogResult.Yes = MessageBox.Show("Delete the created file?", "Confirmation", MessageBoxButtons.YesNo) Then
            File.Delete(randomFilePath)
        End If
    End Sub

    Private Sub FileCreationTimer_Tick(sender As Object, e As EventArgs) Handles fileCreationTimer.Tick
        elapsedSeconds += 1
    End Sub

    Private Function FormatBytes(bytes As Long) As String
        Dim units As String() = {"B", "KB", "MB", "GB", "TB"}
        Dim size As Double = bytes
        Dim unitIndex As Integer = 0

        While size >= 1024 AndAlso unitIndex < units.Length - 1
            size /= 1024
            unitIndex += 1
        End While

        Return $"{Math.Round(size, 2)} {units(unitIndex)}"
    End Function

    Private Function FormatTime(seconds As Integer) As String
        Dim ts As TimeSpan = TimeSpan.FromSeconds(seconds)
        Return $"{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}"
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class

