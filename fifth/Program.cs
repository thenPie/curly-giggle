Console.Write("Input username: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") {
    Console.Write("Ура, это же Маша!");
}
else {
    Console.Write("Привет, " + username);
}