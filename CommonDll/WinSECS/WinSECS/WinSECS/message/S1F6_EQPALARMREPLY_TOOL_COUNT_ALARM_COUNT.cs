using System;
using System.Collections.Generic;
using System.Text;
using WinSECS.structure;

namespace WinSECS
{
    public class S1F6_EQPALARMREPLY_TOOL_COUNT_ALARM_COUNT
    {
        private ListFormat ownerList = new ListFormat();

		private String alcd= "";
		private String alid= "";
		private String altx= "";
		private String altm= "";
		private String unitid= "";

        public S1F6_EQPALARMREPLY_TOOL_COUNT_ALARM_COUNT(String alcd, String alid, String altx, String altm, String unitid)
        {
			this.alcd = alcd;
			this.alid = alid;
			this.altx = altx;
			this.altm = altm;
			this.unitid = unitid;

        }

        public ListFormat getMessage(bool isNoPadding)
        {
            ownerList.Length = 5;

			String[] sArray =  alcd.Split(' ');
			if (isNoPadding)
				ownerList.add(BinaryFormat.TYPE, sArray.Length, "ALCD", alcd);
			else
				ownerList.add(BinaryFormat.TYPE, 1, "ALCD", alcd);
			sArray =  alid.Split(' ');
			if (isNoPadding)
				ownerList.add(Uint4Format.TYPE, sArray.Length, "ALID", alid);
			else
				ownerList.add(Uint4Format.TYPE, 1, "ALID", alid);
			if (isNoPadding)
				ownerList.add(AsciiFormat.TYPE, Encoding.GetEncoding("ks_c_5601-1987").GetBytes(altx).Length, "ALTX", altx);
			else
				ownerList.add(AsciiFormat.TYPE, 80, "ALTX", altx);
			if (isNoPadding)
				ownerList.add(AsciiFormat.TYPE, Encoding.GetEncoding("ks_c_5601-1987").GetBytes(altm).Length, "ALTM", altm);
			else
				ownerList.add(AsciiFormat.TYPE, 14, "ALTM", altm);
			if (isNoPadding)
				ownerList.add(AsciiFormat.TYPE, Encoding.GetEncoding("ks_c_5601-1987").GetBytes(unitid).Length, "UNITID", unitid);
			else
				ownerList.add(AsciiFormat.TYPE, 9, "UNITID", unitid);

            return ownerList;
        }

    }
}