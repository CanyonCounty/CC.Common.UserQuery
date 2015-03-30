namespace CC.Common.UserQuery.Demo
{
  partial class frmMain
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
      this.userQueryUI1 = new CC.Common.UserQuery.UserQueryUI();
      this.SuspendLayout();
      // 
      // userQueryUI1
      // 
      this.userQueryUI1.AdvancedPath = "-PATH-";
      this.userQueryUI1.AppName = "MyCustomQuery";
      this.userQueryUI1.Config.DatabaseName = "-DatabaseName-";
      this.userQueryUI1.Config.Password = "userpwd";
      this.userQueryUI1.Config.ServerName = "-ServerName-";
      this.userQueryUI1.Config.Username = "username";
      this.userQueryUI1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.userQueryUI1.Location = new System.Drawing.Point(0, 0);
      this.userQueryUI1.Name = "userQueryUI1";
      this.userQueryUI1.SimplePath = "-PATH-";
      this.userQueryUI1.Size = new System.Drawing.Size(895, 494);
      this.userQueryUI1.TabIndex = 3;
      this.userQueryUI1.View = "vwPOInventory";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(895, 494);
      this.Controls.Add(this.userQueryUI1);
      this.Name = "frmMain";
      this.Text = "Demo";
      this.ResumeLayout(false);

    }

    #endregion

    private UserQueryUI userQueryUI1;


  }
}

