using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Worker
    {
        List<IPart> Parts = new List<IPart>()
        {
            new Foundation(),
            new Wall(),
            new Roof(),
            new Window()
        };


        public void Start(int choices)
        {
            switch (choices)
            {
                case 1:
                    Parts[0].Build();
                    break;
                case 2:
                    if (Parts[0] != null)
                    {


                        Parts[1].Build();
                    }
                        break;  
                case 3:
                    Parts[2].Build();
                    break;
                case 4:
                    Parts[3].Build();
                    break;
            }
        }
    }
}
