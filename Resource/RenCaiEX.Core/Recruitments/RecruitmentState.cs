using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenCaiEX.Recruitments
{
    public enum RecruitmentState : byte
    {
        //创建
        New=0,
        //未完成
        Incomplete=1,
        //已发布
        Published=2
    }
}
