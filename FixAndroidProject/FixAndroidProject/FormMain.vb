Public Class FormMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExploreGradle.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtGradle.Text = ofd.FileName
            pathGradle = ofd.FileName
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtNameApp.Text.Equals("") Then
            MsgBox("Nombre de la app es requerido")
            txtNameApp.Focus()
            Exit Sub
        End If

        If txtPackage.Text.Equals("") Then
            MsgBox("Paquete es requerido")
            txtPackage.Focus()
            Exit Sub
        End If

        If pathGradle.Equals("") Then
            MsgBox("Debe seleccionar un archivo gradle-x.x.x-all.zip")
            btnExploreGradle.Focus()
            Exit Sub
        End If

        configureProject(txtPackage.Text.Trim, checkReposGoogle.Checked)

        If chechClean.Checked And My.Computer.FileSystem.DirectoryExists("app\build") Then My.Computer.FileSystem.DeleteDirectory("app\build", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        If chechClean.Checked And My.Computer.FileSystem.DirectoryExists(".gradle") Then My.Computer.FileSystem.DeleteDirectory(".gradle", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        If chechClean.Checked And My.Computer.FileSystem.DirectoryExists(".idea") Then My.Computer.FileSystem.DeleteDirectory(".idea", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        If chechClean.Checked And My.Computer.FileSystem.DirectoryExists("build") Then My.Computer.FileSystem.DeleteDirectory("build", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        MsgBox("La operación de completó correctamente")
    End Sub
End Class
