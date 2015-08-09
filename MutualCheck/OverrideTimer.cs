using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualCheck
{
    public class OverrideTimer : System.Timers.Timer
    {

        private String  type;
        private String   station;
        private GetSnControl gc;
        private LineMaterialCheckControl lmcc;
        private S_BoxCheckControl sbc;
        private CheckMudleControl cmc;
        private PackageCheckControl pcc;
        private MudleOkOrNot moo;
        private MUC2012.Job2SystemTestData pn;

        public MudleOkOrNot Moo
        {
            set { moo = value; }
            get { return moo; }
        }
        public MUC2012.Job2SystemTestData Pn
        {
            get { return pn; }
            set { pn = value; }
        }
        public PackageCheckControl Pcc
        {
            set { pcc = value; }
            get { return pcc; }
        }
        public CheckMudleControl Cmc
        {
            set { cmc = value; }
            get { return cmc; }
        }
        public S_BoxCheckControl Sbc
        {
            set { sbc = value; }
            get { return sbc; }
        }
        public LineMaterialCheckControl Lmcc
        {
            set { lmcc = value; }
            get { return lmcc; }
        }
        public String  Type
        {
            get { return type; }
            set { type = value; }
        }

        public String  Station
        {
            set { station = value; }
            get { return station ; }
        }
        public GetSnControl Gc
        {
            set { gc = value; }
            get { return gc; }
        }
        public OverrideTimer()
            : base()
        {

        }


    }
}
