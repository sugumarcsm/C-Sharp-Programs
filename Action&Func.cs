using System;


{
    internal class AnonymsExample
    {
        static void Main(string[] args)
        {
            // ---------- Action Example ----------
            Action<string, int> act = (name, age) =>
                Console.WriteLine($"Name: {name}, Age: {age}");

            act("Sugumar", 22);
            act("Sathish", 21);


            // ---------- Func Example ----------
            int StuId = 1;
            string Name = "Sugumar";
            string Password = "sugu@2004";

            // Func with three input parameters and string return
            Func<int, string, string, string> validateUser = (id, name, pass) =>
            {
                if (id == StuId)
                {
                    if (Name.Equals(name))
                    {
                        if (Password.Equals(pass))
                            return " Login Successful";
                        else
                            return " Password Incorrect";
                    }
                    else
                    {
                        return " Username Incorrect";
                    }
                }
                else
                {
                    return " Student ID Incorrect";
                }
            };

            // Call Func delegate
            string result1 = validateUser(1, "Sugumar", "sugu@2004");
            Console.WriteLine(result1);

            string result2 = validateUser(1, "Sathish", "wrong");
            Console.WriteLine(result2);
        }
    }

