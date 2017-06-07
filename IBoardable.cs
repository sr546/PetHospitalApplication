using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsHospitalApplication
{
    interface IBoardable
    {
        void SetBoardStart(int month, int day, int year);
        void SetBoardEnd(int month, int day, int year);
        Boolean Boarding(int month, int day, int year);
    }
}
