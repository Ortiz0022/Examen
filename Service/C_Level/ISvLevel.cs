using Entities;

namespace Service.C_Level
{
    public interface ISvLevel
    {
        public Level Add_Level(Level level);

        public List<Level> GetAllLevel();

        public Level Get_ById(int id); 
    }
}