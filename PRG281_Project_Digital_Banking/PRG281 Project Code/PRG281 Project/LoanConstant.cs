﻿// Michael Richter 577302 (code)
// Arlo Roos 577441 (code)
// Hendro Opperman 577861 (User manual)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    public interface LoanConstants
    {
        //these are the constants that will be used throughout the program
        int ShortTerm { get;  }
        int MediumTerm { get; }
        int LongTerm { get; }
        string CompanyName { get;  }
        double MaxLoanAmount { get;  }
    }
       
}

