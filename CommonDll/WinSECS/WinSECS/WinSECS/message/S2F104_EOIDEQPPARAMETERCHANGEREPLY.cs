using System;
using System.Collections.Generic;
using System.Text;
using WinSECS.structure;

namespace WinSECS
{
    public class S2F104_EOIDEQPPARAMETERCHANGEREPLY
    {
        public static SECSTransaction makeTransaction(bool isNoPadding , List<S2F104_EOIDEQPPARAMETERCHANGEREPLY_TOOL_COUNT> tool_count)
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 104;

			ListFormat listNode_TOOL_COUNT = trx.add(ListFormat.TYPE, -1, "TOOL_COUNT", "") as ListFormat;
			if(tool_count != null)
			{
				foreach (S2F104_EOIDEQPPARAMETERCHANGEREPLY_TOOL_COUNT item in tool_count)
				{
					listNode_TOOL_COUNT.add(item.getMessage(isNoPadding));
				}
			}

            return trx;

        }
    }


}