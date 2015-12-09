using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.TtGen
{
    public enum ClassEnum
    {
        /// <summary>
        /// OR8 - Verbrenner Offroad 1:8 Buggy
        /// </summary>
        [Description("OR8")]
        Or8 = 0,
        /// <summary>
        /// ORT - Verbrenner Offroad 1:8 Truggy
        /// </summary>
        [Description("ORT")]
        Ort,
        /// <summary>
        /// ORE8 - Elektro Offroad 1:8 Buggy
        /// </summary>
        [Description("ORE8")]
        Ore8
    }
}
