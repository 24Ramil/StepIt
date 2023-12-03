using ComputerBuilder.Interface;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class ComputerDirector
    {
        private IComputer _computer;

        public IComputer Computer 
        {
            get { return _computer; }
            
            set { _computer = value; }
        }


        public void MakeComputer(IComputer computer, string processor, string videocard, string ram, string rom) 
        {
            computer.Processor(processor);
            computer.Ram(ram);
            computer.Rom(rom);
            computer.VideoCard(videocard);
        }


    
    }
}
