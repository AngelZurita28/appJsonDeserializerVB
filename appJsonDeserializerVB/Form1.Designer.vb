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
        button1 = New Button()
        lbSerie = New Label()
        lbFecha = New Label()
        lbPrecio = New Label()
        SuspendLayout()
        ' 
        ' button1
        ' 

        button1.Location = New Point(70, 44)
        button1.Margin = New Padding(4, 3, 4, 3)
        button1.Name = "button1"
        button1.Size = New Size(88, 27)
        button1.TabIndex = 0
        button1.Text = "button1"
        button1.UseVisualStyleBackColor = True
        ' 
        ' lbSerie
        ' 
        lbSerie.AutoSize = True
        lbSerie.Font = New Font("JetBrains Mono", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        lbSerie.Location = New Point(224, 10)
        lbSerie.Margin = New Padding(4, 0, 4, 0)
        lbSerie.Name = "lbSerie"
        lbSerie.Size = New Size(0, 23)
        lbSerie.TabIndex = 1
        ' 
        ' lbFecha
        ' 
        lbFecha.AutoSize = True
        lbFecha.Font = New Font("JetBrains Mono", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        lbFecha.Location = New Point(224, 44)
        lbFecha.Margin = New Padding(4, 0, 4, 0)
        lbFecha.Name = "lbFecha"
        lbFecha.Size = New Size(0, 23)
        lbFecha.TabIndex = 2
        ' 
        ' lbPrecio
        ' 
        lbPrecio.AutoSize = True
        lbPrecio.Font = New Font("JetBrains Mono", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        lbPrecio.Location = New Point(224, 77)
        lbPrecio.Margin = New Padding(4, 0, 4, 0)
        lbPrecio.Name = "lbPrecio"
        lbPrecio.Size = New Size(0, 23)
        lbPrecio.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 122)
        Controls.Add(lbPrecio)
        Controls.Add(lbFecha)
        Controls.Add(lbSerie)
        Controls.Add(button1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents button1 As System.Windows.Forms.Button
    Private lbSerie As System.Windows.Forms.Label
    Private lbFecha As System.Windows.Forms.Label
    Private lbPrecio As System.Windows.Forms.Label
End Class
