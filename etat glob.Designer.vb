<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chercher = New System.Windows.Forms.Button()
        Me.Radiopre = New System.Windows.Forms.RadioButton()
        Me.RadioNom = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chercher_T = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(841, 381)
        Me.DataGridView1.TabIndex = 7
        '
        'Chercher
        '
        Me.Chercher.BackColor = System.Drawing.Color.DimGray
        Me.Chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chercher.ForeColor = System.Drawing.Color.Black
        Me.Chercher.Location = New System.Drawing.Point(709, 538)
        Me.Chercher.Name = "Chercher"
        Me.Chercher.Size = New System.Drawing.Size(146, 36)
        Me.Chercher.TabIndex = 16
        Me.Chercher.Text = "Chercher"
        Me.Chercher.UseVisualStyleBackColor = False
        '
        'Radiopre
        '
        Me.Radiopre.AutoSize = True
        Me.Radiopre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radiopre.Location = New System.Drawing.Point(413, 541)
        Me.Radiopre.Name = "Radiopre"
        Me.Radiopre.Size = New System.Drawing.Size(83, 33)
        Me.Radiopre.TabIndex = 15
        Me.Radiopre.TabStop = True
        Me.Radiopre.Text = "N_G"
        Me.Radiopre.UseVisualStyleBackColor = True
        '
        'RadioNom
        '
        Me.RadioNom.AutoSize = True
        Me.RadioNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNom.Location = New System.Drawing.Point(180, 539)
        Me.RadioNom.Name = "RadioNom"
        Me.RadioNom.Size = New System.Drawing.Size(198, 33)
        Me.RadioNom.TabIndex = 14
        Me.RadioNom.TabStop = True
        Me.RadioNom.Text = "Nom du bateau"
        Me.RadioNom.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 541)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Chercher par :"
        '
        'chercher_T
        '
        Me.chercher_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chercher_T.Location = New System.Drawing.Point(543, 542)
        Me.chercher_T.Multiline = True
        Me.chercher_T.Name = "chercher_T"
        Me.chercher_T.Size = New System.Drawing.Size(146, 32)
        Me.chercher_T.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre d'entrées :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 29)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Nom du bateau : "
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(734, 114)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(637, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Année :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(861, 205)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 41)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "modifier  emplye"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(486, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-9, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(640, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "_______________________________________________________________________________"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 602)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chercher_T)
        Me.Controls.Add(Me.Chercher)
        Me.Controls.Add(Me.Radiopre)
        Me.Controls.Add(Me.RadioNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormProductos"
        Me.Text = "FormProductos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Chercher As Button
    Friend WithEvents Radiopre As RadioButton
    Friend WithEvents RadioNom As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents chercher_T As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
