using System;
using System.Collections.Generic;
using System.Text;
using WinSECS.structure;

namespace WinSECS
{
    public class S6F13_JOBDATACOLLECTION_LEVEL_COUNT_FIRST_COUNT
    {
        private ListFormat ownerList = new ListFormat();

		private String name1= "";
		private String value1= "";

        public S6F13_JOBDATACOLLECTION_LEVEL_COUNT_FIRST_COUNT(String name1, String value1)
        {
			this.name1 = name1;
			this.value1 = value1;

        }

        public ListFormat getMessage(bool isNoPadding)
        {
            ownerList.Length = 2;

			String[] sArray =  name1.Split(' ');
			if (isNoPadding)
				ownerList.add(AsciiFormat.TYPE, sArray.Length, "NAME1", name1);
			else
				ownerList.add(AsciiFormat.TYPE, 16, "NAME1", name1);
			sArray =  value1.Split(' ');
			if (isNoPadding)
				ownerList.add(AsciiFormat.TYPE, sArray.Length, "VALUE1", value1);
			else
				ownerList.add(AsciiFormat.TYPE, 16, "VALUE1", value1);

            return ownerList;
        }

    }
}