<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFtpSimpleClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFtpSimpleClient))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLocalFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnDeleteImg = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picData = New System.Windows.Forms.PictureBox()
        Me.picURL = New System.Windows.Forms.PictureBox()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picURL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Local"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Local Filename:"
        '
        'txtLocalFileName
        '
        Me.txtLocalFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocalFileName.BackColor = System.Drawing.Color.GhostWhite
        Me.txtLocalFileName.Location = New System.Drawing.Point(110, 3)
        Me.txtLocalFileName.Name = "txtLocalFileName"
        Me.txtLocalFileName.Size = New System.Drawing.Size(663, 23)
        Me.txtLocalFileName.TabIndex = 0
        Me.txtLocalFileName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 511)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'btnUpload
        '
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpload.Location = New System.Drawing.Point(218, 43)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(99, 34)
        Me.btnUpload.TabIndex = 3
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnDeleteImg
        '
        Me.btnDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteImg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDeleteImg.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnDeleteImg.Location = New System.Drawing.Point(111, 43)
        Me.btnDeleteImg.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteImg.Name = "btnDeleteImg"
        Me.btnDeleteImg.Size = New System.Drawing.Size(99, 34)
        Me.btnDeleteImg.TabIndex = 2
        Me.btnDeleteImg.Text = "Clear Image"
        Me.btnDeleteImg.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBrowse.Location = New System.Drawing.Point(7, 43)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(99, 34)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'picData
        '
        Me.picData.BackColor = System.Drawing.SystemColors.Control
        Me.picData.Image = CType(resources.GetObject("picData.Image"), System.Drawing.Image)
        Me.picData.Location = New System.Drawing.Point(7, 118)
        Me.picData.Margin = New System.Windows.Forms.Padding(4)
        Me.picData.Name = "picData"
        Me.picData.Size = New System.Drawing.Size(364, 389)
        Me.picData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picData.TabIndex = 81
        Me.picData.TabStop = False
        '
        'picURL
        '
        Me.picURL.BackColor = System.Drawing.SystemColors.Control
        Me.picURL.Image = CType(resources.GetObject("picURL.Image"), System.Drawing.Image)
        Me.picURL.Location = New System.Drawing.Point(403, 118)
        Me.picURL.Margin = New System.Windows.Forms.Padding(4)
        Me.picURL.Name = "picURL"
        Me.picURL.Size = New System.Drawing.Size(364, 389)
        Me.picURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picURL.TabIndex = 83
        Me.picURL.TabStop = False
        '
        'frmFtpUpDownFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 530)
        Me.Controls.Add(Me.picURL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLocalFileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDeleteImg)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picData)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFtpUpDownFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTP Upload and Download File. - coDe bY: Thongkorn Tubtimkrob"
        CType(Me.picData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picURL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLocalFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnDeleteImg As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents picData As System.Windows.Forms.PictureBox
    Friend WithEvents picURL As System.Windows.Forms.PictureBox

End Class
