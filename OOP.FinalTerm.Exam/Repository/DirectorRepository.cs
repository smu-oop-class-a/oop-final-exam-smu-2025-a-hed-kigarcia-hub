using OOP.FinalTerm.Exam.Model;
using OOP.FinalTerm.Exam.Utils;
using SQLite;

namespace OOP.FinalTerm.Exam.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ISQLiteConnection _dbConnection;

        public DirectorRepository()
        {

           _dbConnection = new SQLiteConnection(DatabaseHelper.GetDatabasePath()); 
_dbConnection.CreateTable<DirectorModel>();
        public void AddDirector(DirectorModel director)
        {
            _dbConnection.Insert(director);
        }

      
        public List<DirectorModel> GetAllDirectors()
        {
            return _dbConnection.Table<DirectorModel>().ToList();
            return new List<DirectorModel>(); 
        }

        /// <summary>
        /// Retrieves a specific director by their ID.
        /// </summary>
        /// <param name="id">The director ID to search for</param>
        /// <returns>Director object if found, null otherwise</returns>
        public DirectorModel GetDirectorById(int id)
        {
            // TODO: Students will implement this method
            // Hint: Use _dbConnection.Find<DirectorModel>(id);
            return null; //remove this
        }
    }
}