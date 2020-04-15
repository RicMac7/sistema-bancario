<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formbancos
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
        Me.components = New System.ComponentModel.Container()
        Dim CodigobancoLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formbancos))
        Me.ContasbancariasDataSet = New Exercicio46.contasbancariasDataSet()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancosTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.bancosTableAdapter()
        Me.TableAdapterManager = New Exercicio46.contasbancariasDataSetTableAdapters.TableAdapterManager()
        Me.BancosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BancosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtcodigobanco = New System.Windows.Forms.TextBox()
        Me.txtbanco = New System.Windows.Forms.TextBox()
        CodigobancoLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        CType(Me.ContasbancariasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BancosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigobancoLabel
        '
        CodigobancoLabel.AutoSize = True
        CodigobancoLabel.Location = New System.Drawing.Point(75, 70)
        CodigobancoLabel.Name = "CodigobancoLabel"
        CodigobancoLabel.Size = New System.Drawing.Size(72, 13)
        CodigobancoLabel.TabIndex = 1
        CodigobancoLabel.Text = "codigobanco:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(75, 96)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 3
        BancoLabel.Text = "banco:"
        '
        'ContasbancariasDataSet
        '
        Me.ContasbancariasDataSet.DataSetName = "contasbancariasDataSet"
        Me.ContasbancariasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "bancos"
        Me.BancosBindingSource.DataSource = Me.ContasbancariasDataSet
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancosTableAdapter = Me.BancosTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.contasTableAdapter = Nothing
        Me.TableAdapterManager.movimentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Exercicio46.contasbancariasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BancosBindingNavigator
        '
        Me.BancosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BancosBindingNavigator.BindingSource = Me.BancosBindingSource
        Me.BancosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BancosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BancosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BancosBindingNavigatorSaveItem})
        Me.BancosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BancosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BancosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BancosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BancosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BancosBindingNavigator.Name = "BancosBindingNavigator"
        Me.BancosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BancosBindingNavigator.Size = New System.Drawing.Size(314, 25)
        Me.BancosBindingNavigator.TabIndex = 0
        Me.BancosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BancosBindingNavigatorSaveItem
        '
        Me.BancosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BancosBindingNavigatorSaveItem.Image = CType(resources.GetObject("BancosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BancosBindingNavigatorSaveItem.Name = "BancosBindingNavigatorSaveItem"
        Me.BancosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BancosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtcodigobanco
        '
        Me.txtcodigobanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "codigobanco", True))
        Me.txtcodigobanco.Enabled = False
        Me.txtcodigobanco.Location = New System.Drawing.Point(153, 67)
        Me.txtcodigobanco.Name = "txtcodigobanco"
        Me.txtcodigobanco.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigobanco.TabIndex = 2
        '
        'txtbanco
        '
        Me.txtbanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "banco", True))
        Me.txtbanco.Location = New System.Drawing.Point(153, 93)
        Me.txtbanco.Name = "txtbanco"
        Me.txtbanco.Size = New System.Drawing.Size(100, 20)
        Me.txtbanco.TabIndex = 4
        '
        'Formbancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 187)
        Me.Controls.Add(CodigobancoLabel)
        Me.Controls.Add(Me.txtcodigobanco)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.txtbanco)
        Me.Controls.Add(Me.BancosBindingNavigator)
        Me.Name = "Formbancos"
        Me.Text = "Bancos"
        CType(Me.ContasbancariasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BancosBindingNavigator.ResumeLayout(False)
        Me.BancosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContasbancariasDataSet As contasbancariasDataSet
    Friend WithEvents BancosBindingSource As BindingSource
    Friend WithEvents BancosTableAdapter As contasbancariasDataSetTableAdapters.bancosTableAdapter
    Friend WithEvents TableAdapterManager As contasbancariasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BancosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BancosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtcodigobanco As TextBox
    Friend WithEvents txtbanco As TextBox
End Class
