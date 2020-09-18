using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berättelse_del_2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStory();
            Console.ReadKey(true);
        }
        public static void AnimalInformation()
        {
            Djur hans = new Djur();
            hans.AnimalType = "Katt";
            hans.Name = "Hans";
            hans.BirthYear = 2005;
            hans.Age = Djur.CalculateAge(hans.BirthYear);
            hans.NumbersOfLegs = Djur.NumberOfLegs(2);
            hans.Fast = true;


        }
        public static void TellStory(Djur hans) 
        {
            AnimalInformation();
            StoryWriter(hans);
        }
        public static void StoryWriter(Djur hans)
        {
            Djur.BuildStory(hans);
        }

    }






    public class Djur
    {

        public string AnimalType { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int Age { get; set; }
        public int NumbersOfLegs { get; set; }
        public bool Fast { get; set; }

        
        public static int NumberOfLegs(int legs)
        {
            int lostLegs = 1;
            return legs - lostLegs;
        }
        public static int CalculateAge(int birthyear)
        {
            int year = DateTime.Now.Year;
            return year - birthyear;
        }
        public static void BuildStory(Djur cat)
        {
            string story = "Det var en gång en " + cat.Age + " år gammal " + cat.AnimalType + " som hette " + cat.Name + ".";
            story += " En dag var " + cat.Name + " ute på en promenad i skogen , och mötte en stor varg. Vargen bet av ett ben.";
            story += cat.Name + " sprang ";

            if (cat.Fast == true)
            {
                story += " snabbt";
            }
            else
            {
                story += " långsamt";
            }

            story += " hem på sina ben " + cat.NumbersOfLegs + ". Så var sagan slut!";
            Console.WriteLine(story);
        }
        










    }
 }
    

