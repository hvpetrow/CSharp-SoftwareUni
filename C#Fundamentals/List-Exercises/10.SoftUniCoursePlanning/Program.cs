using System;
using System.Collections.Generic;
using System.Linq;
namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
             .Split(", " , StringSplitOptions.RemoveEmptyEntries)
             .ToList();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "course start")
                {
                    break;
                }
                string[] line = Console.ReadLine()
                    .Split(":" , StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string theCommand = line[0];
                string lessonTitle = line[1];

                for (int i = 0; i < list.Count; i++)
                {
                    int counter = i;
                    bool isValid = true;
                    string currentIndex = list[i];
                    if (theCommand=="Add")
                    {
                        if (lessonTitle == currentIndex)
                        {
                            isValid = false;
                        }
                        if (isValid)
                        {
                            list.Add(lessonTitle);
                        }
                    }
                    else if (theCommand=="Insert")
                    {
                        int insertIndex = int.Parse(line[2]);

                        if (lessonTitle == currentIndex)
                        {
                            isValid = false;
                        }
                        if (isValid)
                        {
                            list.Insert(insertIndex,  lessonTitle);
                        }
                    }
                    else if (theCommand=="Remove")
                    {
                        if (lessonTitle==currentIndex)
                        {
                            list.Remove(currentIndex);
                        }

                    }
                    else if (theCommand=="Swap")
                    {
                        string toSwapLesson = line[2];
                        bool areTheExisting1 = true;
                        bool areTheExisting2 = true;
                        if (lessonTitle==currentIndex )
                        {
                            areTheExisting1 = false;
                        }
                        if (toSwapLesson == currentIndex)
                        {
                            areTheExisting2 = false;
                        }
                        if (areTheExisting1 && areTheExisting2)
                        {
                            int indexOfFirstLesson = list.IndexOf(lessonTitle);
                            int indexOfSecondLesson = list.IndexOf(toSwapLesson);
                            list[indexOfFirstLesson] = toSwapLesson; 
                            list[indexOfSecondLesson] = lessonTitle; 
                        }
                    }
                    else if (lessonTitle=="Exerscise")
                    {

                    }

                }

            }
        }
    }
}
