using GrigStock.DataService;
using GrigStock.Model;

namespace GrigStock.Sercive
{
    internal class AuthService
    {
        public static bool Registration(User user)
        {
            try
            {
                using (UchetTovarovNaSkladeContext db = new UchetTovarovNaSkladeContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static User? Authorize(string login, string password)
        {
            using (UchetTovarovNaSkladeContext db = new UchetTovarovNaSkladeContext())
            {
                User[] users = db.Users.ToArray();
                foreach (User _user in users)
                {
                    if (_user.UserLogin == login && _user.UserPassword == password)
                    {
                        return _user;
                    }
                }
                return null;
            }
        }
    }
}
