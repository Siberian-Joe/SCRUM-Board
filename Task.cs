using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardNewDesign
{
    public class Task
    {
        string title { get; set; }
        string info { get; set; }
        public Task (string title, string info)
        {
            this.title = title;
            this.info = info;
        }
    }
}
