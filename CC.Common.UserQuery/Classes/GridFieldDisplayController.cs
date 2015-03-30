using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace CC.Common.UserQuery
{
  public class GridFieldDisplayController : IDisposable
  {
    private Form _frm;
    private Form _parent;
    private Button _btnOK;
    private Button _btnCancel;
    private FieldCheckedListBox _clb;
    private ToolStripMenuItem _mnuVisibleFields;
    private DataGridView _grid;
    private ContextMenuStrip _menu;
    private String _fieldText;

    public GridFieldDisplayController(DataGridView grid, Form parent)
    {
      _grid = grid;
      _parent = parent;

      BuildMenu();
      //_grid.MouseDown += grid_MouseDown;

      //_menu = new ContextMenuStrip();
      //_menu.Items.Add("Something Will Go Here");
    }

    private void BuildMenu()
    {
      // Check to see if we already have a context menu
      bool created = false;
      if (_grid.ContextMenuStrip == null)
      {
        created = true;
        _menu = new ContextMenuStrip();
      }
      else
        _menu = _grid.ContextMenuStrip;

      _menu.Opening += new System.ComponentModel.CancelEventHandler(this.gridMenu_Opening);

      if (!created)
      {
        _menu.Items.Add(new ToolStripSeparator());
      }

      _mnuVisibleFields = new ToolStripMenuItem("Select Visible Fields", null, mnuVisibleFields_Click);
      _menu.Items.Add(_mnuVisibleFields);

      if (created)
        _grid.ContextMenuStrip = _menu;
    }

    private void mnuVisibleFields_Click(object sender, EventArgs e)
    {
      HandleFields();
    }

    private void gridMenu_Opening(object sender, CancelEventArgs e)
    {
      _mnuVisibleFields.Enabled = _grid.Rows.Count > 0;
    }


    private void HandleFields()
    {
      Cursor.Current = Cursors.WaitCursor;

      _clb = new FieldCheckedListBox();
      _clb.Location = new System.Drawing.Point(12, 12);
      _clb.Size = new System.Drawing.Size(260, 199);
      _clb.Name = "clb";
      _clb.TabIndex = 0;
      _clb.IntegralHeight = false;
      _clb.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right);

      _btnOK = new Button();
      _btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      _btnOK.Location = new System.Drawing.Point(116, 227);
      _btnOK.Name = "btnOK";
      _btnOK.Size = new System.Drawing.Size(75, 23);
      _btnOK.TabIndex = 1;
      _btnOK.Text = "OK";
      _btnOK.UseVisualStyleBackColor = true;
      _btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);

      _btnCancel = new Button();
      _btnCancel.DialogResult = DialogResult.Cancel;
      _btnCancel.Location = new Point(197, 227);
      _btnCancel.Size = new Size(75, 23);
      _btnCancel.Name = "btnCancel";
      _btnCancel.TabIndex = 2;
      _btnCancel.Text = "Cancel";
      _btnCancel.UseVisualStyleBackColor = true;
      _btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);

      _frm = new Form();
      //_frm.Parent = _parent;
      _frm.ClientSize = new Size(284, 262);
      _frm.AcceptButton = _btnOK;
      _frm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      _frm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      _frm.CancelButton = _btnCancel;
      _frm.Name = "frmVisibleFields";
      _frm.FormBorderStyle = FormBorderStyle.FixedDialog;
      _frm.Text = "Select Visible Fields";
      _frm.StartPosition = FormStartPosition.CenterParent;
      _frm.FormClosing += frm_FormClosing;

      _frm.Controls.Add(_clb);
      _frm.Controls.Add(_btnOK);
      _frm.Controls.Add(_btnCancel);

      _fieldText = String.Empty;
      foreach (DataGridViewColumn col in _grid.Columns)
      {
        _clb.Items.Add(col.HeaderText);
        if (col.Visible)
          _fieldText += col.HeaderText + ",";
      }

      _clb.Text = _fieldText.TrimEnd(',');
      Cursor.Current = Cursors.WaitCursor;

      //DataGridViewColumn lastVisible = null;
      if (_frm.ShowDialog(_parent) == DialogResult.OK)
      {
        Cursor.Current = Cursors.WaitCursor;
        _fieldText = _clb.Text;
        string[] fields = _fieldText.Split(',');
        foreach (DataGridViewColumn col in _grid.Columns)
        {
          if (fields.Contains(col.HeaderText))
          {
            col.Visible = true;
            //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //lastVisible = col;
          }
          else
            col.Visible = false;
        }

        //lastVisible.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Cursor.Current = Cursors.Default;
      }

      _frm.Dispose();

    }

    private void frm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (_clb.Text.Length < 1)
      {
        MessageBox.Show("You must have at least one visible field!");
        e.Cancel = true;
      }
    }

    //private void grid_MouseDown(object sender, MouseEventArgs e)
    //{
    //  if (e.Button == MouseButtons.Right)
    //  {
    //    if (_grid.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.ColumnHeader)
    //    {
    //      _menu.Show(_grid, e.Location);
    //    }
    //  }
    //}

    // Handle IDispose
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        // dispose managed resources
        _frm.Dispose();
        _btnOK.Dispose();
        _btnCancel.Dispose();
        _clb.Dispose();
        _mnuVisibleFields.Dispose();
        _menu.Dispose();
      }
      // free native resources
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    // I don't like it here but F*CK'n Visual Studio will think the whole damn file is a control
    internal class FieldCheckedListBox : CheckedListBox
    {
      //Properties
      private List<string> _StringList;
      private char _Delimiter;
      private char[] _DelimArray;
      private bool _Flag;


      //Constructors
      public FieldCheckedListBox()
      {
        InitializeProperties();
      }

      private void InitializeProperties()
      {
        _StringList = new List<string>();
        _Delimiter = ',';
        // Create this only once, and not each time it's called
        _DelimArray = new char[] { _Delimiter };
        // Used to signal that I'm changing a property so it's not called twice
        _Flag = false;

        // set out property
        this.CheckOnClick = true;

        this.ItemCheck += new ItemCheckEventHandler(this.CCCheckedListBox_ItemCheck);
      }


      //Accessors
      public new string Text
      {
        get
        {
          return GetText();
        }
        set
        {
          SetText(value);
        }
      }


      //Event Handlers
      private void CCCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
      {
        if (!_Flag)
        {
          if (e.NewValue == CheckState.Checked)
            _StringList.Add(Items[e.Index].ToString().Trim());
          else
            _StringList.Remove(Items[e.Index].ToString().Trim());
        }
      }

      //Methods
      private string GetText()
      {
        string text = "";

        foreach (string str in _StringList)
          text += str + _Delimiter;

        text = text.TrimEnd(_DelimArray);

        return text;
      }

      private void SetText(string value)
      {
        // Flag that I'm beginning to change things
        _Flag = true;
        // UnCheck/Reset Everything
        _StringList.Clear();

        for (int i = 0; i < Items.Count; i++)
        {
          // Calling inherited method
          this.SetItemChecked(i, false);
        }

        if (!string.IsNullOrEmpty(value))
        {
          string[] strArray = value.Split(_Delimiter);

          foreach (string str in strArray)
          {
            int index = this.Items.IndexOf(str.Trim());
            if (index > -1)
            {
              // Calling inherited method
              this.SetItemChecked(index, true);

              // Only add if it's not already there
              // This is so you can select items programitacally
              // and it will handle it if it's already selected but not 
              // continue to add Items to the _StringList
              // ie: CCCheckListBox.Text += ",Item I want to select"; // Notice the comma
              if (_StringList.IndexOf(str.Trim()) == -1)
              {
                _StringList.Add(str.Trim());
              }
            }
          }
        }

        // Flag that I'm done changing things
        _Flag = false;
      }
    }
  }
}
