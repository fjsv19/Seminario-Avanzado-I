<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLectores))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lbklTitulo = New System.Windows.Forms.Label()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.dataLectores = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnAgregar = New System.Windows.Forms.PictureBox()
        Me.panelTitulo.SuspendLayout()
        Me.panelBusqueda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenido.SuspendLayout()
        Me.panelDatos.SuspendLayout()
        CType(Me.dataLectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLateral.SuspendLayout()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Controls.Add(Me.lbklTitulo)
        Me.panelTitulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(715, 40)
        Me.panelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(670, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 40)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lbklTitulo
        '
        Me.lbklTitulo.AutoSize = True
        Me.lbklTitulo.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbklTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbklTitulo.Name = "lbklTitulo"
        Me.lbklTitulo.Size = New System.Drawing.Size(100, 22)
        Me.lbklTitulo.TabIndex = 0
        Me.lbklTitulo.Text = "LECTORES"
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BackColor = System.Drawing.Color.White
        Me.panelBusqueda.Controls.Add(Me.txtBuscar)
        Me.panelBusqueda.Controls.Add(Me.PictureBox1)
        Me.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 40)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(715, 46)
        Me.panelBusqueda.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(62, 10)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(628, 26)
        Me.txtBuscar.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.White
        Me.panelContenido.Controls.Add(Me.panelDatos)
        Me.panelContenido.Controls.Add(Me.dataLectores)
        Me.panelContenido.Controls.Add(Me.panelLateral)
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(0, 86)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(715, 401)
        Me.panelContenido.TabIndex = 2
        '
        'panelDatos
        '
        Me.panelDatos.Controls.Add(Me.btnCancelar)
        Me.panelDatos.Controls.Add(Me.btnModificar)
        Me.panelDatos.Controls.Add(Me.btnGuardar)
        Me.panelDatos.Controls.Add(Me.txtObservacion)
        Me.panelDatos.Controls.Add(Me.txtDireccion)
        Me.panelDatos.Controls.Add(Me.txtTelefono)
        Me.panelDatos.Controls.Add(Me.txtNombre)
        Me.panelDatos.Controls.Add(Me.lblObservaciones)
        Me.panelDatos.Controls.Add(Me.lblDireccion)
        Me.panelDatos.Controls.Add(Me.txtIdentidad)
        Me.panelDatos.Controls.Add(Me.lblTelefono)
        Me.panelDatos.Controls.Add(Me.lblNombre)
        Me.panelDatos.Controls.Add(Me.lblIdentidad)
        Me.panelDatos.Location = New System.Drawing.Point(0, 0)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(715, 401)
        Me.panelDatos.TabIndex = 2
        Me.panelDatos.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(525, 341)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(124, 38)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(309, 341)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(124, 38)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(86, 341)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(124, 38)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(212, 251)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(419, 57)
        Me.txtObservacion.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(212, 174)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(419, 57)
        Me.txtDireccion.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(212, 127)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(419, 26)
        Me.txtTelefono.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(212, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(419, 26)
        Me.txtNombre.TabIndex = 1
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(73, 251)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(115, 20)
        Me.lblObservaciones.TabIndex = 0
        Me.lblObservaciones.Text = "Obsercaciones"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(73, 174)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 0
        Me.lblDireccion.Text = "Dirección"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidad.Location = New System.Drawing.Point(212, 36)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(419, 26)
        Me.txtIdentidad.TabIndex = 1
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(73, 130)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(91, 20)
        Me.lblTelefono.TabIndex = 0
        Me.lblTelefono.Text = "N° Telefono"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(73, 85)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(137, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre Completo"
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentidad.Location = New System.Drawing.Point(73, 39)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(118, 20)
        Me.lblIdentidad.TabIndex = 0
        Me.lblIdentidad.Text = "N° de Identidad"
        '
        'dataLectores
        '
        Me.dataLectores.AllowUserToAddRows = False
        Me.dataLectores.AllowUserToDeleteRows = False
        Me.dataLectores.AllowUserToResizeColumns = False
        Me.dataLectores.BackgroundColor = System.Drawing.Color.White
        Me.dataLectores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataLectores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataLectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataLectores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLectores.Location = New System.Drawing.Point(0, 0)
        Me.dataLectores.Name = "dataLectores"
        Me.dataLectores.RowHeadersVisible = False
        Me.dataLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataLectores.Size = New System.Drawing.Size(637, 401)
        Me.dataLectores.TabIndex = 1
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        '
        'panelLateral
        '
        Me.panelLateral.Controls.Add(Me.btnAgregar)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelLateral.Location = New System.Drawing.Point(637, 0)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(78, 401)
        Me.panelLateral.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(78, 401)
        Me.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.TabStop = False
        '
        'frmLectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 487)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelBusqueda)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenido.ResumeLayout(False)
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        CType(Me.dataLectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLateral.ResumeLayout(False)
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lbklTitulo As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents panelContenido As Panel
    Friend WithEvents dataLectores As DataGridView
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents panelDatos As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
