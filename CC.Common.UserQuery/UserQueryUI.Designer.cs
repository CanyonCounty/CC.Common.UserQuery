namespace CC.Common.UserQuery
{
  partial class UserQueryUI
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserQueryUI));
      this.lblCount = new System.Windows.Forms.ToolStripLabel();
      this.sepOpSelect = new System.Windows.Forms.ToolStripSeparator();
      this.cboOp = new System.Windows.Forms.ToolStripComboBox();
      this.sepLogicOp = new System.Windows.Forms.ToolStripSeparator();
      this.cboLogic = new System.Windows.Forms.ToolStripComboBox();
      this.sepExcelLogic = new System.Windows.Forms.ToolStripSeparator();
      this.btnExcel = new System.Windows.Forms.ToolStripButton();
      this.btnExport = new System.Windows.Forms.ToolStripButton();
      this.sepRunExport = new System.Windows.Forms.ToolStripSeparator();
      this.btnRun = new System.Windows.Forms.ToolStripButton();
      this.sepSaveRun = new System.Windows.Forms.ToolStripSeparator();
      this.btnSave = new System.Windows.Forms.ToolStripButton();
      this.btnOpen = new System.Windows.Forms.ToolStripButton();
      this.btnNew = new System.Windows.Forms.ToolStripButton();
      this.tsMenu = new System.Windows.Forms.ToolStrip();
      this.cboSelect = new System.Windows.Forms.ToolStripComboBox();
      this.txtAdvanced = new System.Windows.Forms.TextBox();
      this.tpAdvanced = new System.Windows.Forms.TabPage();
      this.txtSimple = new System.Windows.Forms.TextBox();
      this.tpSimple = new System.Windows.Forms.TabPage();
      this.tcQuery = new System.Windows.Forms.TabControl();
      this.txtFilter = new System.Windows.Forms.TextBox();
      this.lbFields = new System.Windows.Forms.ListBox();
      this.pnlFields = new System.Windows.Forms.Panel();
      this.split = new System.Windows.Forms.SplitContainer();
      this.grid = new System.Windows.Forms.DataGridView();
      this.tsMenu.SuspendLayout();
      this.tpAdvanced.SuspendLayout();
      this.tpSimple.SuspendLayout();
      this.tcQuery.SuspendLayout();
      this.pnlFields.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
      this.split.Panel1.SuspendLayout();
      this.split.Panel2.SuspendLayout();
      this.split.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      this.SuspendLayout();
      // 
      // lblCount
      // 
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(79, 22);
      this.lblCount.Text = "Count: 10,000";
      // 
      // sepOpSelect
      // 
      this.sepOpSelect.Name = "sepOpSelect";
      this.sepOpSelect.Size = new System.Drawing.Size(6, 25);
      // 
      // cboOp
      // 
      this.cboOp.AutoSize = false;
      this.cboOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboOp.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
      this.cboOp.Items.AddRange(new object[] {
            "=",
            "!=",
            ">",
            "<",
            ">=",
            "<="});
      this.cboOp.Name = "cboOp";
      this.cboOp.Size = new System.Drawing.Size(121, 23);
      // 
      // sepLogicOp
      // 
      this.sepLogicOp.Name = "sepLogicOp";
      this.sepLogicOp.Size = new System.Drawing.Size(6, 25);
      this.sepLogicOp.Visible = false;
      // 
      // cboLogic
      // 
      this.cboLogic.AutoSize = false;
      this.cboLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboLogic.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
      this.cboLogic.Items.AddRange(new object[] {
            "and",
            "or"});
      this.cboLogic.Name = "cboLogic";
      this.cboLogic.Size = new System.Drawing.Size(121, 23);
      this.cboLogic.Visible = false;
      // 
      // sepExcelLogic
      // 
      this.sepExcelLogic.Name = "sepExcelLogic";
      this.sepExcelLogic.Size = new System.Drawing.Size(6, 25);
      // 
      // btnExcel
      // 
      this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnExcel.Enabled = false;
      this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
      this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnExcel.Name = "btnExcel";
      this.btnExcel.Size = new System.Drawing.Size(23, 22);
      this.btnExcel.Text = "Open In Excel";
      this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
      // 
      // btnExport
      // 
      this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnExport.Enabled = false;
      this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
      this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(23, 22);
      this.btnExport.Text = "Export";
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // sepRunExport
      // 
      this.sepRunExport.Name = "sepRunExport";
      this.sepRunExport.Size = new System.Drawing.Size(6, 25);
      // 
      // btnRun
      // 
      this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnRun.Enabled = false;
      this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
      this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(23, 22);
      this.btnRun.Text = "Run";
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // sepSaveRun
      // 
      this.sepSaveRun.Name = "sepSaveRun";
      this.sepSaveRun.Size = new System.Drawing.Size(6, 25);
      // 
      // btnSave
      // 
      this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSave.Enabled = false;
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(23, 22);
      this.btnSave.Text = "Save";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnOpen
      // 
      this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
      this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(23, 22);
      this.btnOpen.Text = "Open";
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // btnNew
      // 
      this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
      this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(23, 22);
      this.btnNew.Text = "New";
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // tsMenu
      // 
      this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.sepSaveRun,
            this.btnRun,
            this.sepRunExport,
            this.btnExport,
            this.btnExcel,
            this.sepExcelLogic,
            this.cboLogic,
            this.sepLogicOp,
            this.cboOp,
            this.sepOpSelect,
            this.cboSelect,
            this.lblCount});
      this.tsMenu.Location = new System.Drawing.Point(0, 0);
      this.tsMenu.Name = "tsMenu";
      this.tsMenu.Size = new System.Drawing.Size(717, 25);
      this.tsMenu.TabIndex = 4;
      this.tsMenu.Text = "toolStrip1";
      // 
      // cboSelect
      // 
      this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboSelect.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
      this.cboSelect.Items.AddRange(new object[] {
            "select all",
            "count"});
      this.cboSelect.Name = "cboSelect";
      this.cboSelect.Size = new System.Drawing.Size(121, 25);
      // 
      // txtAdvanced
      // 
      this.txtAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAdvanced.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAdvanced.Location = new System.Drawing.Point(3, 3);
      this.txtAdvanced.Multiline = true;
      this.txtAdvanced.Name = "txtAdvanced";
      this.txtAdvanced.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtAdvanced.Size = new System.Drawing.Size(545, 191);
      this.txtAdvanced.TabIndex = 1;
      this.txtAdvanced.WordWrap = false;
      this.txtAdvanced.TextChanged += new System.EventHandler(this.txtAdvanced_TextChanged);
      // 
      // tpAdvanced
      // 
      this.tpAdvanced.Controls.Add(this.txtAdvanced);
      this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
      this.tpAdvanced.Name = "tpAdvanced";
      this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
      this.tpAdvanced.Size = new System.Drawing.Size(709, 199);
      this.tpAdvanced.TabIndex = 1;
      this.tpAdvanced.Text = "Advanced";
      this.tpAdvanced.UseVisualStyleBackColor = true;
      // 
      // txtSimple
      // 
      this.txtSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSimple.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSimple.Location = new System.Drawing.Point(3, 3);
      this.txtSimple.Multiline = true;
      this.txtSimple.Name = "txtSimple";
      this.txtSimple.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtSimple.Size = new System.Drawing.Size(545, 193);
      this.txtSimple.TabIndex = 0;
      this.txtSimple.WordWrap = false;
      this.txtSimple.TextChanged += new System.EventHandler(this.txtSimple_TextChanged);
      // 
      // tpSimple
      // 
      this.tpSimple.Controls.Add(this.txtSimple);
      this.tpSimple.Location = new System.Drawing.Point(4, 22);
      this.tpSimple.Name = "tpSimple";
      this.tpSimple.Padding = new System.Windows.Forms.Padding(3);
      this.tpSimple.Size = new System.Drawing.Size(709, 199);
      this.tpSimple.TabIndex = 0;
      this.tpSimple.Text = "Simple";
      this.tpSimple.UseVisualStyleBackColor = true;
      // 
      // tcQuery
      // 
      this.tcQuery.Controls.Add(this.tpSimple);
      this.tcQuery.Controls.Add(this.tpAdvanced);
      this.tcQuery.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tcQuery.Location = new System.Drawing.Point(0, 25);
      this.tcQuery.Name = "tcQuery";
      this.tcQuery.SelectedIndex = 0;
      this.tcQuery.Size = new System.Drawing.Size(717, 225);
      this.tcQuery.TabIndex = 3;
      this.tcQuery.SelectedIndexChanged += new System.EventHandler(this.tcQuery_SelectedIndexChanged);
      // 
      // txtFilter
      // 
      this.txtFilter.Location = new System.Drawing.Point(3, 0);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(156, 20);
      this.txtFilter.TabIndex = 1;
      this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
      // 
      // lbFields
      // 
      this.lbFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbFields.FormattingEnabled = true;
      this.lbFields.IntegralHeight = false;
      this.lbFields.Location = new System.Drawing.Point(3, 22);
      this.lbFields.Name = "lbFields";
      this.lbFields.Size = new System.Drawing.Size(159, 201);
      this.lbFields.Sorted = true;
      this.lbFields.TabIndex = 0;
      this.lbFields.DoubleClick += new System.EventHandler(this.lbFields_DoubleClick);
      // 
      // pnlFields
      // 
      this.pnlFields.Controls.Add(this.txtFilter);
      this.pnlFields.Controls.Add(this.lbFields);
      this.pnlFields.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnlFields.Location = new System.Drawing.Point(555, 25);
      this.pnlFields.Name = "pnlFields";
      this.pnlFields.Size = new System.Drawing.Size(162, 225);
      this.pnlFields.TabIndex = 0;
      // 
      // split
      // 
      this.split.Dock = System.Windows.Forms.DockStyle.Fill;
      this.split.Location = new System.Drawing.Point(0, 0);
      this.split.Name = "split";
      this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // split.Panel1
      // 
      this.split.Panel1.Controls.Add(this.pnlFields);
      this.split.Panel1.Controls.Add(this.tcQuery);
      this.split.Panel1.Controls.Add(this.tsMenu);
      // 
      // split.Panel2
      // 
      this.split.Panel2.Controls.Add(this.grid);
      this.split.Panel2.Padding = new System.Windows.Forms.Padding(5);
      this.split.Size = new System.Drawing.Size(717, 430);
      this.split.SplitterDistance = 250;
      this.split.TabIndex = 1;
      // 
      // grid
      // 
      this.grid.AllowUserToAddRows = false;
      this.grid.AllowUserToDeleteRows = false;
      this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid.Location = new System.Drawing.Point(5, 5);
      this.grid.MultiSelect = false;
      this.grid.Name = "grid";
      this.grid.ReadOnly = true;
      this.grid.RowHeadersWidth = 20;
      this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grid.Size = new System.Drawing.Size(707, 166);
      this.grid.TabIndex = 5;
      // 
      // UserQueryUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.split);
      this.Name = "UserQueryUI";
      this.Size = new System.Drawing.Size(717, 430);
      this.Load += new System.EventHandler(this.UserQueryUI_Load);
      this.tsMenu.ResumeLayout(false);
      this.tsMenu.PerformLayout();
      this.tpAdvanced.ResumeLayout(false);
      this.tpAdvanced.PerformLayout();
      this.tpSimple.ResumeLayout(false);
      this.tpSimple.PerformLayout();
      this.tcQuery.ResumeLayout(false);
      this.pnlFields.ResumeLayout(false);
      this.pnlFields.PerformLayout();
      this.split.Panel1.ResumeLayout(false);
      this.split.Panel1.PerformLayout();
      this.split.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
      this.split.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripLabel lblCount;
    private System.Windows.Forms.ToolStripSeparator sepOpSelect;
    private System.Windows.Forms.ToolStripComboBox cboOp;
    private System.Windows.Forms.ToolStripSeparator sepLogicOp;
    private System.Windows.Forms.ToolStripComboBox cboLogic;
    private System.Windows.Forms.ToolStripSeparator sepExcelLogic;
    private System.Windows.Forms.ToolStripButton btnExcel;
    private System.Windows.Forms.ToolStripButton btnExport;
    private System.Windows.Forms.ToolStripSeparator sepRunExport;
    private System.Windows.Forms.ToolStripButton btnRun;
    private System.Windows.Forms.ToolStripSeparator sepSaveRun;
    private System.Windows.Forms.ToolStripButton btnSave;
    private System.Windows.Forms.ToolStripButton btnOpen;
    private System.Windows.Forms.ToolStripButton btnNew;
    private System.Windows.Forms.ToolStrip tsMenu;
    private System.Windows.Forms.ToolStripComboBox cboSelect;
    private System.Windows.Forms.TextBox txtAdvanced;
    private System.Windows.Forms.TabPage tpAdvanced;
    private System.Windows.Forms.TextBox txtSimple;
    private System.Windows.Forms.TabPage tpSimple;
    private System.Windows.Forms.TabControl tcQuery;
    private System.Windows.Forms.TextBox txtFilter;
    private System.Windows.Forms.ListBox lbFields;
    private System.Windows.Forms.Panel pnlFields;
    private System.Windows.Forms.SplitContainer split;
    private System.Windows.Forms.DataGridView grid;
  }
}
