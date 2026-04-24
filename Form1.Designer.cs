namespace Курсовий_проєкт_на_тему_склад
{
    partial class Warehouse_Window_Form
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
            program_TabControl = new TabControl();
            allProduct_TabPage = new TabPage();
            allProductTable_ViewProducts_DataGridView = new DataGridView();
            id_AllProduct_TableColumn = new DataGridViewTextBoxColumn();
            dateAndTime = new DataGridViewTextBoxColumn();
            name_AllProduct_TableColumn = new DataGridViewTextBoxColumn();
            allProductInfo_ViewProducts_Panel = new Panel();
            id_ViewSpecificProduct_LabelText = new Label();
            history_ViewSpecificProduct_DataGridView = new DataGridView();
            date_ViewProduct_TableColumn = new DataGridViewTextBoxColumn();
            Incident_ViewProduct_TableColumn = new DataGridViewTextBoxColumn();
            time_ViewSpecificProduct_Label = new Label();
            time_ViewSpecificProduct_LabelText = new Label();
            quantity_ViewSpecificProduct_Label = new Label();
            quantity_ViewSpecificProduct_LabelText = new Label();
            deleteHistory_ViewSpecificProduct_Button = new Button();
            historyLastPage_ViewSpecificProduct_Label = new Label();
            historyNextPage_ViewSpecificProduct_Button = new Button();
            historyGetPage_ViewSpecificProduct_TextBox = new TextBox();
            historyThisPage_ViewSpecificProduct_Label = new Label();
            historyPreviousPage_ViewSpecificProduct_Button = new Button();
            historyFirstPage_ViewSpecificProduct_Label = new Label();
            history_ViewSpecificProduct_Label = new Label();
            delete_ViewSpecificProduct_Button = new Button();
            copyId_ViewSpecificProduct_Button = new Button();
            saveAndClose_ViewSpecificProduct_Button = new Button();
            close_ViewSpecificProduct_Button = new Button();
            note_ViewSpecificProduct_TextBox = new TextBox();
            weight_ViewSpecificProduct_TextBox = new TextBox();
            length_ViewSpecificProduct_TextBox = new TextBox();
            width_ViewSpecificProduct_TextBox = new TextBox();
            height_ViewSpecificProduct_TextBox = new TextBox();
            note_ViewSpecificProduct_Label = new Label();
            weight_ViewSpecificProduct_Label = new Label();
            length_ViewSpecificProduct_Label = new Label();
            width_ViewSpecificProduct_Label = new Label();
            height_ViewSpecificProduct_Label = new Label();
            charactericstics_ViewSpecificProduct_Label = new Label();
            price_ViewSpecificProduct_TextBox = new TextBox();
            id_ViewSpecificProduct_Label = new Label();
            name_ViewSpecificProduct_TextBox = new TextBox();
            price_ViewSpecificProduct_Label = new Label();
            name_ViewSpecificProduct_Label = new Label();
            allProductsThisPage_ViewProducts_Label = new Label();
            allProductsLastPage_ViewProducts_Label = new Label();
            allProductsFirstPage_ViewProducts_Label = new Label();
            allProductsGetPage_ViewProducts_TextBox = new TextBox();
            allProductsNextPage_ViewProducts_Button = new Button();
            allProductsPreviousPage_ViewProducts_Button = new Button();
            pageName_ViewProducts_Label = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            addProduct_TabPage = new TabPage();
            notification_AddProduct_Label = new Label();
            addProduct_Addproduct_Button = new Button();
            note_AddProduct_TextBox = new TextBox();
            note_AddProduct_Label = new Label();
            weight_AddProduct_Label = new Label();
            weight_AddProduct_TextBox = new TextBox();
            length_AddProduct_Label = new Label();
            width_AddProduct_Label = new Label();
            height_AddProduct_Label = new Label();
            characcteristics_AddProduct_Label = new Label();
            length_AddProduct_TextBox = new TextBox();
            width_AddProduct_TextBox = new TextBox();
            height_AddProduct_TextBox = new TextBox();
            price_AddProduct_TextBox = new TextBox();
            price_AddProduct_lable = new Label();
            name_AddProduct_TextBox = new TextBox();
            name_AddProduct_Label = new Label();
            addProduct_AddProduct_Label = new Label();
            tabPage6 = new TabPage();
            button1 = new Button();
            program_TabControl.SuspendLayout();
            allProduct_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allProductTable_ViewProducts_DataGridView).BeginInit();
            allProductInfo_ViewProducts_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)history_ViewSpecificProduct_DataGridView).BeginInit();
            addProduct_TabPage.SuspendLayout();
            SuspendLayout();
            // 
            // program_TabControl
            // 
            program_TabControl.Controls.Add(allProduct_TabPage);
            program_TabControl.Controls.Add(tabPage2);
            program_TabControl.Controls.Add(tabPage3);
            program_TabControl.Controls.Add(tabPage4);
            program_TabControl.Controls.Add(addProduct_TabPage);
            program_TabControl.Controls.Add(tabPage6);
            program_TabControl.Dock = DockStyle.Fill;
            program_TabControl.Location = new Point(0, 0);
            program_TabControl.Name = "program_TabControl";
            program_TabControl.Padding = new Point(10, 15);
            program_TabControl.SelectedIndex = 0;
            program_TabControl.Size = new Size(1262, 673);
            program_TabControl.TabIndex = 1;
            program_TabControl.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // allProduct_TabPage
            // 
            allProduct_TabPage.Controls.Add(allProductTable_ViewProducts_DataGridView);
            allProduct_TabPage.Controls.Add(allProductInfo_ViewProducts_Panel);
            allProduct_TabPage.Controls.Add(allProductsThisPage_ViewProducts_Label);
            allProduct_TabPage.Controls.Add(allProductsLastPage_ViewProducts_Label);
            allProduct_TabPage.Controls.Add(allProductsFirstPage_ViewProducts_Label);
            allProduct_TabPage.Controls.Add(allProductsGetPage_ViewProducts_TextBox);
            allProduct_TabPage.Controls.Add(allProductsNextPage_ViewProducts_Button);
            allProduct_TabPage.Controls.Add(allProductsPreviousPage_ViewProducts_Button);
            allProduct_TabPage.Controls.Add(pageName_ViewProducts_Label);
            allProduct_TabPage.Location = new Point(4, 53);
            allProduct_TabPage.Name = "allProduct_TabPage";
            allProduct_TabPage.Padding = new Padding(3);
            allProduct_TabPage.Size = new Size(1254, 616);
            allProduct_TabPage.TabIndex = 0;
            allProduct_TabPage.Text = "Перегляд товарів на складі ";
            allProduct_TabPage.UseVisualStyleBackColor = true;
            // 
            // allProductTable_ViewProducts_DataGridView
            // 
            allProductTable_ViewProducts_DataGridView.AllowUserToAddRows = false;
            allProductTable_ViewProducts_DataGridView.AllowUserToDeleteRows = false;
            allProductTable_ViewProducts_DataGridView.AllowUserToResizeColumns = false;
            allProductTable_ViewProducts_DataGridView.AllowUserToResizeRows = false;
            allProductTable_ViewProducts_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            allProductTable_ViewProducts_DataGridView.BackgroundColor = SystemColors.AppWorkspace;
            allProductTable_ViewProducts_DataGridView.ColumnHeadersHeight = 54;
            allProductTable_ViewProducts_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            allProductTable_ViewProducts_DataGridView.Columns.AddRange(new DataGridViewColumn[] { id_AllProduct_TableColumn, dateAndTime, name_AllProduct_TableColumn });
            allProductTable_ViewProducts_DataGridView.GridColor = SystemColors.ControlText;
            allProductTable_ViewProducts_DataGridView.Location = new Point(3, 70);
            allProductTable_ViewProducts_DataGridView.MultiSelect = false;
            allProductTable_ViewProducts_DataGridView.Name = "allProductTable_ViewProducts_DataGridView";
            allProductTable_ViewProducts_DataGridView.ReadOnly = true;
            allProductTable_ViewProducts_DataGridView.RowHeadersVisible = false;
            allProductTable_ViewProducts_DataGridView.RowHeadersWidth = 54;
            allProductTable_ViewProducts_DataGridView.RowTemplate.Height = 45;
            allProductTable_ViewProducts_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allProductTable_ViewProducts_DataGridView.Size = new Size(594, 507);
            allProductTable_ViewProducts_DataGridView.TabIndex = 5;
            allProductTable_ViewProducts_DataGridView.CellClick += allProductTable_ViewProducts_DataGridView_CellClick;
            // 
            // id_AllProduct_TableColumn
            // 
            id_AllProduct_TableColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_AllProduct_TableColumn.DataPropertyName = "Id";
            id_AllProduct_TableColumn.FillWeight = 15F;
            id_AllProduct_TableColumn.HeaderText = "Id товару";
            id_AllProduct_TableColumn.MinimumWidth = 6;
            id_AllProduct_TableColumn.Name = "id_AllProduct_TableColumn";
            id_AllProduct_TableColumn.ReadOnly = true;
            // 
            // dateAndTime
            // 
            dateAndTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateAndTime.DataPropertyName = "DateAndTime";
            dateAndTime.FillWeight = 25F;
            dateAndTime.HeaderText = "Дата";
            dateAndTime.MinimumWidth = 6;
            dateAndTime.Name = "dateAndTime";
            dateAndTime.ReadOnly = true;
            // 
            // name_AllProduct_TableColumn
            // 
            name_AllProduct_TableColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name_AllProduct_TableColumn.DataPropertyName = "Name";
            name_AllProduct_TableColumn.FillWeight = 60F;
            name_AllProduct_TableColumn.HeaderText = "Назва";
            name_AllProduct_TableColumn.MinimumWidth = 6;
            name_AllProduct_TableColumn.Name = "name_AllProduct_TableColumn";
            name_AllProduct_TableColumn.ReadOnly = true;
            // 
            // allProductInfo_ViewProducts_Panel
            // 
            allProductInfo_ViewProducts_Panel.AutoScroll = true;
            allProductInfo_ViewProducts_Panel.AutoScrollMinSize = new Size(0, 1200);
            allProductInfo_ViewProducts_Panel.BackColor = Color.LemonChiffon;
            allProductInfo_ViewProducts_Panel.Controls.Add(id_ViewSpecificProduct_LabelText);
            allProductInfo_ViewProducts_Panel.Controls.Add(history_ViewSpecificProduct_DataGridView);
            allProductInfo_ViewProducts_Panel.Controls.Add(time_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(time_ViewSpecificProduct_LabelText);
            allProductInfo_ViewProducts_Panel.Controls.Add(quantity_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(quantity_ViewSpecificProduct_LabelText);
            allProductInfo_ViewProducts_Panel.Controls.Add(deleteHistory_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(historyLastPage_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(historyNextPage_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(historyGetPage_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(historyThisPage_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(historyPreviousPage_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(historyFirstPage_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(history_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(delete_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(copyId_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(saveAndClose_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(close_ViewSpecificProduct_Button);
            allProductInfo_ViewProducts_Panel.Controls.Add(note_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(weight_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(length_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(width_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(height_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(note_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(weight_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(length_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(width_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(height_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(charactericstics_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(price_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(id_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(name_ViewSpecificProduct_TextBox);
            allProductInfo_ViewProducts_Panel.Controls.Add(price_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Controls.Add(name_ViewSpecificProduct_Label);
            allProductInfo_ViewProducts_Panel.Location = new Point(603, 70);
            allProductInfo_ViewProducts_Panel.Name = "allProductInfo_ViewProducts_Panel";
            allProductInfo_ViewProducts_Panel.Size = new Size(645, 507);
            allProductInfo_ViewProducts_Panel.TabIndex = 8;
            allProductInfo_ViewProducts_Panel.Visible = false;
            // 
            // id_ViewSpecificProduct_LabelText
            // 
            id_ViewSpecificProduct_LabelText.AutoSize = true;
            id_ViewSpecificProduct_LabelText.Location = new Point(318, 11);
            id_ViewSpecificProduct_LabelText.Name = "id_ViewSpecificProduct_LabelText";
            id_ViewSpecificProduct_LabelText.Size = new Size(80, 20);
            id_ViewSpecificProduct_LabelText.TabIndex = 34;
            id_ViewSpecificProduct_LabelText.Text = "Id товару: ";
            // 
            // history_ViewSpecificProduct_DataGridView
            // 
            history_ViewSpecificProduct_DataGridView.AllowUserToAddRows = false;
            history_ViewSpecificProduct_DataGridView.AllowUserToDeleteRows = false;
            history_ViewSpecificProduct_DataGridView.AllowUserToResizeColumns = false;
            history_ViewSpecificProduct_DataGridView.AllowUserToResizeRows = false;
            history_ViewSpecificProduct_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            history_ViewSpecificProduct_DataGridView.BackgroundColor = SystemColors.AppWorkspace;
            history_ViewSpecificProduct_DataGridView.ColumnHeadersHeight = 54;
            history_ViewSpecificProduct_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            history_ViewSpecificProduct_DataGridView.Columns.AddRange(new DataGridViewColumn[] { date_ViewProduct_TableColumn, Incident_ViewProduct_TableColumn });
            history_ViewSpecificProduct_DataGridView.GridColor = SystemColors.ControlText;
            history_ViewSpecificProduct_DataGridView.Location = new Point(3, 590);
            history_ViewSpecificProduct_DataGridView.MultiSelect = false;
            history_ViewSpecificProduct_DataGridView.Name = "history_ViewSpecificProduct_DataGridView";
            history_ViewSpecificProduct_DataGridView.ReadOnly = true;
            history_ViewSpecificProduct_DataGridView.RowHeadersVisible = false;
            history_ViewSpecificProduct_DataGridView.RowHeadersWidth = 54;
            history_ViewSpecificProduct_DataGridView.RowTemplate.Height = 45;
            history_ViewSpecificProduct_DataGridView.Size = new Size(518, 508);
            history_ViewSpecificProduct_DataGridView.TabIndex = 17;
            // 
            // date_ViewProduct_TableColumn
            // 
            date_ViewProduct_TableColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date_ViewProduct_TableColumn.DataPropertyName = "Date";
            date_ViewProduct_TableColumn.FillWeight = 20F;
            date_ViewProduct_TableColumn.HeaderText = "Дата події";
            date_ViewProduct_TableColumn.MinimumWidth = 6;
            date_ViewProduct_TableColumn.Name = "date_ViewProduct_TableColumn";
            date_ViewProduct_TableColumn.ReadOnly = true;
            // 
            // Incident_ViewProduct_TableColumn
            // 
            Incident_ViewProduct_TableColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Incident_ViewProduct_TableColumn.DataPropertyName = "WhatHappened";
            Incident_ViewProduct_TableColumn.FillWeight = 80F;
            Incident_ViewProduct_TableColumn.HeaderText = "Подія";
            Incident_ViewProduct_TableColumn.MinimumWidth = 6;
            Incident_ViewProduct_TableColumn.Name = "Incident_ViewProduct_TableColumn";
            Incident_ViewProduct_TableColumn.ReadOnly = true;
            // 
            // time_ViewSpecificProduct_Label
            // 
            time_ViewSpecificProduct_Label.AutoSize = true;
            time_ViewSpecificProduct_Label.Location = new Point(421, 64);
            time_ViewSpecificProduct_Label.Name = "time_ViewSpecificProduct_Label";
            time_ViewSpecificProduct_Label.Size = new Size(50, 20);
            time_ViewSpecificProduct_Label.TabIndex = 32;
            time_ViewSpecificProduct_Label.Text = "label3";
            // 
            // time_ViewSpecificProduct_LabelText
            // 
            time_ViewSpecificProduct_LabelText.AutoSize = true;
            time_ViewSpecificProduct_LabelText.Location = new Point(207, 64);
            time_ViewSpecificProduct_LabelText.Name = "time_ViewSpecificProduct_LabelText";
            time_ViewSpecificProduct_LabelText.Size = new Size(218, 20);
            time_ViewSpecificProduct_LabelText.TabIndex = 31;
            time_ViewSpecificProduct_LabelText.Text = "Час останньої зміни кількості:";
            // 
            // quantity_ViewSpecificProduct_Label
            // 
            quantity_ViewSpecificProduct_Label.AutoSize = true;
            quantity_ViewSpecificProduct_Label.Location = new Point(363, 90);
            quantity_ViewSpecificProduct_Label.Name = "quantity_ViewSpecificProduct_Label";
            quantity_ViewSpecificProduct_Label.Size = new Size(50, 20);
            quantity_ViewSpecificProduct_Label.TabIndex = 30;
            quantity_ViewSpecificProduct_Label.Text = "label2";
            // 
            // quantity_ViewSpecificProduct_LabelText
            // 
            quantity_ViewSpecificProduct_LabelText.AutoSize = true;
            quantity_ViewSpecificProduct_LabelText.Location = new Point(207, 90);
            quantity_ViewSpecificProduct_LabelText.Name = "quantity_ViewSpecificProduct_LabelText";
            quantity_ViewSpecificProduct_LabelText.Size = new Size(159, 20);
            quantity_ViewSpecificProduct_LabelText.TabIndex = 29;
            quantity_ViewSpecificProduct_LabelText.Text = "Одиниць в наявності:";
            // 
            // deleteHistory_ViewSpecificProduct_Button
            // 
            deleteHistory_ViewSpecificProduct_Button.Location = new Point(329, 555);
            deleteHistory_ViewSpecificProduct_Button.Name = "deleteHistory_ViewSpecificProduct_Button";
            deleteHistory_ViewSpecificProduct_Button.Size = new Size(192, 29);
            deleteHistory_ViewSpecificProduct_Button.TabIndex = 16;
            deleteHistory_ViewSpecificProduct_Button.Text = "Видалити історію товару";
            deleteHistory_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // historyLastPage_ViewSpecificProduct_Label
            // 
            historyLastPage_ViewSpecificProduct_Label.AutoSize = true;
            historyLastPage_ViewSpecificProduct_Label.Location = new Point(479, 1108);
            historyLastPage_ViewSpecificProduct_Label.Name = "historyLastPage_ViewSpecificProduct_Label";
            historyLastPage_ViewSpecificProduct_Label.Size = new Size(58, 20);
            historyLastPage_ViewSpecificProduct_Label.TabIndex = 27;
            historyLastPage_ViewSpecificProduct_Label.Text = "label16";
            // 
            // historyNextPage_ViewSpecificProduct_Button
            // 
            historyNextPage_ViewSpecificProduct_Button.Location = new Point(379, 1104);
            historyNextPage_ViewSpecificProduct_Button.Name = "historyNextPage_ViewSpecificProduct_Button";
            historyNextPage_ViewSpecificProduct_Button.Size = new Size(94, 29);
            historyNextPage_ViewSpecificProduct_Button.TabIndex = 20;
            historyNextPage_ViewSpecificProduct_Button.Text = "Наступна";
            historyNextPage_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // historyGetPage_ViewSpecificProduct_TextBox
            // 
            historyGetPage_ViewSpecificProduct_TextBox.Location = new Point(248, 1106);
            historyGetPage_ViewSpecificProduct_TextBox.Name = "historyGetPage_ViewSpecificProduct_TextBox";
            historyGetPage_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            historyGetPage_ViewSpecificProduct_TextBox.TabIndex = 19;
            // 
            // historyThisPage_ViewSpecificProduct_Label
            // 
            historyThisPage_ViewSpecificProduct_Label.AutoSize = true;
            historyThisPage_ViewSpecificProduct_Label.Location = new Point(280, 1136);
            historyThisPage_ViewSpecificProduct_Label.Name = "historyThisPage_ViewSpecificProduct_Label";
            historyThisPage_ViewSpecificProduct_Label.Size = new Size(58, 20);
            historyThisPage_ViewSpecificProduct_Label.TabIndex = 24;
            historyThisPage_ViewSpecificProduct_Label.Text = "label15";
            // 
            // historyPreviousPage_ViewSpecificProduct_Button
            // 
            historyPreviousPage_ViewSpecificProduct_Button.Location = new Point(137, 1106);
            historyPreviousPage_ViewSpecificProduct_Button.Name = "historyPreviousPage_ViewSpecificProduct_Button";
            historyPreviousPage_ViewSpecificProduct_Button.Size = new Size(105, 27);
            historyPreviousPage_ViewSpecificProduct_Button.TabIndex = 18;
            historyPreviousPage_ViewSpecificProduct_Button.Text = "Попередня";
            historyPreviousPage_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            // 
            // historyFirstPage_ViewSpecificProduct_Label
            // 
            historyFirstPage_ViewSpecificProduct_Label.AutoSize = true;
            historyFirstPage_ViewSpecificProduct_Label.Location = new Point(3, 1106);
            historyFirstPage_ViewSpecificProduct_Label.Name = "historyFirstPage_ViewSpecificProduct_Label";
            historyFirstPage_ViewSpecificProduct_Label.Size = new Size(135, 20);
            historyFirstPage_ViewSpecificProduct_Label.TabIndex = 22;
            historyFirstPage_ViewSpecificProduct_Label.Text = "Перша сторінка: 1";
            // 
            // history_ViewSpecificProduct_Label
            // 
            history_ViewSpecificProduct_Label.AutoSize = true;
            history_ViewSpecificProduct_Label.Location = new Point(3, 559);
            history_ViewSpecificProduct_Label.Name = "history_ViewSpecificProduct_Label";
            history_ViewSpecificProduct_Label.Size = new Size(56, 20);
            history_ViewSpecificProduct_Label.TabIndex = 21;
            history_ViewSpecificProduct_Label.Text = "Історія";
            // 
            // delete_ViewSpecificProduct_Button
            // 
            delete_ViewSpecificProduct_Button.Location = new Point(222, 496);
            delete_ViewSpecificProduct_Button.Name = "delete_ViewSpecificProduct_Button";
            delete_ViewSpecificProduct_Button.Size = new Size(213, 29);
            delete_ViewSpecificProduct_Button.TabIndex = 15;
            delete_ViewSpecificProduct_Button.Text = "Видалити";
            delete_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            delete_ViewSpecificProduct_Button.Click += delete_ViewSpecificProduct_Button_Click;
            // 
            // copyId_ViewSpecificProduct_Button
            // 
            copyId_ViewSpecificProduct_Button.Location = new Point(222, 461);
            copyId_ViewSpecificProduct_Button.Name = "copyId_ViewSpecificProduct_Button";
            copyId_ViewSpecificProduct_Button.Size = new Size(213, 29);
            copyId_ViewSpecificProduct_Button.TabIndex = 13;
            copyId_ViewSpecificProduct_Button.Text = "Скопіювати id";
            copyId_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            copyId_ViewSpecificProduct_Button.Click += copyId_ViewSpecificProduct_Button_Click;
            // 
            // saveAndClose_ViewSpecificProduct_Button
            // 
            saveAndClose_ViewSpecificProduct_Button.Location = new Point(3, 496);
            saveAndClose_ViewSpecificProduct_Button.Name = "saveAndClose_ViewSpecificProduct_Button";
            saveAndClose_ViewSpecificProduct_Button.Size = new Size(213, 29);
            saveAndClose_ViewSpecificProduct_Button.TabIndex = 14;
            saveAndClose_ViewSpecificProduct_Button.Text = "Зберегти та закрити";
            saveAndClose_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            saveAndClose_ViewSpecificProduct_Button.Click += saveAndClose_ViewSpecificProduct_Button_Click;
            // 
            // close_ViewSpecificProduct_Button
            // 
            close_ViewSpecificProduct_Button.Location = new Point(3, 461);
            close_ViewSpecificProduct_Button.Name = "close_ViewSpecificProduct_Button";
            close_ViewSpecificProduct_Button.Size = new Size(213, 29);
            close_ViewSpecificProduct_Button.TabIndex = 12;
            close_ViewSpecificProduct_Button.Text = "Закрити";
            close_ViewSpecificProduct_Button.UseVisualStyleBackColor = true;
            close_ViewSpecificProduct_Button.Click += close_ViewSpecificProduct_Button_Click;
            // 
            // note_ViewSpecificProduct_TextBox
            // 
            note_ViewSpecificProduct_TextBox.Location = new Point(3, 213);
            note_ViewSpecificProduct_TextBox.Multiline = true;
            note_ViewSpecificProduct_TextBox.Name = "note_ViewSpecificProduct_TextBox";
            note_ViewSpecificProduct_TextBox.Size = new Size(518, 239);
            note_ViewSpecificProduct_TextBox.TabIndex = 12;
            // 
            // weight_ViewSpecificProduct_TextBox
            // 
            weight_ViewSpecificProduct_TextBox.Location = new Point(396, 160);
            weight_ViewSpecificProduct_TextBox.Name = "weight_ViewSpecificProduct_TextBox";
            weight_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            weight_ViewSpecificProduct_TextBox.TabIndex = 11;
            // 
            // length_ViewSpecificProduct_TextBox
            // 
            length_ViewSpecificProduct_TextBox.Location = new Point(265, 160);
            length_ViewSpecificProduct_TextBox.Name = "length_ViewSpecificProduct_TextBox";
            length_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            length_ViewSpecificProduct_TextBox.TabIndex = 10;
            // 
            // width_ViewSpecificProduct_TextBox
            // 
            width_ViewSpecificProduct_TextBox.Location = new Point(134, 160);
            width_ViewSpecificProduct_TextBox.Name = "width_ViewSpecificProduct_TextBox";
            width_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            width_ViewSpecificProduct_TextBox.TabIndex = 9;
            // 
            // height_ViewSpecificProduct_TextBox
            // 
            height_ViewSpecificProduct_TextBox.Location = new Point(3, 160);
            height_ViewSpecificProduct_TextBox.Name = "height_ViewSpecificProduct_TextBox";
            height_ViewSpecificProduct_TextBox.Size = new Size(125, 27);
            height_ViewSpecificProduct_TextBox.TabIndex = 8;
            // 
            // note_ViewSpecificProduct_Label
            // 
            note_ViewSpecificProduct_Label.AutoSize = true;
            note_ViewSpecificProduct_Label.Location = new Point(3, 190);
            note_ViewSpecificProduct_Label.Name = "note_ViewSpecificProduct_Label";
            note_ViewSpecificProduct_Label.Size = new Size(74, 20);
            note_ViewSpecificProduct_Label.TabIndex = 10;
            note_ViewSpecificProduct_Label.Text = "Примітка";
            // 
            // weight_ViewSpecificProduct_Label
            // 
            weight_ViewSpecificProduct_Label.AutoSize = true;
            weight_ViewSpecificProduct_Label.Location = new Point(396, 137);
            weight_ViewSpecificProduct_Label.Name = "weight_ViewSpecificProduct_Label";
            weight_ViewSpecificProduct_Label.Size = new Size(40, 20);
            weight_ViewSpecificProduct_Label.TabIndex = 9;
            weight_ViewSpecificProduct_Label.Text = "Вага";
            // 
            // length_ViewSpecificProduct_Label
            // 
            length_ViewSpecificProduct_Label.AutoSize = true;
            length_ViewSpecificProduct_Label.Location = new Point(265, 137);
            length_ViewSpecificProduct_Label.Name = "length_ViewSpecificProduct_Label";
            length_ViewSpecificProduct_Label.Size = new Size(73, 20);
            length_ViewSpecificProduct_Label.TabIndex = 8;
            length_ViewSpecificProduct_Label.Text = "Довжина";
            // 
            // width_ViewSpecificProduct_Label
            // 
            width_ViewSpecificProduct_Label.AutoSize = true;
            width_ViewSpecificProduct_Label.Location = new Point(134, 137);
            width_ViewSpecificProduct_Label.Name = "width_ViewSpecificProduct_Label";
            width_ViewSpecificProduct_Label.Size = new Size(67, 20);
            width_ViewSpecificProduct_Label.TabIndex = 7;
            width_ViewSpecificProduct_Label.Text = "Ширина";
            // 
            // height_ViewSpecificProduct_Label
            // 
            height_ViewSpecificProduct_Label.AutoSize = true;
            height_ViewSpecificProduct_Label.Location = new Point(3, 137);
            height_ViewSpecificProduct_Label.Name = "height_ViewSpecificProduct_Label";
            height_ViewSpecificProduct_Label.Size = new Size(57, 20);
            height_ViewSpecificProduct_Label.TabIndex = 6;
            height_ViewSpecificProduct_Label.Text = "Висота";
            // 
            // charactericstics_ViewSpecificProduct_Label
            // 
            charactericstics_ViewSpecificProduct_Label.AutoSize = true;
            charactericstics_ViewSpecificProduct_Label.Location = new Point(3, 117);
            charactericstics_ViewSpecificProduct_Label.Name = "charactericstics_ViewSpecificProduct_Label";
            charactericstics_ViewSpecificProduct_Label.Size = new Size(120, 20);
            charactericstics_ViewSpecificProduct_Label.TabIndex = 5;
            charactericstics_ViewSpecificProduct_Label.Text = "Характеристики";
            // 
            // price_ViewSpecificProduct_TextBox
            // 
            price_ViewSpecificProduct_TextBox.Location = new Point(3, 87);
            price_ViewSpecificProduct_TextBox.Name = "price_ViewSpecificProduct_TextBox";
            price_ViewSpecificProduct_TextBox.Size = new Size(198, 27);
            price_ViewSpecificProduct_TextBox.TabIndex = 7;
            // 
            // id_ViewSpecificProduct_Label
            // 
            id_ViewSpecificProduct_Label.AutoSize = true;
            id_ViewSpecificProduct_Label.Location = new Point(396, 11);
            id_ViewSpecificProduct_Label.Name = "id_ViewSpecificProduct_Label";
            id_ViewSpecificProduct_Label.Size = new Size(50, 20);
            id_ViewSpecificProduct_Label.TabIndex = 3;
            id_ViewSpecificProduct_Label.Text = "label6";
            // 
            // name_ViewSpecificProduct_TextBox
            // 
            name_ViewSpecificProduct_TextBox.Location = new Point(3, 34);
            name_ViewSpecificProduct_TextBox.Name = "name_ViewSpecificProduct_TextBox";
            name_ViewSpecificProduct_TextBox.Size = new Size(518, 27);
            name_ViewSpecificProduct_TextBox.TabIndex = 6;
            // 
            // price_ViewSpecificProduct_Label
            // 
            price_ViewSpecificProduct_Label.AutoSize = true;
            price_ViewSpecificProduct_Label.Location = new Point(3, 64);
            price_ViewSpecificProduct_Label.Name = "price_ViewSpecificProduct_Label";
            price_ViewSpecificProduct_Label.Size = new Size(66, 20);
            price_ViewSpecificProduct_Label.TabIndex = 1;
            price_ViewSpecificProduct_Label.Text = "Вартість";
            // 
            // name_ViewSpecificProduct_Label
            // 
            name_ViewSpecificProduct_Label.AutoSize = true;
            name_ViewSpecificProduct_Label.Location = new Point(3, 11);
            name_ViewSpecificProduct_Label.Name = "name_ViewSpecificProduct_Label";
            name_ViewSpecificProduct_Label.Size = new Size(51, 20);
            name_ViewSpecificProduct_Label.TabIndex = 0;
            name_ViewSpecificProduct_Label.Text = "Назва";
            // 
            // allProductsThisPage_ViewProducts_Label
            // 
            allProductsThisPage_ViewProducts_Label.AutoSize = true;
            allProductsThisPage_ViewProducts_Label.Location = new Point(6, 580);
            allProductsThisPage_ViewProducts_Label.Name = "allProductsThisPage_ViewProducts_Label";
            allProductsThisPage_ViewProducts_Label.Size = new Size(50, 20);
            allProductsThisPage_ViewProducts_Label.TabIndex = 7;
            allProductsThisPage_ViewProducts_Label.Text = "label3";
            // 
            // allProductsLastPage_ViewProducts_Label
            // 
            allProductsLastPage_ViewProducts_Label.AutoSize = true;
            allProductsLastPage_ViewProducts_Label.Location = new Point(508, 38);
            allProductsLastPage_ViewProducts_Label.Name = "allProductsLastPage_ViewProducts_Label";
            allProductsLastPage_ViewProducts_Label.Size = new Size(50, 20);
            allProductsLastPage_ViewProducts_Label.TabIndex = 6;
            allProductsLastPage_ViewProducts_Label.Text = "label2";
            // 
            // allProductsFirstPage_ViewProducts_Label
            // 
            allProductsFirstPage_ViewProducts_Label.AutoSize = true;
            allProductsFirstPage_ViewProducts_Label.Location = new Point(8, 38);
            allProductsFirstPage_ViewProducts_Label.Name = "allProductsFirstPage_ViewProducts_Label";
            allProductsFirstPage_ViewProducts_Label.Size = new Size(133, 20);
            allProductsFirstPage_ViewProducts_Label.TabIndex = 5;
            allProductsFirstPage_ViewProducts_Label.Text = "перша сторінка: 1";
            // 
            // allProductsGetPage_ViewProducts_TextBox
            // 
            allProductsGetPage_ViewProducts_TextBox.Location = new Point(263, 35);
            allProductsGetPage_ViewProducts_TextBox.Name = "allProductsGetPage_ViewProducts_TextBox";
            allProductsGetPage_ViewProducts_TextBox.Size = new Size(125, 27);
            allProductsGetPage_ViewProducts_TextBox.TabIndex = 3;
            allProductsGetPage_ViewProducts_TextBox.KeyDown += allProductsGetPage_ViewProducts_TextBox_KeyDown;
            // 
            // allProductsNextPage_ViewProducts_Button
            // 
            allProductsNextPage_ViewProducts_Button.Location = new Point(394, 33);
            allProductsNextPage_ViewProducts_Button.Name = "allProductsNextPage_ViewProducts_Button";
            allProductsNextPage_ViewProducts_Button.Size = new Size(108, 29);
            allProductsNextPage_ViewProducts_Button.TabIndex = 4;
            allProductsNextPage_ViewProducts_Button.Text = "Наступна";
            allProductsNextPage_ViewProducts_Button.UseVisualStyleBackColor = true;
            allProductsNextPage_ViewProducts_Button.Click += allProductsNextPage_ViewProducts_Button_Click;
            // 
            // allProductsPreviousPage_ViewProducts_Button
            // 
            allProductsPreviousPage_ViewProducts_Button.Location = new Point(147, 34);
            allProductsPreviousPage_ViewProducts_Button.Name = "allProductsPreviousPage_ViewProducts_Button";
            allProductsPreviousPage_ViewProducts_Button.Size = new Size(113, 29);
            allProductsPreviousPage_ViewProducts_Button.TabIndex = 2;
            allProductsPreviousPage_ViewProducts_Button.Text = "Попередня";
            allProductsPreviousPage_ViewProducts_Button.UseVisualStyleBackColor = true;
            allProductsPreviousPage_ViewProducts_Button.Click += allProductsPreviousPage_ViewProducts_Button_Click;
            // 
            // pageName_ViewProducts_Label
            // 
            pageName_ViewProducts_Label.AutoSize = true;
            pageName_ViewProducts_Label.Location = new Point(3, 3);
            pageName_ViewProducts_Label.Name = "pageName_ViewProducts_Label";
            pageName_ViewProducts_Label.Size = new Size(238, 20);
            pageName_ViewProducts_Label.TabIndex = 0;
            pageName_ViewProducts_Label.Text = "Усі товари що присутні на складі";
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
            // addProduct_TabPage
            // 
            addProduct_TabPage.Controls.Add(notification_AddProduct_Label);
            addProduct_TabPage.Controls.Add(addProduct_Addproduct_Button);
            addProduct_TabPage.Controls.Add(note_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(note_AddProduct_Label);
            addProduct_TabPage.Controls.Add(weight_AddProduct_Label);
            addProduct_TabPage.Controls.Add(weight_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(length_AddProduct_Label);
            addProduct_TabPage.Controls.Add(width_AddProduct_Label);
            addProduct_TabPage.Controls.Add(height_AddProduct_Label);
            addProduct_TabPage.Controls.Add(characcteristics_AddProduct_Label);
            addProduct_TabPage.Controls.Add(length_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(width_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(height_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(price_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(price_AddProduct_lable);
            addProduct_TabPage.Controls.Add(name_AddProduct_TextBox);
            addProduct_TabPage.Controls.Add(name_AddProduct_Label);
            addProduct_TabPage.Controls.Add(addProduct_AddProduct_Label);
            addProduct_TabPage.Location = new Point(4, 53);
            addProduct_TabPage.Name = "addProduct_TabPage";
            addProduct_TabPage.Padding = new Padding(3);
            addProduct_TabPage.Size = new Size(1254, 616);
            addProduct_TabPage.TabIndex = 4;
            addProduct_TabPage.Text = "Додати товар";
            addProduct_TabPage.UseVisualStyleBackColor = true;
            // 
            // notification_AddProduct_Label
            // 
            notification_AddProduct_Label.AutoSize = true;
            notification_AddProduct_Label.Location = new Point(270, 572);
            notification_AddProduct_Label.Name = "notification_AddProduct_Label";
            notification_AddProduct_Label.Size = new Size(0, 20);
            notification_AddProduct_Label.TabIndex = 17;
            // 
            // addProduct_Addproduct_Button
            // 
            addProduct_Addproduct_Button.Location = new Point(8, 557);
            addProduct_Addproduct_Button.Name = "addProduct_Addproduct_Button";
            addProduct_Addproduct_Button.Size = new Size(256, 51);
            addProduct_Addproduct_Button.TabIndex = 16;
            addProduct_Addproduct_Button.Text = "Додати товар";
            addProduct_Addproduct_Button.UseVisualStyleBackColor = true;
            addProduct_Addproduct_Button.Click += addProduct_Addproduct_Button_Click;
            // 
            // note_AddProduct_TextBox
            // 
            note_AddProduct_TextBox.Location = new Point(8, 323);
            note_AddProduct_TextBox.Multiline = true;
            note_AddProduct_TextBox.Name = "note_AddProduct_TextBox";
            note_AddProduct_TextBox.Size = new Size(712, 228);
            note_AddProduct_TextBox.TabIndex = 15;
            // 
            // note_AddProduct_Label
            // 
            note_AddProduct_Label.AutoSize = true;
            note_AddProduct_Label.Location = new Point(6, 300);
            note_AddProduct_Label.Name = "note_AddProduct_Label";
            note_AddProduct_Label.Size = new Size(74, 20);
            note_AddProduct_Label.TabIndex = 14;
            note_AddProduct_Label.Text = "Примітка";
            // 
            // weight_AddProduct_Label
            // 
            weight_AddProduct_Label.AutoSize = true;
            weight_AddProduct_Label.Location = new Point(134, 273);
            weight_AddProduct_Label.Name = "weight_AddProduct_Label";
            weight_AddProduct_Label.Size = new Size(125, 20);
            weight_AddProduct_Label.TabIndex = 13;
            weight_AddProduct_Label.Text = "Вага (кілограми)";
            // 
            // weight_AddProduct_TextBox
            // 
            weight_AddProduct_TextBox.Location = new Point(8, 270);
            weight_AddProduct_TextBox.Name = "weight_AddProduct_TextBox";
            weight_AddProduct_TextBox.Size = new Size(120, 27);
            weight_AddProduct_TextBox.TabIndex = 12;
            // 
            // length_AddProduct_Label
            // 
            length_AddProduct_Label.AutoSize = true;
            length_AddProduct_Label.Location = new Point(134, 240);
            length_AddProduct_Label.Name = "length_AddProduct_Label";
            length_AddProduct_Label.Size = new Size(130, 20);
            length_AddProduct_Label.TabIndex = 11;
            length_AddProduct_Label.Text = "Довжина (метри)";
            // 
            // width_AddProduct_Label
            // 
            width_AddProduct_Label.AutoSize = true;
            width_AddProduct_Label.Location = new Point(134, 207);
            width_AddProduct_Label.Name = "width_AddProduct_Label";
            width_AddProduct_Label.Size = new Size(124, 20);
            width_AddProduct_Label.TabIndex = 10;
            width_AddProduct_Label.Text = "Ширина (метри)";
            // 
            // height_AddProduct_Label
            // 
            height_AddProduct_Label.AutoSize = true;
            height_AddProduct_Label.Location = new Point(134, 174);
            height_AddProduct_Label.Name = "height_AddProduct_Label";
            height_AddProduct_Label.Size = new Size(114, 20);
            height_AddProduct_Label.TabIndex = 9;
            height_AddProduct_Label.Text = "Висота (метри)";
            // 
            // characcteristics_AddProduct_Label
            // 
            characcteristics_AddProduct_Label.AutoSize = true;
            characcteristics_AddProduct_Label.Location = new Point(8, 148);
            characcteristics_AddProduct_Label.Name = "characcteristics_AddProduct_Label";
            characcteristics_AddProduct_Label.Size = new Size(120, 20);
            characcteristics_AddProduct_Label.TabIndex = 8;
            characcteristics_AddProduct_Label.Text = "Характеристики";
            // 
            // length_AddProduct_TextBox
            // 
            length_AddProduct_TextBox.Location = new Point(8, 237);
            length_AddProduct_TextBox.Name = "length_AddProduct_TextBox";
            length_AddProduct_TextBox.Size = new Size(120, 27);
            length_AddProduct_TextBox.TabIndex = 7;
            // 
            // width_AddProduct_TextBox
            // 
            width_AddProduct_TextBox.Location = new Point(8, 204);
            width_AddProduct_TextBox.Name = "width_AddProduct_TextBox";
            width_AddProduct_TextBox.Size = new Size(120, 27);
            width_AddProduct_TextBox.TabIndex = 6;
            // 
            // height_AddProduct_TextBox
            // 
            height_AddProduct_TextBox.Location = new Point(8, 171);
            height_AddProduct_TextBox.Name = "height_AddProduct_TextBox";
            height_AddProduct_TextBox.Size = new Size(120, 27);
            height_AddProduct_TextBox.TabIndex = 5;
            // 
            // price_AddProduct_TextBox
            // 
            price_AddProduct_TextBox.Location = new Point(8, 118);
            price_AddProduct_TextBox.Name = "price_AddProduct_TextBox";
            price_AddProduct_TextBox.Size = new Size(120, 27);
            price_AddProduct_TextBox.TabIndex = 4;
            // 
            // price_AddProduct_lable
            // 
            price_AddProduct_lable.AutoSize = true;
            price_AddProduct_lable.Location = new Point(8, 95);
            price_AddProduct_lable.Name = "price_AddProduct_lable";
            price_AddProduct_lable.Size = new Size(114, 20);
            price_AddProduct_lable.TabIndex = 3;
            price_AddProduct_lable.Text = "Вартість (грн) *";
            // 
            // name_AddProduct_TextBox
            // 
            name_AddProduct_TextBox.Location = new Point(8, 65);
            name_AddProduct_TextBox.Name = "name_AddProduct_TextBox";
            name_AddProduct_TextBox.Size = new Size(456, 27);
            name_AddProduct_TextBox.TabIndex = 2;
            // 
            // name_AddProduct_Label
            // 
            name_AddProduct_Label.AutoSize = true;
            name_AddProduct_Label.Location = new Point(8, 42);
            name_AddProduct_Label.Name = "name_AddProduct_Label";
            name_AddProduct_Label.Size = new Size(61, 20);
            name_AddProduct_Label.TabIndex = 1;
            name_AddProduct_Label.Text = "Назва *";
            // 
            // addProduct_AddProduct_Label
            // 
            addProduct_AddProduct_Label.AutoSize = true;
            addProduct_AddProduct_Label.Location = new Point(8, 3);
            addProduct_AddProduct_Label.Name = "addProduct_AddProduct_Label";
            addProduct_AddProduct_Label.Size = new Size(236, 20);
            addProduct_AddProduct_Label.TabIndex = 0;
            addProduct_AddProduct_Label.Text = "Дадавання нового товару у базу";
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
            // Warehouse_Window_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(program_TabControl);
            ForeColor = SystemColors.ControlText;
            Text = "Склад";
            program_TabControl.ResumeLayout(false);
            allProduct_TabPage.ResumeLayout(false);
            allProduct_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allProductTable_ViewProducts_DataGridView).EndInit();
            allProductInfo_ViewProducts_Panel.ResumeLayout(false);
            allProductInfo_ViewProducts_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)history_ViewSpecificProduct_DataGridView).EndInit();
            addProduct_TabPage.ResumeLayout(false);
            addProduct_TabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl program_TabControl;
        private TabPage allProduct_TabPage;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private TabPage addProduct_TabPage;
        private Label name_AddProduct_Label;
        private Label addProduct_AddProduct_Label;
        private TextBox name_AddProduct_TextBox;
        private Label price_AddProduct_lable;
        private Label characcteristics_AddProduct_Label;
        private TextBox length_AddProduct_TextBox;
        private TextBox width_AddProduct_TextBox;
        private TextBox height_AddProduct_TextBox;
        private TextBox price_AddProduct_TextBox;
        private Label length_AddProduct_Label;
        private Label width_AddProduct_Label;
        private Label height_AddProduct_Label;
        private Label weight_AddProduct_Label;
        private TextBox weight_AddProduct_TextBox;
        private Label note_AddProduct_Label;
        private TextBox note_AddProduct_TextBox;
        private Button addProduct_Addproduct_Button;
        private TabPage tabPage4;
        private TabPage tabPage6;
        private Label notification_AddProduct_Label;
        private Label pageName_ViewProducts_Label;
        private Button allProductsPreviousPage_ViewProducts_Button;
        private Label allProductsThisPage_ViewProducts_Label;
        private Label allProductsLastPage_ViewProducts_Label;
        private Label allProductsFirstPage_ViewProducts_Label;
        private TextBox allProductsGetPage_ViewProducts_TextBox;
        private Button allProductsNextPage_ViewProducts_Button;
        private Panel allProductInfo_ViewProducts_Panel;
        private TextBox name_ViewSpecificProduct_TextBox;
        private Label price_ViewSpecificProduct_Label;
        private Label name_ViewSpecificProduct_Label;
        private TextBox note_ViewSpecificProduct_TextBox;
        private TextBox weight_ViewSpecificProduct_TextBox;
        private TextBox length_ViewSpecificProduct_TextBox;
        private TextBox width_ViewSpecificProduct_TextBox;
        private TextBox height_ViewSpecificProduct_TextBox;
        private Label note_ViewSpecificProduct_Label;
        private Label weight_ViewSpecificProduct_Label;
        private Label length_ViewSpecificProduct_Label;
        private Label width_ViewSpecificProduct_Label;
        private Label height_ViewSpecificProduct_Label;
        private Label charactericstics_ViewSpecificProduct_Label;
        private TextBox price_ViewSpecificProduct_TextBox;
        private Label id_ViewSpecificProduct_Label;
        private Label history_ViewSpecificProduct_Label;
        private Button delete_ViewSpecificProduct_Button;
        private Button copyId_ViewSpecificProduct_Button;
        private Button saveAndClose_ViewSpecificProduct_Button;
        private Button close_ViewSpecificProduct_Button;
        private Button deleteHistory_ViewSpecificProduct_Button;
        private Label historyLastPage_ViewSpecificProduct_Label;
        private Button historyNextPage_ViewSpecificProduct_Button;
        private TextBox historyGetPage_ViewSpecificProduct_TextBox;
        private Label historyThisPage_ViewSpecificProduct_Label;
        private Button historyPreviousPage_ViewSpecificProduct_Button;
        private Label historyFirstPage_ViewSpecificProduct_Label;
        private Label quantity_ViewSpecificProduct_Label;
        private Label quantity_ViewSpecificProduct_LabelText;
        private Label time_ViewSpecificProduct_Label;
        private Label time_ViewSpecificProduct_LabelText;
        private DataGridView allProductTable_ViewProducts_DataGridView;
        private DataGridViewTextBoxColumn id_AllProduct_TableColumn;
        private DataGridViewTextBoxColumn dateAndTime;
        private DataGridViewTextBoxColumn name_AllProduct_TableColumn;
        private DataGridView history_ViewSpecificProduct_DataGridView;
        private Label id_ViewSpecificProduct_LabelText;
        private DataGridViewTextBoxColumn date_ViewProduct_TableColumn;
        private DataGridViewTextBoxColumn Incident_ViewProduct_TableColumn;
    }
}
