using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebChat.Models
{
    public enum ReturnResultTypes
    {
        [Description("操作成功")]
        Success =0,

        [Description("操作失败")]
        Error = 1,

        [Description("警告")]
        Warning = 2,

    }
}