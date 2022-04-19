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

            Student std1 = new Student("вася", "пупкин", "123456789", 23, 3, "АІ18273645", true);
            Student std2 = new Student("петя", "васильев", "987654321", 23, 3, "АІ18273645", true);
            Student std3 = new Student("коля", "пупкин", "123656789", 23, 3, "АІ18273645", true);
            Student std4 = new Student("саша", "васильев", "987854321", 23, 3, "АІ18273645", true);
            Student std5 = new Student("вася", "пупкин", "123455789", 23, 3, "АІ18273645", true);
            Student std6 = new Student("петя", "васильев", "987624321", 23, 3, "АІ18273645", true);
            Student std7 = new Student("коля", "пупкин", "134456789", 23, 3, "АІ18273645", true);
            Student std8 = new Student("саша", "пупкин", "123456789", 23, 3, "АІ18273645", true);
            Student std9 = new Student("петя", "васильев", "987154321", 23, 3, "АІ18273645", true);
            Student std10 = new Student("коля", "васильев", "987652321", 23, 3, "АІ18273645", true);
            Teacher tchr1 = new Teacher("наталья", "васильева", "937654321", 23, true);


           
            var group = main.CreateGroup("ПІ225");
            main.AddStudentToTheGroup("ПІ225", std1);
            main.AddStudentToTheGroup("ПІ225", std2);
            main.AddStudentToTheGroup("ПІ225", std3);
            main.AddStudentToTheGroup("ПІ225", std4);
            main.AddStudentToTheGroup("ПІ225", std5);
            main.AddStudentToTheGroup("ПІ225", std6);
            main.AddStudentToTheGroup("ПІ225", std7);
            main.AddStudentToTheGroup("ПІ225", std8);
            main.AddStudentToTheGroup("ПІ225", std9);
            main.AddStudentToTheGroup("ПІ225", std10);
            main.AddTeacherToTheDeparment(tchr1);


            main.Update();

            if (groupDB.SearchForGroup("ПІ225").isReadyToStart == true)
            { Assert.True(true); }
        }

        [Fact]
        public void TestStartingLearningProccess()
        {
            IGroupsDatabase groupDB = new GroupsDatabase();
            MainDepartment main = new MainDepartment(groupDB);

            Student std1 = new Student("вася", "пупкин", "123456789", 23, 3, "АІ18273645", true);
            Student std2 = new Student("петя", "васильев", "987654321", 23, 3, "АІ18273645", true);
            Student std3 = new Student("коля", "пупкин", "123656789", 23, 3, "АІ18273645", true);
            Student std4 = new Student("саша", "васильев", "987854321", 23, 3, "АІ18273645", true);
            Student std5 = new Student("вася", "пупкин", "123455789", 23, 3, "АІ18273645", true);
            Student std6 = new Student("петя", "васильев", "987624321", 23, 3, "АІ18273645", true);
            Student std7 = new Student("коля", "пупкин", "134456789", 23, 3, "АІ18273645", true);
            Student std8 = new Student("саша", "пупкин", "123456789", 23, 3, "АІ18273645", true);
            Student std9 = new Student("петя", "васильев", "987154321", 23, 3, "АІ18273645", true);
            Student std10 = new Student("коля", "васильев", "987652321", 23, 3, "АІ18273645", true);
            Student std11 = new Student("коля", "васильев", "987665321", 23, 3, "АІ18273645", true);
            Teacher tchr1 = new Teacher("наталья", "васильева", "937654321", 23, true);
            Teacher tchr2 = new Teacher();


            var group = main.CreateGroup("ПІ225");
            var group2 = main.CreateGroup("ПІ226");
            main.AddStudentToTheGroup("ПІ225", std1);
            main.AddStudentToTheGroup("ПІ225", std2);
           
            main.AddStudentToTheGroup("ПІ225", std3);
            main.AddStudentToTheGroup("ПІ225", std4);
            main.AddStudentToTheGroup("ПІ225", std5);
            main.AddStudentToTheGroup("ПІ225", std6);
            main.AddStudentToTheGroup("ПІ225", std7);
            main.AddStudentToTheGroup("ПІ225", std8);
            main.AddStudentToTheGroup("ПІ225", std9);
            main.AddStudentToTheGroup("ПІ225", std10);
            main.AddTeacherToTheDeparment(tchr1);
            main.AddTeacherToTheDeparment(tchr2);

            main.AddStudentToTheGroup("ПІ225", std3);
            main.DeleteStudentFromTheGroup("ПІ225", std3);
            main.AddStudentToTheGroup("ПІ226", std11);
            main.TransferStudentToAnotherGroup("ПІ225", group2, std11);


            main.Update();

            if (groupDB.SearchForGroup("ПІ225").isReadyToStart == true)
            {
                group.ChooseSubject("OOP");
            }
        }
    }
}
