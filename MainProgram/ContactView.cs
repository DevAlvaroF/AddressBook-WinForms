using MainProgram.Models;
using MainProgram.Repository;
using System.ComponentModel;

namespace MainProgram
{
    public partial class ContactView : Form
    {
        System.Data.DataTable dt;

        static string connString = @"Data Source=localhost;Initial Catalog=AddressBook;Integrated Security=True";

        // Create Command Instance
        ContactCommand contactCmd = new ContactCommand(connString);
        private BindingSource interBinding;
        public ContactView(BindingSource mainBinding)
        {
            interBinding = mainBinding;
            InitializeComponent();
        }

        public void UpdateGrid(DataGridView dg)
        {
            // Add to Data Grid
            dataGridView1.DataSource = dg.DataSource;
        }
        private void ContactView_Load(object sender, EventArgs e)
        {

            // Add to Data Binding Object to Grid
            dataGridView1.DataSource = interBinding;

            // Get Data from MS SQL DB to the Binding Source
            GetDataToBindingsource();

            // Block Cell ID From Editing
            dataGridView1.Columns[0].ReadOnly = true;

            //// Change DataGrid Size
            //dataGridView1.Left = 0;
            //dataGridView1.Top = 0;
            //Rectangle recNew = new Rectangle();
            //recNew = this.ClientRectangle;
            //dataGridView1.Size = recNew.Size;

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
