﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMiner
{
    public class AlphabeticShift
    {
        //constructor
        CircularShift CircularShift;

        public List<string> AlphabetizedShifts { get; set; }

        public AlphabeticShift(CircularShift CS)
        {
            CircularShift = CS;
            AlphabetizedShifts = new List<string>();
        }

        public void Alpha()
        {

            //gets char and word from circular shift to get shifted lines 
            //and create alphabetized lines
            var list = CircularShift.Shifts;
            list.Sort();
            AlphabetizedShifts = list;

        }
        public int CSIndex(int blah)
        {
            //returns the index of the circular shift which comes i-th in the ordering
            return blah; //placeholder
        }

    }
}