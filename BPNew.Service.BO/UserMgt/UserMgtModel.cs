using System;
using System.Collections.Generic;
using System.Text;

namespace BPNewBO.UserMgt
{
    public class UserMgtModel
    {

    }

    public class UserReadModel
    {
        public int CustomUserId { get; set; }
        public string UserName { get; set; }
        public byte ReadStatus { get; set; }
    }
}
