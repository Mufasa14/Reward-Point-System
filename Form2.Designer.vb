<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleIntLabel As System.Windows.Forms.Label
        Dim DatePurchLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim PntsEarndLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PointsTableDataSet1 = New WindowsApp2.PointsTableDataSet1()
        Me.PTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PTblTableAdapter = New WindowsApp2.PointsTableDataSet1TableAdapters.PTblTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.PointsTableDataSet1TableAdapters.TableAdapterManager()
        Me.PTblBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PTblBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleIntTextBox = New System.Windows.Forms.TextBox()
        Me.DatePurchDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PntsEarndTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccountNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePurchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PntsEarndDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AccountNumberLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleIntLabel = New System.Windows.Forms.Label()
        DatePurchLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        PntsEarndLabel = New System.Windows.Forms.Label()
        CType(Me.PointsTableDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PTblBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTblBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(18, 71)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(90, 13)
        AccountNumberLabel.TabIndex = 1
        AccountNumberLabel.Text = "Account Number:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(18, 97)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(18, 123)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleIntLabel
        '
        MiddleIntLabel.AutoSize = True
        MiddleIntLabel.Location = New System.Drawing.Point(18, 149)
        MiddleIntLabel.Name = "MiddleIntLabel"
        MiddleIntLabel.Size = New System.Drawing.Size(56, 13)
        MiddleIntLabel.TabIndex = 7
        MiddleIntLabel.Text = "Middle Int:"
        '
        'DatePurchLabel
        '
        DatePurchLabel.AutoSize = True
        DatePurchLabel.Location = New System.Drawing.Point(18, 176)
        DatePurchLabel.Name = "DatePurchLabel"
        DatePurchLabel.Size = New System.Drawing.Size(64, 13)
        DatePurchLabel.TabIndex = 9
        DatePurchLabel.Text = "Date Purch:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(18, 201)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 11
        AmountLabel.Text = "Amount:"
        '
        'PntsEarndLabel
        '
        PntsEarndLabel.AutoSize = True
        PntsEarndLabel.Location = New System.Drawing.Point(18, 227)
        PntsEarndLabel.Name = "PntsEarndLabel"
        PntsEarndLabel.Size = New System.Drawing.Size(62, 13)
        PntsEarndLabel.TabIndex = 13
        PntsEarndLabel.Text = "Pnts Earnd:"
        '
        'PointsTableDataSet1
        '
        Me.PointsTableDataSet1.DataSetName = "PointsTableDataSet1"
        Me.PointsTableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PTblBindingSource
        '
        Me.PTblBindingSource.DataMember = "PTbl"
        Me.PTblBindingSource.DataSource = Me.PointsTableDataSet1
        '
        'PTblTableAdapter
        '
        Me.PTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PTblTableAdapter = Me.PTblTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.PointsTableDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PTblBindingNavigator
        '
        Me.PTblBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PTblBindingNavigator.BindingSource = Me.PTblBindingSource
        Me.PTblBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PTblBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PTblBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PTblBindingNavigatorSaveItem})
        Me.PTblBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PTblBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PTblBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PTblBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PTblBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PTblBindingNavigator.Name = "PTblBindingNavigator"
        Me.PTblBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PTblBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PTblBindingNavigator.TabIndex = 0
        Me.PTblBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'PTblBindingNavigatorSaveItem
        '
        Me.PTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PTblBindingNavigatorSaveItem.Image = CType(resources.GetObject("PTblBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PTblBindingNavigatorSaveItem.Name = "PTblBindingNavigatorSaveItem"
        Me.PTblBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PTblBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTblBindingSource, "AccountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(114, 68)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccountNumberTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTblBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(114, 94)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTblBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(114, 120)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'MiddleIntTextBox
        '
        Me.MiddleIntTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTblBindingSource, "MiddleInt", True))
        Me.MiddleIntTextBox.Location = New System.Drawing.Point(114, 146)
        Me.MiddleIntTextBox.Name = "MiddleIntTextBox"
        Me.MiddleIntTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MiddleIntTextBox.TabIndex = 8
        '
        'DatePurchDateTimePicker
        '
        Me.DatePurchDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PTblBindingSource, "DatePurch", True))
        Me.DatePurchDateTimePicker.Location = New System.Drawing.Point(114, 172)
        Me.DatePurchDateTimePicker.Name = "DatePurchDateTimePicker"
        Me.DatePurchDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatePurchDateTimePicker.TabIndex = 10
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTblBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(114, 198)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 12
        '
        'PntsEarndTextBox
        '
        Me.PntsEarndTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PTblBindingSource, "PntsEarnd", True))
        Me.PntsEarndTextBox.Location = New System.Drawing.Point(114, 224)
        Me.PntsEarndTextBox.Name = "PntsEarndTextBox"
        Me.PntsEarndTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PntsEarndTextBox.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleIntDataGridViewTextBoxColumn, Me.DatePurchDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.PntsEarndDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(386, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(364, 259)
        Me.DataGridView1.TabIndex = 15
        Me.DataGridView1.Visible = False
        '
        'AccountNumberDataGridViewTextBoxColumn
        '
        Me.AccountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber"
        Me.AccountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber"
        Me.AccountNumberDataGridViewTextBoxColumn.Name = "AccountNumberDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleIntDataGridViewTextBoxColumn
        '
        Me.MiddleIntDataGridViewTextBoxColumn.DataPropertyName = "MiddleInt"
        Me.MiddleIntDataGridViewTextBoxColumn.HeaderText = "MiddleInt"
        Me.MiddleIntDataGridViewTextBoxColumn.Name = "MiddleIntDataGridViewTextBoxColumn"
        '
        'DatePurchDataGridViewTextBoxColumn
        '
        Me.DatePurchDataGridViewTextBoxColumn.DataPropertyName = "DatePurch"
        Me.DatePurchDataGridViewTextBoxColumn.HeaderText = "DatePurch"
        Me.DatePurchDataGridViewTextBoxColumn.Name = "DatePurchDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'PntsEarndDataGridViewTextBoxColumn
        '
        Me.PntsEarndDataGridViewTextBoxColumn.DataPropertyName = "PntsEarnd"
        Me.PntsEarndDataGridViewTextBoxColumn.HeaderText = "PntsEarnd"
        Me.PntsEarndDataGridViewTextBoxColumn.Name = "PntsEarndDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(AccountNumberLabel)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MiddleIntLabel)
        Me.Controls.Add(Me.MiddleIntTextBox)
        Me.Controls.Add(DatePurchLabel)
        Me.Controls.Add(Me.DatePurchDateTimePicker)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(PntsEarndLabel)
        Me.Controls.Add(Me.PntsEarndTextBox)
        Me.Controls.Add(Me.PTblBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PointsTableDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PTblBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTblBindingNavigator.ResumeLayout(False)
        Me.PTblBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PointsTableDataSet1 As PointsTableDataSet1
    Friend WithEvents PTblBindingSource As BindingSource
    Friend WithEvents PTblTableAdapter As PointsTableDataSet1TableAdapters.PTblTableAdapter
    Friend WithEvents TableAdapterManager As PointsTableDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PTblBindingNavigator As BindingNavigator
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
    Friend WithEvents PTblBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AccountNumberTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MiddleIntTextBox As TextBox
    Friend WithEvents DatePurchDateTimePicker As DateTimePicker
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents PntsEarndTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AccountNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatePurchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PntsEarndDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
