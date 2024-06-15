using Entities;
using Microsoft.EntityFrameworkCore;
using Service.C_Level;
using Service.MyDbContext;

namespace Service.C_Level
{
    public class SvLevel : ISvLevel
    {
        private MyContext _myDbContext;
        public SvLevel()
        {
            _myDbContext = new MyContext();
        }
        public Level Add_Level(Level level)
        {
            _myDbContext.Levels.Add(level);
            _myDbContext.SaveChanges();

            return level;
        }

        public List<Level> GetAllLevel()
        {
            return _myDbContext.Levels.ToList();
        }

        public Level Get_ById(int id)
        {
            return _myDbContext.Levels.SingleOrDefault(x => x.Id == id);
        }
    }
}