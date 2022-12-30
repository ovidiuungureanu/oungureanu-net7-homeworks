using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5.Exercise_7
{
    interface Stay
    {
        DateTime GetDueDate();
    }

    interface Available
    {
        int AvailableRooms();
    }

    enum NumberOfTheRoom
    {
        Room100,
        Room101,
        Room102,
        Room103,
        Room104,
        Room105,
        Room106,
        Room107,
        Room108,
        Room109,
        Room1010,
        Room1011,
        Room1012,
        Room1013,
        Room1014,
        Room1015
    }
}
