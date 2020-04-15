<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcontas
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NibLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim AgenciaLabel As System.Windows.Forms.Label
        Dim DataAberturaLabel As System.Windows.Forms.Label
        Dim _1_TitularLabel As System.Windows.Forms.Label
        Dim _2_TitularLabel As System.Windows.Forms.Label
        Dim SaldoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formcontas))
        Me.ContasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ContasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContasbancariasDataSet = New Exercicio46.contasbancariasDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ContasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btlistas = New System.Windows.Forms.ToolStripButton()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnib = New System.Windows.Forms.TextBox()
        Me.combobanco = New System.Windows.Forms.ComboBox()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtagencia = New System.Windows.Forms.TextBox()
        Me.dtpdata = New System.Windows.Forms.DateTimePicker()
        Me.txttitular1 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txttitular2 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grelha = New System.Windows.Forms.DataGridView()
        Me.MovimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoContaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContasTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.contasTableAdapter()
        Me.TableAdapterManager = New Exercicio46.contasbancariasDataSetTableAdapters.TableAdapterManager()
        Me.MovimentosTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.movimentosTableAdapter()
        Me.BancosTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.bancosTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuirpara = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnutransf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnubancos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuclientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClientesTableAdapter = New Exercicio46.contasbancariasDataSetTableAdapters.ClientesTableAdapter()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.btsaldo = New System.Windows.Forms.Button()
        CodigoLabel = New System.Windows.Forms.Label()
        NibLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        AgenciaLabel = New System.Windows.Forms.Label()
        DataAberturaLabel = New System.Windows.Forms.Label()
        _1_TitularLabel = New System.Windows.Forms.Label()
        _2_TitularLabel = New System.Windows.Forms.Label()
        SaldoLabel = New System.Windows.Forms.Label()
        CType(Me.ContasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContasBindingNavigator.SuspendLayout()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContasbancariasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(51, 59)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(42, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "codigo:"
        '
        'NibLabel
        '
        NibLabel.AutoSize = True
        NibLabel.Location = New System.Drawing.Point(51, 85)
        NibLabel.Name = "NibLabel"
        NibLabel.Size = New System.Drawing.Size(24, 13)
        NibLabel.TabIndex = 3
        NibLabel.Text = "nib:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(51, 111)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 5
        BancoLabel.Text = "banco:"
        '
        'AgenciaLabel
        '
        AgenciaLabel.AutoSize = True
        AgenciaLabel.Location = New System.Drawing.Point(51, 138)
        AgenciaLabel.Name = "AgenciaLabel"
        AgenciaLabel.Size = New System.Drawing.Size(48, 13)
        AgenciaLabel.TabIndex = 7
        AgenciaLabel.Text = "agencia:"
        '
        'DataAberturaLabel
        '
        DataAberturaLabel.AutoSize = True
        DataAberturaLabel.Location = New System.Drawing.Point(51, 165)
        DataAberturaLabel.Name = "DataAberturaLabel"
        DataAberturaLabel.Size = New System.Drawing.Size(74, 13)
        DataAberturaLabel.TabIndex = 9
        DataAberturaLabel.Text = "data Abertura:"
        '
        '_1_TitularLabel
        '
        _1_TitularLabel.AutoSize = True
        _1_TitularLabel.Location = New System.Drawing.Point(51, 190)
        _1_TitularLabel.Name = "_1_TitularLabel"
        _1_TitularLabel.Size = New System.Drawing.Size(48, 13)
        _1_TitularLabel.TabIndex = 11
        _1_TitularLabel.Text = "1 Titular:"
        '
        '_2_TitularLabel
        '
        _2_TitularLabel.AutoSize = True
        _2_TitularLabel.Location = New System.Drawing.Point(51, 217)
        _2_TitularLabel.Name = "_2_TitularLabel"
        _2_TitularLabel.Size = New System.Drawing.Size(48, 13)
        _2_TitularLabel.TabIndex = 13
        _2_TitularLabel.Text = "2 Titular:"
        '
        'SaldoLabel
        '
        SaldoLabel.AutoSize = True
        SaldoLabel.Location = New System.Drawing.Point(51, 244)
        SaldoLabel.Name = "SaldoLabel"
        SaldoLabel.Size = New System.Drawing.Size(37, 13)
        SaldoLabel.TabIndex = 18
        SaldoLabel.Text = "Saldo:"
        '
        'ContasBindingNavigator
        '
        Me.ContasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ContasBindingNavigator.BindingSource = Me.ContasBindingSource
        Me.ContasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContasBindingNavigator.DeleteItem = Nothing
        Me.ContasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ContasBindingNavigatorSaveItem, Me.btlistas})
        Me.ContasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ContasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContasBindingNavigator.Name = "ContasBindingNavigator"
        Me.ContasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContasBindingNavigator.Size = New System.Drawing.Size(537, 25)
        Me.ContasBindingNavigator.TabIndex = 0
        Me.ContasBindingNavigator.Text = "BindingNavigator1"
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
        'ContasBindingSource
        '
        Me.ContasBindingSource.DataMember = "contas"
        Me.ContasBindingSource.DataSource = Me.ContasbancariasDataSet
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ContasBindingNavigatorSaveItem
        '
        Me.ContasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContasBindingNavigatorSaveItem.Name = "ContasBindingNavigatorSaveItem"
        Me.ContasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ContasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btlistas
        '
        Me.btlistas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btlistas.Enabled = False
        Me.btlistas.Image = CType(resources.GetObject("btlistas.Image"), System.Drawing.Image)
        Me.btlistas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btlistas.Name = "btlistas"
        Me.btlistas.Size = New System.Drawing.Size(23, 22)
        Me.btlistas.Text = "Atualizar listas"
        Me.btlistas.Visible = False
        '
        'txtcodigo
        '
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "codigo", True))
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(131, 56)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtcodigo.TabIndex = 2
        '
        'txtnib
        '
        Me.txtnib.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "nib", True))
        Me.txtnib.Location = New System.Drawing.Point(131, 82)
        Me.txtnib.Name = "txtnib"
        Me.txtnib.Size = New System.Drawing.Size(200, 20)
        Me.txtnib.TabIndex = 4
        '
        'combobanco
        '
        Me.combobanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "banco", True))
        Me.combobanco.DataSource = Me.BancosBindingSource
        Me.combobanco.DisplayMember = "banco"
        Me.combobanco.FormattingEnabled = True
        Me.combobanco.Location = New System.Drawing.Point(131, 108)
        Me.combobanco.Name = "combobanco"
        Me.combobanco.Size = New System.Drawing.Size(200, 21)
        Me.combobanco.TabIndex = 6
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "bancos"
        Me.BancosBindingSource.DataSource = Me.ContasbancariasDataSet
        '
        'txtagencia
        '
        Me.txtagencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "agencia", True))
        Me.txtagencia.Location = New System.Drawing.Point(131, 135)
        Me.txtagencia.Name = "txtagencia"
        Me.txtagencia.Size = New System.Drawing.Size(200, 20)
        Me.txtagencia.TabIndex = 8
        '
        'dtpdata
        '
        Me.dtpdata.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ContasBindingSource, "dataAbertura", True))
        Me.dtpdata.Location = New System.Drawing.Point(131, 161)
        Me.dtpdata.Name = "dtpdata"
        Me.dtpdata.Size = New System.Drawing.Size(200, 20)
        Me.dtpdata.TabIndex = 10
        '
        'txttitular1
        '
        Me.txttitular1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "1_Titular", True))
        Me.txttitular1.DataSource = Me.ClientesBindingSource
        Me.txttitular1.DisplayMember = "Nome"
        Me.txttitular1.FormattingEnabled = True
        Me.txttitular1.Location = New System.Drawing.Point(131, 187)
        Me.txttitular1.Name = "txttitular1"
        Me.txttitular1.Size = New System.Drawing.Size(200, 21)
        Me.txttitular1.TabIndex = 12
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ContasbancariasDataSet
        '
        'txttitular2
        '
        Me.txttitular2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "2_Titular", True))
        Me.txttitular2.DataSource = Me.ClientesBindingSource1
        Me.txttitular2.DisplayMember = "Nome"
        Me.txttitular2.FormattingEnabled = True
        Me.txttitular2.Location = New System.Drawing.Point(131, 214)
        Me.txttitular2.Name = "txttitular2"
        Me.txttitular2.Size = New System.Drawing.Size(200, 21)
        Me.txttitular2.TabIndex = 14
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.ContasbancariasDataSet
        '
        'grelha
        '
        Me.grelha.AllowUserToAddRows = False
        Me.grelha.AllowUserToDeleteRows = False
        Me.grelha.AllowUserToOrderColumns = True
        Me.grelha.AutoGenerateColumns = False
        Me.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grelha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimentoDataGridViewTextBoxColumn, Me.CodigoContaDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        Me.grelha.DataSource = Me.MovimentosBindingSource
        Me.grelha.Location = New System.Drawing.Point(12, 291)
        Me.grelha.Name = "grelha"
        Me.grelha.ReadOnly = True
        Me.grelha.RowHeadersVisible = False
        Me.grelha.Size = New System.Drawing.Size(505, 227)
        Me.grelha.TabIndex = 15
        '
        'MovimentoDataGridViewTextBoxColumn
        '
        Me.MovimentoDataGridViewTextBoxColumn.DataPropertyName = "movimento"
        Me.MovimentoDataGridViewTextBoxColumn.HeaderText = "movimento"
        Me.MovimentoDataGridViewTextBoxColumn.Name = "MovimentoDataGridViewTextBoxColumn"
        Me.MovimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoContaDataGridViewTextBoxColumn
        '
        Me.CodigoContaDataGridViewTextBoxColumn.DataPropertyName = "CodigoConta"
        Me.CodigoContaDataGridViewTextBoxColumn.HeaderText = "CodigoConta"
        Me.CodigoContaDataGridViewTextBoxColumn.Name = "CodigoContaDataGridViewTextBoxColumn"
        Me.CodigoContaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "descricao"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovimentosBindingSource
        '
        Me.MovimentosBindingSource.DataMember = "movimentos"
        Me.MovimentosBindingSource.DataSource = Me.ContasbancariasDataSet
        '
        'ContasTableAdapter
        '
        Me.ContasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancosTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.contasTableAdapter = Me.ContasTableAdapter
        Me.TableAdapterManager.movimentosTableAdapter = Me.MovimentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Exercicio46.contasbancariasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MovimentosTableAdapter
        '
        Me.MovimentosTableAdapter.ClearBeforeFill = True
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuirpara, Me.ToolStripSeparator4, Me.mnutransf, Me.ToolStripSeparator3, Me.mnubancos, Me.ToolStripSeparator1, Me.mnuclientes})
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'mnuirpara
        '
        Me.mnuirpara.Name = "mnuirpara"
        Me.mnuirpara.Size = New System.Drawing.Size(148, 22)
        Me.mnuirpara.Text = "Ir para.."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(145, 6)
        '
        'mnutransf
        '
        Me.mnutransf.Name = "mnutransf"
        Me.mnutransf.Size = New System.Drawing.Size(148, 22)
        Me.mnutransf.Text = "Transferencias"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(145, 6)
        '
        'mnubancos
        '
        Me.mnubancos.Name = "mnubancos"
        Me.mnubancos.Size = New System.Drawing.Size(148, 22)
        Me.mnubancos.Text = "Gerir Bancos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'mnuclientes
        '
        Me.mnuclientes.Name = "mnuclientes"
        Me.mnuclientes.Size = New System.Drawing.Size(148, 22)
        Me.mnuclientes.Text = "Clientes"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(131, 241)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtsaldo.TabIndex = 19
        '
        'btsaldo
        '
        Me.btsaldo.Location = New System.Drawing.Point(378, 234)
        Me.btsaldo.Name = "btsaldo"
        Me.btsaldo.Size = New System.Drawing.Size(75, 23)
        Me.btsaldo.TabIndex = 20
        Me.btsaldo.Text = "Saldo"
        Me.btsaldo.UseVisualStyleBackColor = True
        '
        'Formcontas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 538)
        Me.Controls.Add(Me.btsaldo)
        Me.Controls.Add(SaldoLabel)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.grelha)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(NibLabel)
        Me.Controls.Add(Me.txtnib)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.combobanco)
        Me.Controls.Add(AgenciaLabel)
        Me.Controls.Add(Me.txtagencia)
        Me.Controls.Add(DataAberturaLabel)
        Me.Controls.Add(Me.dtpdata)
        Me.Controls.Add(_1_TitularLabel)
        Me.Controls.Add(Me.txttitular1)
        Me.Controls.Add(_2_TitularLabel)
        Me.Controls.Add(Me.txttitular2)
        Me.Controls.Add(Me.ContasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formcontas"
        Me.Text = "Contas e Movimentos"
        CType(Me.ContasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContasBindingNavigator.ResumeLayout(False)
        Me.ContasBindingNavigator.PerformLayout()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContasbancariasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grelha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContasbancariasDataSet As contasbancariasDataSet
    Friend WithEvents ContasBindingSource As BindingSource
    Friend WithEvents ContasTableAdapter As contasbancariasDataSetTableAdapters.contasTableAdapter
    Friend WithEvents TableAdapterManager As contasbancariasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContasBindingNavigator As BindingNavigator
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
    Friend WithEvents ContasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MovimentosTableAdapter As contasbancariasDataSetTableAdapters.movimentosTableAdapter
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnib As TextBox
    Friend WithEvents combobanco As ComboBox
    Friend WithEvents txtagencia As TextBox
    Friend WithEvents dtpdata As DateTimePicker
    Friend WithEvents txttitular1 As ComboBox
    Friend WithEvents txttitular2 As ComboBox
    Friend WithEvents MovimentosBindingSource As BindingSource
    Friend WithEvents grelha As DataGridView
    Friend WithEvents BancosBindingSource As BindingSource
    Friend WithEvents BancosTableAdapter As contasbancariasDataSetTableAdapters.bancosTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuirpara As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnutransf As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnubancos As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuclientes As ToolStripMenuItem
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As contasbancariasDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents btlistas As ToolStripButton
    Friend WithEvents MovimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoContaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents txtsaldo As TextBox
    Friend WithEvents btsaldo As Button
End Class
