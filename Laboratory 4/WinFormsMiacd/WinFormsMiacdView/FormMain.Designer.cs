
namespace WinFormsMiacdView
{
    partial class FormMain
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
            this.checkBoxFirstDateUTC = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFirstDate = new System.Windows.Forms.DateTimePicker();
            this.buttonFirstDateSetCurrentTime = new System.Windows.Forms.Button();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.labelFirstDateTime = new System.Windows.Forms.Label();
            this.groupBoxFirstDateTime = new System.Windows.Forms.GroupBox();
            this.groupBoxSecondDateTime = new System.Windows.Forms.GroupBox();
            this.labelSecondDateTime = new System.Windows.Forms.Label();
            this.buttonSecondDateSetCurrentDate = new System.Windows.Forms.Button();
            this.dateTimePickerSecondDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSecondDateUTC = new System.Windows.Forms.CheckBox();
            this.buttonDo = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.dateTimePickerTimeAdd = new System.Windows.Forms.DateTimePicker();
            this.labelOperations = new System.Windows.Forms.Label();
            this.labelTimeAdd = new System.Windows.Forms.Label();
            this.groupBoxFirstDateTime.SuspendLayout();
            this.groupBoxSecondDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxFirstDateUTC
            // 
            this.checkBoxFirstDateUTC.AutoSize = true;
            this.checkBoxFirstDateUTC.Checked = true;
            this.checkBoxFirstDateUTC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstDateUTC.Location = new System.Drawing.Point(176, 54);
            this.checkBoxFirstDateUTC.Name = "checkBoxFirstDateUTC";
            this.checkBoxFirstDateUTC.Size = new System.Drawing.Size(70, 24);
            this.checkBoxFirstDateUTC.TabIndex = 0;
            this.checkBoxFirstDateUTC.Text = "В UTC";
            this.checkBoxFirstDateUTC.UseVisualStyleBackColor = true;
            this.checkBoxFirstDateUTC.CheckedChanged += new System.EventHandler(this.checkBoxFirstDateUTC_CheckedChanged);
            // 
            // dateTimePickerFirstDate
            // 
            this.dateTimePickerFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFirstDate.Location = new System.Drawing.Point(10, 50);
            this.dateTimePickerFirstDate.Name = "dateTimePickerFirstDate";
            this.dateTimePickerFirstDate.ShowUpDown = true;
            this.dateTimePickerFirstDate.Size = new System.Drawing.Size(160, 27);
            this.dateTimePickerFirstDate.TabIndex = 1;
            this.dateTimePickerFirstDate.ValueChanged += new System.EventHandler(this.dateTimePickerFirstDate_ValueChanged);
            // 
            // buttonFirstDateSetCurrentTime
            // 
            this.buttonFirstDateSetCurrentTime.Location = new System.Drawing.Point(10, 84);
            this.buttonFirstDateSetCurrentTime.Name = "buttonFirstDateSetCurrentTime";
            this.buttonFirstDateSetCurrentTime.Size = new System.Drawing.Size(236, 29);
            this.buttonFirstDateSetCurrentTime.TabIndex = 2;
            this.buttonFirstDateSetCurrentTime.Text = "Установить текущее время";
            this.buttonFirstDateSetCurrentTime.UseVisualStyleBackColor = true;
            this.buttonFirstDateSetCurrentTime.Click += new System.EventHandler(this.buttonFirstDateSetCurrentTime_Click);
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Location = new System.Drawing.Point(12, 178);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(337, 28);
            this.comboBoxOperations.TabIndex = 3;
            // 
            // labelFirstDateTime
            // 
            this.labelFirstDateTime.AutoSize = true;
            this.labelFirstDateTime.Location = new System.Drawing.Point(10, 27);
            this.labelFirstDateTime.Name = "labelFirstDateTime";
            this.labelFirstDateTime.Size = new System.Drawing.Size(95, 20);
            this.labelFirstDateTime.TabIndex = 4;
            this.labelFirstDateTime.Text = "Первая дата";
            // 
            // groupBoxFirstDateTime
            // 
            this.groupBoxFirstDateTime.Controls.Add(this.labelFirstDateTime);
            this.groupBoxFirstDateTime.Controls.Add(this.buttonFirstDateSetCurrentTime);
            this.groupBoxFirstDateTime.Controls.Add(this.dateTimePickerFirstDate);
            this.groupBoxFirstDateTime.Controls.Add(this.checkBoxFirstDateUTC);
            this.groupBoxFirstDateTime.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFirstDateTime.Name = "groupBoxFirstDateTime";
            this.groupBoxFirstDateTime.Size = new System.Drawing.Size(255, 134);
            this.groupBoxFirstDateTime.TabIndex = 6;
            this.groupBoxFirstDateTime.TabStop = false;
            this.groupBoxFirstDateTime.Text = "Первая дата";
            // 
            // groupBoxSecondDateTime
            // 
            this.groupBoxSecondDateTime.Controls.Add(this.labelSecondDateTime);
            this.groupBoxSecondDateTime.Controls.Add(this.buttonSecondDateSetCurrentDate);
            this.groupBoxSecondDateTime.Controls.Add(this.dateTimePickerSecondDate);
            this.groupBoxSecondDateTime.Controls.Add(this.checkBoxSecondDateUTC);
            this.groupBoxSecondDateTime.Location = new System.Drawing.Point(273, 12);
            this.groupBoxSecondDateTime.Name = "groupBoxSecondDateTime";
            this.groupBoxSecondDateTime.Size = new System.Drawing.Size(255, 134);
            this.groupBoxSecondDateTime.TabIndex = 7;
            this.groupBoxSecondDateTime.TabStop = false;
            this.groupBoxSecondDateTime.Text = "Вторая дата";
            // 
            // labelSecondDateTime
            // 
            this.labelSecondDateTime.AutoSize = true;
            this.labelSecondDateTime.Location = new System.Drawing.Point(10, 27);
            this.labelSecondDateTime.Name = "labelSecondDateTime";
            this.labelSecondDateTime.Size = new System.Drawing.Size(92, 20);
            this.labelSecondDateTime.TabIndex = 4;
            this.labelSecondDateTime.Text = "Вторая дата";
            // 
            // buttonSecondDateSetCurrentDate
            // 
            this.buttonSecondDateSetCurrentDate.Location = new System.Drawing.Point(10, 84);
            this.buttonSecondDateSetCurrentDate.Name = "buttonSecondDateSetCurrentDate";
            this.buttonSecondDateSetCurrentDate.Size = new System.Drawing.Size(236, 29);
            this.buttonSecondDateSetCurrentDate.TabIndex = 2;
            this.buttonSecondDateSetCurrentDate.Text = "Установить текущее время";
            this.buttonSecondDateSetCurrentDate.UseVisualStyleBackColor = true;
            this.buttonSecondDateSetCurrentDate.Click += new System.EventHandler(this.buttonSecondDateSetCurrentDate_Click);
            // 
            // dateTimePickerSecondDate
            // 
            this.dateTimePickerSecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSecondDate.Location = new System.Drawing.Point(10, 50);
            this.dateTimePickerSecondDate.Name = "dateTimePickerSecondDate";
            this.dateTimePickerSecondDate.ShowUpDown = true;
            this.dateTimePickerSecondDate.Size = new System.Drawing.Size(160, 27);
            this.dateTimePickerSecondDate.TabIndex = 1;
            this.dateTimePickerSecondDate.ValueChanged += new System.EventHandler(this.dateTimePickerSecondDate_ValueChanged);
            // 
            // checkBoxSecondDateUTC
            // 
            this.checkBoxSecondDateUTC.AutoSize = true;
            this.checkBoxSecondDateUTC.Checked = true;
            this.checkBoxSecondDateUTC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSecondDateUTC.Location = new System.Drawing.Point(176, 54);
            this.checkBoxSecondDateUTC.Name = "checkBoxSecondDateUTC";
            this.checkBoxSecondDateUTC.Size = new System.Drawing.Size(70, 24);
            this.checkBoxSecondDateUTC.TabIndex = 0;
            this.checkBoxSecondDateUTC.Text = "В UTC";
            this.checkBoxSecondDateUTC.UseVisualStyleBackColor = true;
            this.checkBoxSecondDateUTC.CheckedChanged += new System.EventHandler(this.checkBoxSecondDateUTC_CheckedChanged);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(220, 222);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(104, 29);
            this.buttonDo.TabIndex = 8;
            this.buttonDo.Text = "Выполнить";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(188, 275);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 9;
            // 
            // dateTimePickerTimeAdd
            // 
            this.dateTimePickerTimeAdd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeAdd.Location = new System.Drawing.Point(402, 178);
            this.dateTimePickerTimeAdd.Name = "dateTimePickerTimeAdd";
            this.dateTimePickerTimeAdd.ShowUpDown = true;
            this.dateTimePickerTimeAdd.Size = new System.Drawing.Size(80, 27);
            this.dateTimePickerTimeAdd.TabIndex = 10;
            this.dateTimePickerTimeAdd.Value = new System.DateTime(2021, 9, 26, 0, 0, 0, 0);
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Location = new System.Drawing.Point(12, 155);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(81, 20);
            this.labelOperations.TabIndex = 11;
            this.labelOperations.Text = "Операции";
            // 
            // labelTimeAdd
            // 
            this.labelTimeAdd.AutoSize = true;
            this.labelTimeAdd.Location = new System.Drawing.Point(354, 155);
            this.labelTimeAdd.Name = "labelTimeAdd";
            this.labelTimeAdd.Size = new System.Drawing.Size(170, 20);
            this.labelTimeAdd.TabIndex = 12;
            this.labelTimeAdd.Text = "Время для добавления";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 348);
            this.Controls.Add(this.labelTimeAdd);
            this.Controls.Add(this.labelOperations);
            this.Controls.Add(this.dateTimePickerTimeAdd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.groupBoxSecondDateTime);
            this.Controls.Add(this.groupBoxFirstDateTime);
            this.Controls.Add(this.comboBoxOperations);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.groupBoxFirstDateTime.ResumeLayout(false);
            this.groupBoxFirstDateTime.PerformLayout();
            this.groupBoxSecondDateTime.ResumeLayout(false);
            this.groupBoxSecondDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFirstDateUTC;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDate;
        private System.Windows.Forms.Button buttonFirstDateSetCurrentTime;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Label labelFirstDateTime;
        private System.Windows.Forms.GroupBox groupBoxFirstDateTime;
        private System.Windows.Forms.GroupBox groupBoxSecondDateTime;
        private System.Windows.Forms.Label labelSecondDateTime;
        private System.Windows.Forms.Button buttonSecondDateSetCurrentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecondDate;
        private System.Windows.Forms.CheckBox checkBoxSecondDateUTC;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeAdd;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.Label labelTimeAdd;
    }
}