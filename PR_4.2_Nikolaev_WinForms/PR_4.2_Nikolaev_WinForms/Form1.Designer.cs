namespace PR_4._2_Nikolaev_WinForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nnum = new System.Windows.Forms.NumericUpDown();
            this.Mnum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.butInput = new System.Windows.Forms.Button();
            this.butOutput = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultListArray = new System.Windows.Forms.ListBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность массива";
            // 
            // Nnum
            // 
            this.Nnum.Location = new System.Drawing.Point(305, 25);
            this.Nnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nnum.Name = "Nnum";
            this.Nnum.Size = new System.Drawing.Size(65, 20);
            this.Nnum.TabIndex = 2;
            this.Nnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Nnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Mnum
            // 
            this.Mnum.Location = new System.Drawing.Point(402, 25);
            this.Mnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Mnum.Name = "Mnum";
            this.Mnum.Size = new System.Drawing.Size(65, 20);
            this.Mnum.TabIndex = 3;
            this.Mnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Mnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(376, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.Location = new System.Drawing.Point(17, 66);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGrid.Size = new System.Drawing.Size(663, 416);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGrid_EditingControlShowing);
            // 
            // butInput
            // 
            this.butInput.BackColor = System.Drawing.Color.GreenYellow;
            this.butInput.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butInput.FlatAppearance.BorderSize = 0;
            this.butInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butInput.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butInput.Location = new System.Drawing.Point(59, 488);
            this.butInput.Name = "butInput";
            this.butInput.Size = new System.Drawing.Size(250, 45);
            this.butInput.TabIndex = 4;
            this.butInput.Text = "Задать массив";
            this.butInput.UseVisualStyleBackColor = false;
            this.butInput.Click += new System.EventHandler(this.butInput_Click);
            // 
            // butOutput
            // 
            this.butOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butOutput.Enabled = false;
            this.butOutput.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butOutput.FlatAppearance.BorderSize = 0;
            this.butOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butOutput.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOutput.Location = new System.Drawing.Point(395, 488);
            this.butOutput.Name = "butOutput";
            this.butOutput.Size = new System.Drawing.Size(232, 45);
            this.butOutput.TabIndex = 5;
            this.butOutput.Text = "Вывести массив";
            this.butOutput.UseVisualStyleBackColor = false;
            this.butOutput.Click += new System.EventHandler(this.butOutput_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Black;
            this.butExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butExit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butExit.Location = new System.Drawing.Point(712, 488);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(168, 45);
            this.butExit.TabIndex = 1;
            this.butExit.Tag = "0";
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(693, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 72);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество строк, \r\nгде все элементы \r\nотрицательны = ";
            // 
            // ResultListArray
            // 
            this.ResultListArray.FormattingEnabled = true;
            this.ResultListArray.Location = new System.Drawing.Point(697, 112);
            this.ResultListArray.Name = "ResultListArray";
            this.ResultListArray.Size = new System.Drawing.Size(199, 368);
            this.ResultListArray.TabIndex = 0;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(697, 85);
            this.CountBox.Name = "CountBox";
            this.CountBox.ReadOnly = true;
            this.CountBox.Size = new System.Drawing.Size(199, 20);
            this.CountBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 545);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.ResultListArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOutput);
            this.Controls.Add(this.butInput);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mnum);
            this.Controls.Add(this.Nnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)(this.Nnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Nnum;
        private System.Windows.Forms.NumericUpDown Mnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button butInput;
        private System.Windows.Forms.Button butOutput;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ResultListArray;
        private System.Windows.Forms.TextBox CountBox;
    }
}

