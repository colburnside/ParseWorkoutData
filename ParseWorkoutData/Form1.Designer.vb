﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog3 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog4 = New System.Windows.Forms.SaveFileDialog()
        Me.txtDataToParse = New System.Windows.Forms.TextBox()
        Me.btnParse = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnWriteToFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDataToParse
        '
        Me.txtDataToParse.AllowDrop = True
        Me.txtDataToParse.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataToParse.Location = New System.Drawing.Point(12, 12)
        Me.txtDataToParse.Multiline = True
        Me.txtDataToParse.Name = "txtDataToParse"
        Me.txtDataToParse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDataToParse.Size = New System.Drawing.Size(766, 218)
        Me.txtDataToParse.TabIndex = 0
        '
        'btnParse
        '
        Me.btnParse.Enabled = False
        Me.btnParse.Location = New System.Drawing.Point(12, 236)
        Me.btnParse.Name = "btnParse"
        Me.btnParse.Size = New System.Drawing.Size(193, 48)
        Me.btnParse.TabIndex = 1
        Me.btnParse.Text = "Parse"
        Me.btnParse.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 20
        Me.lstResults.Location = New System.Drawing.Point(12, 290)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.ScrollAlwaysVisible = True
        Me.lstResults.Size = New System.Drawing.Size(760, 184)
        Me.lstResults.TabIndex = 2
        Me.lstResults.Visible = False
        '
        'btnWriteToFile
        '
        Me.btnWriteToFile.Location = New System.Drawing.Point(13, 481)
        Me.btnWriteToFile.Name = "btnWriteToFile"
        Me.btnWriteToFile.Size = New System.Drawing.Size(192, 54)
        Me.btnWriteToFile.TabIndex = 3
        Me.btnWriteToFile.Text = "Save Results"
        Me.btnWriteToFile.UseVisualStyleBackColor = True
        Me.btnWriteToFile.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 597)
        Me.Controls.Add(Me.btnWriteToFile)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnParse)
        Me.Controls.Add(Me.txtDataToParse)
        Me.Name = "Form1"
        Me.Text = "Parse Workout Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents SaveFileDialog3 As SaveFileDialog
    Friend WithEvents SaveFileDialog4 As SaveFileDialog
    Friend WithEvents txtDataToParse As TextBox
    Friend WithEvents btnParse As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnWriteToFile As Button
End Class
