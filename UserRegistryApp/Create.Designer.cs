
namespace UserRegistryApp
{
    partial class Create
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tlp_form = new System.Windows.Forms.TableLayoutPanel();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.tlp_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(3, 29);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 15);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-Mail";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(3, 58);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(45, 15);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(3, 87);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 15);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status";
            // 
            // tlp_form
            // 
            this.tlp_form.ColumnCount = 2;
            this.tlp_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_form.Controls.Add(this.lbl_name, 0, 0);
            this.tlp_form.Controls.Add(this.lbl_status, 0, 3);
            this.tlp_form.Controls.Add(this.lbl_gender, 0, 2);
            this.tlp_form.Controls.Add(this.lbl_email, 0, 1);
            this.tlp_form.Controls.Add(this.txb_name, 1, 0);
            this.tlp_form.Controls.Add(this.txb_email, 1, 1);
            this.tlp_form.Controls.Add(this.cmb_gender, 1, 2);
            this.tlp_form.Controls.Add(this.cmb_status, 1, 3);
            this.tlp_form.Controls.Add(this.btn_create, 1, 4);
            this.tlp_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_form.Location = new System.Drawing.Point(0, 0);
            this.tlp_form.Name = "tlp_form";
            this.tlp_form.RowCount = 4;
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_form.Size = new System.Drawing.Size(355, 152);
            this.tlp_form.TabIndex = 2;
            // 
            // txb_name
            // 
            this.txb_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_name.Location = new System.Drawing.Point(54, 3);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(298, 23);
            this.txb_name.TabIndex = 7;
            // 
            // txb_email
            // 
            this.txb_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_email.Location = new System.Drawing.Point(54, 32);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(298, 23);
            this.txb_email.TabIndex = 8;
            // 
            // cmb_gender
            // 
            this.cmb_gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmb_gender.Location = new System.Drawing.Point(54, 61);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(298, 23);
            this.cmb_gender.TabIndex = 13;
            // 
            // cmb_status
            // 
            this.cmb_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmb_status.Location = new System.Drawing.Point(54, 90);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(298, 23);
            this.cmb_status.TabIndex = 14;
            // 
            // btn_create
            // 
            this.tlp_form.SetColumnSpan(this.btn_create, 2);
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_create.Location = new System.Drawing.Point(3, 119);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(349, 30);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 152);
            this.Controls.Add(this.tlp_form);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create";
            this.Text = "Create";
            this.tlp_form.ResumeLayout(false);
            this.tlp_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TableLayoutPanel tlp_form;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Button btn_create;
    }
}