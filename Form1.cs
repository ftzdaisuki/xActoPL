using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace PhotoLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();

                // Create a SqlCommand to retrieve the names and counts of the tags from the database
                using (SQLiteCommand command = new SQLiteCommand("SELECT t.Name, COUNT(pt.tagID) AS PhotoCount FROM tags t LEFT JOIN photoTags pt ON t.Id = pt.tagID GROUP BY t.Name", connection))
                {
                    // Execute the command and retrieve the data using a SqlDataReader
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the rows of the result set
                        while (reader.Read())
                        {
                            // Concatenate the name and count of the tag and add it to the CheckedListBox
                            tagCheckListBox.Items.Add(reader["Name"] + " (" + reader["PhotoCount"] + ")");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbOperations.importToDatabase();
        }

       
        private void dbDebugButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();

                // Get the table and column information from the sqlite_master table
                string sql = "SELECT * FROM photos";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Build a string with the table and column information
                        StringBuilder sb = new StringBuilder();
                        while (reader.Read())
                        {
                            string id = reader["id"].ToString();
                            string name = reader["name"].ToString();
                            string filepath = reader["filepath"].ToString();
                            string date_taken = reader["date_taken"].ToString();
                            sb.AppendLine(id);
                            sb.AppendLine();
                            sb.AppendLine(name);
                            sb.AppendLine();
                            sb.AppendLine(filepath);
                            sb.AppendLine();
                            sb.AppendLine(date_taken);
                        }

                        // Display the table and column information in a message box
                        MessageBox.Show(sb.ToString(), "DB Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connection.Close();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void innerSplitLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}