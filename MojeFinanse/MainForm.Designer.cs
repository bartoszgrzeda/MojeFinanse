namespace MojeFinanse
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.navigatorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.categoriesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.categoriesCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.toDatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateCheckBox = new System.Windows.Forms.CheckBox();
            this.mainPanel.SuspendLayout();
            this.navigatorPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.categoriesPanel.SuspendLayout();
            this.toDatePanel.SuspendLayout();
            this.fromDatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainPanel.Controls.Add(this.closeButton, 0, 2);
            this.mainPanel.Controls.Add(this.navigatorPanel, 0, 1);
            this.mainPanel.Controls.Add(this.filterPanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.Size = new System.Drawing.Size(944, 501);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(3, 453);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 45);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // navigatorPanel
            // 
            this.navigatorPanel.ColumnCount = 1;
            this.navigatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigatorPanel.Controls.Add(this.categoriesButton, 0, 2);
            this.navigatorPanel.Controls.Add(this.removeButton, 0, 1);
            this.navigatorPanel.Controls.Add(this.addButton, 0, 0);
            this.navigatorPanel.Controls.Add(this.settingsButton, 0, 7);
            this.navigatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigatorPanel.Location = new System.Drawing.Point(0, 75);
            this.navigatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigatorPanel.Name = "navigatorPanel";
            this.navigatorPanel.RowCount = 8;
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.navigatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.navigatorPanel.Size = new System.Drawing.Size(94, 375);
            this.navigatorPanel.TabIndex = 1;
            this.navigatorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navigatorPanel_Paint);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoriesButton.Location = new System.Drawing.Point(3, 95);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(88, 40);
            this.categoriesButton.TabIndex = 5;
            this.categoriesButton.Text = "&Kategorie";
            this.categoriesButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeButton.Location = new System.Drawing.Point(3, 49);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 40);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "&Usuń";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.Location = new System.Drawing.Point(3, 325);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(88, 47);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "U&stawienia";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // filterPanel
            // 
            this.filterPanel.ColumnCount = 8;
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterPanel.Controls.Add(this.categoriesPanel, 0, 0);
            this.filterPanel.Controls.Add(this.toDatePanel, 0, 0);
            this.filterPanel.Controls.Add(this.fromDatePanel, 0, 0);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(94, 0);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.RowCount = 1;
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterPanel.Size = new System.Drawing.Size(850, 75);
            this.filterPanel.TabIndex = 2;
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.ColumnCount = 1;
            this.categoriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.categoriesPanel.Controls.Add(this.categoriesCheckBox, 0, 0);
            this.categoriesPanel.Controls.Add(this.categoriesComboBox, 0, 1);
            this.categoriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesPanel.Location = new System.Drawing.Point(186, 0);
            this.categoriesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.RowCount = 2;
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.categoriesPanel.Size = new System.Drawing.Size(562, 75);
            this.categoriesPanel.TabIndex = 2;
            // 
            // categoriesCheckBox
            // 
            this.categoriesCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.categoriesCheckBox.AutoSize = true;
            this.categoriesCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoriesCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoriesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoriesCheckBox.Location = new System.Drawing.Point(3, 11);
            this.categoriesCheckBox.Name = "categoriesCheckBox";
            this.categoriesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoriesCheckBox.Size = new System.Drawing.Size(556, 23);
            this.categoriesCheckBox.TabIndex = 2;
            this.categoriesCheckBox.Text = "Do daty:";
            this.categoriesCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Items.AddRange(new object[] {
            "Tu",
            "Będą",
            "Dane",
            "Z",
            "Bazy"});
            this.categoriesComboBox.Location = new System.Drawing.Point(3, 40);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesComboBox.TabIndex = 3;
            // 
            // toDatePanel
            // 
            this.toDatePanel.ColumnCount = 1;
            this.toDatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toDatePanel.Controls.Add(this.toDatePicker, 0, 1);
            this.toDatePanel.Controls.Add(this.toDateCheckBox, 0, 0);
            this.toDatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toDatePanel.Location = new System.Drawing.Point(93, 0);
            this.toDatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.toDatePanel.Name = "toDatePanel";
            this.toDatePanel.RowCount = 2;
            this.toDatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toDatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toDatePanel.Size = new System.Drawing.Size(93, 75);
            this.toDatePanel.TabIndex = 1;
            // 
            // toDatePicker
            // 
            this.toDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(3, 40);
            this.toDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.toDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(87, 20);
            this.toDatePicker.TabIndex = 1;
            // 
            // toDateCheckBox
            // 
            this.toDateCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.toDateCheckBox.AutoSize = true;
            this.toDateCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.toDateCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toDateCheckBox.Location = new System.Drawing.Point(3, 11);
            this.toDateCheckBox.Name = "toDateCheckBox";
            this.toDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toDateCheckBox.Size = new System.Drawing.Size(87, 23);
            this.toDateCheckBox.TabIndex = 2;
            this.toDateCheckBox.Text = "Do daty:";
            this.toDateCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toDateCheckBox.UseVisualStyleBackColor = true;
            this.toDateCheckBox.CheckedChanged += new System.EventHandler(this.toDateCheckBox_CheckedChanged);
            // 
            // fromDatePanel
            // 
            this.fromDatePanel.ColumnCount = 1;
            this.fromDatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fromDatePanel.Controls.Add(this.fromDatePicker, 0, 1);
            this.fromDatePanel.Controls.Add(this.fromDateCheckBox, 0, 0);
            this.fromDatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromDatePanel.Location = new System.Drawing.Point(0, 0);
            this.fromDatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.fromDatePanel.Name = "fromDatePanel";
            this.fromDatePanel.RowCount = 2;
            this.fromDatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fromDatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fromDatePanel.Size = new System.Drawing.Size(93, 75);
            this.fromDatePanel.TabIndex = 0;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(3, 40);
            this.fromDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.fromDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(87, 20);
            this.fromDatePicker.TabIndex = 1;
            // 
            // fromDateCheckBox
            // 
            this.fromDateCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.fromDateCheckBox.AutoSize = true;
            this.fromDateCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fromDateCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fromDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromDateCheckBox.Location = new System.Drawing.Point(3, 11);
            this.fromDateCheckBox.Name = "fromDateCheckBox";
            this.fromDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromDateCheckBox.Size = new System.Drawing.Size(87, 23);
            this.fromDateCheckBox.TabIndex = 2;
            this.fromDateCheckBox.Text = "Od daty:";
            this.fromDateCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fromDateCheckBox.UseVisualStyleBackColor = true;
            this.fromDateCheckBox.CheckedChanged += new System.EventHandler(this.fromDateCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moje Finanse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.navigatorPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.categoriesPanel.ResumeLayout(false);
            this.categoriesPanel.PerformLayout();
            this.toDatePanel.ResumeLayout(false);
            this.toDatePanel.PerformLayout();
            this.fromDatePanel.ResumeLayout(false);
            this.fromDatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // starting values of buttons' fonts sizes in points
        private float addButtonFontSize;
        private float removeButtonFontSize;
        private float settingsButtonFontSize;
        private float closeButtonFontSize;
        private float fromDateCheckBoxFontSize;
        private float fromDatePickerFontSize;
        private float toDateCheckBoxFontSize;
        private float toDatePickerFontSize;
        private float categoriesButtonFontSize;

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel navigatorPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TableLayoutPanel filterPanel;
        private System.Windows.Forms.TableLayoutPanel fromDatePanel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.CheckBox fromDateCheckBox;
        private System.Windows.Forms.TableLayoutPanel toDatePanel;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.CheckBox toDateCheckBox;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.TableLayoutPanel categoriesPanel;
        private System.Windows.Forms.CheckBox categoriesCheckBox;
        private System.Windows.Forms.ComboBox categoriesComboBox;
    }
}