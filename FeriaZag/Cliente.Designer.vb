﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.ICBNuevo = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.ICBRegistrar = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.TBDirección = New System.Windows.Forms.TextBox()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBConsulta.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBDirección)
        Me.GBMantenimiento.Controls.Add(Me.TBDni)
        Me.GBMantenimiento.Controls.Add(Me.LDirección)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevo)
        Me.GBMantenimiento.Controls.Add(Me.IconButton4)
        Me.GBMantenimiento.Controls.Add(Me.ICBRegistrar)
        Me.GBMantenimiento.Controls.Add(Me.IconButton2)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigo)
        Me.GBMantenimiento.Controls.Add(Me.LApellido)
        Me.GBMantenimiento.Controls.Add(Me.TBNombre)
        Me.GBMantenimiento.Controls.Add(Me.LDni)
        Me.GBMantenimiento.Controls.Add(Me.LTelefono)
        Me.GBMantenimiento.Controls.Add(Me.TBPrecio)
        Me.GBMantenimiento.Location = New System.Drawing.Point(12, 12)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 682)
        Me.GBMantenimiento.TabIndex = 21
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Mantenimiento"
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(24, 312)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(55, 13)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(24, 41)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(47, 13)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'ICBNuevo
        '
        Me.ICBNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevo.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ICBNuevo.IconColor = System.Drawing.Color.Black
        Me.ICBNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevo.Location = New System.Drawing.Point(40, 392)
        Me.ICBNuevo.Name = "ICBNuevo"
        Me.ICBNuevo.Size = New System.Drawing.Size(118, 42)
        Me.ICBNuevo.TabIndex = 16
        Me.ICBNuevo.Text = "Nuevo"
        Me.ICBNuevo.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.Location = New System.Drawing.Point(182, 478)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(118, 41)
        Me.IconButton4.TabIndex = 17
        Me.IconButton4.Text = "Eliminar"
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'ICBRegistrar
        '
        Me.ICBRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBRegistrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ICBRegistrar.IconColor = System.Drawing.Color.Black
        Me.ICBRegistrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBRegistrar.Location = New System.Drawing.Point(182, 393)
        Me.ICBRegistrar.Name = "ICBRegistrar"
        Me.ICBRegistrar.Size = New System.Drawing.Size(118, 41)
        Me.ICBRegistrar.TabIndex = 14
        Me.ICBRegistrar.Text = "Registrar"
        Me.ICBRegistrar.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(40, 477)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(118, 42)
        Me.IconButton2.TabIndex = 15
        Me.IconButton2.Text = "Modificar"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'TBCodigo
        '
        Me.TBCodigo.Location = New System.Drawing.Point(118, 38)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(153, 20)
        Me.TBCodigo.TabIndex = 12
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(23, 101)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(47, 13)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(118, 98)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(153, 20)
        Me.TBNombre.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(24, 165)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(29, 13)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "DNI:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(23, 237)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(118, 234)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(153, 20)
        Me.TBPrecio.TabIndex = 11
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(118, 162)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(153, 20)
        Me.TBDni.TabIndex = 18
        '
        'TBDirección
        '
        Me.TBDirección.Location = New System.Drawing.Point(118, 309)
        Me.TBDirección.Name = "TBDirección"
        Me.TBDirección.Size = New System.Drawing.Size(153, 20)
        Me.TBDirección.TabIndex = 19
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.TextBox2)
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.Label4)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TextBox1)
        Me.GBConsulta.Location = New System.Drawing.Point(416, 11)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 115)
        Me.GBConsulta.TabIndex = 22
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consulta"
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.Location = New System.Drawing.Point(665, 13)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 41)
        Me.ICBBuscar.TabIndex = 18
        Me.ICBBuscar.Text = "Buscar"
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(383, 27)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(153, 20)
        Me.TextBox2.TabIndex = 19
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Location = New System.Drawing.Point(416, 133)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 561)
        Me.GBListar.TabIndex = 23
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.DNI, Me.Telefono, Me.Dirección})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 542)
        Me.DataGridView1.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Dirección
        '
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        Me.Dirección.ReadOnly = True
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cliente"
        Me.Text = "Clientes"
        Me.GBMantenimiento.ResumeLayout(False)
        Me.GBMantenimiento.PerformLayout()
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.GBListar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBMantenimiento As GroupBox
    Friend WithEvents TBDirección As TextBox
    Friend WithEvents TBDni As TextBox
    Friend WithEvents LDirección As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents ICBNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBRegistrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Dirección As DataGridViewTextBoxColumn
End Class