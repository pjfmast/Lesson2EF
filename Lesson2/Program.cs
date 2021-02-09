using Lesson2.Models;
using Lesson2EF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Team management");
            using var teamsManagementContext = new TeamManagmentDBContext();

            teamsManagementContext.Members.Add(new Member { Name = "Jeroen", Email = "jeroen@breda.nl" });

            var memberList = new List<Member> {
                new Member { Name="Henk", Email = "Henk@breda.nl"},
                new Member { Name="Loes", Email = "Loes@avans.nl"},
            };

            teamsManagementContext.Members.AddRange(memberList);
            teamsManagementContext.SaveChanges();

            var selectedStudents = teamsManagementContext
                .Members
                .Where(member => member.Name.Contains("oe"))
                .OrderBy(member => member.Name)
                .ToList();

            foreach (var member in selectedStudents) {
                Console.WriteLine(member.Name);
            }

            Console.WriteLine("before update");
            Member before = teamsManagementContext.Members.FirstOrDefault(Member => Member.Name == "Henk");
            Console.WriteLine(before.Email);

            before.Email = "henk@gmail.nl";
            teamsManagementContext.SaveChanges();

            Console.WriteLine("after update");
            Member after = teamsManagementContext.Members.FirstOrDefault(Member => Member.Name == "Henk");
            Console.WriteLine(after.Email);

        }
    }
}
