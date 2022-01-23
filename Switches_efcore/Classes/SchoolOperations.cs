using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Switches.Data;
using Switches.Models;

// ReSharper disable once CheckNamespace - DO NOT change
namespace Switches.Classes
{
#nullable enable
    public class SchoolOperations
    {
        public delegate void OnIteratePersonGrades(PersonGrades personData);
        public static event OnIteratePersonGrades? OnIteratePersonGradesEvent;

        /// <summary>
        /// Get students in a course by course identifier, better solution
        /// then in StudentsForCourse as there is only one condition
        /// </summary>
        /// <param name="courseIdentifier"></param>
        public async static Task<List<StudentEntity>> GradesForPeople(int courseIdentifier = 2021)
        {
            
            using var context = new SchoolContext();
            
            List<StudentEntity> studentEntities = await context
                .StudentGrade
                .Include(studentEntity => studentEntity.Student)
                .Select(StudentGrade.Projection)
                .Where(studentEntity => studentEntity.CourseID == courseIdentifier)
                .ToListAsync();

            foreach (var entity in studentEntities)
            {
                var letterGrade = entity.Grade.Value switch
                {
                    >= 1.00m and <= 2.00m => "F",
                    2.50m => "C",
                    3.00m => "B",
                    3.50m => "A",
                    4.00m => "A+",
                    _ => "unknown",
                };

                OnIteratePersonGradesEvent?.Invoke(new PersonGrades()
                {
                    PersonID = entity.PersonID,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Grade = entity.Grade,
                    GradeLetter = letterGrade
                });

            }

            return studentEntities;
            
        }
        
    }
}
