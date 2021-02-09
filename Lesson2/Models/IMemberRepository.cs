using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Models {
    interface IMemberRepository {
        ICollection<Member> AllMembers();
    }
}
