
namespace SudokuForm
{
  partial class RecordsForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.RecordsTable = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).BeginInit();
      this.SuspendLayout();
      // 
      // RecordsTable
      // 
      this.RecordsTable.AllowUserToAddRows = false;
      this.RecordsTable.AllowUserToDeleteRows = false;
      this.RecordsTable.AllowUserToResizeColumns = false;
      this.RecordsTable.AllowUserToResizeRows = false;
      this.RecordsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.RecordsTable.BackgroundColor = System.Drawing.Color.PeachPuff;
      this.RecordsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.RecordsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.RecordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.AntiqueWhite;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.RecordsTable.DefaultCellStyle = dataGridViewCellStyle2;
      this.RecordsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RecordsTable.GridColor = System.Drawing.Color.SandyBrown;
      this.RecordsTable.Location = new System.Drawing.Point(0, 0);
      this.RecordsTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.RecordsTable.MinimumSize = new System.Drawing.Size(20, 20);
      this.RecordsTable.MultiSelect = false;
      this.RecordsTable.Name = "RecordsTable";
      this.RecordsTable.ReadOnly = true;
      this.RecordsTable.RowHeadersVisible = false;
      this.RecordsTable.RowHeadersWidth = 51;
      this.RecordsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.RecordsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RecordsTable.Size = new System.Drawing.Size(467, 458);
      this.RecordsTable.TabIndex = 1;
      // 
      // RecordsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.PeachPuff;
      this.ClientSize = new System.Drawing.Size(467, 458);
      this.Controls.Add(this.RecordsTable);
      this.Name = "RecordsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RecordsForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordsForm_FormClosed);
      this.Load += new System.EventHandler(this.RecordsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView RecordsTable;
  }
}