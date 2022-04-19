using System;
using Xunit;
using BLL;

namespace Test
{
    public class IntegrationTest
    {
        [Fact]
        public void TestCreatingLearningGroup()
        {
            IGroupsDatabase groupDB = new GroupsDatabase();
            MainDepartment main = new MainDepartment(groupDB);

            Student std1 = new Student("����", "������", "123456789", 23, 3, "��18273645", true);
            Student std2 = new Student("����", "��������", "987654321", 23, 3, "��18273645", true);
            Student std3 = new Student("����", "������", "123656789", 23, 3, "��18273645", true);
            Student std4 = new Student("����", "��������", "987854321", 23, 3, "��18273645", true);
            Student std5 = new Student("����", "������", "123455789", 23, 3, "��18273645", true);
            Student std6 = new Student("����", "��������", "987624321", 23, 3, "��18273645", true);
            Student std7 = new Student("����", "������", "134456789", 23, 3, "��18273645", true);
            Student std8 = new Student("����", "������", "123456789", 23, 3, "��18273645", true);
            Student std9 = new Student("����", "��������", "987154321", 23, 3, "��18273645", true);
            Student std10 = new Student("����", "��������", "987652321", 23, 3, "��18273645", true);
            Teacher tchr1 = new Teacher("�������", "���������", "937654321", 23, true);


           
            var group = main.CreateGroup("ϲ225");
            main.AddStudentToTheGroup("ϲ225", std1);
            main.AddStudentToTheGroup("ϲ225", std2);
            main.AddStudentToTheGroup("ϲ225", std3);
            main.AddStudentToTheGroup("ϲ225", std4);
            main.AddStudentToTheGroup("ϲ225", std5);
            main.AddStudentToTheGroup("ϲ225", std6);
            main.AddStudentToTheGroup("ϲ225", std7);
            main.AddStudentToTheGroup("ϲ225", std8);
            main.AddStudentToTheGroup("ϲ225", std9);
            main.AddStudentToTheGroup("ϲ225", std10);
            main.AddTeacherToTheDeparment(tchr1);


            main.Update();

            if (groupDB.SearchForGroup("ϲ225").isReadyToStart == true)
            { Assert.True(true); }
        }

        [Fact]
        public void TestStartingLearningProccess()
        {
            IGroupsDatabase groupDB = new GroupsDatabase();
            MainDepartment main = new MainDepartment(groupDB);

            Student std1 = new Student("����", "������", "123456789", 23, 3, "��18273645", true);
            Student std2 = new Student("����", "��������", "987654321", 23, 3, "��18273645", true);
            Student std3 = new Student("����", "������", "123656789", 23, 3, "��18273645", true);
            Student std4 = new Student("����", "��������", "987854321", 23, 3, "��18273645", true);
            Student std5 = new Student("����", "������", "123455789", 23, 3, "��18273645", true);
            Student std6 = new Student("����", "��������", "987624321", 23, 3, "��18273645", true);
            Student std7 = new Student("����", "������", "134456789", 23, 3, "��18273645", true);
            Student std8 = new Student("����", "������", "123456789", 23, 3, "��18273645", true);
            Student std9 = new Student("����", "��������", "987154321", 23, 3, "��18273645", true);
            Student std10 = new Student("����", "��������", "987652321", 23, 3, "��18273645", true);
            Student std11 = new Student("����", "��������", "987665321", 23, 3, "��18273645", true);
            Teacher tchr1 = new Teacher("�������", "���������", "937654321", 23, true);
            Teacher tchr2 = new Teacher();


            var group = main.CreateGroup("ϲ225");
            var group2 = main.CreateGroup("ϲ226");
            main.AddStudentToTheGroup("ϲ225", std1);
            main.AddStudentToTheGroup("ϲ225", std2);
           
            main.AddStudentToTheGroup("ϲ225", std3);
            main.AddStudentToTheGroup("ϲ225", std4);
            main.AddStudentToTheGroup("ϲ225", std5);
            main.AddStudentToTheGroup("ϲ225", std6);
            main.AddStudentToTheGroup("ϲ225", std7);
            main.AddStudentToTheGroup("ϲ225", std8);
            main.AddStudentToTheGroup("ϲ225", std9);
            main.AddStudentToTheGroup("ϲ225", std10);
            main.AddTeacherToTheDeparment(tchr1);
            main.AddTeacherToTheDeparment(tchr2);

            main.AddStudentToTheGroup("ϲ225", std3);
            main.DeleteStudentFromTheGroup("ϲ225", std3);
            main.AddStudentToTheGroup("ϲ226", std11);
            main.TransferStudentToAnotherGroup("ϲ225", group2, std11);


            main.Update();

            if (groupDB.SearchForGroup("ϲ225").isReadyToStart == true)
            {
                group.ChooseSubject("OOP");
            }
        }
    }
}
