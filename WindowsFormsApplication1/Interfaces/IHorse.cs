using WindowsFormsApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IHorse
    {
        IEnumerable<Horse> GetHorse();
        int insertHorse(Horse newHorse);
        bool updateHorse(Horse horse);
        bool deleteHorse(Horse horseDelete);

    }
}
