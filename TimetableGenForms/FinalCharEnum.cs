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
