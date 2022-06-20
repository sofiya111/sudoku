
namespace SudokuForm
{
  partial class InputNameForm
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
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.AcceptButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxName
      // 
      this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.textBoxName.Location = new System.Drawing.Point(104, 66);
      this.textBoxName.MaxLength = 10;
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(140, 38);
      this.textBoxName.TabIndex = 0;
      // 
      // AcceptButton
      // 
      this.AcceptButton.BackColor = System.Drawing.Color.AntiqueWhite;
      this.AcceptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.AcceptButton.Location = new System.Drawing.Point(127, 121);
      this.AcceptButton.Name = "AcceptButton";
      this.AcceptButton.Size = new System.Drawing.Size(94, 41);
      this.AcceptButton.TabIndex = 1;
      this.AcceptButton.Text = "ОК";
      this.AcceptButton.UseVisualStyleBackColor = false;
      this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(70, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(210, 31);
      this.label1.TabIndex = 2;
      this.label1.Text = "Введите ваше имя:";
      // 
      // InputNameForm
      // 
      this.AcceptButton = this.AcceptButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.PeachPuff;
      this.ClientSize = new System.Drawing.Size(344, 174);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.AcceptButton);
      this.Controls.Add(this.textBoxName);
      this.Name = "InputNameForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Поздравляем";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Button AcceptButton;
    private System.Windows.Forms.Label label1;
  }
}