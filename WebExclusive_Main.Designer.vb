<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebExclusive_Main
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
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnSaveXML = New System.Windows.Forms.Button()
        Me.txtSaveLocation = New System.Windows.Forms.TextBox()
        Me.btnLoadWeb = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnClearGrid = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblDifferent = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.uxGrid = New System.Windows.Forms.DataGridView()
        Me.dsData = New WebExclusiveCompare.dsForm12()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldPricesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEENTEREDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEUPDATEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.uxGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(18, 31)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFile.TabIndex = 0
        Me.btnLoadFile.Text = "load"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(111, 32)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(412, 20)
        Me.txtLocation.TabIndex = 2
        Me.txtLocation.Text = "C:\test\20140506_news.txt"
        '
        'btnSaveXML
        '
        Me.btnSaveXML.Location = New System.Drawing.Point(18, 65)
        Me.btnSaveXML.Name = "btnSaveXML"
        Me.btnSaveXML.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveXML.TabIndex = 3
        Me.btnSaveXML.Text = "save"
        Me.btnSaveXML.UseVisualStyleBackColor = True
        '
        'txtSaveLocation
        '
        Me.txtSaveLocation.Location = New System.Drawing.Point(113, 68)
        Me.txtSaveLocation.Name = "txtSaveLocation"
        Me.txtSaveLocation.Size = New System.Drawing.Size(350, 20)
        Me.txtSaveLocation.TabIndex = 4
        Me.txtSaveLocation.Text = "C:\test"
        '
        'btnLoadWeb
        '
        Me.btnLoadWeb.Location = New System.Drawing.Point(18, 13)
        Me.btnLoadWeb.Name = "btnLoadWeb"
        Me.btnLoadWeb.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadWeb.TabIndex = 5
        Me.btnLoadWeb.Text = "Load Web"
        Me.btnLoadWeb.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.btnLoadFile)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(0, 630)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 83)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load File"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(99, 16)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(408, 20)
        Me.txtUrl.TabIndex = 7
        Me.txtUrl.Text = "http://897theriver.com/news.asp?int=210"
        '
        'btnClearGrid
        '
        Me.btnClearGrid.Location = New System.Drawing.Point(607, 99)
        Me.btnClearGrid.Name = "btnClearGrid"
        Me.btnClearGrid.Size = New System.Drawing.Size(75, 23)
        Me.btnClearGrid.TabIndex = 8
        Me.btnClearGrid.Text = "Clear"
        Me.btnClearGrid.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnLoadWeb)
        Me.Panel1.Controls.Add(Me.btnClearGrid)
        Me.Panel1.Controls.Add(Me.txtUrl)
        Me.Panel1.Controls.Add(Me.btnSaveXML)
        Me.Panel1.Controls.Add(Me.txtSaveLocation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 125)
        Me.Panel1.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(15, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "total"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(15, 38)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(27, 13)
        Me.lblNew.TabIndex = 9
        Me.lblNew.Text = "new"
        '
        'lblDifferent
        '
        Me.lblDifferent.AutoSize = True
        Me.lblDifferent.Location = New System.Drawing.Point(15, 59)
        Me.lblDifferent.Name = "lblDifferent"
        Me.lblDifferent.Size = New System.Drawing.Size(21, 13)
        Me.lblDifferent.TabIndex = 9
        Me.lblDifferent.Text = "diff"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblDifferent)
        Me.Panel2.Controls.Add(Me.lblNew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(689, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 125)
        Me.Panel2.TabIndex = 10
        '
        'uxGrid
        '
        Me.uxGrid.AllowUserToAddRows = False
        Me.uxGrid.AutoGenerateColumns = False
        Me.uxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.uxGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.OldPricesDataGridViewTextBoxColumn, Me.DATEENTEREDDataGridViewTextBoxColumn, Me.DATEUPDATEDDataGridViewTextBoxColumn})
        Me.uxGrid.DataMember = "DataTable1"
        Me.uxGrid.DataSource = Me.dsData
        Me.uxGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxGrid.Location = New System.Drawing.Point(0, 125)
        Me.uxGrid.Name = "uxGrid"
        Me.uxGrid.Size = New System.Drawing.Size(809, 505)
        Me.uxGrid.TabIndex = 1
        '
        'dsData
        '
        Me.dsData.DataSetName = "dsForm12"
        Me.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'OldPricesDataGridViewTextBoxColumn
        '
        Me.OldPricesDataGridViewTextBoxColumn.DataPropertyName = "OldPrices"
        Me.OldPricesDataGridViewTextBoxColumn.HeaderText = "OldPrices"
        Me.OldPricesDataGridViewTextBoxColumn.Name = "OldPricesDataGridViewTextBoxColumn"
        '
        'DATEENTEREDDataGridViewTextBoxColumn
        '
        Me.DATEENTEREDDataGridViewTextBoxColumn.DataPropertyName = "DATE_ENTERED"
        Me.DATEENTEREDDataGridViewTextBoxColumn.HeaderText = "DATE_ENTERED"
        Me.DATEENTEREDDataGridViewTextBoxColumn.Name = "DATEENTEREDDataGridViewTextBoxColumn"
        Me.DATEENTEREDDataGridViewTextBoxColumn.Width = 120
        '
        'DATEUPDATEDDataGridViewTextBoxColumn
        '
        Me.DATEUPDATEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_UPDATED"
        Me.DATEUPDATEDDataGridViewTextBoxColumn.HeaderText = "DATE_UPDATED"
        Me.DATEUPDATEDDataGridViewTextBoxColumn.Name = "DATEUPDATEDDataGridViewTextBoxColumn"
        Me.DATEUPDATEDDataGridViewTextBoxColumn.Width = 120
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 713)
        Me.Controls.Add(Me.uxGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form12"
        Me.Text = "897 The River Phone-a-thon Web-Exclusive Scraper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.uxGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoadFile As System.Windows.Forms.Button
    Friend WithEvents uxGrid As System.Windows.Forms.DataGridView
    Friend WithEvents dsData As WebExclusiveCompare.dsForm12
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveXML As System.Windows.Forms.Button
    Friend WithEvents txtSaveLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadWeb As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents btnClearGrid As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDifferent As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldPricesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEENTEREDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEUPDATEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
