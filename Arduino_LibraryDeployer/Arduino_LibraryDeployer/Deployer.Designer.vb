<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deployer
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
		Me.btn_deploy = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btn_newRow = New System.Windows.Forms.Button()
		Me.btn_removeRow = New System.Windows.Forms.Button()
		Me.lbl_from = New System.Windows.Forms.Label()
		Me.lbl_destination = New System.Windows.Forms.Label()
		Me.btn_exit = New System.Windows.Forms.Button()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.btn_template = New System.Windows.Forms.Button()
		Me.Panel2.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'btn_deploy
		'
		Me.btn_deploy.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_deploy.Location = New System.Drawing.Point(10, 3)
		Me.btn_deploy.Name = "btn_deploy"
		Me.btn_deploy.Size = New System.Drawing.Size(96, 27)
		Me.btn_deploy.TabIndex = 0
		Me.btn_deploy.Text = "Deploy"
		Me.btn_deploy.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel2.Location = New System.Drawing.Point(865, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
		Me.Panel2.Size = New System.Drawing.Size(137, 117)
		Me.Panel2.TabIndex = 6
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.btn_removeRow, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.btn_newRow, 0, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 30)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(809, 74)
		Me.TableLayoutPanel1.TabIndex = 4
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
		Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Padding = New System.Windows.Forms.Padding(30)
		Me.Panel1.Size = New System.Drawing.Size(869, 117)
		Me.Panel1.TabIndex = 5
		'
		'btn_newRow
		'
		Me.btn_newRow.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btn_newRow.Location = New System.Drawing.Point(4, 41)
		Me.btn_newRow.Name = "btn_newRow"
		Me.btn_newRow.Size = New System.Drawing.Size(397, 29)
		Me.btn_newRow.TabIndex = 1
		Me.btn_newRow.Text = "Add Row"
		Me.btn_newRow.UseVisualStyleBackColor = True
		'
		'btn_removeRow
		'
		Me.btn_removeRow.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btn_removeRow.Location = New System.Drawing.Point(408, 41)
		Me.btn_removeRow.Name = "btn_removeRow"
		Me.btn_removeRow.Size = New System.Drawing.Size(397, 29)
		Me.btn_removeRow.TabIndex = 2
		Me.btn_removeRow.Text = "Remove Row"
		Me.btn_removeRow.UseVisualStyleBackColor = True
		'
		'lbl_from
		'
		Me.lbl_from.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lbl_from.AutoSize = True
		Me.lbl_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_from.Location = New System.Drawing.Point(180, 1)
		Me.lbl_from.Name = "lbl_from"
		Me.lbl_from.Size = New System.Drawing.Size(44, 17)
		Me.lbl_from.TabIndex = 5
		Me.lbl_from.Text = "From"
		'
		'lbl_destination
		'
		Me.lbl_destination.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lbl_destination.AutoSize = True
		Me.lbl_destination.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_destination.Location = New System.Drawing.Point(561, 1)
		Me.lbl_destination.Name = "lbl_destination"
		Me.lbl_destination.Size = New System.Drawing.Size(90, 17)
		Me.lbl_destination.TabIndex = 6
		Me.lbl_destination.Text = "Destination"
		'
		'btn_exit
		'
		Me.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_exit.Location = New System.Drawing.Point(10, 69)
		Me.btn_exit.Name = "btn_exit"
		Me.btn_exit.Size = New System.Drawing.Size(96, 28)
		Me.btn_exit.TabIndex = 1
		Me.btn_exit.Text = "Exit"
		Me.btn_exit.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.lbl_destination, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.lbl_from, 0, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(30, 6)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(809, 20)
		Me.TableLayoutPanel2.TabIndex = 7
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 1
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.btn_template, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.btn_exit, 0, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.btn_deploy, 0, 0)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 10)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 3
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(117, 100)
		Me.TableLayoutPanel3.TabIndex = 2
		'
		'btn_template
		'
		Me.btn_template.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btn_template.Location = New System.Drawing.Point(10, 36)
		Me.btn_template.Name = "btn_template"
		Me.btn_template.Size = New System.Drawing.Size(96, 27)
		Me.btn_template.TabIndex = 2
		Me.btn_template.Text = "Template"
		Me.btn_template.UseVisualStyleBackColor = True
		'
		'Deployer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1002, 117)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.MinimumSize = New System.Drawing.Size(500, 164)
		Me.Name = "Deployer"
		Me.Text = "Deployer"
		Me.Panel2.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btn_deploy As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btn_exit As Button
	Friend WithEvents btn_removeRow As Button
	Friend WithEvents btn_newRow As Button
	Friend WithEvents lbl_destination As Label
	Friend WithEvents lbl_from As Label
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents btn_template As Button
End Class
