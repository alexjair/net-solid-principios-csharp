using System.Text;
using static DependencyInversion.Logbook;

namespace DependencyInversion
{
    public class Logbook : ILogbook
    {
        public void Add(string description)
        {
            File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logbook.txt"), $"{description}\n", Encoding.Unicode);
        }

        /*******************[ Interfaces ]*****************/

        public interface ILogbook
        {
            public void Add(string description);
        }
    }
}