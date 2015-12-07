using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.TtGen
{
    public enum FinalNameEnum
    {
        [Description("Finale")]
        Finale = 0,
        [Description("1/2 Finale")]
        Finale_1_2,
        [Description("1/4 Finale")]
        Finale_1_4,
        [Description("1/8 Finale")]
        Finale_1_8,
        [Description("1/16 Finale")]
        Finale_1_16,
        [Description("1/32 Finale")]
        Finale_1_32,
        [Description("1/64 Finale")]
        Finale_1_64,
        [Description("1/128 Finale")]
        Finale_1_128,
    }
}
