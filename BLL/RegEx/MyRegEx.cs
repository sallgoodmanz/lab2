using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public static class MyRegEx
    {
        public static readonly Regex Name = new Regex("^[а-яА-ЯіїйЇІЙ]{0,20}$");

        public static readonly Regex Surname = new Regex("^[а-яА-ЯіїйЇІЙ]{0,20}$");

        public static readonly Regex PassportID = new Regex("[0-9]{9}");
        
        public static readonly Regex Age = new Regex("[0-9]{0,3}$");

        public static readonly Regex StudentTicket = new Regex("^[A-Я ІЇЙ]{2}[0-9]{8}$");

        public static readonly Regex GroupName = new Regex("^[A-Я ІЇЙ]{2}[0-9]{3}$");

        public static readonly Regex YearOfStudy = new Regex("[1-6]{1}");
    }
}
