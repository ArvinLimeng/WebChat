using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebChat.Models;

namespace WebChat.Models
{
    public class ReturnResult
    {
        public ReturnResult(ReturnResultTypes returnResultType,string messgae)
        {
            returnResultType = ReturnResultType;
            messgae = Message;
        }
        public ReturnResultTypes  ReturnResultType { get; set; }

        public string Message { get; set; }
    }
}