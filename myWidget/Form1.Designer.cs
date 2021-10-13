namespace myWidget
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSendTextToSQL = new System.Windows.Forms.Button();
            this.buttonDellTaskSQL = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxPoverh = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxShowTask = new System.Windows.Forms.CheckBox();
            this.panelTask = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelLoadData = new System.Windows.Forms.Panel();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "получить список заданий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSendTextToSQL
            // 
            this.buttonSendTextToSQL.Location = new System.Drawing.Point(481, 1);
            this.buttonSendTextToSQL.Name = "buttonSendTextToSQL";
            this.buttonSendTextToSQL.Size = new System.Drawing.Size(107, 47);
            this.buttonSendTextToSQL.TabIndex = 2;
            this.buttonSendTextToSQL.Text = "Отправить задание";
            this.buttonSendTextToSQL.UseVisualStyleBackColor = true;
            this.buttonSendTextToSQL.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonDellTaskSQL
            // 
            this.buttonDellTaskSQL.Location = new System.Drawing.Point(481, 50);
            this.buttonDellTaskSQL.Name = "buttonDellTaskSQL";
            this.buttonDellTaskSQL.Size = new System.Drawing.Size(107, 23);
            this.buttonDellTaskSQL.TabIndex = 3;
            this.buttonDellTaskSQL.Text = "Удалить задание";
            this.buttonDellTaskSQL.UseVisualStyleBackColor = true;
            this.buttonDellTaskSQL.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
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
            this.buttonExit.Location = new System.Drawing.Point(481, 78);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 40);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Закрыть приложение";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxPoverh
            // 
            this.checkBoxPoverh.AutoSize = true;
            this.checkBoxPoverh.Checked = true;
            this.checkBoxPoverh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPoverh.Location = new System.Drawing.Point(2, 2);
            this.checkBoxPoverh.Name = "checkBoxPoverh";
            this.checkBoxPoverh.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPoverh.TabIndex = 8;
            this.checkBoxPoverh.Text = "Поверх всех окон";
            this.checkBoxPoverh.UseVisualStyleBackColor = true;
            this.checkBoxPoverh.CheckedChanged += new System.EventHandler(this.checkBoxPoverh_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // checkBoxShowTask
            // 
            this.checkBoxShowTask.AutoSize = true;
            this.checkBoxShowTask.Checked = true;
            this.checkBoxShowTask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowTask.Location = new System.Drawing.Point(3, 26);
            this.checkBoxShowTask.Name = "checkBoxShowTask";
            this.checkBoxShowTask.Size = new System.Drawing.Size(127, 17);
            this.checkBoxShowTask.TabIndex = 13;
            this.checkBoxShowTask.Text = "Показывать задачи";
            this.checkBoxShowTask.UseVisualStyleBackColor = true;
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.dataGridView1);
            this.panelTask.Controls.Add(this.buttonSendTextToSQL);
            this.panelTask.Controls.Add(this.buttonDellTaskSQL);
            this.panelTask.Controls.Add(this.button3);
            this.panelTask.Controls.Add(this.buttonExit);
            this.panelTask.Location = new System.Drawing.Point(151, 0);
            this.panelTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(596, 150);
            this.panelTask.TabIndex = 14;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.checkBoxShowTask);
            this.panelSetting.Controls.Add(this.checkBoxPoverh);
            this.panelSetting.Location = new System.Drawing.Point(750, 1);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(130, 57);
            this.panelSetting.TabIndex = 15;
            // 
            // panelLoadData
            // 
            this.panelLoadData.Controls.Add(this.dateTimePicker2);
            this.panelLoadData.Controls.Add(this.button1);
            this.panelLoadData.Controls.Add(this.textBox1);
            this.panelLoadData.Controls.Add(this.dateTimePicker1);
            this.panelLoadData.Location = new System.Drawing.Point(886, 3);
            this.panelLoadData.Name = "panelLoadData";
            this.panelLoadData.Size = new System.Drawing.Size(200, 108);
            this.panelLoadData.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 151);
            this.Controls.Add(this.panelLoadData);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSendTextToSQL;
        private System.Windows.Forms.Button buttonDellTaskSQL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxPoverh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxShowTask;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel panelLoadData;
    }
}

