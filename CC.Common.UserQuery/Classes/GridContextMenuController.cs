using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace CC.Common.UserQuery
{
  public delegate void GridAskForFileNameDelegate(object sender, ref string fileName);

  public class GridContextMenuController : IDisposable
  {
    private DataGridView _grid;
    private ContextMenuStrip _gridMenu;
    private ToolStripMenuItem _mnuExportToCSV;
    private ToolStripMenuItem _mnuOpenInExcel;
    private GridAskForFileNameDelegate _askForFileName;
    private string _fileName;

    public GridContextMenuController(DataGridView grid)
    {
      _grid = grid;
      _fileName = String.Empty;
      _askForFileName = null;

      BuildMenu();
    }

    public GridContextMenuController(DataGridView grid, string exportFileName)
    {
      _grid = grid;
      _fileName = exportFileName;
      _askForFileName = null;

      BuildMenu();
    }

    public GridContextMenuController(DataGridView grid, GridAskForFileNameDelegate askMe)
    {
      _grid = grid;
      _fileName = String.Empty;
      _askForFileName = askMe;

      BuildMenu();
    }

    public void Export()
    {
      if (_askForFileName != null)
        _askForFileName(_grid, ref _fileName);

      this.Export(_fileName);
    }

    public void Export(string fileName)
    {
      if (!String.IsNullOrEmpty(fileName))
      {
        new GridToCSV().ExportDialog(_grid, fileName);
      }
      else
      {
        throw new Exception("GridContextMenuController.Export received a null or empty file name");
      }
    }

    public void OpenInExcel()
    {
      new GridToCSV().OpenInExcel(_grid);
    }

    private void BuildMenu()
    {
      // Check to see if we already have a context menu
      bool created = false;
      if (_grid.ContextMenuStrip == null)
      {
        created = true;
        _gridMenu = new ContextMenuStrip();
      }
      else
        _gridMenu = _grid.ContextMenuStrip;

      _gridMenu.Opening += new System.ComponentModel.CancelEventHandler(this.gridMenu_Opening);

      if (!created)
      {
        _gridMenu.Items.Add(new ToolStripSeparator());
      }

      _mnuExportToCSV = new ToolStripMenuItem("Export To CSV", null, mnuExportToCSV_Click);
      _gridMenu.Items.Add(_mnuExportToCSV);

      _mnuOpenInExcel = new ToolStripMenuItem("Open In Excel", null, mnuOpenInExcel_Click);
      _gridMenu.Items.Add(_mnuOpenInExcel);

      if (created)
        _grid.ContextMenuStrip = _gridMenu;
    }

    private void mnuExportToCSV_Click(object sender, EventArgs e)
    {
      Export();
    }

    private void mnuOpenInExcel_Click(object sender, EventArgs e)
    {
      new GridToCSV().OpenInExcel(_grid);
    }

    private void gridMenu_Opening(object sender, CancelEventArgs e)
    {
      _mnuExportToCSV.Enabled = _grid.Rows.Count > 0;
      _mnuOpenInExcel.Enabled = _grid.Rows.Count > 0;
    }

    // Handle IDispose
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        // dispose managed resources
        _gridMenu.Dispose();
        _mnuExportToCSV.Dispose();
        _mnuOpenInExcel.Dispose();
      }
      // free native resources
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}
