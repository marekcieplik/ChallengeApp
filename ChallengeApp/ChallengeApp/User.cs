namespace ChallengeApp
{
    public class User
    {
        public static int userQuantity = 0;  // zmienna statyczna
        private List<int> score = new List<int>();  //hermetyzacja: zbiera punkty,jednak wynik tylko jawny

        public User(string login)
        {
            this.Login = login;
        }

        public User(string login, string password)  //konstruktor
        {
            this.Login = login;
            this.Password = password;
            userQuantity += 1;
        }
        public string Login { get; private set; }  // pole jako propertis{get; set}
        public string Password { get; private set; }
        public int Result  // hermetyzacja: zbiera punkty,jednak wynik tylko jawny
        {
            get
            {
                return score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}
