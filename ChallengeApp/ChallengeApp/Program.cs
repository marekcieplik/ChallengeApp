
using ChallengeApp;

User user1 = new User("user1", "1234");
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
