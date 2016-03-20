using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ClassMarkerTesting.Utilities
{
    public static class UserUtils
    {
        public static List<ClassMarkerUser> Admins 
        {
            get
            {
                return GetUsers(Environment.CurrentDirectory + @"\Users\Admins.xml");
            }
        }

        public static List<ClassMarkerUser> Users
        {
            get
            {
                return GetUsers(Environment.CurrentDirectory + @"\Users\Users.xml");
            }
        }

        private static List<ClassMarkerUser> GetUsers(string xmlPath)
        {
            var users = new List<ClassMarkerUser>();
            using (var fileStream = new FileStream(xmlPath, FileMode.Open))
            {
                fileStream.Flush();
                var reader = new XmlTextReader(fileStream);
                while (reader.Read() && reader.Name != "users")
                {
                }

                while (reader.Read())
                {
                    var user = new ClassMarkerUser();
                    user.Login = reader.MoveToElementWithName("login").ReadInnerXml();
                    user.Password = reader.MoveToElementWithName("password").ReadInnerXml();
                    user.Email = reader.MoveToElementWithName("email").ReadInnerXml();
                    user.EmailPassword = reader.MoveToElementWithName("emailpassword").ReadInnerXml();
                    users.Add(user);
                    reader.Read();
                }
            }

            return users;
        } 
    }
}
