namespace StudentInfo.View
{
    partial class Form1
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
            this.GCStudent = new DevExpress.XtraGrid.GridControl();
            this.GVStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEFirstName = new DevExpress.XtraEditors.TextEdit();
            this.TEAge = new DevExpress.XtraEditors.TextEdit();
            this.TEMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.TELastName = new DevExpress.XtraEditors.TextEdit();
            this.btnADD = new DevExpress.XtraEditors.SimpleButton();
            this.btnUPDATE = new DevExpress.XtraEditors.SimpleButton();
            this.btnDELETE = new DevExpress.XtraEditors.SimpleButton();
            this.LBFirstName = new DevExpress.XtraEditors.LabelControl();
            this.LBLastName = new DevExpress.XtraEditors.LabelControl();
            this.LBMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.LBGender = new DevExpress.XtraEditors.LabelControl();
            this.LBAge = new DevExpress.XtraEditors.LabelControl();
            this.TEGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TELastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GCStudent
            // 
            this.GCStudent.Location = new System.Drawing.Point(322, 12);
            this.GCStudent.MainView = this.GVStudent;
            this.GCStudent.Name = "GCStudent";
            this.GCStudent.Size = new System.Drawing.Size(522, 293);
            this.GCStudent.TabIndex = 0;
            this.GCStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVStudent});
            // 
            // GVStudent
            // 
            this.GVStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Gender,
            this.Age});
            this.GVStudent.GridControl = this.GCStudent;
            this.GVStudent.Name = "GVStudent";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "FirstName";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "MiddleName";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Caption = "LastName";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 3;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 4;
            // 
            // TEFirstName
            // 
            this.TEFirstName.Location = new System.Drawing.Point(43, 100);
            this.TEFirstName.Name = "TEFirstName";
            this.TEFirstName.Properties.AutoHeight = false;
            this.TEFirstName.Size = new System.Drawing.Size(272, 29);
            this.TEFirstName.TabIndex = 1;
            // 
            // TEAge
            // 
            this.TEAge.Location = new System.Drawing.Point(44, 272);
            this.TEAge.Name = "TEAge";
            this.TEAge.Properties.AutoHeight = false;
            this.TEAge.Size = new System.Drawing.Size(133, 33);
            this.TEAge.TabIndex = 2;
            // 
            // TEMiddleName
            // 
            this.TEMiddleName.Location = new System.Drawing.Point(43, 155);
            this.TEMiddleName.Name = "TEMiddleName";
            this.TEMiddleName.Properties.AutoHeight = false;
            this.TEMiddleName.Size = new System.Drawing.Size(272, 29);
            this.TEMiddleName.TabIndex = 3;
            // 
            // TELastName
            // 
            this.TELastName.Location = new System.Drawing.Point(43, 210);
            this.TELastName.Name = "TELastName";
            this.TELastName.Properties.AutoHeight = false;
            this.TELastName.Size = new System.Drawing.Size(272, 29);
            this.TELastName.TabIndex = 5;
            // 
            // btnADD
            // 
            this.btnADD.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.btnADD.Appearance.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Appearance.Options.UseBackColor = true;
            this.btnADD.Appearance.Options.UseFont = true;
            this.btnADD.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.btnADD.AppearanceDisabled.Options.UseBackColor = true;
            this.btnADD.Location = new System.Drawing.Point(44, 311);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(272, 37);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "ADD";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnUPDATE.Appearance.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Appearance.Options.UseBackColor = true;
            this.btnUPDATE.Appearance.Options.UseFont = true;
            this.btnUPDATE.Location = new System.Drawing.Point(322, 311);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(269, 37);
            this.btnUPDATE.TabIndex = 7;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.btnDELETE.Appearance.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Appearance.Options.UseBackColor = true;
            this.btnDELETE.Appearance.Options.UseFont = true;
            this.btnDELETE.Location = new System.Drawing.Point(597, 311);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(247, 37);
            this.btnDELETE.TabIndex = 8;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // LBFirstName
            // 
            this.LBFirstName.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFirstName.Appearance.Options.UseFont = true;
            this.LBFirstName.Location = new System.Drawing.Point(43, 80);
            this.LBFirstName.Name = "LBFirstName";
            this.LBFirstName.Size = new System.Drawing.Size(72, 14);
            this.LBFirstName.TabIndex = 9;
            this.LBFirstName.Text = "First Name";
            // 
            // LBLastName
            // 
            this.LBLastName.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLastName.Appearance.Options.UseFont = true;
            this.LBLastName.Location = new System.Drawing.Point(44, 190);
            this.LBLastName.Name = "LBLastName";
            this.LBLastName.Size = new System.Drawing.Size(66, 14);
            this.LBLastName.TabIndex = 10;
            this.LBLastName.Text = "Last Name";
            // 
            // LBMiddleName
            // 
            this.LBMiddleName.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMiddleName.Appearance.Options.UseFont = true;
            this.LBMiddleName.Location = new System.Drawing.Point(44, 135);
            this.LBMiddleName.Name = "LBMiddleName";
            this.LBMiddleName.Size = new System.Drawing.Size(78, 14);
            this.LBMiddleName.TabIndex = 11;
            this.LBMiddleName.Text = "MiddleName";
            // 
            // LBGender
            // 
            this.LBGender.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBGender.Appearance.Options.UseFont = true;
            this.LBGender.Location = new System.Drawing.Point(181, 252);
            this.LBGender.Name = "LBGender";
            this.LBGender.Size = new System.Drawing.Size(47, 14);
            this.LBGender.TabIndex = 12;
            this.LBGender.Text = "Gender";
            // 
            // LBAge
            // 
            this.LBAge.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAge.Appearance.Options.UseFont = true;
            this.LBAge.Location = new System.Drawing.Point(44, 252);
            this.LBAge.Name = "LBAge";
            this.LBAge.Size = new System.Drawing.Size(23, 14);
            this.LBAge.TabIndex = 13;
            this.LBAge.Text = "Age";
            // 
            // TEGender
            // 
            this.TEGender.Location = new System.Drawing.Point(181, 272);
            this.TEGender.Name = "TEGender";
            this.TEGender.Properties.AutoHeight = false;
            this.TEGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TEGender.Properties.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.TEGender.Size = new System.Drawing.Size(134, 33);
            this.TEGender.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(281, 44);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Student Form";
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 360);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TEGender);
            this.Controls.Add(this.LBAge);
            this.Controls.Add(this.LBGender);
            this.Controls.Add(this.LBMiddleName);
            this.Controls.Add(this.LBLastName);
            this.Controls.Add(this.LBFirstName);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.TELastName);
            this.Controls.Add(this.TEMiddleName);
            this.Controls.Add(this.TEAge);
            this.Controls.Add(this.TEFirstName);
            this.Controls.Add(this.GCStudent);
            this.Name = "Form1";
            this.Text = "StudentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.GCStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TELastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGender.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView GVStudent;
        private DevExpress.XtraEditors.TextEdit TEFirstName;
        private DevExpress.XtraEditors.TextEdit TEAge;
        private DevExpress.XtraEditors.TextEdit TEMiddleName;
        private DevExpress.XtraEditors.TextEdit TELastName;
        private DevExpress.XtraEditors.SimpleButton btnADD;
        private DevExpress.XtraEditors.SimpleButton btnUPDATE;
        private DevExpress.XtraEditors.SimpleButton btnDELETE;
        private DevExpress.XtraEditors.LabelControl LBFirstName;
        private DevExpress.XtraEditors.LabelControl LBLastName;
        private DevExpress.XtraEditors.LabelControl LBMiddleName;
        private DevExpress.XtraEditors.LabelControl LBGender;
        private DevExpress.XtraEditors.LabelControl LBAge;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraEditors.ComboBoxEdit TEGender;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}