
namespace LibProyectoPII
{
    public class Logueo
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Logueo(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
