using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Models {
    public interface ITeamRepository {
        ICollection<Team> AllTeams { get; }
    }
}
