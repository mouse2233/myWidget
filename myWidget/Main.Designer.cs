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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGetTaskFromSQL = new System.Windows.Forms.Button();
            this.buttonDellTaskSQL = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTask = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkGetChecket = new System.Windows.Forms.CheckBox();
            this.кнНовоеЗадание = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTask.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(701, 324);
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
            this.buttonExit.Location = new System.Drawing.Point(561, 324);
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
            this.dataGridView1.Size = new System.Drawing.Size(808, 312);
            this.dataGridView1.TabIndex = 12;
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.buttonOK);
            this.panelTask.Controls.Add(this.buttonExit);
            this.panelTask.Controls.Add(this.checkGetChecket);
            this.panelTask.Controls.Add(this.кнНовоеЗадание);
            this.panelTask.Controls.Add(this.dataGridView1);
            this.panelTask.Controls.Add(this.buttonGetTaskFromSQL);
            this.panelTask.Controls.Add(this.buttonDellTaskSQL);
            this.panelTask.Controls.Add(this.button3);
            this.panelTask.Location = new System.Drawing.Point(151, 0);
            this.panelTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(811, 352);
            this.panelTask.TabIndex = 14;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(330, 324);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "Выполнено";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkGetChecket
            // 
            this.checkGetChecket.AutoSize = true;
            this.checkGetChecket.Location = new System.Drawing.Point(415, 324);
            this.checkGetChecket.Name = "checkGetChecket";
            this.checkGetChecket.Size = new System.Drawing.Size(140, 17);
            this.checkGetChecket.TabIndex = 16;
            this.checkGetChecket.Text = "Получить выполненые";
            this.checkGetChecket.UseVisualStyleBackColor = true;
            // 
            // кнНовоеЗадание
            // 
            this.кнНовоеЗадание.Location = new System.Drawing.Point(230, 324);
            this.кнНовоеЗадание.Name = "кнНовоеЗадание";
            this.кнНовоеЗадание.Size = new System.Drawing.Size(93, 25);
            this.кнНовоеЗадание.TabIndex = 13;
            this.кнНовоеЗадание.Text = "Новое задание";
            this.кнНовоеЗадание.UseVisualStyleBackColor = true;
            this.кнНовоеЗадание.Click += new System.EventHandler(this.кнНовоеЗадание_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 155);
            this.textBox1.TabIndex = 16;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Виджет часов";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 20);
            this.button2.TabIndex = 17;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
            this.panelTask.PerformLayout();
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
        private System.Windows.Forms.Button кнНовоеЗадание;
        private System.Windows.Forms.CheckBox checkGetChecket;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;
    }
}

