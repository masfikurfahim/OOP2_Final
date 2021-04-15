
namespace Demo_Database_Lab_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtCourses = new System.Windows.Forms.DataGridView();
            this.loadData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSrchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCnameUpdate = new System.Windows.Forms.TextBox();
            this.tbCCodeUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(171, 18);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(159, 20);
            this.tbCName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Code";
            // 
            // tbCCode
            // 
            this.tbCCode.Location = new System.Drawing.Point(170, 81);
            this.tbCCode.Name = "tbCCode";
            this.tbCCode.Size = new System.Drawing.Size(159, 20);
            this.tbCCode.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(254, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtCourses
            // 
            this.dtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCourses.Location = new System.Drawing.Point(458, 9);
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.Size = new System.Drawing.Size(330, 299);
            this.dtCourses.TabIndex = 5;
            // 
            // loadData
            // 
            this.loadData.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadData.Location = new System.Drawing.Point(7, 122);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(75, 39);
            this.loadData.TabIndex = 6;
            this.loadData.Text = "Load";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edit Panel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course ID";
            // 
            // tbSrchId
            // 
            this.tbSrchId.Location = new System.Drawing.Point(170, 253);
            this.tbSrchId.Name = "tbSrchId";
            this.tbSrchId.Size = new System.Drawing.Size(159, 20);
            this.tbSrchId.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(335, 240);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 39);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Course Code";
            // 
            // tbCnameUpdate
            // 
            this.tbCnameUpdate.Location = new System.Drawing.Point(171, 301);
            this.tbCnameUpdate.Name = "tbCnameUpdate";
            this.tbCnameUpdate.Size = new System.Drawing.Size(159, 20);
            this.tbCnameUpdate.TabIndex = 13;
            // 
            // tbCCodeUpdate
            // 
            this.tbCCodeUpdate.Location = new System.Drawing.Point(171, 351);
            this.tbCCodeUpdate.Name = "tbCCodeUpdate";
            this.tbCCodeUpdate.Size = new System.Drawing.Size(159, 20);
            this.tbCCodeUpdate.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(221, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 39);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbCCodeUpdate);
            this.Controls.Add(this.tbCnameUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSrchId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.dtCourses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtCourses;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSrchId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCnameUpdate;
        private System.Windows.Forms.TextBox tbCCodeUpdate;
        private System.Windows.Forms.Button btnUpdate;
    }
}

