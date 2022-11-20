<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvempl = New System.Windows.Forms.DataGridView()
        Me.supp = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.chercher_T = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.RadioNom = New System.Windows.Forms.RadioButton()
        Me.Chercher = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvempl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvempl
        '
        Me.dgvempl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvempl.Location = New System.Drawing.Point(12, 38)
        Me.dgvempl.Name = "dgvempl"
        Me.dgvempl.RowHeadersWidth = 51
        Me.dgvempl.RowTemplate.Height = 24
        Me.dgvempl.Size = New System.Drawing.Size(991, 359)
        Me.dgvempl.TabIndex = 1
        '
        'supp
        '
        Me.supp.BackColor = System.Drawing.Color.DimGray
        Me.supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp.ForeColor = System.Drawing.Color.Black
        Me.supp.Location = New System.Drawing.Point(1009, 38)
        Me.supp.Name = "supp"
        Me.supp.Size = New System.Drawing.Size(146, 41)
        Me.supp.TabIndex = 3
        Me.supp.Text = "suprimmer employe"
        Me.supp.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(1009, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 41)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "modifier  emplye"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'chercher_T
        '
        Me.chercher_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chercher_T.Location = New System.Drawing.Point(513, 411)
        Me.chercher_T.Multiline = True
        Me.chercher_T.Name = "chercher_T"
        Me.chercher_T.Size = New System.Drawing.Size(146, 41)
        Me.chercher_T.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Chercher par :"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(187, 412)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(57, 33)
        Me.id.TabIndex = 7
        Me.id.TabStop = True
        Me.id.Text = "ID"
        Me.id.UseVisualStyleBackColor = True
        '
        'RadioNom
        '
        Me.RadioNom.AutoSize = True
        Me.RadioNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNom.Location = New System.Drawing.Point(277, 412)
        Me.RadioNom.Name = "RadioNom"
        Me.RadioNom.Size = New System.Drawing.Size(198, 33)
        Me.RadioNom.TabIndex = 8
        Me.RadioNom.TabStop = True
        Me.RadioNom.Text = "Nom du bateau"
        Me.RadioNom.UseVisualStyleBackColor = True
        '
        'Chercher
        '
        Me.Chercher.BackColor = System.Drawing.Color.DimGray
        Me.Chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chercher.ForeColor = System.Drawing.Color.Black
        Me.Chercher.Location = New System.Drawing.Point(683, 407)
        Me.Chercher.Name = "Chercher"
        Me.Chercher.Size = New System.Drawing.Size(146, 41)
        Me.Chercher.TabIndex = 10
        Me.Chercher.Text = "Chercher"
        Me.Chercher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Chercher.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 11
        '
        'empl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 689)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chercher)
        Me.Controls.Add(Me.RadioNom)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chercher_T)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.supp)
        Me.Controls.Add(Me.dgvempl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "empl"
        Me.Text = "empl"
        CType(Me.dgvempl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvempl As DataGridView
    Friend WithEvents supp As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents chercher_T As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As RadioButton
    Friend WithEvents RadioNom As RadioButton
    Friend WithEvents Chercher As Button
    Friend WithEvents Label2 As Label
End Class
