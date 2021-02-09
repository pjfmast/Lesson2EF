using System.Collections.Generic;

namespace Lesson2.Models {
    public class Member {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Team Team { get; set; }
        public int TeamId { get; set; }

    }
}