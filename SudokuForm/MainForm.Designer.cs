
namespace SudokuForm
{
  partial class MainForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.SudokuTable = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.ButtonRecords = new System.Windows.Forms.Button();
      this.ButtonCheck = new System.Windows.Forms.Button();
      this.ButtonNewGame = new System.Windows.Forms.Button();
      this.LabelTime = new System.Windows.Forms.Label();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.HelpButton = new System.Windows.Forms.Button();
      this.SudokuPictureBox = new System.Windows.Forms.PictureBox();
      this.Timer = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SudokuPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // SudokuTable
      // 
      this.SudokuTable.AllowUserToAddRows = false;
      this.SudokuTable.AllowUserToDeleteRows = false;
      this.SudokuTable.AllowUserToResizeColumns = false;
      this.SudokuTable.AllowUserToResizeRows = false;
      this.SudokuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.SudokuTable.BackgroundColor = System.Drawing.Color.PeachPuff;
      this.SudokuTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      this.SudokuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SudokuTable.ColumnHeadersVisible = false;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.SudokuTable.DefaultCellStyle = dataGridViewCellStyle3;
      this.SudokuTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SudokuTable.GridColor = System.Drawing.Color.SandyBrown;
      this.SudokuTable.Location = new System.Drawing.Point(3, 139);
      this.SudokuTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.SudokuTable.MinimumSize = new System.Drawing.Size(20, 20);
      this.SudokuTable.MultiSelect = false;
      this.SudokuTable.Name = "SudokuTable";
      this.SudokuTable.RowHeadersVisible = false;
      this.SudokuTable.RowHeadersWidth = 51;
      this.SudokuTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.SudokuTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.SudokuTable.Size = new System.Drawing.Size(411, 379);
      this.SudokuTable.TabIndex = 0;
      this.SudokuTable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SudokuTable_EditingControlShowing);
      this.SudokuTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SudokuTable_KeyPress);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.92659F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.07341F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
      this.tableLayoutPanel1.Controls.Add(this.SudokuTable, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.LabelTime, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.SudokuPictureBox, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 15);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 522);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8996F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.1004F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
      this.tableLayoutPanel2.Controls.Add(this.ButtonRecords, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.ButtonCheck, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.ButtonNewGame, 1, 2);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(420, 139);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 3;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 379);
      this.tableLayoutPanel2.TabIndex = 2;
      // 
      // ButtonRecords
      // 
      this.ButtonRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ButtonRecords.BackColor = System.Drawing.Color.SeaShell;
      this.ButtonRecords.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ButtonRecords.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ButtonRecords.Location = new System.Drawing.Point(3, 4);
      this.ButtonRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ButtonRecords.Name = "ButtonRecords";
      this.ButtonRecords.Size = new System.Drawing.Size(213, 119);
      this.ButtonRecords.TabIndex = 1;
      this.ButtonRecords.Text = "Рекорды";
      this.ButtonRecords.UseVisualStyleBackColor = false;
      this.ButtonRecords.Click += new System.EventHandler(this.ButtonRecords_Click);
      // 
      // ButtonCheck
      // 
      this.ButtonCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ButtonCheck.BackColor = System.Drawing.Color.SeaShell;
      this.ButtonCheck.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ButtonCheck.Location = new System.Drawing.Point(3, 131);
      this.ButtonCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ButtonCheck.Name = "ButtonCheck";
      this.ButtonCheck.Size = new System.Drawing.Size(213, 117);
      this.ButtonCheck.TabIndex = 2;
      this.ButtonCheck.Text = "Проверить";
      this.ButtonCheck.UseVisualStyleBackColor = false;
      this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
      // 
      // ButtonNewGame
      // 
      this.ButtonNewGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ButtonNewGame.BackColor = System.Drawing.Color.SeaShell;
      this.ButtonNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ButtonNewGame.Location = new System.Drawing.Point(3, 256);
      this.ButtonNewGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ButtonNewGame.Name = "ButtonNewGame";
      this.ButtonNewGame.Size = new System.Drawing.Size(213, 119);
      this.ButtonNewGame.TabIndex = 3;
      this.ButtonNewGame.Text = "Новая игра";
      this.ButtonNewGame.UseVisualStyleBackColor = false;
      this.ButtonNewGame.Click += new System.EventHandler(this.NewGameButton_Click);
      // 
      // LabelTime
      // 
      this.LabelTime.AutoSize = true;
      this.LabelTime.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.LabelTime.Location = new System.Drawing.Point(420, 0);
      this.LabelTime.Name = "LabelTime";
      this.LabelTime.Size = new System.Drawing.Size(219, 135);
      this.LabelTime.TabIndex = 3;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Controls.Add(this.HelpButton, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(645, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.41085F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.58915F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(78, 129);
      this.tableLayoutPanel3.TabIndex = 5;
      // 
      // HelpButton
      // 
      this.HelpButton.BackColor = System.Drawing.Color.PaleTurquoise;
      this.HelpButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.HelpButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.HelpButton.Location = new System.Drawing.Point(3, 3);
      this.HelpButton.Name = "HelpButton";
      this.HelpButton.Size = new System.Drawing.Size(72, 49);
      this.HelpButton.TabIndex = 0;
      this.HelpButton.Text = "?";
      this.HelpButton.UseVisualStyleBackColor = false;
      this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
      // 
      // SudokuPictureBox
      // 
      this.SudokuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SudokuPictureBox.Image = global::SudokuForm.Properties.Resources.sudoku;
      this.SudokuPictureBox.Location = new System.Drawing.Point(3, 3);
      this.SudokuPictureBox.Name = "SudokuPictureBox";
      this.SudokuPictureBox.Size = new System.Drawing.Size(411, 129);
      this.SudokuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.SudokuPictureBox.TabIndex = 6;
      this.SudokuPictureBox.TabStop = false;
      this.SudokuPictureBox.Click += new System.EventHandler(this.SudokuPictureBox_Click);
      // 
      // Timer
      // 
      this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
      // 
      // BackgroundWorker
      // 
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.PeachPuff;
      this.ClientSize = new System.Drawing.Size(778, 585);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sudoku";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ClientSizeChanged += new System.EventHandler(this.MainForm_ResizeEnd);
      ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SudokuPictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView SudokuTable;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Timer Timer;
    private System.Windows.Forms.Label LabelTime;
    private System.Windows.Forms.Button ButtonRecords;
    private System.Windows.Forms.Button ButtonCheck;
    private System.Windows.Forms.Button ButtonNewGame;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button HelpButton;
    private System.Windows.Forms.PictureBox SudokuPictureBox;
    private System.ComponentModel.BackgroundWorker BackgroundWorker;
  }
}

