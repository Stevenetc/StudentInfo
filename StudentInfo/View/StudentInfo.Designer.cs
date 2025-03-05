namespace StudentInfo.View
{
    partial class StudentInfo
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEFirstName = new DevExpress.XtraEditors.TextEdit();
            this.TEAge = new DevExpress.XtraEditors.TextEdit();
            this.TEMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.TEGender = new DevExpress.XtraEditors.TextEdit();
            this.TELastName = new DevExpress.XtraEditors.TextEdit();
            this.btnADD = new DevExpress.XtraEditors.SimpleButton();
            this.btnUPDATE = new DevExpress.XtraEditors.SimpleButton();
            this.btnDELETE = new DevExpress.XtraEditors.SimpleButton();
            this.LBFirstName = new DevExpress.XtraEditors.LabelControl();
            this.LBLastName = new DevExpress.XtraEditors.LabelControl();
            this.LBMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.LBGender = new DevExpress.XtraEditors.LabelControl();
            this.LBAge = new DevExpress.XtraEditors.LabelControl();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TELastName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GCStudent
            // 
            this.GCStudent.Location = new System.Drawing.Point(322, 36);
            this.GCStudent.MainView = this.gridView1;
            this.GCStudent.Name = "GCStudent";
            this.GCStudent.Size = new System.Drawing.Size(522, 256);
            this.GCStudent.TabIndex = 0;
            this.GCStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Gender,
            this.Age});
            this.gridView1.GridControl = this.GCStudent;
            this.gridView1.Name = "gridView1";
            // 
            // TEFirstName
            // 
            this.TEFirstName.Location = new System.Drawing.Point(43, 39);
            this.TEFirstName.Name = "TEFirstName";
            this.TEFirstName.Properties.AutoHeight = false;
            this.TEFirstName.Size = new System.Drawing.Size(273, 20);
            this.TEFirstName.TabIndex = 1;
            // 
            // TEAge
            // 
            this.TEAge.Location = new System.Drawing.Point(44, 272);
            this.TEAge.Name = "TEAge";
            this.TEAge.Properties.AutoHeight = false;
            this.TEAge.Size = new System.Drawing.Size(272, 20);
            this.TEAge.TabIndex = 2;
            // 
            // TEMiddleName
            // 
            this.TEMiddleName.Location = new System.Drawing.Point(43, 96);
            this.TEMiddleName.Name = "TEMiddleName";
            this.TEMiddleName.Properties.AutoHeight = false;
            this.TEMiddleName.Size = new System.Drawing.Size(273, 20);
            this.TEMiddleName.TabIndex = 3;
            // 
            // TEGender
            // 
            this.TEGender.Location = new System.Drawing.Point(43, 212);
            this.TEGender.Name = "TEGender";
            this.TEGender.Properties.AutoHeight = false;
            this.TEGender.Size = new System.Drawing.Size(273, 20);
            this.TEGender.TabIndex = 4;
            // 
            // TELastName
            // 
            this.TELastName.Location = new System.Drawing.Point(43, 151);
            this.TELastName.Name = "TELastName";
            this.TELastName.Properties.AutoHeight = false;
            this.TELastName.Size = new System.Drawing.Size(273, 20);
            this.TELastName.TabIndex = 5;
            // 
            // btnADD
            // 
            this.btnADD.Appearance.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Appearance.Options.UseFont = true;
            this.btnADD.Location = new System.Drawing.Point(44, 298);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(272, 37);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "ADD";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Appearance.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Appearance.Options.UseFont = true;
            this.btnUPDATE.Location = new System.Drawing.Point(322, 298);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(269, 37);
            this.btnUPDATE.TabIndex = 7;
            this.btnUPDATE.Text = "UPDATE";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Appearance.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Appearance.Options.UseFont = true;
            this.btnDELETE.Location = new System.Drawing.Point(597, 298);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(247, 37);
            this.btnDELETE.TabIndex = 8;
            this.btnDELETE.Text = "DELETE";
            // 
            // LBFirstName
            // 
            this.LBFirstName.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFirstName.Appearance.Options.UseFont = true;
            this.LBFirstName.Location = new System.Drawing.Point(43, 19);
            this.LBFirstName.Name = "LBFirstName";
            this.LBFirstName.Size = new System.Drawing.Size(72, 14);
            this.LBFirstName.TabIndex = 9;
            this.LBFirstName.Text = "First Name";
            // 
            // LBLastName
            // 
            this.LBLastName.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLastName.Appearance.Options.UseFont = true;
            this.LBLastName.Location = new System.Drawing.Point(44, 132);
            this.LBLastName.Name = "LBLastName";
            this.LBLastName.Size = new System.Drawing.Size(66, 14);
            this.LBLastName.TabIndex = 10;
            this.LBLastName.Text = "Last Name";
            // 
            // LBMiddleName
            // 
            this.LBMiddleName.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMiddleName.Appearance.Options.UseFont = true;
            this.LBMiddleName.Location = new System.Drawing.Point(44, 77);
            this.LBMiddleName.Name = "LBMiddleName";
            this.LBMiddleName.Size = new System.Drawing.Size(78, 14);
            this.LBMiddleName.TabIndex = 11;
            this.LBMiddleName.Text = "MiddleName";
            // 
            // LBGender
            // 
            this.LBGender.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBGender.Appearance.Options.UseFont = true;
            this.LBGender.Location = new System.Drawing.Point(43, 193);
            this.LBGender.Name = "LBGender";
            this.LBGender.Size = new System.Drawing.Size(47, 14);
            this.LBGender.TabIndex = 12;
            this.LBGender.Text = "Gender";
            // 
            // LBAge
            // 
            this.LBAge.Appearance.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAge.Appearance.Options.UseFont = true;
            this.LBAge.Location = new System.Drawing.Point(44, 253);
            this.LBAge.Name = "LBAge";
            this.LBAge.Size = new System.Drawing.Size(23, 14);
            this.LBAge.TabIndex = 13;
            this.LBAge.Text = "Age";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Caption = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 3;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 4;
            // 
            // StudentInfo
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 360);
            this.Controls.Add(this.LBAge);
            this.Controls.Add(this.LBGender);
            this.Controls.Add(this.LBMiddleName);
            this.Controls.Add(this.LBLastName);
            this.Controls.Add(this.LBFirstName);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.TELastName);
            this.Controls.Add(this.TEGender);
            this.Controls.Add(this.TEMiddleName);
            this.Controls.Add(this.TEAge);
            this.Controls.Add(this.TEFirstName);
            this.Controls.Add(this.GCStudent);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.GCStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TELastName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TEFirstName;
        private DevExpress.XtraEditors.TextEdit TEAge;
        private DevExpress.XtraEditors.TextEdit TEMiddleName;
        private DevExpress.XtraEditors.TextEdit TEGender;
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
    }
}