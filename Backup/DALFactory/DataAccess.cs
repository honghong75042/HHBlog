using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.Configuration;


namespace Blogo.DALFactory
{
    public static class DataAccess
    {
        private static string path = ConfigurationManager.AppSettings["WebDAL"].ToString();

        public static Blogo.IDAL.IAuthor CreateAuthor()
        {
            return (Blogo.IDAL.IAuthor)Assembly.Load(path).CreateInstance(path + ".Author");
        }

        public static Blogo.IDAL.IBlogentrie CreateBlogentrie()
        {
            return (Blogo.IDAL.IBlogentrie)Assembly.Load(path).CreateInstance(path + ".Blogentrie");
        }

        public static Blogo.IDAL.IBlogotype CreateBlogotype()
        {
            return (Blogo.IDAL.IBlogotype)Assembly.Load(path).CreateInstance(path + ".Blogotype");
        }

        public static Blogo.IDAL.IComment CreateComment()
        {
            return (Blogo.IDAL.IComment)Assembly.Load(path).CreateInstance(path + ".Comment");
        }

        public static Blogo.IDAL.IFile CreateFile()
        {
            return (Blogo.IDAL.IFile)Assembly.Load(path).CreateInstance(path + ".File");
        }

        public static Blogo.IDAL.ILog CreateLog()
        {
            return (Blogo.IDAL.ILog)Assembly.Load(path).CreateInstance(path + ".Log");
        }

        public static Blogo.IDAL.IModel CreateModel()
        {
            return (Blogo.IDAL.IModel)Assembly.Load(path).CreateInstance(path + ".Model");
        }

        public static Blogo.IDAL.IPersonsetting CreatePersonsetting()
        {
            return (Blogo.IDAL.IPersonsetting)Assembly.Load(path).CreateInstance(path + ".Personsetting");
        }

        public static Blogo.IDAL.IRole CreateRole()
        {
            return (Blogo.IDAL.IRole)Assembly.Load(path).CreateInstance(path + ".Role");
        }
    }
}
