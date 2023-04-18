using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();           

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(":");
                switch (command[0])
                {
                    case "Add":
                        AddMethod(courses, command[1]);
                        break;
                    case "Insert":
                        InsertMethod(courses, command[1], command[2]);
                        break;
                    case "Remove":
                        RemoveMethod(courses, command[1]);
                        break;
                    case "Swap":
                        SwapMethod(courses, command[1], command[2]);
                        break;
                    case "Exercise":
                        ExerciseMethod(courses, command[1]);
                        break;
                }

                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var item in courses)
            {
                Console.WriteLine($"{count}.{item}");
                count++;
            }
        }

        private static void ExerciseMethod(List<string> courses, string v)
        {
            string exerciseString = $"{v}-Exercise";

            bool flag = false;
            bool flag2 = false;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == exerciseString)
                {
                    flag = true;
                }
            }
            int index = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == v)
                {
                    flag2= true;
                    index = i;
                }
            }
            if (flag)
            {              
                return;
            }
            else if (flag2 && !flag)
            {
                if (index + 1 > courses.Count - 1)
                {
                    courses.Add(exerciseString);
                }
                else
                {
                 courses.Insert(index + 1, exerciseString);
                }           
            }
            else
            {
                courses.Add(v);
                courses.Add(exerciseString);                
            }
        }

        static void AddMethod(List<string> courses, string v)
        {
            bool flag = false;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == v)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                return;
            }
            else
            {
                courses.Add(v);
            }
        }

        private static void InsertMethod(List<string> courses, string v1, string v2)
        {

            int index = int.Parse(v2);
            bool flag = false;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == v1)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                return;
            }
            else
            {
                courses.Insert(index, v1);
            }
        }

        private static void RemoveMethod(List<string> courses, string v)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == v)
                {
                    if (i + 1 <= courses.Count - 1)
                    {
                        if (courses[i + 1] == $"{v}-Exercise")
                        {
                            courses.RemoveAt(i + 1);
                        }
                    }
                    courses.RemoveAt(i);
                }
            }

        }

        private static void SwapMethod(List<string> courses, string v1, string v2)
        {
            bool flag = false;
            bool flag2 = false;           
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == v1)
                {                               
                    flag = true;
                    index1 = i;
                }
            }

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == v2)
                {                   

                    flag2 = true;
                    index2 = i;
                }
            }

            if (flag && flag2)
            {
                courses[index1] = v2;             
                courses[index2] = v1;
                if (index1 + 1 <= courses.Count - 1)
                {
                    if (courses[index1 + 1] == $"{v1}-Exercise")
                    {
                        courses.RemoveAt(index1 + 1);
                        index1 = courses.IndexOf(v1);
                        courses.Insert(index1 + 1, $"{v1}-Exercise");
                    }
                }
                if (index2 + 1 <= courses.Count - 1)
                {
                    if (courses[index2 + 1] == $"{v2}-Exercise")
                    {
                        courses.RemoveAt(index2 + 1);
                        index2 = courses.IndexOf(v2);
                        courses.Insert(index2 + 1, $"{v2}-Exercise");
                    }
                }

            }
           
        }
    }
}
