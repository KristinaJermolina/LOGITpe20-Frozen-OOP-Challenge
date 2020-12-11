using System;
using System.Collections.Generic;
using System.IO;

namespace FrozenOOPChallenge
{
    class Program
    {


        class Frozen
        {

            string character;
            string title;

            public Frozen(string _title, string _character)
            {
                character = _character;
                title = _title;
            }

            public string Character { get { return character; } }
            public string Title { get { return title; } }


        }

        class FrozenList
        {
            List<Frozen> frozens;


            public FrozenList()
            {
                frozens = new List<Frozen>();

            }

            public void AddFrozenToList(string title, string character)
            {
                Frozen newFrozen = new Frozen(title, character);
                frozens.Add(newFrozen);
            }

            public void PrintAllFrozen()
            {
                foreach (Frozen character in frozens)
                {
                    Console.WriteLine($"{character.Character} wants {character.Title} for  christmas");
                }

            }

        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"frozenI.txt";
            string fullFilePath = Path.Combine(filePath, fileName);

            //create an arry of records from file
            string[] linesFromfile = File.ReadAllLines(fullFilePath);

            //create a list of movies to store the movie objects from file
            FrozenList myFrozens = new FrozenList();
            foreach (string line in linesFromfile)
            {
                //split the line to get the movie data
                string[] tempArry = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string frozenTitle = tempArry[1];
                string frozenCharacter = tempArry[0];
                myFrozens.AddFrozenToList(frozenTitle, frozenCharacter);





            }
            myFrozens.PrintAllFrozen();
        }

    }

}
