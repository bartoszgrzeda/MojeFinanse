using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeFinanse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Czy napewno chcesz zamknąć program?", "Moje Finanse", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            setFontSize();
        }

        private void setFontSize()
        // scales fonts in controls
        {
            this.addButton.Font = new Font(this.addButton.Font.Name, addButtonFontSize * this.Size.Width / 960);
            this.removeButton.Font = new Font(this.removeButton.Font.Name, removeButtonFontSize * this.Size.Width / 960);
            this.settingsButton.Font = new Font(this.settingsButton.Font.Name, settingsButtonFontSize * this.Size.Width / 960);
            this.closeButton.Font = new Font(this.closeButton.Font.Name, closeButtonFontSize * this.Size.Width / 960);
            this.fromDateCheckBox.Font = new Font(this.fromDateCheckBox.Font.Name, fromDateCheckBoxFontSize * this.Size.Width / 960);
            this.fromDatePicker.Font = new Font(this.fromDatePicker.Font.Name, fromDatePickerFontSize * this.Size.Width / 960);
            this.fromDatePicker.CalendarFont = new Font(this.fromDatePicker.CalendarFont.Name, fromDatePickerFontSize * this.Size.Width / 960);
            this.toDateCheckBox.Font = new Font(this.toDateCheckBox.Font.Name, toDateCheckBoxFontSize * this.Size.Width / 960);
            this.toDatePicker.Font = new Font(this.toDatePicker.Font.Name, toDatePickerFontSize * this.Size.Width / 960);
            this.toDatePicker.CalendarFont = new Font(this.toDatePicker.CalendarFont.Name, toDatePickerFontSize * this.Size.Width / 960);
            this.categoriesButton.Font = new Font(this.categoriesButton.Font.Name, categoriesButtonFontSize * this.Size.Width / 960);
        }

        private void initStartingFontsSizes()
        // inits starting fonts' sizes
        {
            addButtonFontSize = this.addButton.Font.SizeInPoints;
            removeButtonFontSize = this.removeButton.Font.SizeInPoints;
            settingsButtonFontSize = this.settingsButton.Font.SizeInPoints;
            closeButtonFontSize = this.closeButton.Font.SizeInPoints;
            fromDateCheckBoxFontSize = this.fromDateCheckBox.Font.SizeInPoints;
            fromDatePickerFontSize = this.fromDatePicker.Font.SizeInPoints;
            toDateCheckBoxFontSize = this.toDateCheckBox.Font.SizeInPoints;
            toDatePickerFontSize = this.toDatePicker.Font.SizeInPoints;
            categoriesButtonFontSize = this.categoriesButton.Font.SizeInPoints;
        }

        private void setStartingCheckBoxes()
        // sets starting states of checkboxes
        {
            this.fromDateCheckBox.CheckState = CheckState.Unchecked;
            this.toDateCheckBox.CheckState = CheckState.Unchecked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            initStartingFontsSizes();
            setFontSize();
            setStartingCheckBoxes();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void fromDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.fromDateCheckBox.Checked)
            {
                this.fromDateCheckBox.BackColor = SystemColors.Control;
                this.fromDatePicker.Enabled = false;
            }

            else
            {
                this.fromDateCheckBox.BackColor = SystemColors.ActiveCaption;
                this.fromDatePicker.Enabled = true;
            }
        }

        private void toDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.toDateCheckBox.Checked)
                this.toDateCheckBox.BackColor = SystemColors.Control;

            else
                this.toDateCheckBox.BackColor = SystemColors.ActiveCaption;
        }

        private void navigatorPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
