namespace PasswordManagerGUI3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;

        // NEW
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.ProgressBar prgStrength;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Timer timerClipboardClear;
        private System.Windows.Forms.Timer timerCopiedHide;

        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();

            // NEW
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.prgStrength = new System.Windows.Forms.ProgressBar();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblCopied = new System.Windows.Forms.Label();
            this.timerClipboardClear = new System.Windows.Forms.Timer(this.components);
            this.timerCopiedHide = new System.Windows.Forms.Timer(this.components);

            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(20, 20);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(52, 13);
            this.lblWebsite.Text = "Website:";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.Text = "Username:";

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.Text = "Password:";

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(420, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.Text = "Search:";

            // Textboxes
            this.txtWebsite.Location = new System.Drawing.Point(90, 17);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(200, 20);

            this.txtUsername.Location = new System.Drawing.Point(90, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);

            this.txtPassword.Location = new System.Drawing.Point(90, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            this.txtSearch.Location = new System.Drawing.Point(470, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // Buttons (CRUD)
            this.btnAdd.Location = new System.Drawing.Point(310, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnDelete.Location = new System.Drawing.Point(310, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnReveal.Location = new System.Drawing.Point(310, 75);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(80, 25);
            this.btnReveal.Text = "Reveal";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);

            this.btnUpdate.Location = new System.Drawing.Point(560, 75);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 25);
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // Buttons (CSV)
            this.btnExport.Location = new System.Drawing.Point(20, 405);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 25);
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.btnImport.Location = new System.Drawing.Point(150, 405);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 25);
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);

            // NEW — Generator / Strength / Clipboard
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(420, 50);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 13);
            this.lblLength.Text = "Length:";

            this.nudLength.Location = new System.Drawing.Point(470, 47);
            this.nudLength.Minimum = 8;
            this.nudLength.Maximum = 64;
            this.nudLength.Value = 16;
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(60, 20);

            this.btnGenerate.Location = new System.Drawing.Point(540, 45);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 25);
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(300, 79);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(54, 17);
            this.chkShow.Text = "Show";
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);

            this.btnCopy.Location = new System.Drawing.Point(360, 75);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(50, 25);
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);

            this.lblCopied.AutoSize = true;
            this.lblCopied.Location = new System.Drawing.Point(420, 80);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(44, 13);
            this.lblCopied.Text = "Copied!";
            this.lblCopied.Visible = false;

            this.prgStrength.Location = new System.Drawing.Point(470, 100);
            this.prgStrength.Name = "prgStrength";
            this.prgStrength.Size = new System.Drawing.Size(200, 12);

            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(420, 98);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(50, 13);
            this.lblStrength.Text = "Strength";

            // Timers
            this.timerClipboardClear.Tick += new System.EventHandler(this.timerClipboardClear_Tick);
            this.timerCopiedHide.Tick += new System.EventHandler(this.timerCopiedHide_Tick);

            // DataGridView
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colWebsite, this.colUsername
            });
            this.dgvAccounts.Location = new System.Drawing.Point(20, 130);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(650, 260);
            this.dgvAccounts.TabIndex = 99;
            this.dgvAccounts.AutoGenerateColumns = false;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);

            // Columns
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;

            this.colWebsite.DataPropertyName = "Website";
            this.colWebsite.HeaderText = "Website";
            this.colWebsite.Name = "colWebsite";

            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblCopied);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.prgStrength);

            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWebsite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager (PasswordManagerGUI3) — Day 25";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
