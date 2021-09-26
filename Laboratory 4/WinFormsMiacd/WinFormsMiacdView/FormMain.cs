using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsMiacdView
{
    public partial class FormMain : Form
    {
        private DateTime _firstDateTime;
        private DateTime _secondDateTime;
        private const string _datePickerFormat = "dd.MM.yyyy HH:mm:ss";
        private const string _differenceInDay = "Разница дат в днях";
        private const string _differenceInHours = "Разница дат в часах";
        private const string _additionalTimes = "Добавить к 1му времени значение";

        List<string> listOperations = new List<string>
        {
            _differenceInDay,_differenceInHours,_additionalTimes
        };
        public FormMain()
        {
            InitializeComponent();
            _firstDateTime = new DateTime(2001, 9, 12, 6, 30, 56, DateTimeKind.Utc);
            dateTimePickerFirstDate.Value = _firstDateTime;
            dateTimePickerFirstDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFirstDate.CustomFormat = _datePickerFormat;
            _secondDateTime = new DateTime(1996, 2, 5, 15, 30, 30, DateTimeKind.Utc);
            dateTimePickerSecondDate.Value = _secondDateTime;
            dateTimePickerSecondDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerSecondDate.CustomFormat = _datePickerFormat;
            comboBoxOperations.DataSource = listOperations;
            comboBoxOperations.SelectedItem = null;
            comboBoxOperations.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonFirstDateSetCurrentTime_Click(object sender, EventArgs e)
        {
            if (checkBoxFirstDateUTC.Checked)
            {
                dateTimePickerFirstDate.Value = DateTime.UtcNow;
                return;
            }
            dateTimePickerFirstDate.Value = DateTime.Now;
        }

        private void buttonSecondDateSetCurrentDate_Click(object sender, EventArgs e)
        {
            if (checkBoxSecondDateUTC.Checked)
            {
                dateTimePickerSecondDate.Value = DateTime.UtcNow;
                return;
            }
            dateTimePickerSecondDate.Value = DateTime.Now;
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            if (comboBoxOperations.SelectedItem == null)
            {
                MessageBox.Show("Выберите операцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxOperations.SelectedItem)
            {
                case _differenceInDay:
                    {
                        labelResult.Text = _firstDateTime.Subtract(_secondDateTime).TotalDays.ToString();
                        break;
                    }
                case _differenceInHours:
                    {
                        labelResult.Text = _firstDateTime.Subtract(_secondDateTime).TotalHours.ToString();
                        break;
                    }
                case _additionalTimes:
                    {
                        DateTime result = _firstDateTime.Add(dateTimePickerTimeAdd.Value.TimeOfDay);
                        labelResult.Text = checkBoxFirstDateUTC.Checked ? result.ToString() : result.ToLocalTime().ToString();
                        break;
                    }
            }
        }

        private void dateTimePickerFirstDate_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxFirstDateUTC.Checked)
            {
                _firstDateTime = dateTimePickerFirstDate.Value;
                return;
            }
            _firstDateTime = dateTimePickerFirstDate.Value.ToUniversalTime();
        }

        private void dateTimePickerSecondDate_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxSecondDateUTC.Checked)
            {
                _secondDateTime = dateTimePickerSecondDate.Value;
                return;
            }
            _secondDateTime = dateTimePickerSecondDate.Value.ToUniversalTime();
        }

        private void checkBoxFirstDateUTC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFirstDateUTC.Checked)
            {
                dateTimePickerFirstDate.Value = _firstDateTime;
                return;
            }
            dateTimePickerFirstDate.Value = _firstDateTime.ToLocalTime();
        }

        private void checkBoxSecondDateUTC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecondDateUTC.Checked)
            {
                dateTimePickerSecondDate.Value = _secondDateTime;
                return;
            }
            dateTimePickerSecondDate.Value = _secondDateTime.ToLocalTime();
        }
    }
}
