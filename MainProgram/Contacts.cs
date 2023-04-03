using MainProgram.Models;
using MainProgram.Repository;
using System.ComponentModel;
using System.Diagnostics; // To alllow excel to start
using System.Runtime.InteropServices;
using MyExcel = Microsoft.Office.Interop.Excel; // to save to excel COM

namespace MainProgram
{
    public partial class Contacts : Form
    {
        System.Data.DataTable dt;

        static string connString = @"Data Source=localhost;Initial Catalog=AddressBook;Integrated Security=True";

        // Create Command Instance
        ContactCommand contactCmd = new ContactCommand(connString);

        public BindingSource interBinding;

        //DataTable dt;
        public Contacts(BindingSource mainBinding)
        {
            InitializeComponent();
            interBinding = mainBinding;
        }


        private void Contacts_Load(object sender, EventArgs e)
        {
            // Default Value
            comboBoxSearch.SelectedIndex = 0;

            // Add to Data Binding Object to Grid
            dataGridView1.DataSource = interBinding;

            // Get Data from MS SQL DB to the Binding Source
            GetDataToBindingsource();

            // Block Cell ID From Editing
            dataGridView1.Columns[0].ReadOnly = true;

            // Change DataGrid Size
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height = dataGridView1.Height;


        }

        private void GetDataToBindingsource(string searchQuery = "")
        {
            IList<ContactModel> contactModelList;
            // Call Get All Rows in a List Object
            if (searchQuery == "")
            {
                contactModelList = contactCmd.GetAllList();
            }
            else
            {
                contactModelList = contactCmd.GetAllList(searchQuery);
            }

            // ------------------------------------------------------
            // Option 1: Fill Directly with Binding List
            // ------------------------------------------------------

            // convert List to Binding List so I can assign to DataGridView
            //BindingList<ContactModel> bindingList = new BindingList<ContactModel>(contactModelList);
            // Create Binding with BindingList
            //var source = new BindingSource(bindingList, null);



            // ------------------------------------------------------
            // Option 2: Fill With Data Table
            // ------------------------------------------------------
            // convert List to DataTable
            dt = ConvertToDatatable(contactModelList);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            // Create Binding with DataTable
            //bindingSource1 = new BindingSource(dt, null);
            interBinding.DataSource = dt;

            // To mark all rows as unchanged
            dt.AcceptChanges();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Create String Array with Values from Forms
            string[] formValues = new string[]{
                dateTimePicker1.Value.Date.ToString(),
                textBoxCompany.Text,
                textBoxWebsite.Text,
                textBoxTitle.Text,
                textBoxFirstName.Text,
                textBoxLastName.Text,
                textBoxAddress.Text,
                textBoxCity.Text,
                textBoxState.Text,
                textBoxPostalCode.Text,
                textBoxEmail.Text,
                textBoxMobile.Text,
                textBoxNotes.Text,
                openFileDialog.FileName,
            };
            contactCmd.InsertElement(formValues);

            // Update Grid

            // Get Data from MS SQL DB
            GetDataToBindingsource();

            // Add to Data Grid
            dataGridView1.Update();


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Ends Edit on the table
            interBinding.EndEdit();

            // Uses Command To update DB
            contactCmd.UpdateDb(dt);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Get Selected Row where cell is selected
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;

            contactCmd.DeleteRow(row);

            // Get Data from MS SQL DB
            GetDataToBindingsource();

            // Add to Data Grid
            dataGridView1.Update();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Get Selected Item
            switch (comboBoxSearch.SelectedItem.ToString())
            {
                case "First Name":
                    GetDataToBindingsource(searchQuery: $@"SELECT * FROM ContactsTable WHERE lower(First_Name) LIKE '%{textBoxSearch.Text.ToLower()}%'");
                    break;
                case "Last Name":
                    GetDataToBindingsource(searchQuery: $@"SELECT * FROM ContactsTable WHERE lower(Last_Name) LIKE '%{textBoxSearch.Text.ToLower()}%'");
                    break;
                case "Companay":
                    GetDataToBindingsource(searchQuery: $@"SELECT * FROM ContactsTable WHERE lower(Compnay) LIKE '%{textBoxSearch.Text.ToLower()}%'");
                    break;

            }
        }

        private void buttonGetImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog.FileName);

            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create New form to show the image
            Form frm = new Form();
            // Set new Form Bh as the image
            frm.BackgroundImage = pictureBox1.Image;
            frm.Size = pictureBox1.Image.Size;
            frm.Show();
        }

        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);
        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Files(*.xlsx)|*.xlsx";
            MyExcel._Application app = new MyExcel.Application();

            // Creating Workbook
            MyExcel.Workbooks wb = app.Workbooks;
            MyExcel._Workbook workbook = wb.Add(Type.Missing);
            // Creating Worksheet
            MyExcel._Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Business Contacts";
                // Add Column Headers
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // Add Data
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            // Excel offset requires [i+2,j+1]
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }


                    }
                }
                // If dialog ok and Excel exists
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && Type.GetTypeFromProgID("Excel.Application") != null)
                {
                    app.ActiveWorkbook.SaveAs(saveFileDialog1.FileName);
                    Process.Start("excel.exe", saveFileDialog1.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Clear Process
                app.Quit();
                GetWindowThreadProcessId(app.Hwnd, out int id);
                Process.GetProcessById(id).Kill();
            }
        }

        private void buttonExportTxt_Click(object sender, EventArgs e)
        {
            // Define file properties
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // using Streamwriter Object
                using (StreamWriter strmWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    // Add Column Headers
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        if (dataGridView1.Columns[i - 1] != null)
                        {
                            strmWriter.Write(dataGridView1.Columns[i - 1].HeaderText.ToString());
                        }
                        else
                        {
                            strmWriter.Write("null");
                        }
                        strmWriter.Write(",");
                    }
                    strmWriter.Write("\n");

                    // Add Data
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        var row = dataGridView1.Rows[i];
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                strmWriter.Write(cell.Value.ToString());
                            }
                            else
                            {
                                strmWriter.Write("null");
                            }

                            strmWriter.Write(",");
                        }
                        strmWriter.Write("\n");
                    }
                }
                // Open file on notepad after file has been written
                Process.Start("notepad.exe", saveFileDialog1.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contacts_ResizeEnd(object sender, EventArgs e)
        {
            // Change DataGrid Size
            Rectangle recNew = new Rectangle();
            recNew = this.ClientRectangle;
            recNew.Height = dataGridView1.Height;
            recNew.Width -= 30;
            dataGridView1.Size = recNew.Size;
        }

        private static System.Data.DataTable ConvertToDatatable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            System.Data.DataTable table = new System.Data.DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
