using MainProgram.Models;
using System.Data;
using System.Data.SqlClient;

namespace MainProgram.Repository
{
    internal class ContactCommand
    {
        public string ConnectionString { get; private set; }

        public ContactCommand(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Update DataTable from modifications on the DataGridView on the GUI
        /// </summary>
        /// <param name="tableGUI"></param>
        public void UpdateDb(DataTable tableGUI)
        {

            // Check if changes done since last time table.AccepChanges() was executed
            DataTable changes = tableGUI.GetChanges();

            if (changes != null)
            {
                // Open Connection
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Crate an adapter with all the entries to make automatic update
                    // Select command is SELECT * FROM ContactsTable
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ContactsTable", conn))
                    {
                        // Create command builder to allow to detect automatic SQL commands
                        using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter))
                        {
                            // Assign auto get command to data adaptEr
                            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                            // Update Table on Database
                            dataAdapter.Update(tableGUI);
                            // Accept Changes to Track future modifications
                            tableGUI.AcceptChanges();

                            MessageBox.Show("Cell Updated");
                            return;

                        }
                    }
                }
            }

        }

        public IList<ContactModel> GetAllList(string query = "SELECT * FROM ContactsTable")
        {
            List<ContactModel> contactModelsList = new List<ContactModel>();

            // SQL Connection Established
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // If Data To be read
                        if (reader.HasRows)
                        {
                            // Iterate while we have values to read
                            while (reader.Read())
                            {
                                // Create Model With Data of each Row
                                ContactModel contactModel = new ContactModel()
                                {

                                    ID = Convert.ToInt32(reader["ID"].ToString()),
                                    Date_Added = Convert.ToString(reader["Date_Added"])!,
                                    Company = Convert.ToString(reader["Company"]),
                                    Website = Convert.ToString(reader["Website"]),
                                    Title = Convert.ToString(reader["Title"]),
                                    First_Name = Convert.ToString(reader["First_Name"]),
                                    Last_Name = Convert.ToString(reader["Last_Name"]),
                                    Address = Convert.ToString(reader["Address"]),
                                    City = Convert.ToString(reader["City"]),
                                    State = Convert.ToString(reader["State"]),
                                    Postal_Code = Convert.ToString(reader["Postal_Code"]),
                                    Email = Convert.ToString(reader["Email"]),
                                    Mobile = Convert.ToString(reader["Mobile"]),
                                    Notes = Convert.ToString(reader["Notes"]),
                                };

                                // Verify if Image is not null to convert object to Byte Array
                                if (!Convert.IsDBNull(reader["Image"]))
                                {
                                    contactModel.Image = (byte[])reader["Image"];
                                }

                                // Add Instance to List
                                contactModelsList.Add(contactModel);

                            }

                        }
                    }

                }
            }

            return contactModelsList;
        }

        public void InsertElement(string[] contactValues)
        {
            string sqlInsertStr = @"
                INSERT INTO ContactsTable(Date_Added, Company, Website, Title, First_Name, Last_Name, Address, City, State, Postal_Code, Email, Mobile, Notes, Image)
                VALUES
                    (@Date_Added, @Company, @Website, @Title, @First_Name, @Last_Name, @Address, @City, @State, @Postal_Code, @Email, @Mobile, @Notes, @Image)";
            // SQL Connection Established
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlInsertStr, conn))
                {
                    cmd.Parameters.AddWithValue("@Date_Added", contactValues[0]);
                    cmd.Parameters.AddWithValue("@Company", contactValues[1]);
                    cmd.Parameters.AddWithValue("@Website", contactValues[2]);
                    cmd.Parameters.AddWithValue("@Title", contactValues[3]);
                    cmd.Parameters.AddWithValue("@First_Name", contactValues[4]);
                    cmd.Parameters.AddWithValue("@Last_Name", contactValues[5]);
                    cmd.Parameters.AddWithValue("@Address", contactValues[6]);
                    cmd.Parameters.AddWithValue("@City", contactValues[7]);
                    cmd.Parameters.AddWithValue("@State", contactValues[8]);
                    cmd.Parameters.AddWithValue("@Postal_Code", contactValues[9]);
                    cmd.Parameters.AddWithValue("@Email", contactValues[10]);
                    cmd.Parameters.AddWithValue("@Mobile", contactValues[11]);
                    cmd.Parameters.AddWithValue("@Notes", contactValues[12]);

                    // Check if Image provided, if not, DBNull
                    if (contactValues[13] != "")
                        cmd.Parameters.AddWithValue(@"Image", File.ReadAllBytes(contactValues[13]));
                    else
                        cmd.Parameters.Add(@"Image", SqlDbType.VarBinary).Value = DBNull.Value;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRow(DataGridViewRow row)
        {

            //Grab value from ID Column
            string idValue = Convert.ToString(row.Cells["ID"].Value);
            string fnameValue = Convert.ToString(row.Cells["First_Name"].Value);
            string lnameValue = Convert.ToString(row.Cells["Last_Name"].Value);

            // Show Message to User
            DialogResult result = MessageBox.Show($"Do you really want to delete {fnameValue} {lnameValue}, Record: {idValue}", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // SQL Connection Established
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand($@"DELETE FROM ContactsTable WHERE ID= {idValue}", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}