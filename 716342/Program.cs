﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732104_Week04_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ounntryside c = new countryside();
            // c.run();
        }
    }
    class LearningExperment
    {
        public void run()
        {

            Village Toronto;
            Toronto = new Village();
            Village a;
            Toronto.villageName = "Version A";
            a = Toronto;
            Toronto = new Village();
            Toronto.villageName = "Version B";
            b = Toronto;
            Toronto = new Village();
            Toronto.villageName = "Version C";
            c = Toronto;

        }
    }

    class Village
    {
        public bool isAstrilde;
        public Village nextVillage;
        public Village prevVillage;
        public string villageName;

    }

    class Countryside
    {
        Village Toronto, Maple, Ajax;

        public void run()
        {
            Maple = new Village();
            Toronto = new Village();
            Ajax = new Village();
            Maple.villageName = "Toronto";
            Maple.nextVillage = Toronto;

        }
    }
}

