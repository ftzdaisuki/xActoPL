using System.Data;
using System.Data.SQLite;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace PhotoLibrary
{
    internal static class Program
    {
        [STAThread]


        static void Main()
        {
            // Set the file path for the database
            string dbFilePath = "database.db";

            // Check if the database file exists
            if (!File.Exists(dbFilePath))
            {
                // Display a "database not found" message box
                MessageBox.Show("The database file was not found. A new database will be created.", "Database Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQLiteConnection.CreateFile(dbFilePath);


                dbOperations.ExecuteSql(@"CREATE TABLE photos (id INTEGER PRIMARY KEY,name TEXT,filepath TEXT,dateTaken DATETIME);
                CREATE TABLE tags (id INTEGER PRIMARY KEY,name TEXT);
                CREATE TABLE photoTags (photoID INTEGER,tagID INTEGER,FOREIGN KEY(photoID) REFERENCES photos(id),    
                FOREIGN KEY(tagID) REFERENCES tags(id));");

            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public static class dbOperations
    { 
        public static void ExecuteSql(string sql)
        {
            // Helper function to handle SQL commands, since it's a bit clunky to open and close new connections all the time

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static DataTable ExecuteSqlAndReturnData(string sql)
        {
            // Helper function for querying data from the database.
            DataTable dataTable = new DataTable();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {

                            adapter.Fill(dataTable);

                        }
                    }
                    connection.Close();
                    return dataTable;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable failureDataTable = new DataTable();
                return failureDataTable;
            }
        }

        public static void importToDatabase()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // Prompt the user to select a folder
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = dialog.SelectedPath;
                    string[] filePaths = Directory.GetFiles(folderPath);

                    // Iterate through each file in the folder and check if it's a photo; if it is, give it a new ID,
                    // grab its creation date, and add it to the database.
                    foreach (string filePath in filePaths)
                    {
                        
                        if (IsImageFile(filePath))
                        {
                            string safeFilePath = filePath.Replace(":", "_");
                            int photoId = GetNextPhotoId();
                            DateTime creationDate = File.GetCreationTime(filePath);
                            AddPhotoToDatabase(photoId, safeFilePath, creationDate);
                        }
                    }
                }
            }
        }
        private static int GetNextPhotoId()
        {
            int value = 0;
            
            // Execute the SELECT statement and retrieve the data; if it's not empty, update value to highest present in database
            DataTable table = ExecuteSqlAndReturnData("SELECT MAX(id) AS MaxId FROM photos");
            if (table.Rows.Count > 0 && table.Rows[0]["MaxId"] != DBNull.Value)
                value = Convert.ToInt32(table.Rows[0]["MaxId"]);

            //also ensures an empty database assigns ID of 1
            return value+1;
        }
        private static bool IsImageFile(string filePath)
        {
            if (filePath.EndsWith(".jpg") || filePath.EndsWith(".jpeg") || filePath.EndsWith(".png") || filePath.EndsWith(".gif"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //private static DateTime GetCreationDate(string filePath)
        //{
        //    using (Image image = Image.FromFile(filePath))
        //    {
        //        // Get the PropertyItem that contains the creation date
        //        PropertyItem propertyItem = image.GetPropertyItem(0x9003);
        //        string dateString = Encoding.UTF8.GetString(propertyItem.Value);

        //        // Parse the string to a DateTime
        //        DateTime creationDate = DateTime.ParseExact(dateString, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture);

        //        return creationDate;
        //    }
        //}
        private static void AddPhotoToDatabase(int photoID, string filePath, DateTime creationDate)
        {
            DataTable doesItExist = new DataTable();
            doesItExist = ExecuteSqlAndReturnData($"SELECT COUNT(*) FROM photos WHERE filepath = {filePath}");
            if (Convert.ToInt32(doesItExist.Rows[0]["COUNT(*)"]) == 0)
            {
                string insertion = $"INSERT INTO photos (Id, Name, FilePath, DateTaken) VALUES ({photoID}, '', '{filePath}', '{creationDate:yyyy-MM-dd HH:mm:ss}');";
                ExecuteSql(insertion);
            }
        }
    }
}