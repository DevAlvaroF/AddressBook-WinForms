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
            buttonAdd = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            InterBinding = new BindingSource(components);
            pictureBox1 = new PictureBox();
            buttonGetImage = new Button();
            openFileDialog = new OpenFileDialog();
            buttonExportExcel = new Button();
            buttonExportTxt = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterBinding).BeginInit();
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
            textBoxTitle.Location = new Point(135, 8);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(245, 27);
            textBoxTitle.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(135, 70);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(245, 27);
            textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(10, 69);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(110, 28);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(135, 133);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(245, 27);
            textBoxLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(10, 132);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(107, 28);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(135, 196);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(245, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddress.Location = new Point(10, 195);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(86, 28);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Address:";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(135, 259);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(245, 27);
            textBoxCity.TabIndex = 9;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCity.Location = new Point(10, 258);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(50, 28);
            labelCity.TabIndex = 8;
            labelCity.Text = "City:";
            // 
            // textBoxState
            // 
            textBoxState.Location = new Point(135, 322);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(245, 27);
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
            textBoxPostalCode.Location = new Point(135, 385);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(245, 27);
            textBoxPostalCode.TabIndex = 13;
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPostalCode.Location = new Point(10, 384);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(119, 28);
            labelPostalCode.TabIndex = 12;
            labelPostalCode.Text = "Postal Code:";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Location = new Point(135, 448);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(245, 27);
            textBoxCompany.TabIndex = 15;
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompany.Location = new Point(10, 447);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(100, 28);
            labelCompany.TabIndex = 14;
            labelCompany.Text = "Company:";
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(135, 511);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(245, 27);
            textBoxWebsite.TabIndex = 17;
            // 
            // labelWebsite
            // 
            labelWebsite.AutoSize = true;
            labelWebsite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWebsite.Location = new Point(10, 510);
            labelWebsite.Name = "labelWebsite";
            labelWebsite.Size = new Size(86, 28);
            labelWebsite.TabIndex = 16;
            labelWebsite.Text = "Website:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(139, 670);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(313, 27);
            textBoxSearch.TabIndex = 19;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearch.Location = new Point(23, 666);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(74, 28);
            labelSearch.TabIndex = 18;
            labelSearch.Text = "Search:";
            // 
            // textBoxMobile
            // 
            textBoxMobile.Location = new Point(511, 66);
            textBoxMobile.Name = "textBoxMobile";
            textBoxMobile.Size = new Size(194, 27);
            textBoxMobile.TabIndex = 21;
            // 
            // labelMobile
            // 
            labelMobile.AutoSize = true;
            labelMobile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMobile.Location = new Point(400, 65);
            labelMobile.Name = "labelMobile";
            labelMobile.Size = new Size(78, 28);
            labelMobile.TabIndex = 20;
            labelMobile.Text = "Mobile:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(400, 128);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(129, 28);
            labelDate.TabIndex = 22;
            labelDate.Text = "Date Entered:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(541, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotes.Location = new Point(400, 195);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(68, 28);
            labelNotes.TabIndex = 24;
            labelNotes.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(511, 195);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(280, 96);
            textBoxNotes.TabIndex = 25;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "First Name", "Last Name", "Company" });
            comboBoxSearch.Location = new Point(470, 670);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(177, 28);
            comboBoxSearch.TabIndex = 26;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(664, 664);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 27;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.MenuHighlight;
            buttonAdd.Location = new Point(554, 568);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 44);
            buttonAdd.TabIndex = 29;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(305, 1010);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 30;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 716);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(790, 267);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(511, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(194, 27);
            textBoxEmail.TabIndex = 33;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(400, 3);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 28);
            labelEmail.TabIndex = 32;
            labelEmail.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(522, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonGetImage
            // 
            buttonGetImage.Location = new Point(407, 317);
            buttonGetImage.Name = "buttonGetImage";
            buttonGetImage.Size = new Size(94, 29);
            buttonGetImage.TabIndex = 35;
            buttonGetImage.Text = "Get Image";
            buttonGetImage.UseVisualStyleBackColor = true;
            buttonGetImage.Click += buttonGetImage_Click;
            // 
            // buttonExportExcel
            // 
            buttonExportExcel.Location = new Point(23, 1010);
            buttonExportExcel.Name = "buttonExportExcel";
            buttonExportExcel.Size = new Size(127, 29);
            buttonExportExcel.TabIndex = 36;
            buttonExportExcel.Text = "Export to Excel";
            buttonExportExcel.UseVisualStyleBackColor = true;
            buttonExportExcel.Click += buttonExportExcel_Click;
            // 
            // buttonExportTxt
            // 
            buttonExportTxt.Location = new Point(165, 1010);
            buttonExportTxt.Name = "buttonExportTxt";
            buttonExportTxt.Size = new Size(125, 29);
            buttonExportTxt.TabIndex = 37;
            buttonExportTxt.Text = "Export to Txt";
            buttonExportTxt.UseVisualStyleBackColor = true;
            buttonExportTxt.Click += buttonExportTxt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 616);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 38;
            label1.Text = "Search ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 630);
            label2.Name = "label2";
            label2.Size = new Size(639, 20);
            label2.TabIndex = 39;
            label2.Text = "---------------------------------------------------------------------------------------------------------";
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(827, 1055);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonExportTxt);
            Controls.Add(buttonExportExcel);
            Controls.Add(buttonGetImage);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
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
            ResizeEnd += Contacts_ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterBinding).EndInit();
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
        private Button buttonAdd;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private BindingSource InterBinding;
        private PictureBox pictureBox1;
        private Button buttonGetImage;
        private OpenFileDialog openFileDialog;
        private Button buttonExportExcel;
        private Button buttonExportTxt;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label2;
    }
}