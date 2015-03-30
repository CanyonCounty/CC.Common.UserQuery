using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CC.Common.UserQuery
{
  public class GridToCSV
  {
    private string _error;

    public GridToCSV()
    {
    }

    public string Error
    {
      get { return _error; }
    }

    public bool Export(DataGridView grid, string fileName)
    {
      bool ret = true;
      string header = String.Empty;
      string line = String.Empty;
      string data = String.Empty;
      _error = String.Empty;

      // header
      foreach (DataGridViewColumn col in grid.Columns)
      {
        if (col.Visible && !col.HeaderText.ToUpper().StartsWith("SSN"))
          header += "\"" + col.HeaderText + "\",";
      }
      data += header.TrimEnd(',');
      data += Environment.NewLine;

      try
      {
        using (StreamWriter outfile = new StreamWriter(fileName))
        {
          outfile.Write(data);

          foreach (DataGridViewRow row in grid.Rows)
          {
            if (row.Visible)
            {
              line = String.Empty;
              foreach (DataGridViewCell cel in row.Cells)
              {
                if (grid.Columns[cel.ColumnIndex].Visible && !grid.Columns[cel.ColumnIndex].HeaderText.ToUpper().StartsWith("SSN"))
                  line += "\"" + cel.Value.ToString().Replace(Environment.NewLine, "<br>") + "\",";
              }
              line = line.TrimEnd(',') + Environment.NewLine;

              outfile.Write(line);
            }
          }
          outfile.Flush();
          //outfile.Close();
        }
      }
      catch (Exception e)
      {
        ret = false;
        _error = e.Message;
      }

      return ret;
    }

    private string GetTempDir
    {
      get { return Path.GetTempPath() + @"CC.BOCC.IT.POInventoryQuery\"; }
    }

    public void OpenInExcel(DataGridView grid)
    {
      string dir = GetTempDir;
      Directory.CreateDirectory(dir);
      string fileName = dir + DateTime.Now.ToString("MMddyyyyhhmmssfffffff") + ".csv";

      Cursor.Current = Cursors.WaitCursor;
      if (this.Export(grid, fileName))
        OpenExcel(fileName);
      else
        MessageBox.Show(this.Error);

      Cursor.Current = Cursors.Default;
    }

    private void OpenExcel(string fileName)
    {
      System.Diagnostics.Process.Start("excel", "\"" + fileName + "\"");
    }

    public void ExportDialog(DataGridView grid, string fileName)
    {
      if (grid.Rows.Count > 0)
      {
        SaveFileDialog saveFileDlg = new SaveFileDialog();
        saveFileDlg.FileName = fileName;
        if (saveFileDlg.ShowDialog() == DialogResult.OK)
        {
          fileName = saveFileDlg.FileName;
          //GridToCSV g2csv = new GridToCSV(grid, fileName);
          Cursor.Current = Cursors.WaitCursor;
          if (this.Export(grid, fileName))
          {
            if (MessageBox.Show("File created, would you like to open it in Excel?", "Open in Excel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              OpenExcel(fileName);
          }
          else
            MessageBox.Show(this.Error);
          Cursor.Current = Cursors.Default;
        }
      }
    }
  }
}
