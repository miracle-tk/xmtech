using System;
using System.Collections.Generic;
using System.Text;
using WinSECS.structure;

namespace WinSECS
{
    public class S7F104_RMSPPIDEXISTENCEREPLY
    {
        public static SECSTransaction makeTransaction(bool isNoPadding , List<S7F104_RMSPPIDEXISTENCEREPLY_PPID_COUNT> ppid_count)
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 104;

			ListFormat listNode_PPID_COUNT = trx.add(ListFormat.TYPE, -1, "PPID_COUNT", "") as ListFormat;
			if(ppid_count != null)
			{
				foreach (S7F104_RMSPPIDEXISTENCEREPLY_PPID_COUNT item in ppid_count)
				{
					listNode_PPID_COUNT.add(item.getMessage(isNoPadding));
				}
			}

            return trx;

        }
    }


}