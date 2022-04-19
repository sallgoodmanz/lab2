using System;
using System.Text;
using BLL;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                IGroupsDatabase groupDB = new GroupsDatabase();
                
              
                Student std1 = new Student("вася", "пупкин", "123456789", 23, 3, "АІ18273645", true);
                Student std2 = new Student("петя", "васильев", "987654321", 23, 3, "АІ18273645", true);
                Teacher teacher = new Teacher("наталья", "васильева", "987654321", 23, true);


                MainDepartment main = new MainDepartment(groupDB);
                main.CreateGroup("ПІ225");
                main.AddStudentToTheGroup("ПІ225",std1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
