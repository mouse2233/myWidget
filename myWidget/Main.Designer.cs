namespace myWidget
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGetTaskFromSQL = new System.Windows.Forms.Button();
            this.buttonDellTaskSQL = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTask = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelLoadData = new System.Windows.Forms.Panel();
            this.кнНовоеЗадание = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.writeTask = new System.Windows.Forms.Button();
            this.пЗадача = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxShowTask = new System.Windows.Forms.CheckBox();
            this.checkBoxPoverh = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTask.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.panelLoadData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonGetTaskFromSQL
            // 
            this.buttonGetTaskFromSQL.Location = new System.Drawing.Point(4, 324);
            this.buttonGetTaskFromSQL.Name = "buttonGetTaskFromSQL";
            this.buttonGetTaskFromSQL.Size = new System.Drawing.Size(107, 25);
            this.buttonGetTaskFromSQL.TabIndex = 2;
            this.buttonGetTaskFromSQL.Text = "Получить задание";
            this.buttonGetTaskFromSQL.UseVisualStyleBackColor = true;
            this.buttonGetTaskFromSQL.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonDellTaskSQL
            // 
            this.buttonDellTaskSQL.Location = new System.Drawing.Point(117, 324);
            this.buttonDellTaskSQL.Name = "buttonDellTaskSQL";
            this.buttonDellTaskSQL.Size = new System.Drawing.Size(107, 25);
            this.buttonDellTaskSQL.TabIndex = 3;
            this.buttonDellTaskSQL.Text = "Удалить задание";
            this.buttonDellTaskSQL.UseVisualStyleBackColor = true;
            this.buttonDellTaskSQL.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(622, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Настройки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.dateLabel.Location = new System.Drawing.Point(54, 150);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(482, 324);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 25);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Закрыть приложение";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 312);
            this.dataGridView1.TabIndex = 12;
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.кнНовоеЗадание);
            this.panelTask.Controls.Add(this.dataGridView1);
            this.panelTask.Controls.Add(this.buttonGetTaskFromSQL);
            this.panelTask.Controls.Add(this.buttonDellTaskSQL);
            this.panelTask.Controls.Add(this.button3);
            this.panelTask.Controls.Add(this.buttonExit);
            this.panelTask.Location = new System.Drawing.Point(151, 0);
            this.panelTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(732, 352);
            this.panelTask.TabIndex = 14;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.checkBox1);
            this.panelSetting.Controls.Add(this.checkBoxShowTask);
            this.panelSetting.Controls.Add(this.checkBoxPoverh);
            this.panelSetting.Location = new System.Drawing.Point(886, 192);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(131, 83);
            this.panelSetting.TabIndex = 15;
            // 
            // panelLoadData
            // 
            this.panelLoadData.Controls.Add(this.checkBoxTime);
            this.panelLoadData.Controls.Add(this.TimePicker);
            this.panelLoadData.Controls.Add(this.writeTask);
            this.panelLoadData.Controls.Add(this.пЗадача);
            this.panelLoadData.Controls.Add(this.datePicker);
            this.panelLoadData.Location = new System.Drawing.Point(886, 3);
            this.panelLoadData.Name = "panelLoadData";
            this.panelLoadData.Size = new System.Drawing.Size(204, 108);
            this.panelLoadData.TabIndex = 16;
            this.panelLoadData.Visible = false;
            // 
            // кнНовоеЗадание
            // 
            this.кнНовоеЗадание.Location = new System.Drawing.Point(230, 324);
            this.кнНовоеЗадание.Name = "кнНовоеЗадание";
            this.кнНовоеЗадание.Size = new System.Drawing.Size(107, 25);
            this.кнНовоеЗадание.TabIndex = 13;
            this.кнНовоеЗадание.Text = "Новое задание";
            this.кнНовоеЗадание.UseVisualStyleBackColor = true;
            this.кнНовоеЗадание.Click += new System.EventHandler(this.кнНовоеЗадание_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(6, 58);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(161, 20);
            this.TimePicker.TabIndex = 15;
            // 
            // writeTask
            // 
            this.writeTask.Location = new System.Drawing.Point(6, 82);
            this.writeTask.Name = "writeTask";
            this.writeTask.Size = new System.Drawing.Size(150, 23);
            this.writeTask.TabIndex = 12;
            this.writeTask.Text = "записать задание";
            this.writeTask.UseVisualStyleBackColor = true;
            // 
            // пЗадача
            // 
            this.пЗадача.Location = new System.Drawing.Point(6, 4);
            this.пЗадача.Name = "пЗадача";
            this.пЗадача.Size = new System.Drawing.Size(161, 20);
            this.пЗадача.TabIndex = 13;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 31);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(161, 20);
            this.datePicker.TabIndex = 14;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(174, 60);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(29, 17);
            this.checkBoxTime.TabIndex = 16;
            this.checkBoxTime.Text = "!";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowTask
            // 
            this.checkBoxShowTask.AutoSize = true;
            this.checkBoxShowTask.Checked = true;
            this.checkBoxShowTask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowTask.Location = new System.Drawing.Point(2, 31);
            this.checkBoxShowTask.Name = "checkBoxShowTask";
            this.checkBoxShowTask.Size = new System.Drawing.Size(127, 17);
            this.checkBoxShowTask.TabIndex = 15;
            this.checkBoxShowTask.Text = "Показывать задачи";
            this.checkBoxShowTask.UseVisualStyleBackColor = true;
            // 
            // checkBoxPoverh
            // 
            this.checkBoxPoverh.AutoSize = true;
            this.checkBoxPoverh.Checked = true;
            this.checkBoxPoverh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPoverh.Location = new System.Drawing.Point(2, 8);
            this.checkBoxPoverh.Name = "checkBoxPoverh";
            this.checkBoxPoverh.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPoverh.TabIndex = 14;
            this.checkBoxPoverh.Text = "Поверх всех окон";
            this.checkBoxPoverh.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(2, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Показывать погоду";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 361);
            this.Controls.Add(this.panelLoadData);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTask.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.panelLoadData.ResumeLayout(false);
            this.panelLoadData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGetTaskFromSQL;
        private System.Windows.Forms.Button buttonDellTaskSQL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel panelLoadData;
        private System.Windows.Forms.Button кнНовоеЗадание;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button writeTask;
        private System.Windows.Forms.TextBox пЗадача;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxShowTask;
        private System.Windows.Forms.CheckBox checkBoxPoverh;
        private System.Windows.Forms.CheckBox checkBoxTime;
    }
}

