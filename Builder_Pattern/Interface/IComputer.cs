using ComputerBuilder.ComputerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.Interface
{
    interface IComputer
    {
        public void Processor(string processor);

        public void VideoCard(string processor);

        public void Ram(string ram);

        public void Rom(string rom);

        public Computer Info();
    }

}
