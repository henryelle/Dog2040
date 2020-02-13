using System;
namespace Dog
{
    public class Dog
    {
        
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        public Dog(string dogname, string dogowner, int dogage, Gender doggender)
        {
            name = dogname;
            owner = dogowner;
            age = dogage;
            gender = doggender;

        }

        public static string GetPronoun1(Gender gender)
        {

            if (gender == Gender.Male)
                return "his";

            else
                return "her";

        }

        public void Bark(int number)
        {
            for (int i = 0; i <= number; i++)
                Console.WriteLine("Woof!");
        }

        public string GetTag()
        {
            string hisorher = GetPronoun1(gender).ToString();
            string heorshe;
            if (hisorher == "his")
            {
                heorshe = "he";
            }
            else
            {
                heorshe = "she";
            }

            string yearoryears;
            if (age == 1)
            {
                yearoryears = "year";
            }
            else
            {
                yearoryears = "years";
            }






            return "If lost, call " + owner + " " + hisorher + " name is " + name + " and " + heorshe + " is " + age + " " + yearoryears + " old";

        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
