<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPackage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGradle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExploreGradle = New System.Windows.Forms.Button()
        Me.checkReposGoogle = New System.Windows.Forms.CheckBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNameApp = New System.Windows.Forms.TextBox()
        Me.chechClean = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paquete"
        '
        'txtPackage
        '
        Me.txtPackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackage.Location = New System.Drawing.Point(67, 38)
        Me.txtPackage.Name = "txtPackage"
        Me.txtPackage.Size = New System.Drawing.Size(505, 20)
        Me.txtPackage.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gradle"
        '
        'txtGradle
        '
        Me.txtGradle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGradle.Location = New System.Drawing.Point(67, 64)
        Me.txtGradle.Name = "txtGradle"
        Me.txtGradle.Size = New System.Drawing.Size(464, 20)
        Me.txtGradle.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(64, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "gradle-6.1.1-all.zip"
        '
        'btnExploreGradle
        '
        Me.btnExploreGradle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExploreGradle.Location = New System.Drawing.Point(537, 64)
        Me.btnExploreGradle.Name = "btnExploreGradle"
        Me.btnExploreGradle.Size = New System.Drawing.Size(35, 20)
        Me.btnExploreGradle.TabIndex = 4
        Me.btnExploreGradle.Text = "..."
        Me.btnExploreGradle.UseVisualStyleBackColor = True
        '
        'checkReposGoogle
        '
        Me.checkReposGoogle.AutoSize = True
        Me.checkReposGoogle.Location = New System.Drawing.Point(67, 116)
        Me.checkReposGoogle.Name = "checkReposGoogle"
        Me.checkReposGoogle.Size = New System.Drawing.Size(156, 17)
        Me.checkReposGoogle.TabIndex = 5
        Me.checkReposGoogle.Text = "Usar repositorios de Google"
        Me.checkReposGoogle.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(472, 149)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 50)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre"
        '
        'txtNameApp
        '
        Me.txtNameApp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNameApp.Location = New System.Drawing.Point(67, 12)
        Me.txtNameApp.Name = "txtNameApp"
        Me.txtNameApp.Size = New System.Drawing.Size(505, 20)
        Me.txtNameApp.TabIndex = 1
        '
        'chechClean
        '
        Me.chechClean.AutoSize = True
        Me.chechClean.Checked = True
        Me.chechClean.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chechClean.Location = New System.Drawing.Point(67, 140)
        Me.chechClean.Name = "chechClean"
        Me.chechClean.Size = New System.Drawing.Size(103, 17)
        Me.chechClean.TabIndex = 6
        Me.chechClean.Text = "Limpiar proyecto"
        Me.chechClean.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 211)
        Me.Controls.Add(Me.chechClean)
        Me.Controls.Add(Me.txtNameApp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.checkReposGoogle)
        Me.Controls.Add(Me.btnExploreGradle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGradle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPackage)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FixAndroidProject 4.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPackage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGradle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExploreGradle As System.Windows.Forms.Button
    Friend WithEvents checkReposGoogle As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNameApp As System.Windows.Forms.TextBox
    Friend WithEvents chechClean As System.Windows.Forms.CheckBox

End Class
