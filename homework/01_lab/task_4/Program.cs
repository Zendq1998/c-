using System;
/*
 * 提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”，并且密码是“888888”，则提示正确，否则如果用户名不是admin提示用户不存在，如果是但是密码错误则提示密码错误。
 */
namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            Console.Write("Please enter your username:");
            while(true) {
                username = Console.ReadLine();
                if (username == "admin") {
                    Console.Write("Please enter your password:");
                    while(true) {
                        password = Console.ReadLine();
                        if (password == "888888") {
                            Console.WriteLine("Login success!");
                            break;
                        }
                        else {
                            Console.Write("Password error! Please enter again:");
                        }
                    }
                    break;
                }
                else {
                    Console.Write("The username doesn't exist! Please enter again:");
                }
            }
        }
    }
}
