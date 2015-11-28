using RenCaiEX.Resumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenCaiEX.Users
{
    public class JobHunter: User
    {
        public virtual ICollection<Resume> ResumeList { get; set; }
    }
}
