using ComputerBuilder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder.ComputerModel
{
    class Computer
    {

        public string Processor {set; get; }       
        public string VideoCard { set; get; }
        public string Ram { set; get; }
        public string Rom { set; get; }

        public void Info()
        {
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"Graphics Card: {VideoCard}");
            Console.WriteLine($"RAM: {Ram} GB RAM");
            Console.WriteLine($"ROM: {Rom} ");
            Console.WriteLine();
        }


    }

}
