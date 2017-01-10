using WindowsFormsApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IStaff
    {
        IEnumerable<Staff> GetStaff();
        int insertStaff(Staff newStaff);
        bool updateStaff(Staff staff);
        bool deleteStaff(Staff staffDelete);

    }
}
