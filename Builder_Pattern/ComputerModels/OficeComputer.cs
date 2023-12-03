using ComputerBuilder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.ComputerModel
{
    class OficeComputer : IComputer
    {
        private Computer _computer = new();
        

        public void Processor(string processor)
        {
            _computer.Processor = processor;
        }

        public void Ram(string ram)
        {
            _computer.Ram = ram;
        }

        public void Rom(string rom)
        {
            _computer.Rom = rom;
        }

        public void VideoCard(string vidoecard)
        {
            _computer.VideoCard = vidoecard;
        }

        public Computer Info()
        {
            return _computer;
        }

    }
}
