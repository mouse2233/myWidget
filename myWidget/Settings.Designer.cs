namespace myWidget
{
    partial class Settings
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
            this.checkBoxShowTask = new System.Windows.Forms.CheckBox();
            this.checkBoxPoverh = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxShowTask
            // 
            this.checkBoxShowTask.AutoSize = true;
            this.checkBoxShowTask.Checked = true;
            this.checkBoxShowTask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowTask.Location = new System.Drawing.Point(12, 35);
            this.checkBoxShowTask.Name = "checkBoxShowTask";
            this.checkBoxShowTask.Size = new System.Drawing.Size(127, 17);
            this.checkBoxShowTask.TabIndex = 13;
            this.checkBoxShowTask.Text = "Показывать задачи";
            this.checkBoxShowTask.UseVisualStyleBackColor = true;
            // 
            // checkBoxPoverh
            // 
            this.checkBoxPoverh.AutoSize = true;
            this.checkBoxPoverh.Checked = true;
            this.checkBoxPoverh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPoverh.Location = new System.Drawing.Point(12, 12);
            this.checkBoxPoverh.Name = "checkBoxPoverh";
            this.checkBoxPoverh.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPoverh.TabIndex = 8;
            this.checkBoxPoverh.Text = "Поверх всех окон";
            this.checkBoxPoverh.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Показывать погоду";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 81);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxShowTask);
            this.Controls.Add(this.checkBoxPoverh);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxShowTask;
        private System.Windows.Forms.CheckBox checkBoxPoverh;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}