Imports System.ComponentModel

Public Class frmLoginForm


    Private Sub frmLoginForm_Closed(sender As Object, e As EventArgs)

        Me.Visible = False
    End Sub

    Private Sub frmLoginForm_Hidden(sender As Object, e As eventargs)

        Me.Visible = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class