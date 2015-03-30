using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CC.Common.UserQuery.Data;

namespace CC.Common.UserQuery
{
  public partial class UserQueryUI : UserControl
  {
    private string[] _items;
    private TextBox _tb;
    private QueryType _vtype;
    private GridContextMenuController _gridCtl;

    [Category("\tCCUserQuery")]
    [Description("Set this to a view to pull fields from")]
    [DisplayName("Database View Name")]
    public String View { get; set; }

    [Category("\tCCUserQuery")]
    [DisplayName("Application Name")]
    [Description("When data is exported this is prepended to the file name by default")]
    public String AppName { get; set; }

    [Category("\tCCUserQuery")]
    [DisplayName("Path (Simple)")]
    [Description("Set this to the path to read/write simple queries")]
    public String SimplePath { get; set; }

    [Category("\tCCUserQuery")]
    [DisplayName("Path (Advanced)")]
    [Description("Set this to the path to read/write advanced queries")]
    public String AdvancedPath { get; set; }

    [Category("\tCCUserQuery")]
    [DisplayName("Database Config")]
    [Description("The Database Configuration to use - choose a username with select only permissions")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public UserQueryConfig Config { get; set; }

    public UserQueryUI()
    {
      InitializeComponent();
      this.Config = new UserQueryConfig();
    }

    public UserQueryUI(string view, string appName): this()
    {
      this.View = view;
      this.AppName = appName;
    }

    private void UserQueryUI_Load(object sender, EventArgs e)
    {
      if (!this.DesignMode)
      {
        lblCount.Text = "";
        DataHandler dh = new DataHandler(this.Config);
        _items = dh.GetFields(this.View);
        if (_items.Count() == 0) MessageBox.Show(dh.Message);
        lbFields.Items.AddRange(_items);
        cboLogic.SelectedIndex = 0;
        cboLogic.Width = 60;
        cboOp.SelectedIndex = 0;
        cboOp.Width = 50;
        cboSelect.Width = 80;
        cboSelect.SelectedIndex = 0;

        _tb = txtSimple;
        _vtype = QueryType.Simple;
        _gridCtl = new GridContextMenuController(grid, GridAskForFileName);
        new GridFieldDisplayController(grid, (Form)this.Parent);
        //new NotificationCardController(grid, GridAskForWhereClause);
      }
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
      if (txtFilter.Text.Trim().Equals(String.Empty))
      {
        lbFields.Items.Clear();
        lbFields.Items.AddRange(_items);
      }
      else
      {
        List<string> list = _items.ToList();
        list.RemoveAll(p => !p.ToUpper().Contains(txtFilter.Text.ToUpper()));
        lbFields.Items.Clear();
        lbFields.Items.AddRange(list.ToArray());
      }
    }

    private void lbFields_DoubleClick(object sender, EventArgs e)
    {
      if (lbFields.SelectedIndex > -1)
      {
        HandleText(lbFields.SelectedItem.ToString(), tcQuery.SelectedTab);
      }
    }

    private void tcQuery_SelectedIndexChanged(object sender, EventArgs e)
    {
      _tb = tcQuery.SelectedTab == tpAdvanced ? txtAdvanced : txtSimple;
      _vtype = tcQuery.SelectedTab == tpAdvanced ? QueryType.Advanced : QueryType.Simple;
      bool advanced = tcQuery.SelectedTab == tpAdvanced;

      if (advanced)
      {
        if (txtSimple.Text.Trim().Length > 0 && txtAdvanced.Text.Trim().Length == 0)
        {
          string select = "select *";
          if (cboSelect.SelectedIndex == 1) select = "select count(*) as count";
          txtAdvanced.Text = select + Environment.NewLine + "from " + this.View + " where" + Environment.NewLine + txtSimple.Text;
        }
      }

      cboLogic.Visible = !advanced;
      cboOp.Visible = !advanced;
      cboSelect.Visible = !advanced;
      //sepExcelLogic.Visible = !advanced;
      sepLogicOp.Visible = !advanced;
      sepOpSelect.Visible = !advanced;
      HandleTextChange();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      ClearQuery();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      OpenQuery();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveQuery();
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
      RunQuery();
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      Export();
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      Excel();
    }

    private void txtSimple_TextChanged(object sender, EventArgs e)
    {
      HandleTextChange();
    }

    private void txtAdvanced_TextChanged(object sender, EventArgs e)
    {
      HandleTextChange();
    }

    private void HandleTextChange()
    {
      bool empty = _tb.Text.Trim().Equals(String.Empty);
      cboLogic.Visible = !empty;
      sepLogicOp.Visible = !empty;
      btnSave.Enabled = !empty;
      btnRun.Enabled = !empty;
    }

    private void HandleText(string field, TabPage tabPage)
    {
      if (_tb.Text.Trim() == String.Empty)
      {
        _tb.Text = field + " " + cboOp.SelectedItem.ToString() + " ''";
      }
      else
      {
        if (_tb == txtSimple)
          _tb.Text += "\r\n" + cboLogic.SelectedItem.ToString() + " " + field + " " + cboOp.SelectedItem.ToString() + " ''";
        else
          _tb.Text = _tb.Text.Insert(_tb.SelectionStart, field);
      }
    }

    private void ClearQuery()
    {
      _tb.Text = String.Empty;
    }

    private void OpenQuery()
    {
      frmQueryFileDialog frm = new frmQueryFileDialog(this.SimplePath, this.AdvancedPath);
      frm.DialogType = QueryDialogType.Open;
      frm.QueryType = _vtype;
      if (frm.ShowDialog(this) == DialogResult.OK)
      {
        _tb.Text = String.Join("\r\n", File.ReadAllLines(frm.FileName));
      }
      frm.Dispose();
    }

    private void SaveQuery()
    {
      frmQueryFileDialog frm = new frmQueryFileDialog(this.SimplePath, this.AdvancedPath);
      frm.DialogType = QueryDialogType.Save;
      frm.QueryType = _vtype;
      if (frm.ShowDialog(this) == DialogResult.OK)
      {
        using (StreamWriter sw = new StreamWriter(frm.FileName))
        {
          sw.Write(_tb.Text);
          sw.Flush();
          //sw.Close();
        }
      }
      frm.Dispose();
    }

    private void RunQuery()
    {
      // Lets build our query
      Cursor.Current = Cursors.WaitCursor;
      lblCount.Text = "";
      string sql;
      if (_tb == txtSimple)
      {
        sql = " from " + this.View + " where " + _tb.Text;
        switch (cboSelect.SelectedIndex)
        {
          case 0:
            sql = "select * " + sql;
            break;
          case 1:
            sql = "select count(*) as count " + sql;
            break;
        }
      }
      else
      {
        sql = _tb.Text;
      }

      QueryHandler qh = new QueryHandler(this.Config);
      DataTable table = qh.GetTableQuery(sql);
      if (table != null)
      {
        grid.DataSource = table;
        if (table.Columns.Count < 10)
          grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        btnExcel.Enabled = table.Rows.Count > 0;
        btnExport.Enabled = table.Rows.Count > 0;
        lblCount.Text = String.Format("Rows: {0:n0}", table.Rows.Count);
        Cursor.Current = Cursors.Default;
      }
      else
      {
        MessageBox.Show(qh.Message);
      }
    }

    private string GetFileName()
    {
      return this.AppName + " - " + DateTime.Now.ToString("MMM d yyyy hh-mm-ss") + ".csv";
    }

    private string GetWhereClause()
    {
      string ret = String.Empty;
      if (_tb == txtSimple)
      {
        // Simple is only the where clause
        ret = _tb.Text;
      }
      else
      {
        ret = _tb.Text;
        // Hopefully advanced only has one, and it's the right one...
        ret = ret.Substring(ret.IndexOf("where") + 5);
      }
      return ret;
    }

    private void GridAskForFileName(object sender, ref string fileName)
    {
      fileName = GetFileName();
    }

    private void GridAskForWhereClause(object sender, ref string whereClause)
    {
      whereClause = GetWhereClause();
    }

    private void Export()
    {
      _gridCtl.Export(GetFileName());
    }

    private void Excel()
    {
      _gridCtl.OpenInExcel();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      const int WM_KEYDOWN = 0x100;
      const int WM_SYSKEYDOWN = 0x104;

      if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
      {
        switch (keyData)
        {
          case Keys.Control | Keys.S:
            SaveQuery();
            break;

          case Keys.Control | Keys.N:
            ClearQuery();
            break;

          case Keys.Control | Keys.O:
            OpenQuery();
            break;

          case Keys.Control | Keys.R:
            RunQuery();
            break;

          case Keys.Control | Keys.E:
            Excel();
            break;

          case Keys.Control | Keys.W:
            Export();
            break;

          case Keys.F5:
            RunQuery();
            break;

          case Keys.F6:
            Export();
            break;
        }
      }

      return base.ProcessCmdKey(ref msg, keyData);
    }
  }
}
