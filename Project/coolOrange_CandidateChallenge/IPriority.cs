﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public interface IPriority
    {
        void SetPriority(string level);
        int GetPriority();
    }
}
