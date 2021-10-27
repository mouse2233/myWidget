namespace myWidget
{
    partial class ДобавитьЗапись
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
            this.panelLoadData = new System.Windows.Forms.Panel();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeAdd = new System.Windows.Forms.CheckBox();
            this.checkBoxGood = new System.Windows.Forms.CheckBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.writeTask = new System.Windows.Forms.Button();
            this.пЗадача = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panelLoadData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoadData
            // 
            this.panelLoadData.BackColor = System.Drawing.Color.White;
            this.panelLoadData.Controls.Add(this.checkBoxDate);
            this.panelLoadData.Controls.Add(this.checkBoxTimeAdd);
            this.panelLoadData.Controls.Add(this.checkBoxGood);
            this.panelLoadData.Controls.Add(this.TimePicker);
            this.panelLoadData.Controls.Add(this.writeTask);
            this.panelLoadData.Controls.Add(this.пЗадача);
            this.panelLoadData.Controls.Add(this.datePicker);
            this.panelLoadData.Location = new System.Drawing.Point(0, 0);
            this.panelLoadData.Margin = new System.Windows.Forms.Padding(0);
            this.panelLoadData.Name = "panelLoadData";
            this.panelLoadData.Size = new System.Drawing.Size(569, 147);
            this.panelLoadData.TabIndex = 17;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(162, 92);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(103, 17);
            this.checkBoxDate.TabIndex = 19;
            this.checkBoxDate.Text = "отправить дату";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimeAdd
            // 
            this.checkBoxTimeAdd.AutoSize = true;
            this.checkBoxTimeAdd.Location = new System.Drawing.Point(286, 92);
            this.checkBoxTimeAdd.Name = "checkBoxTimeAdd";
            this.checkBoxTimeAdd.Size = new System.Drawing.Size(113, 17);
            this.checkBoxTimeAdd.TabIndex = 18;
            this.checkBoxTimeAdd.Text = "отправить время";
            this.checkBoxTimeAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxGood
            // 
            this.checkBoxGood.AutoSize = true;
            this.checkBoxGood.Location = new System.Drawing.Point(228, 122);
            this.checkBoxGood.Name = "checkBoxGood";
            this.checkBoxGood.Size = new System.Drawing.Size(89, 17);
            this.checkBoxGood.TabIndex = 16;
            this.checkBoxGood.Text = "Выполнено?";
            this.checkBoxGood.UseVisualStyleBackColor = true;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(405, 92);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(161, 20);
            this.TimePicker.TabIndex = 15;
            // 
            // writeTask
            // 
            this.writeTask.Location = new System.Drawing.Point(6, 118);
            this.writeTask.Name = "writeTask";
            this.writeTask.Size = new System.Drawing.Size(150, 26);
            this.writeTask.TabIndex = 12;
            this.writeTask.Text = "записать задание";
            this.writeTask.UseVisualStyleBackColor = true;
            this.writeTask.Click += new System.EventHandler(this.writeTask_Click);
            // 
            // пЗадача
            // 
            this.пЗадача.Location = new System.Drawing.Point(6, 4);
            this.пЗадача.Multiline = true;
            this.пЗадача.Name = "пЗадача";
            this.пЗадача.Size = new System.Drawing.Size(560, 82);
            this.пЗадача.TabIndex = 13;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 92);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(150, 20);
            this.datePicker.TabIndex = 14;
            // 
            // ДобавитьЗапись
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 148);
            this.Controls.Add(this.panelLoadData);
            this.Name = "ДобавитьЗапись";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ДобавитьЗапись";
            this.panelLoadData.ResumeLayout(false);
            this.panelLoadData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoadData;
        private System.Windows.Forms.CheckBox checkBoxGood;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button writeTask;
        private System.Windows.Forms.TextBox пЗадача;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox checkBoxTimeAdd;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}