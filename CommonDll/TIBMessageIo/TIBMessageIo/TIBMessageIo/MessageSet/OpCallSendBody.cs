﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TIBMessageIo.MessageSet
{
    
   
   public class OpCallSendBody
    {
       [XmlElement]
       public string MACHINENAME;

       [XmlElement]
       public string OPCALLDESCRIPTION;

       [XmlElement]
       public string TERMINALMESSAGE;

    }
}
