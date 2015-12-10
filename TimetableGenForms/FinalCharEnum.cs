using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.TtGen
{
    public enum FinalCharEnum
    {
        [Description("Z5")]
        Z5 = -9,
        [Description("Z4")]
        Z4 = -8,
        [Description("Z3")]
        Z3 = -7,
        [Description("Z2")]
        Z2 = -6,
        [Description("Z1")]
        Z1 = -5,
        [Description("3")]
        A3 = -4,
        [Description("2")]
        A2 = -3,
        [Description("1")]
        A1 = -2,
        [Description("")]
        OnlyOneFinal = - 1,
        [Description("A")]
        A,
        [Description("B")]
        B,
        [Description("C")]
        C
    }
}
