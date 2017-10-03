<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblshipment = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.tbxtotal = New System.Windows.Forms.Label()
        Me.tbxshipment = New System.Windows.Forms.TextBox()
        Me.tbxitem = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblshipment
        '
        Me.lblshipment.AutoSize = True
        Me.lblshipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshipment.Location = New System.Drawing.Point(13, 13)
        Me.lblshipment.Name = "lblshipment"
        Me.lblshipment.Size = New System.Drawing.Size(189, 24)
        Me.lblshipment.TabIndex = 0
        Me.lblshipment.Text = "Cartons per shipment"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(13, 51)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(135, 24)
        Me.lblItem.TabIndex = 1
        Me.lblItem.Text = "Item per carton"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(383, 13)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(51, 24)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "Total"
        '
        'tbxtotal
        '
        Me.tbxtotal.AutoSize = True
        Me.tbxtotal.Location = New System.Drawing.Point(450, 13)
        Me.tbxtotal.Name = "tbxtotal"
        Me.tbxtotal.Size = New System.Drawing.Size(10, 13)
        Me.tbxtotal.TabIndex = 3
        Me.tbxtotal.Text = "."
        '
        'tbxshipment
        '
        Me.tbxshipment.Location = New System.Drawing.Point(212, 13)
        Me.tbxshipment.Name = "tbxshipment"
        Me.tbxshipment.Size = New System.Drawing.Size(127, 20)
        Me.tbxshipment.TabIndex = 4
        '
        'tbxitem
        '
        Me.tbxitem.Location = New System.Drawing.Point(212, 51)
        Me.tbxitem.Name = "tbxitem"
        Me.tbxitem.Size = New System.Drawing.Size(127, 20)
        Me.tbxitem.TabIndex = 5
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(387, 54)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(159, 23)
        Me.btncalculate.TabIndex = 6
        Me.btncalculate.Text = "Calculate Total"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 168)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.tbxitem)
        Me.Controls.Add(Me.tbxshipment)
        Me.Controls.Add(Me.tbxtotal)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblshipment)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblshipment As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents tbxtotal As System.Windows.Forms.Label
    Friend WithEvents tbxshipment As System.Windows.Forms.TextBox
    Friend WithEvents tbxitem As System.Windows.Forms.TextBox
    Friend WithEvents btncalculate As System.Windows.Forms.Button

End Class
