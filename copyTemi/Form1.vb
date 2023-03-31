Public Class Form1

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click

        ' chiude il programma

        End

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' nascondi la progress bar

        ProgressBar.Visible = False

        ' numero minimo e massimo di temi

        NumericUpDownTemiSvoltiInizio.Minimum = 1
        NumericUpDownTemiSvoltiInizio.Maximum = 51

        NumericUpDownTemiSvoltiFine.Minimum = 1
        NumericUpDownTemiSvoltiFine.Maximum = 51

        TextBoxDestinazione.Text = "O:\temi\"

        ' focus sul primo controllo

        NumericUpDownTemiSvoltiInizio.Focus()

        ' Ok come degault

        Me.AcceptButton = btnOk

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim k As Decimal

        ' controllo

        If controllo() = False Then Exit Sub

        ' Chiede conferma

        If MsgBox("Sei sicuro di voler copiare tutti i temi nella cartella " + TextBoxDestinazione.Text + "?", vbYesNo) = vbNo Then Exit Sub

        ' progress bar

        ProgressBar.Minimum = NumericUpDownTemiSvoltiInizio.Value
        ProgressBar.Maximum = NumericUpDownTemiSvoltiFine.Value

        ProgressBar.Visible = True

        ' copia i temi richiesti

        For k = NumericUpDownTemiSvoltiInizio.Value To NumericUpDownTemiSvoltiFine.Value

            ' aggiorna la progress bar

            ProgressBar.Increment(CInt(k))

            ' copia il tema

            If copiaTema(k) = False Then
                MsgBox("Errore!")
                Exit Sub
            End If

        Next

        ' Nasconde la progress bar

        ProgressBar.Hide()

        ' Ok

        MsgBox("Copia dei temi completata!", vbInformation)

    End Sub

    Private Function copiaTema(ByVal numeroTema As Decimal) As Boolean
        Dim numeroTemaStringa As String
        Dim sourcePath As String
        Dim XCopyString As String

        ' copia fallita

        copiaTema = False

        ' converti in stringa il numero tema

        numeroTemaStringa = convertiNumeroTema(numeroTema)

        ' compone la sringa del percorso di origine del tema

        sourcePath = componePercorsoOrigine(numeroTemaStringa)

        ' copia il tema con XCOPY

        XCopyString = "cmd.exe /C xcopy.exe " + sourcePath + "\*.* " + TextBoxDestinazione.Text + "tema" + numeroTemaStringa + " /E /I"

        Shell(XCopyString, AppWinStyle.Hide)

        ' Ok

        copiaTema = True

    End Function

    Private Function convertiNumeroTema(ByVal numeroTema As Decimal) As String

        ' Aggiunge 0 davanti al numero se minore di 10

        If numeroTema < 10 Then
            convertiNumeroTema = "0" + CStr(numeroTema)
        Else
            convertiNumeroTema = CStr(numeroTema)
        End If

    End Function

    Private Function componePercorsoOrigine(ByVal numeroTema As String) As String

        componePercorsoOrigine = "\\arlecchino\tema" + numeroTema + "$"

    End Function

    Private Sub btnSelezionaCartella_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelezionaCartella.Click
        Dim folder As New FolderBrowserDialog

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxDestinazione.Text = folder.SelectedPath
        End If

    End Sub

    Private Function controllo() As Boolean

        ' fallito

        controllo = False

        ' tema fine non può essere minore di tema inizio

        If NumericUpDownTemiSvoltiFine.Value < NumericUpDownTemiSvoltiInizio.Value Then
            MsgBox("Il numero dell'ultimo tema non può essere minore del primo!", vbCritical)
            NumericUpDownTemiSvoltiFine.Focus()
            controllo = False
            Exit Function
        End If

        ' controlla l'ultimo carattere. se manca \ la aggiunge

        If GetChar(TextBoxDestinazione.Text, Len(TextBoxDestinazione.Text)) <> "\" Then TextBoxDestinazione.Text = TextBoxDestinazione.Text + "\"

        ' ok

        controllo = True

    End Function

End Class
