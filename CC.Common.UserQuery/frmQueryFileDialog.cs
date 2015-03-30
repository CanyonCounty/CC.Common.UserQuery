using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CC.Common.UserQuery
{
  public partial class frmQueryFileDialog : Form
  {
    private string _simplePath;
    private string _advancedPath;
    private QueryDialogType _vtype;
    private QueryType _qtype;
    private String _fileName;
    private String _path;
    private bool _cancel;

    public frmQueryFileDialog(string simplePath, string advancedPath)
    {
      InitializeComponent();

      _simplePath = simplePath;
      _advancedPath = advancedPath;
      
      //Directory.CreateDirectory(_simplePath);
      Directory.CreateDirectory(_advancedPath);
    }

    public QueryDialogType DialogType
    {
      set { _vtype = value; }
    }

    public QueryType QueryType
    {
      set { _qtype = value; }
    }

    public String FileName
    {
      get { return _fileName; }
      set { _fileName = value; }
    }

    private void frmQueryFileDialog_Load(object sender, EventArgs e)
    {
      //if (_qtype == null) throw new Exception("QueryType not set!");
      //if (_vtype == null) throw new Exception("DialogType not set!");
      _cancel = false;

      LoadFiles(_qtype);

      switch (_vtype)
      {
        case QueryDialogType.Open:
          Text = "Open File";
          btnAction.Text = "Open";
          txtFile.ReadOnly = true;
          break;
        case QueryDialogType.Save:
          Text = "Save File";
          btnAction.Text = "Save";
          break;
      }

      txtFile.Focus();
    }

    private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lbFiles.SelectedIndex > -1)
      {
        txtFile.Text = lbFiles.SelectedItem.ToString();
        SetFileName();
      }
    }

    private void lbFiles_DoubleClick(object sender, EventArgs e)
    {
      if (lbFiles.SelectedIndex > -1)
      {
        txtFile.Text = lbFiles.SelectedItem.ToString();
        SetFileName();

        DialogResult = DialogResult.OK;
        Close();
      }
    }

    private void frmQueryFileDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!_cancel)
      {
        if (_vtype == QueryDialogType.Save)
        {
          SetFileName();
          if (File.Exists(_fileName))
          {
            if (MessageBox.Show(this, txtFile.Text + " already exists\r\rDo you want to replace it?", "Confirm Save As", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
              e.Cancel = true;
          }
        }
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      _cancel = true;
    }

    private void SetFileName()
    {
      _fileName = _path + txtFile.Text + ".qry";
    }

    private void LoadFiles(QueryType type)
    {
      string[] files;
      if (type == QueryType.Advanced)
      {
        files = Directory.GetFiles(_advancedPath, "*.qry");
        _path = _advancedPath;
      }
      else
      {
        files = Directory.GetFiles(_simplePath, "*.qry");
        _path = _simplePath;
      }

      foreach (string file in files)
      {
        lbFiles.Items.Add(Path.GetFileNameWithoutExtension(file));
      }
    }

  }

  public enum QueryDialogType
  {
    Open,
    Save
  }

  public enum QueryType
  {
    Simple,
    Advanced
  }
}

