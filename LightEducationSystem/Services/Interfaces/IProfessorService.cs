﻿using LightEducationSystem.Entities;
using LightEducationSystem.ViewModels;

namespace LightEducationSystem.Services.Interfaces
{
    public interface IProfessorService
    {
        public bool AddTrainingCourse(TrainingCourseViewModel trainingCourse, int professorId);
        public List<Student> GetStudentsOfTrainingCourse(int trainingCourseId);
        public bool RateStudent(int dtudentId);
    }
}
