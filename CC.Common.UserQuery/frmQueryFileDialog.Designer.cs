namespace CC.Common.UserQuery
{
  partial class frmQueryFileDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lbFiles = new System.Windows.Forms.ListBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnAction = new System.Windows.Forms.Button();
      this.lblFileName = new System.Windows.Forms.Label();
      this.txtFile = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lbFiles
      // 
      this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbFiles.FormattingEnabled = true;
      this.lbFiles.IntegralHeight = false;
      this.lbFiles.Location = new System.Drawing.Point(12, 12);
      this.lbFiles.MultiColumn = true;
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(358, 176);
      this.lbFiles.TabIndex = 3;
      this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
      this.lbFiles.DoubleClick += new System.EventHandler(this.lbFiles_DoubleClick);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(294, 230);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnAction
      // 
      this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnAction.Location = new System.Drawing.Point(213, 230);
      this.btnAction.Name = "btnAction";
      this.btnAction.Size = new System.Drawing.Size(75, 23);
      this.btnAction.TabIndex = 1;
      this.btnAction.Text = "Action";
      this.btnAction.UseVisualStyleBackColor = true;
      // 
      // lblFileName
      // 
      this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblFileName.AutoSize = true;
      this.lblFileName.Location = new System.Drawing.Point(15, 202);
      this.lblFileName.Name = "lblFileName";
      this.lblFileName.Size = new System.Drawing.Size(57, 13);
      this.lblFileName.TabIndex = 3;
      this.lblFileName.Text = "File Name:";
      // 
      // txtFile
      // 
      this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFile.Location = new System.Drawing.Point(78, 199);
      this.txtFile.Name = "txtFile";
      this.txtFile.Size = new System.Drawing.Size(291, 20);
      this.txtFile.TabIndex = 0;
      // 
      // frmQueryFileDialog
      // 
      this.AcceptButton = this.btnAction;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(382, 265);
      this.Controls.Add(this.txtFile);
      this.Controls.Add(this.lblFileName);
      this.Controls.Add(this.btnAction);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.lbFiles);
      this.Name = "frmQueryFileDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "frmQueryFileDialog";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryFileDialog_FormClosing);
      this.Load += new System.EventHandler(this.frmQueryFileDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbFiles;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnAction;
    private System.Windows.Forms.Label lblFileName;
    private System.Windows.Forms.TextBox txtFile;
  }
}