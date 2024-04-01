using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVdatabase
{
    public class ScoreDto
    {
        public string studentID {  get; set; }
        public int courseID { get; set; }

        public double firstTestScore { get; set; }
        public double secondTestScore { get; set;}

        public string fullName { get; set; }
        public string nameCourse { get; set; }

    }
}
