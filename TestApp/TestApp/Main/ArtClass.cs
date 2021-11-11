using System;
using System.Collections.Generic;
using TestApp.Repository;

namespace TestApp.Drawers.Main
{
    public class ArtClass
    {
        private List<Drawer> students;
        private DrawerRepository repository;

        public ArtClass(int studentsCount)
        {
            repository = DrawerRepository.GetInstance(studentsCount);
        }

        public ArtClass()
        {
            repository = DrawerRepository.GetInstance();
        }

        public ArtClass InviteDrawers()
        {
            students = repository.GetDrawers();
            return this;
        }

        public void StartLesson()
        {
            foreach (var student in students)
            {
                student.Draw();
            }
        }

        public ArtClass AbsenceСheck()
        {
            if (students == null || students.Count == 0)
                throw new Exception("There are no students in the lesson");
            return this;
        }
    }
}
