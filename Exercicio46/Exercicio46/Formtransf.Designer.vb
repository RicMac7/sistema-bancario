<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formtransf
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
        Dim MovimentoLabel As System.Windows.Forms.Label
        Dim CodigoContaLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim SaldoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formtransf))
        Me.MovimentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.MovimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContasbancariasDataSet = New Exercicio46.contasbancariasDataSet()
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MovimentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtmovi = New System.Windows.Forms.TextBox()
        Me.txtcodigo1 = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.bttres = New System.Windows.Forms.Button()
        Me.txtres = New System.Windows.Forms.TextBox()
        Me.lbsaldo2 = New System.Windows.Forms.Label()
        Me.MovimentosTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.movimentosTableAdapter()
        Me.TableAdapterManager = New Exercicio46.contasbancariasDataSetTableAdapters.TableAdapterManager()
        Me.btsaldo1 = New System.Windows.Forms.Button()
        Me.ContasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContasTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.contasTableAdapter()
        Me.grelhacontas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grelhatransf = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        MovimentoLabel = New System.Windows.Forms.Label()
        CodigoContaLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        SaldoLabel = New System.Windows.Forms.Label()
        CType(Me.MovimentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MovimentosBindingNavigator.SuspendLayout()
        CType(Me.MovimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContasbancariasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grelhacontas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grelhatransf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovimentoLabel
        '
        MovimentoLabel.AutoSize = True
        MovimentoLabel.Location = New System.Drawing.Point(82, 56)
        MovimentoLabel.Name = "MovimentoLabel"
        MovimentoLabel.Size = New System.Drawing.Size(61, 13)
        MovimentoLabel.TabIndex = 1
        MovimentoLabel.Text = "movimento:"
        '
        'CodigoContaLabel
        '
        CodigoContaLabel.AutoSize = True
        CodigoContaLabel.Location = New System.Drawing.Point(82, 82)
        CodigoContaLabel.Name = "CodigoContaLabel"
        CodigoContaLabel.Size = New System.Drawing.Size(74, 13)
        CodigoContaLabel.TabIndex = 3
        CodigoContaLabel.Text = "Codigo Conta:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(82, 109)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 5
        DataLabel.Text = "Data:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(82, 134)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(56, 13)
        DescricaoLabel.TabIndex = 7
        DescricaoLabel.Text = "descricao:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(82, 160)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(33, 13)
        ValorLabel.TabIndex = 9
        ValorLabel.Text = "valor:"
        '
        'SaldoLabel
        '
        SaldoLabel.AutoSize = True
        SaldoLabel.Location = New System.Drawing.Point(98, 220)
        SaldoLabel.Name = "SaldoLabel"
        SaldoLabel.Size = New System.Drawing.Size(37, 13)
        SaldoLabel.TabIndex = 14
        SaldoLabel.Text = "Saldo:"
        '
        'MovimentosBindingNavigator
        '
        Me.MovimentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MovimentosBindingNavigator.BindingSource = Me.MovimentosBindingSource
        Me.MovimentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MovimentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MovimentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.MovimentosBindingNavigatorSaveItem})
        Me.MovimentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MovimentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MovimentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MovimentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MovimentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MovimentosBindingNavigator.Name = "MovimentosBindingNavigator"
        Me.MovimentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MovimentosBindingNavigator.Size = New System.Drawing.Size(455, 25)
        Me.MovimentosBindingNavigator.TabIndex = 0
        Me.MovimentosBindingNavigator.Text = "BindingNavigator1"
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
        'MovimentosBindingSource
        '
        Me.MovimentosBindingSource.DataMember = "movimentos"
        Me.MovimentosBindingSource.DataSource = Me.ContasbancariasDataSet
        '
        'ContasbancariasDataSet
        '
        Me.ContasbancariasDataSet.DataSetName = "contasbancariasDataSet"
        Me.ContasbancariasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Enabled = False
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
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
        Me.BindingNavigatorMoveFirstItem.Enabled = False
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Enabled = False
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Enabled = False
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Enabled = False
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MovimentosBindingNavigatorSaveItem
        '
        Me.MovimentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MovimentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("MovimentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MovimentosBindingNavigatorSaveItem.Name = "MovimentosBindingNavigatorSaveItem"
        Me.MovimentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MovimentosBindingNavigatorSaveItem.Text = "Confirmar transferencia"
        '
        'txtmovi
        '
        Me.txtmovi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimentosBindingSource, "movimento", True))
        Me.txtmovi.Enabled = False
        Me.txtmovi.Location = New System.Drawing.Point(162, 53)
        Me.txtmovi.Name = "txtmovi"
        Me.txtmovi.Size = New System.Drawing.Size(200, 20)
        Me.txtmovi.TabIndex = 2
        '
        'txtcodigo1
        '
        Me.txtcodigo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimentosBindingSource, "CodigoConta", True))
        Me.txtcodigo1.Location = New System.Drawing.Point(162, 79)
        Me.txtcodigo1.Name = "txtcodigo1"
        Me.txtcodigo1.Size = New System.Drawing.Size(200, 20)
        Me.txtcodigo1.TabIndex = 4
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MovimentosBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(162, 105)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 6
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimentosBindingSource, "descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(162, 131)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescricaoTextBox.TabIndex = 8
        '
        'txtvalor
        '
        Me.txtvalor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimentosBindingSource, "valor", True))
        Me.txtvalor.Location = New System.Drawing.Point(162, 157)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(200, 20)
        Me.txtvalor.TabIndex = 10
        '
        'bttres
        '
        Me.bttres.Location = New System.Drawing.Point(35, 257)
        Me.bttres.Name = "bttres"
        Me.bttres.Size = New System.Drawing.Size(192, 37)
        Me.bttres.TabIndex = 13
        Me.bttres.Text = "calcular antes de transferir:"
        Me.bttres.UseVisualStyleBackColor = True
        '
        'txtres
        '
        Me.txtres.Location = New System.Drawing.Point(233, 266)
        Me.txtres.Name = "txtres"
        Me.txtres.Size = New System.Drawing.Size(103, 20)
        Me.txtres.TabIndex = 14
        '
        'lbsaldo2
        '
        Me.lbsaldo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbsaldo2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbsaldo2.Location = New System.Drawing.Point(178, 220)
        Me.lbsaldo2.Name = "lbsaldo2"
        Me.lbsaldo2.Size = New System.Drawing.Size(100, 23)
        Me.lbsaldo2.TabIndex = 16
        '
        'MovimentosTableAdapter
        '
        Me.MovimentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancosTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.contasTableAdapter = Nothing
        Me.TableAdapterManager.movimentosTableAdapter = Me.MovimentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Exercicio46.contasbancariasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btsaldo1
        '
        Me.btsaldo1.Location = New System.Drawing.Point(303, 220)
        Me.btsaldo1.Name = "btsaldo1"
        Me.btsaldo1.Size = New System.Drawing.Size(75, 23)
        Me.btsaldo1.TabIndex = 17
        Me.btsaldo1.Text = "Saldo"
        Me.btsaldo1.UseVisualStyleBackColor = True
        '
        'ContasBindingSource
        '
        Me.ContasBindingSource.DataMember = "contas"
        Me.ContasBindingSource.DataSource = Me.ContasbancariasDataSet
        '
        'ContasTableAdapter
        '
        Me.ContasTableAdapter.ClearBeforeFill = True
        '
        'grelhacontas
        '
        Me.grelhacontas.AutoGenerateColumns = False
        Me.grelhacontas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grelhacontas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.grelhacontas.DataSource = Me.ContasBindingSource
        Me.grelhacontas.Location = New System.Drawing.Point(397, 324)
        Me.grelhacontas.Name = "grelhacontas"
        Me.grelhacontas.Size = New System.Drawing.Size(300, 220)
        Me.grelhacontas.TabIndex = 17
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nib"
        Me.DataGridViewTextBoxColumn7.HeaderText = "nib"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "banco"
        Me.DataGridViewTextBoxColumn8.HeaderText = "banco"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "agencia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "agencia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "dataAbertura"
        Me.DataGridViewTextBoxColumn10.HeaderText = "dataAbertura"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "1_Titular"
        Me.DataGridViewTextBoxColumn11.HeaderText = "1_Titular"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "2_Titular"
        Me.DataGridViewTextBoxColumn12.HeaderText = "2_Titular"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'grelhatransf
        '
        Me.grelhatransf.AutoGenerateColumns = False
        Me.grelhatransf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grelhatransf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.grelhatransf.DataSource = Me.MovimentosBindingSource
        Me.grelhatransf.Location = New System.Drawing.Point(45, 315)
        Me.grelhatransf.Name = "grelhatransf"
        Me.grelhatransf.Size = New System.Drawing.Size(300, 220)
        Me.grelhatransf.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "movimento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "movimento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodigoConta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodigoConta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descricao"
        Me.DataGridViewTextBoxColumn4.HeaderText = "descricao"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Formtransf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 219)
        Me.Controls.Add(Me.grelhatransf)
        Me.Controls.Add(Me.grelhacontas)
        Me.Controls.Add(Me.btsaldo1)
        Me.Controls.Add(Me.lbsaldo2)
        Me.Controls.Add(SaldoLabel)
        Me.Controls.Add(Me.txtres)
        Me.Controls.Add(Me.bttres)
        Me.Controls.Add(MovimentoLabel)
        Me.Controls.Add(Me.txtmovi)
        Me.Controls.Add(CodigoContaLabel)
        Me.Controls.Add(Me.txtcodigo1)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.MovimentosBindingNavigator)
        Me.Name = "Formtransf"
        Me.Text = "transferencias"
        CType(Me.MovimentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MovimentosBindingNavigator.ResumeLayout(False)
        Me.MovimentosBindingNavigator.PerformLayout()
        CType(Me.MovimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContasbancariasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grelhacontas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grelhatransf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContasbancariasDataSet As contasbancariasDataSet
    Friend WithEvents MovimentosBindingSource As BindingSource
    Friend WithEvents MovimentosTableAdapter As contasbancariasDataSetTableAdapters.movimentosTableAdapter
    Friend WithEvents TableAdapterManager As contasbancariasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MovimentosBindingNavigator As BindingNavigator
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
    Friend WithEvents MovimentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtmovi As TextBox
    Friend WithEvents txtcodigo1 As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents bttres As Button
    Friend WithEvents txtres As TextBox
    Friend WithEvents lbsaldo2 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btsaldo1 As Button
    Friend WithEvents ContasBindingSource As BindingSource
    Friend WithEvents ContasTableAdapter As contasbancariasDataSetTableAdapters.contasTableAdapter
    Friend WithEvents grelhacontas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents grelhatransf As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
