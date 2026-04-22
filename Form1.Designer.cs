namespace Курсовий_проєкт_на_тему_склад
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button1 = new Button();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 15);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1262, 673);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 53);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1254, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Перегляд товарів на складі ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 53);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1254, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Прибуткова накладна";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 53);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1254, 616);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Видаткова накладна ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 53);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1254, 616);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Пошук";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Location = new Point(1059, 12);
            button1.Name = "button1";
            button1.Size = new Size(196, 35);
            button1.TabIndex = 0;
            button1.Text = "Зберегти та вийти ";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 53);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1254, 616);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Додати товар";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Склад";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private TabPage tabPage5;
    }
}
