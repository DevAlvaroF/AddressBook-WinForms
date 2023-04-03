namespace MainProgram
{
    partial class Contacts
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
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            textBoxCity = new TextBox();
            labelCity = new Label();
            textBoxState = new TextBox();
            labelState = new Label();
            textBoxPostalCode = new TextBox();
            labelPostalCode = new Label();
            textBoxCompany = new TextBox();
            labelCompany = new Label();
            textBoxWebsite = new TextBox();
            labelWebsite = new Label();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            textBoxMobile = new TextBox();
            labelMobile = new Label();
            labelDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelNotes = new Label();
            textBoxNotes = new TextBox();
            comboBoxSearch = new ComboBox();
            buttonSearch = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            buttonGetImage = new Button();
            openFileDialog = new OpenFileDialog();
            buttonExportExcel = new Button();
            buttonExportTxt = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(10, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(53, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(126, 8);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(313, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(126, 68);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(313, 27);
            textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(10, 64);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(110, 28);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(126, 131);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(313, 27);
            textBoxLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(10, 127);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(107, 28);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(126, 200);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(313, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddress.Location = new Point(10, 196);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(86, 28);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Address:";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(126, 269);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(313, 27);
            textBoxCity.TabIndex = 9;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCity.Location = new Point(10, 265);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(50, 28);
            labelCity.TabIndex = 8;
            labelCity.Text = "City:";
            // 
            // textBoxState
            // 
            textBoxState.Location = new Point(126, 325);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(313, 27);
            textBoxState.TabIndex = 11;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelState.Location = new Point(10, 321);
            labelState.Name = "labelState";
            labelState.Size = new Size(60, 28);
            labelState.TabIndex = 10;
            labelState.Text = "State:";
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(126, 381);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(313, 27);
            textBoxPostalCode.TabIndex = 13;
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPostalCode.Location = new Point(10, 379);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(119, 28);
            labelPostalCode.TabIndex = 12;
            labelPostalCode.Text = "Postal Code:";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(126, 449);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(313, 27);
            textBoxCompany.TabIndex = 15;
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompany.Location = new Point(10, 445);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(100, 28);
            labelCompany.TabIndex = 14;
            labelCompany.Text = "Company:";
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(126, 517);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(313, 27);
            textBoxWebsite.TabIndex = 17;
            // 
            // labelWebsite
            // 
            labelWebsite.AutoSize = true;
            labelWebsite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWebsite.Location = new Point(10, 513);
            labelWebsite.Name = "labelWebsite";
            labelWebsite.Size = new Size(86, 28);
            labelWebsite.TabIndex = 16;
            labelWebsite.Text = "Website:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(126, 579);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(313, 27);
            textBoxSearch.TabIndex = 19;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearch.Location = new Point(10, 575);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(74, 28);
            labelSearch.TabIndex = 18;
            labelSearch.Text = "Search:";
            // 
            // textBoxMobile
            // 
            textBoxMobile.Location = new Point(651, 68);
            textBoxMobile.Name = "textBoxMobile";
            textBoxMobile.Size = new Size(313, 27);
            textBoxMobile.TabIndex = 21;
            // 
            // labelMobile
            // 
            labelMobile.AutoSize = true;
            labelMobile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMobile.Location = new Point(536, 64);
            labelMobile.Name = "labelMobile";
            labelMobile.Size = new Size(78, 28);
            labelMobile.TabIndex = 20;
            labelMobile.Text = "Mobile:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(513, 129);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(129, 28);
            labelDate.TabIndex = 22;
            labelDate.Text = "Date Entered:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(651, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotes.Location = new Point(536, 196);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(68, 28);
            labelNotes.TabIndex = 24;
            labelNotes.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(651, 200);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(313, 96);
            textBoxNotes.TabIndex = 25;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "First Name", "Last Name", "Company" });
            comboBoxSearch.Location = new Point(457, 579);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(177, 28);
            comboBoxSearch.TabIndex = 26;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(651, 573);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 27;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(781, 573);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 28;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(890, 573);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 29;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1003, 573);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 30;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 659);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1090, 267);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(651, 15);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(313, 27);
            textBoxEmail.TabIndex = 33;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(536, 11);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 28);
            labelEmail.TabIndex = 32;
            labelEmail.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(651, 316);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonGetImage
            // 
            buttonGetImage.Location = new Point(536, 320);
            buttonGetImage.Name = "buttonGetImage";
            buttonGetImage.Size = new Size(94, 29);
            buttonGetImage.TabIndex = 35;
            buttonGetImage.Text = "Get Image";
            buttonGetImage.UseVisualStyleBackColor = true;
            buttonGetImage.Click += buttonGetImage_Click;
            // 
            // buttonExportExcel
            // 
            buttonExportExcel.Location = new Point(918, 435);
            buttonExportExcel.Name = "buttonExportExcel";
            buttonExportExcel.Size = new Size(127, 29);
            buttonExportExcel.TabIndex = 36;
            buttonExportExcel.Text = "Export to Excel";
            buttonExportExcel.UseVisualStyleBackColor = true;
            buttonExportExcel.Click += buttonExportExcel_Click;
            // 
            // buttonExportTxt
            // 
            buttonExportTxt.Location = new Point(920, 477);
            buttonExportTxt.Name = "buttonExportTxt";
            buttonExportTxt.Size = new Size(125, 29);
            buttonExportTxt.TabIndex = 37;
            buttonExportTxt.Text = "Export to Txt";
            buttonExportTxt.UseVisualStyleBackColor = true;
            buttonExportTxt.Click += buttonExportTxt_Click;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 845);
            Controls.Add(buttonExportTxt);
            Controls.Add(buttonExportExcel);
            Controls.Add(buttonGetImage);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxSearch);
            Controls.Add(textBoxNotes);
            Controls.Add(labelNotes);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelDate);
            Controls.Add(textBoxMobile);
            Controls.Add(labelMobile);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(textBoxWebsite);
            Controls.Add(labelWebsite);
            Controls.Add(textBoxCompany);
            Controls.Add(labelCompany);
            Controls.Add(textBoxPostalCode);
            Controls.Add(labelPostalCode);
            Controls.Add(textBoxState);
            Controls.Add(labelState);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Name = "Contacts";
            Text = "Contacts";
            Load += Contacts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTitle;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private TextBox textBoxCity;
        private Label labelCity;
        private TextBox textBoxState;
        private Label labelState;
        private TextBox textBoxPostalCode;
        private Label labelPostalCode;
        private TextBox textBoxCompany;
        private Label labelCompany;
        private TextBox textBoxWebsite;
        private Label labelWebsite;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private TextBox textBoxMobile;
        private Label labelMobile;
        private Label labelDate;
        private DateTimePicker dateTimePicker1;
        private Label labelNotes;
        private TextBox textBoxNotes;
        private ComboBox comboBoxSearch;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private Button buttonGetImage;
        private OpenFileDialog openFileDialog;
        private Button buttonExportExcel;
        private Button buttonExportTxt;
        private SaveFileDialog saveFileDialog1;
    }
}