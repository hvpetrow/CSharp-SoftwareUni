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
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
           .ToList();

            
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="course start")
                {
                    break;
                }

                string[] tokens = input.Split(":" , StringSplitOptions.RemoveEmptyEntries);
                bool isExrsThere = false;
                string command = tokens[0];
                string lessonTitle = tokens[1];
                bool isExisting = list.Contains(lessonTitle);

                if (command=="Add")
                {

                    if (isExisting==false)
                    {
                        list.Add(lessonTitle);
                    }

                }

               else if (command=="Insert")
                {
                    int insertIndex = int.Parse(tokens[2]);

                    if (isExisting==false)
                    {
                        list.Insert(insertIndex, lessonTitle);
                    }
                }
               else if (command=="Remove")
                {
                    bool exerciseExisting = list.Contains($"{lessonTitle}-{command}");

                    if (isExisting==true)
                    {
                        list.Remove(lessonTitle);
                    }
                    if (exerciseExisting==true)
                    {
                        list.Remove($"{lessonTitle}-{command}");
                    }
                }
                else if (command== "Swap" )
                {
                    int indexOfFirstLesson = list.IndexOf(lessonTitle);
                    string secondLessonTitle = tokens[2];
                    int indexOfSecondLesson = list.IndexOf(secondLessonTitle); 
                    string copyOfSecondTitle = secondLessonTitle;
                    bool isSecondLessonExisting = list.Contains(secondLessonTitle);
                    bool exerciseExisting = list.Contains($"{lessonTitle}-{command}");
                    int idxOfExer = list.IndexOf($"{lessonTitle}-{command}");


                    if (isExisting== true && isSecondLessonExisting == true)
                    {
                        list[indexOfFirstLesson] = secondLessonTitle;
                        list[indexOfSecondLesson] = lessonTitle;
                        if (isExrsThere == true)
                        {
                            list.Insert(indexOfSecondLesson + 1, $"{lessonTitle}-{command}");
                            list.RemoveAt(idxOfExer);
                        }
                        
                    }
                 
                    if (exerciseExisting == true)
                    {
                       
                        list.Insert(indexOfFirstLesson + 1, $"{lessonTitle}-{command}");
                       list.Remove($"{lessonTitle}-{command}");
                    }

                }
                else if (command == "Exercise")
                {
                    bool exerciseExisting = list.Contains($"{lessonTitle}-{command}");
                    int indexOfExercise = list.IndexOf(lessonTitle);
                    if (isExisting==true && exerciseExisting==true)
                    {
                        int indexToInsert = indexOfExercise + 1;
                        list.Insert(indexToInsert, $"{lessonTitle}-{command}");
                        isExrsThere = true;
                    }
                    else if (isExisting==false)
                    {
                        list.Add(lessonTitle);
                        list.Add($"{lessonTitle}-{command}");
                    }
                }
            }
            int counter = 0;  

            foreach (var item in list)
            {
                counter++;
                Console.WriteLine($"{counter}.{item}");
            }
        }
    }
}
