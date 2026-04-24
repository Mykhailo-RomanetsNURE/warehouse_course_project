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
            AllProductTable_ViewProducts_DataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            DateAndTime = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            AllProductInfo_ViewProducts_Panel = new Panel();
            Id_ViewSpecificProduct_LabelText = new Label();
            History_ViewSpecificProduct_DataGridView = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Incident = new DataGridViewTextBoxColumn();
            Time_ViewSpecificProduct_Label = new Label();
            Time_ViewSpecificProduct_LabelText = new Label();
            Quantity_ViewSpecificProduct_Lable = new Label();
            Quantity_ViewSpecificProduct_LabelText = new Label();
            DeleteHistory_ViewSpecificProduct_Button = new Button();
            HistoryLastPage_ViewSpecificProduct_Label = new Label();
            HistoryNextPage_ViewSpecificProduct_Button = new Button();
            HistoryGetPage_ViewSpecificProduct_TextBox = new TextBox();
            HistoryThisPage_ViewSpecificProduct_Label = new Label();
            HistoryPreviousPage_ViewSpecificProduct_Button = new Button();
            HistoryFirstPage_ViewSpecificProduct_Label = new Label();
            History_ViewSpecificProduct_Label = new Label();
            Delete_ViewSpecificProduct_Button = new Button();
            CopyId_ViewSpecificProduct_Button = new Button();
            SaveAndClose_ViewSpecificProduct_Button = new Button();
            Close_ViewSpecificProduct_Button = new Button();
            Note_ViewSpecificProduct_TextBox = new TextBox();
            Weight_ViewSpecificProduct_TextBox = new TextBox();
            Length_ViewSpecificProduct_TextBox = new TextBox();
            Width_ViewSpecificProduct_TextBox = new TextBox();
            Height_ViewSpecificProduct_TextBox = new TextBox();
            Note_ViewSpecificProduct_Label = new Label();
            Weight_ViewSpecificProduct_Label = new Label();
            Length_ViewSpecificProduct_Label = new Label();
            Width_ViewSpecificProduct_Label = new Label();
            Height_ViewSpecificProduct_Label = new Label();
            Charactericstics_ViewSpecificProduct_Label = new Label();
            Price_ViewSpecificProduct_TextBox = new TextBox();
            Id_ViewSpecificProduct_Label = new Label();
            Name_ViewSpecificProduct_TextBox = new TextBox();
            Price_ViewSpecificProduct_Label = new Label();
            Name_ViewSpecificProduct_Label = new Label();
            AllProductsThisPage_ViewProducts_Label = new Label();
            AllProductsLastPage_ViewProducts_Label = new Label();
            AllProductsFirstPage_ViewProducts_Label = new Label();
            AllProductsGetPage_ViewProducts_TextBox = new TextBox();
            AllProductsNextPage_ViewProducts_Button = new Button();
            AllProductsPreviousPage_ViewProducts_Button = new Button();
            PageName_ViewProducts_Label = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            Notification_AddProduct_Label = new Label();
            AddProduct_Addproduct_Button = new Button();
            Note_AddProduct_TextBox = new TextBox();
            Note_AddProduct_Label = new Label();
            Weight_AddProduct_Label = new Label();
            Weight_AddProduct_TextBox = new TextBox();
            Length_AddProduct_Label = new Label();
            Width_AddProduct_Label = new Label();
            Height_AddProduct_Label = new Label();
            Characcteristics_AddProduct_Label = new Label();
            Length_AddProduct_TextBox = new TextBox();
            Width_AddProduct_TextBox = new TextBox();
            Height_AddProduct_TextBox = new TextBox();
            Price_AddProduct_TextBox = new TextBox();
            Price_AddProduct_lable = new Label();
            Name_AddProduct_TextBox = new TextBox();
            Name_AddProduct_Label = new Label();
            AddProductNameInPage = new Label();
            tabPage6 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllProductTable_ViewProducts_DataGridView).BeginInit();
            AllProductInfo_ViewProducts_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)History_ViewSpecificProduct_DataGridView).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 15);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1262, 673);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(AllProductTable_ViewProducts_DataGridView);
            tabPage1.Controls.Add(AllProductInfo_ViewProducts_Panel);
            tabPage1.Controls.Add(AllProductsThisPage_ViewProducts_Label);
            tabPage1.Controls.Add(AllProductsLastPage_ViewProducts_Label);
            tabPage1.Controls.Add(AllProductsFirstPage_ViewProducts_Label);
            tabPage1.Controls.Add(AllProductsGetPage_ViewProducts_TextBox);
            tabPage1.Controls.Add(AllProductsNextPage_ViewProducts_Button);
            tabPage1.Controls.Add(AllProductsPreviousPage_ViewProducts_Button);
            tabPage1.Controls.Add(PageName_ViewProducts_Label);
            tabPage1.Location = new Point(4, 53);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1254, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Перегляд товарів на складі ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AllProductTable_ViewProducts_DataGridView
            // 
            AllProductTable_ViewProducts_DataGridView.AllowUserToAddRows = false;
            AllProductTable_ViewProducts_DataGridView.AllowUserToDeleteRows = false;
            AllProductTable_ViewProducts_DataGridView.AllowUserToResizeColumns = false;
            AllProductTable_ViewProducts_DataGridView.AllowUserToResizeRows = false;
            AllProductTable_ViewProducts_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllProductTable_ViewProducts_DataGridView.BackgroundColor = SystemColors.AppWorkspace;
            AllProductTable_ViewProducts_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllProductTable_ViewProducts_DataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, DateAndTime, Name });
            AllProductTable_ViewProducts_DataGridView.GridColor = SystemColors.ControlText;
            AllProductTable_ViewProducts_DataGridView.Location = new Point(3, 70);
            AllProductTable_ViewProducts_DataGridView.MultiSelect = false;
            AllProductTable_ViewProducts_DataGridView.Name = "AllProductTable_ViewProducts_DataGridView";
            AllProductTable_ViewProducts_DataGridView.ReadOnly = true;
            AllProductTable_ViewProducts_DataGridView.RowHeadersVisible = false;
            AllProductTable_ViewProducts_DataGridView.RowHeadersWidth = 51;
            AllProductTable_ViewProducts_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllProductTable_ViewProducts_DataGridView.Size = new Size(594, 507);
            AllProductTable_ViewProducts_DataGridView.TabIndex = 10;
            AllProductTable_ViewProducts_DataGridView.CellClick += AllProductTable_ViewProducts_DataGridView_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.FillWeight = 15F;
            Id.HeaderText = "Id товару";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // DateAndTime
            // 
            DateAndTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateAndTime.DataPropertyName = "DateAndTime";
            DateAndTime.FillWeight = 25F;
            DateAndTime.HeaderText = "Дата";
            DateAndTime.MinimumWidth = 6;
            DateAndTime.Name = "DateAndTime";
            DateAndTime.ReadOnly = true;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.FillWeight = 60F;
            Name.HeaderText = "Назва";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // AllProductInfo_ViewProducts_Panel
            // 
            AllProductInfo_ViewProducts_Panel.AutoScroll = true;
            AllProductInfo_ViewProducts_Panel.AutoScrollMinSize = new Size(0, 1200);
            AllProductInfo_ViewProducts_Panel.BackColor = Color.LemonChiffon;
            AllProductInfo_ViewProducts_Panel.Controls.Add(Id_ViewSpecificProduct_LabelText);
            AllProductInfo_ViewProducts_Panel.Controls.Add(History_ViewSpecificProduct_DataGridView);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Time_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Time_ViewSpecificProduct_LabelText);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Quantity_ViewSpecificProduct_Lable);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Quantity_ViewSpecificProduct_LabelText);
            AllProductInfo_ViewProducts_Panel.Controls.Add(DeleteHistory_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(HistoryLastPage_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(HistoryNextPage_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(HistoryGetPage_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(HistoryThisPage_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(HistoryPreviousPage_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(HistoryFirstPage_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(History_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Delete_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(CopyId_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(SaveAndClose_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Close_ViewSpecificProduct_Button);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Note_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Weight_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Length_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Width_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Height_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Note_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Weight_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Length_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Width_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Height_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Charactericstics_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Price_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Id_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Name_ViewSpecificProduct_TextBox);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Price_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Controls.Add(Name_ViewSpecificProduct_Label);
            AllProductInfo_ViewProducts_Panel.Location = new Point(603, 70);
            AllProductInfo_ViewProducts_Panel.Name = "AllProductInfo_ViewProducts_Panel";
            AllProductInfo_ViewProducts_Panel.Size = new Size(645, 507);
            AllProductInfo_ViewProducts_Panel.TabIndex = 8;
            AllProductInfo_ViewProducts_Panel.Visible = false;
            // 
            // Id_ViewSpecificProduct_LabelText
            // 
            Id_ViewSpecificProduct_LabelText.AutoSize = true;
            Id_ViewSpecificProduct_LabelText.Location = new Point(318, 11);
            Id_ViewSpecificProduct_LabelText.Name = "Id_ViewSpecificProduct_LabelText";
            Id_ViewSpecificProduct_LabelText.Size = new Size(80, 20);
            Id_ViewSpecificProduct_LabelText.TabIndex = 34;
            Id_ViewSpecificProduct_LabelText.Text = "Id товару: ";
            // 
            // History_ViewSpecificProduct_DataGridView
            // 
            History_ViewSpecificProduct_DataGridView.AllowUserToAddRows = false;
            History_ViewSpecificProduct_DataGridView.AllowUserToDeleteRows = false;
            History_ViewSpecificProduct_DataGridView.AllowUserToResizeColumns = false;
            History_ViewSpecificProduct_DataGridView.AllowUserToResizeRows = false;
            History_ViewSpecificProduct_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            History_ViewSpecificProduct_DataGridView.BackgroundColor = SystemColors.AppWorkspace;
            History_ViewSpecificProduct_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            History_ViewSpecificProduct_DataGridView.Columns.AddRange(new DataGridViewColumn[] { Date, Incident });
            History_ViewSpecificProduct_DataGridView.GridColor = SystemColors.ControlText;
            History_ViewSpecificProduct_DataGridView.Location = new Point(3, 590);
            History_ViewSpecificProduct_DataGridView.MultiSelect = false;
            History_ViewSpecificProduct_DataGridView.Name = "History_ViewSpecificProduct_DataGridView";
            History_ViewSpecificProduct_DataGridView.ReadOnly = true;
            History_ViewSpecificProduct_DataGridView.RowHeadersVisible = false;
            History_ViewSpecificProduct_DataGridView.RowHeadersWidth = 51;
            History_ViewSpecificProduct_DataGridView.Size = new Size(518, 508);
            History_ViewSpecificProduct_DataGridView.TabIndex = 33;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.FillWeight = 20F;
            Date.HeaderText = "Дата події";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Incident
            // 
            Incident.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Incident.FillWeight = 80F;
            Incident.HeaderText = "Подія";
            Incident.MinimumWidth = 6;
            Incident.Name = "Incident";
            Incident.ReadOnly = true;
            // 
            // Time_ViewSpecificProduct_Label
            // 
            Time_ViewSpecificProduct_Label.AutoSize = true;
            Time_ViewSpecificProduct_Label.Location = new Point(421, 64);
            Time_ViewSpecificProduct_Label.Name = "Time_ViewSpecificProduct_Label";
            Time_ViewSpecificProduct_Label.Size = new Size(50, 20);
            Time_ViewSpecificProduct_Label.TabIndex = 32;
            Time_ViewSpecificProduct_Label.Text = "label3";
            // 
            // Time_ViewSpecificProduct_LabelText
            // 
            Time_ViewSpecificProduct_LabelText.AutoSize = true;
            Time_ViewSpecificProduct_LabelText.Location = new Point(207, 64);
            Time_ViewSpecificProduct_LabelText.Name = "Time_ViewSpecificProduct_LabelText";
            Time_ViewSpecificProduct_LabelText.Size = new Size(218, 20);
            Time_ViewSpecificProduct_LabelText.TabIndex = 31;
            Time_ViewSpecificProduct_LabelText.Text = "Час останньої зміни кількості:";
            // 
            // Quantity_ViewSpecificProduct_Lable
            // 
            Quantity_ViewSpecificProduct_Lable.AutoSize = true;
            Quantity_ViewSpecificProduct_Lable.Location = new Point(363, 90);
            Quantity_ViewSpecificProduct_Lable.Name = "Quantity_ViewSpecificProduct_Lable";
            Quantity_ViewSpecificProduct_Lable.Size = new Size(50, 20);
            Quantity_ViewSpecificProduct_Lable.TabIndex = 30;
            Quantity_ViewSpecificProduct_Lable.Text = "label2";
            // 
            // Quantity_ViewSpecificProduct_LabelText
            // 
            Quantity_ViewSpecificProduct_LabelText.AutoSize = true;
            Quantity_ViewSpecificProduct_LabelText.Location = new Point(207, 90);
            Quantity_ViewSpecificProduct_LabelText.Name = "Quantity_ViewSpecificProduct_LabelText";
            Quantity_ViewSpecificProduct_LabelText.Size = new Size(159, 20);
            Quantity_ViewSpecificProduct_LabelText.TabIndex = 29;
            Quantity_ViewSpecificProduct_LabelText.Text = "Одиниць в наявності:";
            // 
            // DeleteHistory_ViewSpecificProduct_Button
            // 
            DeleteHistory_ViewSpecificProduct_Button.Location = new Point(329, 555);
            DeleteHistory_ViewSpecificProduct_Button.Name = "DeleteHistory_ViewSpecificProduct_Button";
            DeleteHistory_ViewSpecificProduct_Button.Size = new Size(192, 29);
            DeleteHistory_ViewSpecificProduct_Button.TabIndex = 28;
            DeleteHistory_ViewSpecificProduct_Button.Text = "Видалити історію товару";
            DeleteHistory_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // HistoryLastPage_ViewSpecificProduct_Label
            // 
            HistoryLastPage_ViewSpecificProduct_Label.AutoSize = true;
            HistoryLastPage_ViewSpecificProduct_Label.Location = new Point(479, 1108);
            HistoryLastPage_ViewSpecificProduct_Label.Name = "HistoryLastPage_ViewSpecificProduct_Label";
            HistoryLastPage_ViewSpecificProduct_Label.Size = new Size(58, 20);
            HistoryLastPage_ViewSpecificProduct_Label.TabIndex = 27;
            HistoryLastPage_ViewSpecificProduct_Label.Text = "label16";
            // 
            // HistoryNextPage_ViewSpecificProduct_Button
            // 
            HistoryNextPage_ViewSpecificProduct_Button.Location = new Point(379, 1104);
            HistoryNextPage_ViewSpecificProduct_Button.Name = "HistoryNextPage_ViewSpecificProduct_Button";
            HistoryNextPage_ViewSpecificProduct_Button.Size = new Size(94, 29);
            HistoryNextPage_ViewSpecificProduct_Button.TabIndex = 26;
            HistoryNextPage_ViewSpecificProduct_Button.Text = "Наступна";
            HistoryNextPage_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // HistoryGetPage_ViewSpecificProduct_TextBox
            // 
            HistoryGetPage_ViewSpecificProduct_TextBox.Location = new Point(248, 1106);
            HistoryGetPage_ViewSpecificProduct_TextBox.Name = "HistoryGetPage_ViewSpecificProduct_TextBox";
            HistoryGetPage_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            HistoryGetPage_ViewSpecificProduct_TextBox.TabIndex = 25;
            // 
            // HistoryThisPage_ViewSpecificProduct_Label
            // 
            HistoryThisPage_ViewSpecificProduct_Label.AutoSize = true;
            HistoryThisPage_ViewSpecificProduct_Label.Location = new Point(280, 1136);
            HistoryThisPage_ViewSpecificProduct_Label.Name = "HistoryThisPage_ViewSpecificProduct_Label";
            HistoryThisPage_ViewSpecificProduct_Label.Size = new Size(58, 20);
            HistoryThisPage_ViewSpecificProduct_Label.TabIndex = 24;
            HistoryThisPage_ViewSpecificProduct_Label.Text = "label15";
            // 
            // HistoryPreviousPage_ViewSpecificProduct_Button
            // 
            HistoryPreviousPage_ViewSpecificProduct_Button.Location = new Point(137, 1106);
            HistoryPreviousPage_ViewSpecificProduct_Button.Name = "HistoryPreviousPage_ViewSpecificProduct_Button";
            HistoryPreviousPage_ViewSpecificProduct_Button.Size = new Size(105, 27);
            HistoryPreviousPage_ViewSpecificProduct_Button.TabIndex = 23;
            HistoryPreviousPage_ViewSpecificProduct_Button.Text = "Попередня";
            HistoryPreviousPage_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // HistoryFirstPage_ViewSpecificProduct_Label
            // 
            HistoryFirstPage_ViewSpecificProduct_Label.AutoSize = true;
            HistoryFirstPage_ViewSpecificProduct_Label.Location = new Point(3, 1106);
            HistoryFirstPage_ViewSpecificProduct_Label.Name = "HistoryFirstPage_ViewSpecificProduct_Label";
            HistoryFirstPage_ViewSpecificProduct_Label.Size = new Size(135, 20);
            HistoryFirstPage_ViewSpecificProduct_Label.TabIndex = 22;
            HistoryFirstPage_ViewSpecificProduct_Label.Text = "Перша сторінка: 1";
            // 
            // History_ViewSpecificProduct_Label
            // 
            History_ViewSpecificProduct_Label.AutoSize = true;
            History_ViewSpecificProduct_Label.Location = new Point(3, 559);
            History_ViewSpecificProduct_Label.Name = "History_ViewSpecificProduct_Label";
            History_ViewSpecificProduct_Label.Size = new Size(56, 20);
            History_ViewSpecificProduct_Label.TabIndex = 21;
            History_ViewSpecificProduct_Label.Text = "Історія";
            // 
            // Delete_ViewSpecificProduct_Button
            // 
            Delete_ViewSpecificProduct_Button.Location = new Point(222, 496);
            Delete_ViewSpecificProduct_Button.Name = "Delete_ViewSpecificProduct_Button";
            Delete_ViewSpecificProduct_Button.Size = new Size(213, 29);
            Delete_ViewSpecificProduct_Button.TabIndex = 20;
            Delete_ViewSpecificProduct_Button.Text = "Видалити";
            Delete_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // CopyId_ViewSpecificProduct_Button
            // 
            CopyId_ViewSpecificProduct_Button.Location = new Point(222, 461);
            CopyId_ViewSpecificProduct_Button.Name = "CopyId_ViewSpecificProduct_Button";
            CopyId_ViewSpecificProduct_Button.Size = new Size(213, 29);
            CopyId_ViewSpecificProduct_Button.TabIndex = 19;
            CopyId_ViewSpecificProduct_Button.Text = "Скопіювати id";
            CopyId_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // SaveAndClose_ViewSpecificProduct_Button
            // 
            SaveAndClose_ViewSpecificProduct_Button.Location = new Point(3, 496);
            SaveAndClose_ViewSpecificProduct_Button.Name = "SaveAndClose_ViewSpecificProduct_Button";
            SaveAndClose_ViewSpecificProduct_Button.Size = new Size(213, 29);
            SaveAndClose_ViewSpecificProduct_Button.TabIndex = 18;
            SaveAndClose_ViewSpecificProduct_Button.Text = "Зберегти та закрити";
            SaveAndClose_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            SaveAndClose_ViewSpecificProduct_Button.Click += SaveAndClose_ViewSpecificProduct_Button_Click;
            // 
            // Close_ViewSpecificProduct_Button
            // 
            Close_ViewSpecificProduct_Button.Location = new Point(3, 461);
            Close_ViewSpecificProduct_Button.Name = "Close_ViewSpecificProduct_Button";
            Close_ViewSpecificProduct_Button.Size = new Size(213, 29);
            Close_ViewSpecificProduct_Button.TabIndex = 17;
            Close_ViewSpecificProduct_Button.Text = "Закрити";
            Close_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            Close_ViewSpecificProduct_Button.Click += Close_ViewSpecificProduct_Button_Click;
            // 
            // Note_ViewSpecificProduct_TextBox
            // 
            Note_ViewSpecificProduct_TextBox.Location = new Point(3, 213);
            Note_ViewSpecificProduct_TextBox.Multiline = true;
            Note_ViewSpecificProduct_TextBox.Name = "Note_ViewSpecificProduct_TextBox";
            Note_ViewSpecificProduct_TextBox.Size = new Size(518, 239);
            Note_ViewSpecificProduct_TextBox.TabIndex = 15;
            // 
            // Weight_ViewSpecificProduct_TextBox
            // 
            Weight_ViewSpecificProduct_TextBox.Location = new Point(396, 160);
            Weight_ViewSpecificProduct_TextBox.Name = "Weight_ViewSpecificProduct_TextBox";
            Weight_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            Weight_ViewSpecificProduct_TextBox.TabIndex = 14;
            // 
            // Length_ViewSpecificProduct_TextBox
            // 
            Length_ViewSpecificProduct_TextBox.Location = new Point(265, 160);
            Length_ViewSpecificProduct_TextBox.Name = "Length_ViewSpecificProduct_TextBox";
            Length_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            Length_ViewSpecificProduct_TextBox.TabIndex = 13;
            // 
            // Width_ViewSpecificProduct_TextBox
            // 
            Width_ViewSpecificProduct_TextBox.Location = new Point(134, 160);
            Width_ViewSpecificProduct_TextBox.Name = "Width_ViewSpecificProduct_TextBox";
            Width_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            Width_ViewSpecificProduct_TextBox.TabIndex = 12;
            // 
            // Height_ViewSpecificProduct_TextBox
            // 
            Height_ViewSpecificProduct_TextBox.Location = new Point(3, 160);
            Height_ViewSpecificProduct_TextBox.Name = "Height_ViewSpecificProduct_TextBox";
            Height_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            Height_ViewSpecificProduct_TextBox.TabIndex = 11;
            // 
            // Note_ViewSpecificProduct_Label
            // 
            Note_ViewSpecificProduct_Label.AutoSize = true;
            Note_ViewSpecificProduct_Label.Location = new Point(3, 190);
            Note_ViewSpecificProduct_Label.Name = "Note_ViewSpecificProduct_Label";
            Note_ViewSpecificProduct_Label.Size = new Size(74, 20);
            Note_ViewSpecificProduct_Label.TabIndex = 10;
            Note_ViewSpecificProduct_Label.Text = "Примітка";
            // 
            // Weight_ViewSpecificProduct_Label
            // 
            Weight_ViewSpecificProduct_Label.AutoSize = true;
            Weight_ViewSpecificProduct_Label.Location = new Point(396, 137);
            Weight_ViewSpecificProduct_Label.Name = "Weight_ViewSpecificProduct_Label";
            Weight_ViewSpecificProduct_Label.Size = new Size(40, 20);
            Weight_ViewSpecificProduct_Label.TabIndex = 9;
            Weight_ViewSpecificProduct_Label.Text = "Вага";
            // 
            // Length_ViewSpecificProduct_Label
            // 
            Length_ViewSpecificProduct_Label.AutoSize = true;
            Length_ViewSpecificProduct_Label.Location = new Point(265, 137);
            Length_ViewSpecificProduct_Label.Name = "Length_ViewSpecificProduct_Label";
            Length_ViewSpecificProduct_Label.Size = new Size(73, 20);
            Length_ViewSpecificProduct_Label.TabIndex = 8;
            Length_ViewSpecificProduct_Label.Text = "Довжина";
            // 
            // Width_ViewSpecificProduct_Label
            // 
            Width_ViewSpecificProduct_Label.AutoSize = true;
            Width_ViewSpecificProduct_Label.Location = new Point(134, 137);
            Width_ViewSpecificProduct_Label.Name = "Width_ViewSpecificProduct_Label";
            Width_ViewSpecificProduct_Label.Size = new Size(67, 20);
            Width_ViewSpecificProduct_Label.TabIndex = 7;
            Width_ViewSpecificProduct_Label.Text = "Ширина";
            // 
            // Height_ViewSpecificProduct_Label
            // 
            Height_ViewSpecificProduct_Label.AutoSize = true;
            Height_ViewSpecificProduct_Label.Location = new Point(3, 137);
            Height_ViewSpecificProduct_Label.Name = "Height_ViewSpecificProduct_Label";
            Height_ViewSpecificProduct_Label.Size = new Size(57, 20);
            Height_ViewSpecificProduct_Label.TabIndex = 6;
            Height_ViewSpecificProduct_Label.Text = "Висота";
            // 
            // Charactericstics_ViewSpecificProduct_Label
            // 
            Charactericstics_ViewSpecificProduct_Label.AutoSize = true;
            Charactericstics_ViewSpecificProduct_Label.Location = new Point(3, 117);
            Charactericstics_ViewSpecificProduct_Label.Name = "Charactericstics_ViewSpecificProduct_Label";
            Charactericstics_ViewSpecificProduct_Label.Size = new Size(120, 20);
            Charactericstics_ViewSpecificProduct_Label.TabIndex = 5;
            Charactericstics_ViewSpecificProduct_Label.Text = "Характеристики";
            // 
            // Price_ViewSpecificProduct_TextBox
            // 
            Price_ViewSpecificProduct_TextBox.Location = new Point(3, 87);
            Price_ViewSpecificProduct_TextBox.Name = "Price_ViewSpecificProduct_TextBox";
            Price_ViewSpecificProduct_TextBox.Size = new Size(198, 27);
            Price_ViewSpecificProduct_TextBox.TabIndex = 4;
            // 
            // Id_ViewSpecificProduct_Label
            // 
            Id_ViewSpecificProduct_Label.AutoSize = true;
            Id_ViewSpecificProduct_Label.Location = new Point(396, 11);
            Id_ViewSpecificProduct_Label.Name = "Id_ViewSpecificProduct_Label";
            Id_ViewSpecificProduct_Label.Size = new Size(50, 20);
            Id_ViewSpecificProduct_Label.TabIndex = 3;
            Id_ViewSpecificProduct_Label.Text = "label6";
            // 
            // Name_ViewSpecificProduct_TextBox
            // 
            Name_ViewSpecificProduct_TextBox.Location = new Point(3, 34);
            Name_ViewSpecificProduct_TextBox.Name = "Name_ViewSpecificProduct_TextBox";
            Name_ViewSpecificProduct_TextBox.Size = new Size(518, 27);
            Name_ViewSpecificProduct_TextBox.TabIndex = 2;
            // 
            // Price_ViewSpecificProduct_Label
            // 
            Price_ViewSpecificProduct_Label.AutoSize = true;
            Price_ViewSpecificProduct_Label.Location = new Point(3, 64);
            Price_ViewSpecificProduct_Label.Name = "Price_ViewSpecificProduct_Label";
            Price_ViewSpecificProduct_Label.Size = new Size(66, 20);
            Price_ViewSpecificProduct_Label.TabIndex = 1;
            Price_ViewSpecificProduct_Label.Text = "Вартість";
            // 
            // Name_ViewSpecificProduct_Label
            // 
            Name_ViewSpecificProduct_Label.AutoSize = true;
            Name_ViewSpecificProduct_Label.Location = new Point(3, 11);
            Name_ViewSpecificProduct_Label.Name = "Name_ViewSpecificProduct_Label";
            Name_ViewSpecificProduct_Label.Size = new Size(51, 20);
            Name_ViewSpecificProduct_Label.TabIndex = 0;
            Name_ViewSpecificProduct_Label.Text = "Назва";
            // 
            // AllProductsThisPage_ViewProducts_Label
            // 
            AllProductsThisPage_ViewProducts_Label.AutoSize = true;
            AllProductsThisPage_ViewProducts_Label.Location = new Point(6, 580);
            AllProductsThisPage_ViewProducts_Label.Name = "AllProductsThisPage_ViewProducts_Label";
            AllProductsThisPage_ViewProducts_Label.Size = new Size(50, 20);
            AllProductsThisPage_ViewProducts_Label.TabIndex = 7;
            AllProductsThisPage_ViewProducts_Label.Text = "label3";
            // 
            // AllProductsLastPage_ViewProducts_Label
            // 
            AllProductsLastPage_ViewProducts_Label.AutoSize = true;
            AllProductsLastPage_ViewProducts_Label.Location = new Point(508, 38);
            AllProductsLastPage_ViewProducts_Label.Name = "AllProductsLastPage_ViewProducts_Label";
            AllProductsLastPage_ViewProducts_Label.Size = new Size(50, 20);
            AllProductsLastPage_ViewProducts_Label.TabIndex = 6;
            AllProductsLastPage_ViewProducts_Label.Text = "label2";
            // 
            // AllProductsFirstPage_ViewProducts_Label
            // 
            AllProductsFirstPage_ViewProducts_Label.AutoSize = true;
            AllProductsFirstPage_ViewProducts_Label.Location = new Point(8, 38);
            AllProductsFirstPage_ViewProducts_Label.Name = "AllProductsFirstPage_ViewProducts_Label";
            AllProductsFirstPage_ViewProducts_Label.Size = new Size(133, 20);
            AllProductsFirstPage_ViewProducts_Label.TabIndex = 5;
            AllProductsFirstPage_ViewProducts_Label.Text = "перша сторінка: 1";
            // 
            // AllProductsGetPage_ViewProducts_TextBox
            // 
            AllProductsGetPage_ViewProducts_TextBox.Location = new Point(263, 35);
            AllProductsGetPage_ViewProducts_TextBox.Name = "AllProductsGetPage_ViewProducts_TextBox";
            AllProductsGetPage_ViewProducts_TextBox.Size = new Size(125, 27);
            AllProductsGetPage_ViewProducts_TextBox.TabIndex = 4;
            AllProductsGetPage_ViewProducts_TextBox.KeyDown += AllProductsGetPage_ViewProducts_TextBox_KeyDown;
            // 
            // AllProductsNextPage_ViewProducts_Button
            // 
            AllProductsNextPage_ViewProducts_Button.Location = new Point(394, 33);
            AllProductsNextPage_ViewProducts_Button.Name = "AllProductsNextPage_ViewProducts_Button";
            AllProductsNextPage_ViewProducts_Button.Size = new Size(108, 29);
            AllProductsNextPage_ViewProducts_Button.TabIndex = 3;
            AllProductsNextPage_ViewProducts_Button.Text = "Наступна";
            AllProductsNextPage_ViewProducts_Button.UseVisualStyleBackColor = true;
            AllProductsNextPage_ViewProducts_Button.Click += AllProductsNextPage_ViewProducts_Button_Click;
            // 
            // AllProductsPreviousPage_ViewProducts_Button
            // 
            AllProductsPreviousPage_ViewProducts_Button.Location = new Point(147, 34);
            AllProductsPreviousPage_ViewProducts_Button.Name = "AllProductsPreviousPage_ViewProducts_Button";
            AllProductsPreviousPage_ViewProducts_Button.Size = new Size(113, 29);
            AllProductsPreviousPage_ViewProducts_Button.TabIndex = 2;
            AllProductsPreviousPage_ViewProducts_Button.Text = "Попередня";
            AllProductsPreviousPage_ViewProducts_Button.UseVisualStyleBackColor = true;
            AllProductsPreviousPage_ViewProducts_Button.Click += AllProductsPreviousPage_ViewProducts_Button_Click;
            // 
            // PageName_ViewProducts_Label
            // 
            PageName_ViewProducts_Label.AutoSize = true;
            PageName_ViewProducts_Label.Location = new Point(3, 3);
            PageName_ViewProducts_Label.Name = "PageName_ViewProducts_Label";
            PageName_ViewProducts_Label.Size = new Size(238, 20);
            PageName_ViewProducts_Label.TabIndex = 0;
            PageName_ViewProducts_Label.Text = "Усі товари що присутні на складі";
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
            // tabPage5
            // 
            tabPage5.Controls.Add(Notification_AddProduct_Label);
            tabPage5.Controls.Add(AddProduct_Addproduct_Button);
            tabPage5.Controls.Add(Note_AddProduct_TextBox);
            tabPage5.Controls.Add(Note_AddProduct_Label);
            tabPage5.Controls.Add(Weight_AddProduct_Label);
            tabPage5.Controls.Add(Weight_AddProduct_TextBox);
            tabPage5.Controls.Add(Length_AddProduct_Label);
            tabPage5.Controls.Add(Width_AddProduct_Label);
            tabPage5.Controls.Add(Height_AddProduct_Label);
            tabPage5.Controls.Add(Characcteristics_AddProduct_Label);
            tabPage5.Controls.Add(Length_AddProduct_TextBox);
            tabPage5.Controls.Add(Width_AddProduct_TextBox);
            tabPage5.Controls.Add(Height_AddProduct_TextBox);
            tabPage5.Controls.Add(Price_AddProduct_TextBox);
            tabPage5.Controls.Add(Price_AddProduct_lable);
            tabPage5.Controls.Add(Name_AddProduct_TextBox);
            tabPage5.Controls.Add(Name_AddProduct_Label);
            tabPage5.Controls.Add(AddProductNameInPage);
            tabPage5.Location = new Point(4, 53);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1254, 616);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Додати товар";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Notification_AddProduct_Label
            // 
            Notification_AddProduct_Label.AutoSize = true;
            Notification_AddProduct_Label.Location = new Point(270, 572);
            Notification_AddProduct_Label.Name = "Notification_AddProduct_Label";
            Notification_AddProduct_Label.Size = new Size(0, 20);
            Notification_AddProduct_Label.TabIndex = 17;
            // 
            // AddProduct_Addproduct_Button
            // 
            AddProduct_Addproduct_Button.Location = new Point(8, 557);
            AddProduct_Addproduct_Button.Name = "AddProduct_Addproduct_Button";
            AddProduct_Addproduct_Button.Size = new Size(256, 51);
            AddProduct_Addproduct_Button.TabIndex = 16;
            AddProduct_Addproduct_Button.Text = "Додати товар";
            AddProduct_Addproduct_Button.UseVisualStyleBackColor = true;
            AddProduct_Addproduct_Button.Click += AddProduct_Addproduct_Button_Click;
            // 
            // Note_AddProduct_TextBox
            // 
            Note_AddProduct_TextBox.Location = new Point(8, 323);
            Note_AddProduct_TextBox.Multiline = true;
            Note_AddProduct_TextBox.Name = "Note_AddProduct_TextBox";
            Note_AddProduct_TextBox.Size = new Size(712, 228);
            Note_AddProduct_TextBox.TabIndex = 15;
            // 
            // Note_AddProduct_Label
            // 
            Note_AddProduct_Label.AutoSize = true;
            Note_AddProduct_Label.Location = new Point(6, 300);
            Note_AddProduct_Label.Name = "Note_AddProduct_Label";
            Note_AddProduct_Label.Size = new Size(74, 20);
            Note_AddProduct_Label.TabIndex = 14;
            Note_AddProduct_Label.Text = "Примітка";
            // 
            // Weight_AddProduct_Label
            // 
            Weight_AddProduct_Label.AutoSize = true;
            Weight_AddProduct_Label.Location = new Point(134, 273);
            Weight_AddProduct_Label.Name = "Weight_AddProduct_Label";
            Weight_AddProduct_Label.Size = new Size(125, 20);
            Weight_AddProduct_Label.TabIndex = 13;
            Weight_AddProduct_Label.Text = "Вага (кілограми)";
            // 
            // Weight_AddProduct_TextBox
            // 
            Weight_AddProduct_TextBox.Location = new Point(8, 270);
            Weight_AddProduct_TextBox.Name = "Weight_AddProduct_TextBox";
            Weight_AddProduct_TextBox.Size = new Size(120, 27);
            Weight_AddProduct_TextBox.TabIndex = 12;
            // 
            // Length_AddProduct_Label
            // 
            Length_AddProduct_Label.AutoSize = true;
            Length_AddProduct_Label.Location = new Point(134, 240);
            Length_AddProduct_Label.Name = "Length_AddProduct_Label";
            Length_AddProduct_Label.Size = new Size(130, 20);
            Length_AddProduct_Label.TabIndex = 11;
            Length_AddProduct_Label.Text = "Довжина (метри)";
            // 
            // Width_AddProduct_Label
            // 
            Width_AddProduct_Label.AutoSize = true;
            Width_AddProduct_Label.Location = new Point(134, 207);
            Width_AddProduct_Label.Name = "Width_AddProduct_Label";
            Width_AddProduct_Label.Size = new Size(124, 20);
            Width_AddProduct_Label.TabIndex = 10;
            Width_AddProduct_Label.Text = "Ширина (метри)";
            // 
            // Height_AddProduct_Label
            // 
            Height_AddProduct_Label.AutoSize = true;
            Height_AddProduct_Label.Location = new Point(134, 174);
            Height_AddProduct_Label.Name = "Height_AddProduct_Label";
            Height_AddProduct_Label.Size = new Size(114, 20);
            Height_AddProduct_Label.TabIndex = 9;
            Height_AddProduct_Label.Text = "Висота (метри)";
            // 
            // Characcteristics_AddProduct_Label
            // 
            Characcteristics_AddProduct_Label.AutoSize = true;
            Characcteristics_AddProduct_Label.Location = new Point(8, 148);
            Characcteristics_AddProduct_Label.Name = "Characcteristics_AddProduct_Label";
            Characcteristics_AddProduct_Label.Size = new Size(120, 20);
            Characcteristics_AddProduct_Label.TabIndex = 8;
            Characcteristics_AddProduct_Label.Text = "Характеристики";
            // 
            // Length_AddProduct_TextBox
            // 
            Length_AddProduct_TextBox.Location = new Point(8, 237);
            Length_AddProduct_TextBox.Name = "Length_AddProduct_TextBox";
            Length_AddProduct_TextBox.Size = new Size(120, 27);
            Length_AddProduct_TextBox.TabIndex = 7;
            // 
            // Width_AddProduct_TextBox
            // 
            Width_AddProduct_TextBox.Location = new Point(8, 204);
            Width_AddProduct_TextBox.Name = "Width_AddProduct_TextBox";
            Width_AddProduct_TextBox.Size = new Size(120, 27);
            Width_AddProduct_TextBox.TabIndex = 6;
            // 
            // Height_AddProduct_TextBox
            // 
            Height_AddProduct_TextBox.Location = new Point(8, 171);
            Height_AddProduct_TextBox.Name = "Height_AddProduct_TextBox";
            Height_AddProduct_TextBox.Size = new Size(120, 27);
            Height_AddProduct_TextBox.TabIndex = 5;
            // 
            // Price_AddProduct_TextBox
            // 
            Price_AddProduct_TextBox.Location = new Point(8, 118);
            Price_AddProduct_TextBox.Name = "Price_AddProduct_TextBox";
            Price_AddProduct_TextBox.Size = new Size(120, 27);
            Price_AddProduct_TextBox.TabIndex = 4;
            // 
            // Price_AddProduct_lable
            // 
            Price_AddProduct_lable.AutoSize = true;
            Price_AddProduct_lable.Location = new Point(8, 95);
            Price_AddProduct_lable.Name = "Price_AddProduct_lable";
            Price_AddProduct_lable.Size = new Size(114, 20);
            Price_AddProduct_lable.TabIndex = 3;
            Price_AddProduct_lable.Text = "Вартість (грн) *";
            // 
            // Name_AddProduct_TextBox
            // 
            Name_AddProduct_TextBox.Location = new Point(8, 65);
            Name_AddProduct_TextBox.Name = "Name_AddProduct_TextBox";
            Name_AddProduct_TextBox.Size = new Size(456, 27);
            Name_AddProduct_TextBox.TabIndex = 2;
            Name_AddProduct_TextBox.TextChanged += Name_AddProduct_TextBox_TextChanged;
            // 
            // Name_AddProduct_Label
            // 
            Name_AddProduct_Label.AutoSize = true;
            Name_AddProduct_Label.Location = new Point(8, 42);
            Name_AddProduct_Label.Name = "Name_AddProduct_Label";
            Name_AddProduct_Label.Size = new Size(61, 20);
            Name_AddProduct_Label.TabIndex = 1;
            Name_AddProduct_Label.Text = "Назва *";
            // 
            // AddProductNameInPage
            // 
            AddProductNameInPage.AutoSize = true;
            AddProductNameInPage.Location = new Point(8, 3);
            AddProductNameInPage.Name = "AddProductNameInPage";
            AddProductNameInPage.Size = new Size(236, 20);
            AddProductNameInPage.TabIndex = 0;
            AddProductNameInPage.Text = "Дадавання нового товару у базу";
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 53);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1254, 616);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Історія";
            tabPage6.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ControlText;
            Text = "Склад";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllProductTable_ViewProducts_DataGridView).EndInit();
            AllProductInfo_ViewProducts_Panel.ResumeLayout(false);
            AllProductInfo_ViewProducts_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)History_ViewSpecificProduct_DataGridView).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private TabPage tabPage5;
        private Label Name_AddProduct_Label;
        private Label AddProductNameInPage;
        private TextBox Name_AddProduct_TextBox;
        private Label Price_AddProduct_lable;
        private Label Characcteristics_AddProduct_Label;
        private TextBox Length_AddProduct_TextBox;
        private TextBox Width_AddProduct_TextBox;
        private TextBox Height_AddProduct_TextBox;
        private TextBox Price_AddProduct_TextBox;
        private Label Length_AddProduct_Label;
        private Label Width_AddProduct_Label;
        private Label Height_AddProduct_Label;
        private Label Weight_AddProduct_Label;
        private TextBox Weight_AddProduct_TextBox;
        private Label Note_AddProduct_Label;
        private TextBox Note_AddProduct_TextBox;
        private Button AddProduct_Addproduct_Button;
        private TabPage tabPage4;
        private TabPage tabPage6;
        private Label Notification_AddProduct_Label;
        private Label PageName_ViewProducts_Label;
        private Button AllProductsPreviousPage_ViewProducts_Button;
        private Label AllProductsThisPage_ViewProducts_Label;
        private Label AllProductsLastPage_ViewProducts_Label;
        private Label AllProductsFirstPage_ViewProducts_Label;
        private TextBox AllProductsGetPage_ViewProducts_TextBox;
        private Button AllProductsNextPage_ViewProducts_Button;
        private Panel AllProductInfo_ViewProducts_Panel;
        private TextBox Name_ViewSpecificProduct_TextBox;
        private Label Price_ViewSpecificProduct_Label;
        private Label Name_ViewSpecificProduct_Label;
        private TextBox Note_ViewSpecificProduct_TextBox;
        private TextBox Weight_ViewSpecificProduct_TextBox;
        private TextBox Length_ViewSpecificProduct_TextBox;
        private TextBox Width_ViewSpecificProduct_TextBox;
        private TextBox Height_ViewSpecificProduct_TextBox;
        private Label Note_ViewSpecificProduct_Label;
        private Label Weight_ViewSpecificProduct_Label;
        private Label Length_ViewSpecificProduct_Label;
        private Label Width_ViewSpecificProduct_Label;
        private Label Height_ViewSpecificProduct_Label;
        private Label Charactericstics_ViewSpecificProduct_Label;
        private TextBox Price_ViewSpecificProduct_TextBox;
        private Label Id_ViewSpecificProduct_Label;
        private Label History_ViewSpecificProduct_Label;
        private Button Delete_ViewSpecificProduct_Button;
        private Button CopyId_ViewSpecificProduct_Button;
        private Button SaveAndClose_ViewSpecificProduct_Button;
        private Button Close_ViewSpecificProduct_Button;
        private Button DeleteHistory_ViewSpecificProduct_Button;
        private Label HistoryLastPage_ViewSpecificProduct_Label;
        private Button HistoryNextPage_ViewSpecificProduct_Button;
        private TextBox HistoryGetPage_ViewSpecificProduct_TextBox;
        private Label HistoryThisPage_ViewSpecificProduct_Label;
        private Button HistoryPreviousPage_ViewSpecificProduct_Button;
        private Label HistoryFirstPage_ViewSpecificProduct_Label;
        private Label Quantity_ViewSpecificProduct_Lable;
        private Label Quantity_ViewSpecificProduct_LabelText;
        private Label Time_ViewSpecificProduct_Label;
        private Label Time_ViewSpecificProduct_LabelText;
        private DataGridView AllProductTable_ViewProducts_DataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DateAndTime;
        private DataGridViewTextBoxColumn Name;
        private DataGridView History_ViewSpecificProduct_DataGridView;
        private Label Id_ViewSpecificProduct_LabelText;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Incident;
    }
}
