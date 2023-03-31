<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnChiudi = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.LabelTemi = New System.Windows.Forms.Label()
        Me.NumericUpDownTemiSvoltiInizio = New System.Windows.Forms.NumericUpDown()
        Me.LabelDestinazione = New System.Windows.Forms.Label()
        Me.TextBoxDestinazione = New System.Windows.Forms.TextBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btnSelezionaCartella = New System.Windows.Forms.Button()
        Me.NumericUpDownTemiSvoltiFine = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDownTemiSvoltiInizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTemiSvoltiFine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChiudi
        '
        Me.btnChiudi.Location = New System.Drawing.Point(397, 97)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(75, 23)
        Me.btnChiudi.TabIndex = 4
        Me.btnChiudi.Text = "Chiudi"
        Me.btnChiudi.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(316, 97)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'LabelTemi
        '
        Me.LabelTemi.AutoSize = True
        Me.LabelTemi.Location = New System.Drawing.Point(14, 24)
        Me.LabelTemi.Name = "LabelTemi"
        Me.LabelTemi.Size = New System.Drawing.Size(110, 13)
        Me.LabelTemi.TabIndex = 2
        Me.LabelTemi.Text = "Copia temi (da 1 a 51)"
        '
        'NumericUpDownTemiSvoltiInizio
        '
        Me.NumericUpDownTemiSvoltiInizio.Location = New System.Drawing.Point(134, 22)
        Me.NumericUpDownTemiSvoltiInizio.Name = "NumericUpDownTemiSvoltiInizio"
        Me.NumericUpDownTemiSvoltiInizio.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDownTemiSvoltiInizio.TabIndex = 0
        '
        'LabelDestinazione
        '
        Me.LabelDestinazione.AutoSize = True
        Me.LabelDestinazione.Location = New System.Drawing.Point(12, 57)
        Me.LabelDestinazione.Name = "LabelDestinazione"
        Me.LabelDestinazione.Size = New System.Drawing.Size(103, 13)
        Me.LabelDestinazione.TabIndex = 4
        Me.LabelDestinazione.Text = "Dove salvaere i temi"
        '
        'TextBoxDestinazione
        '
        Me.TextBoxDestinazione.Location = New System.Drawing.Point(134, 54)
        Me.TextBoxDestinazione.Name = "TextBoxDestinazione"
        Me.TextBoxDestinazione.Size = New System.Drawing.Size(308, 20)
        Me.TextBoxDestinazione.TabIndex = 1
        Me.TextBoxDestinazione.Text = "O:\"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(15, 97)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(287, 23)
        Me.ProgressBar.TabIndex = 5
        '
        'btnSelezionaCartella
        '
        Me.btnSelezionaCartella.Location = New System.Drawing.Point(448, 52)
        Me.btnSelezionaCartella.Name = "btnSelezionaCartella"
        Me.btnSelezionaCartella.Size = New System.Drawing.Size(24, 23)
        Me.btnSelezionaCartella.TabIndex = 6
        Me.btnSelezionaCartella.Text = "..."
        Me.btnSelezionaCartella.UseVisualStyleBackColor = True
        '
        'NumericUpDownTemiSvoltiFine
        '
        Me.NumericUpDownTemiSvoltiFine.Location = New System.Drawing.Point(186, 22)
        Me.NumericUpDownTemiSvoltiFine.Name = "NumericUpDownTemiSvoltiFine"
        Me.NumericUpDownTemiSvoltiFine.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDownTemiSvoltiFine.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 136)
        Me.Controls.Add(Me.NumericUpDownTemiSvoltiFine)
        Me.Controls.Add(Me.btnSelezionaCartella)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.TextBoxDestinazione)
        Me.Controls.Add(Me.LabelDestinazione)
        Me.Controls.Add(Me.NumericUpDownTemiSvoltiInizio)
        Me.Controls.Add(Me.LabelTemi)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnChiudi)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy temi"
        CType(Me.NumericUpDownTemiSvoltiInizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTemiSvoltiFine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents LabelTemi As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownTemiSvoltiInizio As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelDestinazione As System.Windows.Forms.Label
    Friend WithEvents TextBoxDestinazione As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSelezionaCartella As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownTemiSvoltiFine As System.Windows.Forms.NumericUpDown

End Class
