namespace ConnectDatabse
{
    partial class DatabaseForm
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
            this.datagrid_main = new System.Windows.Forms.DataGridView();
            this.groupbox_insert = new System.Windows.Forms.GroupBox();
            this.groupbox_purge = new System.Windows.Forms.GroupBox();
            this.groupbox_control = new System.Windows.Forms.GroupBox();
            this.button_refreshget = new System.Windows.Forms.Button();
            this.button_deleteselected = new System.Windows.Forms.Button();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.textbox_age = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_main)).BeginInit();
            this.groupbox_insert.SuspendLayout();
            this.groupbox_purge.SuspendLayout();
            this.groupbox_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_main
            // 
            this.datagrid_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_column,
            this.age_column});
            this.datagrid_main.Location = new System.Drawing.Point(210, 12);
            this.datagrid_main.Name = "datagrid_main";
            this.datagrid_main.Size = new System.Drawing.Size(578, 309);
            this.datagrid_main.TabIndex = 6;
            this.datagrid_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_main_CellClick);
            // 
            // groupbox_insert
            // 
            this.groupbox_insert.Controls.Add(this.button_add);
            this.groupbox_insert.Controls.Add(this.label_age);
            this.groupbox_insert.Controls.Add(this.textbox_age);
            this.groupbox_insert.Controls.Add(this.label_name);
            this.groupbox_insert.Controls.Add(this.textbox_name);
            this.groupbox_insert.Location = new System.Drawing.Point(12, 94);
            this.groupbox_insert.Name = "groupbox_insert";
            this.groupbox_insert.Size = new System.Drawing.Size(192, 160);
            this.groupbox_insert.TabIndex = 1;
            this.groupbox_insert.TabStop = false;
            this.groupbox_insert.Text = "Insert";
            // 
            // groupbox_purge
            // 
            this.groupbox_purge.Controls.Add(this.button_deleteselected);
            this.groupbox_purge.Location = new System.Drawing.Point(12, 260);
            this.groupbox_purge.Name = "groupbox_purge";
            this.groupbox_purge.Size = new System.Drawing.Size(192, 61);
            this.groupbox_purge.TabIndex = 2;
            this.groupbox_purge.TabStop = false;
            this.groupbox_purge.Text = "Purge";
            // 
            // groupbox_control
            // 
            this.groupbox_control.Controls.Add(this.button_refreshget);
            this.groupbox_control.Location = new System.Drawing.Point(12, 12);
            this.groupbox_control.Name = "groupbox_control";
            this.groupbox_control.Size = new System.Drawing.Size(192, 76);
            this.groupbox_control.TabIndex = 3;
            this.groupbox_control.TabStop = false;
            this.groupbox_control.Text = "Control";
            this.groupbox_control.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button_refreshget
            // 
            this.button_refreshget.Location = new System.Drawing.Point(6, 19);
            this.button_refreshget.Name = "button_refreshget";
            this.button_refreshget.Size = new System.Drawing.Size(180, 51);
            this.button_refreshget.TabIndex = 1;
            this.button_refreshget.Text = "Refresh/Get";
            this.button_refreshget.UseVisualStyleBackColor = true;
            this.button_refreshget.Click += new System.EventHandler(this.button_refreshget_Click);
            // 
            // button_deleteselected
            // 
            this.button_deleteselected.Location = new System.Drawing.Point(6, 19);
            this.button_deleteselected.Name = "button_deleteselected";
            this.button_deleteselected.Size = new System.Drawing.Size(180, 36);
            this.button_deleteselected.TabIndex = 5;
            this.button_deleteselected.Text = "Delete Selected";
            this.button_deleteselected.UseVisualStyleBackColor = true;
            this.button_deleteselected.Click += new System.EventHandler(this.button_deleteselected_Click);
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(6, 40);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(180, 20);
            this.textbox_name.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 24);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(6, 70);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(26, 13);
            this.label_age.TabIndex = 3;
            this.label_age.Text = "Age";
            // 
            // textbox_age
            // 
            this.textbox_age.Location = new System.Drawing.Point(6, 86);
            this.textbox_age.Name = "textbox_age";
            this.textbox_age.Size = new System.Drawing.Size(180, 20);
            this.textbox_age.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(6, 112);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(180, 42);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // name_column
            // 
            this.name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_column.HeaderText = "Name";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            this.name_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // age_column
            // 
            this.age_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.age_column.HeaderText = "Age";
            this.age_column.Name = "age_column";
            this.age_column.ReadOnly = true;
            this.age_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.groupbox_control);
            this.Controls.Add(this.groupbox_purge);
            this.Controls.Add(this.groupbox_insert);
            this.Controls.Add(this.datagrid_main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Database Demo by Timothy Merfry Tiwow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_main)).EndInit();
            this.groupbox_insert.ResumeLayout(false);
            this.groupbox_insert.PerformLayout();
            this.groupbox_purge.ResumeLayout(false);
            this.groupbox_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_main;
        private System.Windows.Forms.GroupBox groupbox_insert;
        private System.Windows.Forms.GroupBox groupbox_purge;
        private System.Windows.Forms.GroupBox groupbox_control;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox textbox_age;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Button button_deleteselected;
        private System.Windows.Forms.Button button_refreshget;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn age_column;
    }
}

