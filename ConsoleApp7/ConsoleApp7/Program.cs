using System;
using System.IO;

namespace ConsoleApp7
{
    class Student
    {
        string id, name, uni, dept,path1,path2;
        float gpa;
        int sem;
        public void getPath(string p1, string p2)
        {
            path1 = p1;
            path2 = p2;
            
        }
        public void createAStudent()
        {
            Console.WriteLine("ID :");
            id = Console.ReadLine();
            Console.WriteLine("Name :");
            name = Console.ReadLine(); 
            Console.WriteLine("University :");
            uni = Console.ReadLine();
            Console.WriteLine("Department :");
            dept = Console.ReadLine();
            Console.WriteLine("GPA :");
            gpa =Convert.ToSingle( Console.ReadLine());
            Console.WriteLine("Semester :");
            sem =Convert.ToInt32( Console.ReadLine());


            using(StreamWriter sw =new StreamWriter(path1,true))
            {
                sw.WriteLine(id);
                sw.WriteLine(name);
                sw.WriteLine(uni);
                sw.WriteLine(dept);
                sw.WriteLine(gpa);
                sw.WriteLine(sem);

            }
            Console.WriteLine("File Written Successfully");
        }
        public void searchByID(string ID)
        {
            int lines=File.ReadAllLines(path1).Length;
            string[] id = new string[lines / 6];
            string[] uni = new string[lines / 6];
            string[] dept = new string[lines / 6];
            string[] name = new string[lines / 6];
            int[] sem = new int[lines / 6];
            float[] gpa = new float[lines / 6];

            using(StreamReader sr=new StreamReader(path1))
            {
                for(int i=0;i<lines/6;i++)
                {
                    //Console.WriteLine(id);
                    //Console.WriteLine(name);
                    //Console.WriteLine(uni);
                    //Console.WriteLine(dept);
                    //Console.WriteLine(gpa);
                    //Console.WriteLine(sem);
                    id[i] = sr.ReadLine();
                    name[i] = sr.ReadLine();
                    uni[i] = sr.ReadLine();
                    dept[i] = sr.ReadLine();
                    gpa[i] =Convert.ToSingle( sr.ReadLine());
                    sem[i] =Convert.ToInt32( sr.ReadLine());

                }
            }
            bool check = false;
            for (int i = 0; i < lines / 6;i++)
            {
                if(id[i]==ID)
                {
                    Console.WriteLine("FIle FOund");
                    Console.WriteLine(id[i]);
                    Console.WriteLine(name[i]);
                    Console.WriteLine(uni[i]);
                    Console.WriteLine(dept[i]);
                    Console.WriteLine(gpa[i]);
                    Console.WriteLine(sem[i]);
                    check = true;
                }
            }
            if(check==false)
            {
                Console.WriteLine("File could not be found");
            }
        }
        public void searchByName(string nam)
        {
            int lines = File.ReadAllLines(path1).Length;
            string[] id = new string[lines / 6];
            string[] uni = new string[lines / 6];
            string[] dept = new string[lines / 6];
            string[] name = new string[lines / 6];
            int[] sem = new int[lines / 6];
            float[] gpa = new float[lines / 6];

            using (StreamReader sr = new StreamReader(path1))
            {
                for (int i = 0; i < lines / 6; i++)
                {
                    //Console.WriteLine(id);
                    //Console.WriteLine(name);
                    //Console.WriteLine(uni);
                    //Console.WriteLine(dept);
                    //Console.WriteLine(gpa);
                    //Console.WriteLine(sem);
                    id[i] = sr.ReadLine();
                    name[i] = sr.ReadLine();
                    uni[i] = sr.ReadLine();
                    dept[i] = sr.ReadLine();
                    gpa[i] = Convert.ToSingle(sr.ReadLine());
                    sem[i] = Convert.ToInt32(sr.ReadLine());

                }
            }
            bool check = false;
            for (int i = 0; i < lines / 6; i++)
            {
                if (name[i] ==nam)
                {
                    Console.WriteLine("FIle FOund");
                    Console.WriteLine(id[i]);
                    Console.WriteLine(name[i]);
                    Console.WriteLine(uni[i]);
                    Console.WriteLine(dept[i]);
                    Console.WriteLine(gpa[i]);
                    Console.WriteLine(sem[i]);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("File could not be found");
            }
        }

        public void searchAll()
        {

            //  Student ID(Unique)
            //- Student Name
            //- Semseter
            //- CGPA
            //- Department
            //- University
            var lineCount = File.ReadAllLines(path1).Length;
            string[] id1 = new string[lineCount / 6];
            string[] name1 = new string[lineCount / 6];
            string[] semester1 = new string[lineCount / 6];
            string[] dept = new string[lineCount / 6];
            string[] university = new string[lineCount / 6];
            float[] cgpa = new float[lineCount / 6];

            using (StreamReader sw = new StreamReader(path1))
            {
                for (int i = 0; i < lineCount / 6; i++)
                {
                    if (i == 0 || (lineCount % 6 == 0))
                    {
                        //Console.WriteLine(id);
                        //Console.WriteLine(name);
                        //Console.WriteLine(uni);
                        //Console.WriteLine(dept);
                        //Console.WriteLine(gpa);
                        //Console.WriteLine(sem);
                        id1[i] = sw.ReadLine();
                        name1[i] = sw.ReadLine();
                        university[i] = sw.ReadLine();
                        dept[i] = sw.ReadLine();
                        cgpa[i] = float.Parse(sw.ReadLine());
                        semester1[i] = sw.ReadLine();

                    }
                }
            }

            for (int i = 0; i < lineCount / 6; i++)
            {


                Console.WriteLine("Complete data of student is following\n\n");
                Console.WriteLine($"Stuent #{i + 1}");
                Console.WriteLine($"ID :{id1[i]}");
                Console.WriteLine($"Name :{name1[i]}");
                Console.WriteLine($"Department :{dept[i]}");
                Console.WriteLine($"University :{university[i]}");
                Console.WriteLine($"Semester :{semester1[i]}");
                Console.WriteLine($"CGPA :{cgpa[i]}");

            }


        }

      
        public void delete(string ID)
        {
            var lineCount = File.ReadAllLines(path1).Length;
            string[] id1 = new string[lineCount / 6];
            string[] name1 = new string[lineCount / 6];
            int[] semester1 = new int[lineCount / 6];
            string[] dept = new string[lineCount / 6];
            string[] university = new string[lineCount / 6];
            float[] cgpa = new float[lineCount / 6];

            using (StreamReader sw = new StreamReader(path1))
            {
                for (int i = 0; i < lineCount / 6; i++)
                {
                    if (i == 0 || (lineCount % 6 == 0))
                    {
                        id1[i] = sw.ReadLine();
                        name1[i] = sw.ReadLine();
                        university[i] = sw.ReadLine();
                        dept[i] = sw.ReadLine();
                        cgpa[i] = float.Parse(sw.ReadLine());
                        semester1[i] = Convert.ToInt32(sw.ReadLine());

                    }
                }
            }
            bool check = false;
            for (int i = 0; i < lineCount / 6; i++)
            {
                if (id1[i] == ID)
                {
                    id1[i] = null;


                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Name not found");
            }
            //string[] id1 = new string[lineCount / 6];
            //string[] name1 = new string[lineCount / 6];
            //int[] semester1 = new int[lineCount / 6];
            //string[] dept = new string[lineCount / 6];
            //string[] university = new string[lineCount / 6];
            //float[] cgpa = new float[lineCount / 6];
            else
            {
                File.WriteAllText(path1, String.Empty);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path1, true))
                {
                    for (int i = 0; i < lineCount / 6; i++)
                        if (id1[i] == null)
                        {

                        }
                        else
                        {


                            file.WriteLine(id1[i]);
                            file.WriteLine(name1[i]);
                            file.WriteLine(dept[i]);
                            file.WriteLine(university[i]);
                            file.WriteLine(Convert.ToString(semester1[i]));
                            file.WriteLine(Convert.ToString(cgpa[i]));
                        }

                }

                Console.WriteLine("\nData Deleted Successfuly\n");
            }


        }
        public void top3()
        {
            var lineCount = File.ReadAllLines(path1).Length;
            string[] id1 = new string[lineCount / 6];
            string[] name1 = new string[lineCount / 6];
            int[] semester1 = new int[lineCount / 6];
            string[] dept = new string[lineCount / 6];
            string[] university = new string[lineCount / 6];
            float[] cgpa = new float[lineCount / 6];

            using (StreamReader sw = new StreamReader(path1))
            {
                for (int i = 0; i < lineCount / 6; i++)
                {
                    if (i == 0 || (lineCount % 6 == 0))
                    {
                        //sw.WriteLine(id);
                        //sw.WriteLine(name);
                        //sw.WriteLine(uni);
                        //sw.WriteLine(dept);
                        //sw.WriteLine(gpa);
                        //sw.WriteLine(sem);
                        id1[i] = sw.ReadLine();
                        name1[i] = sw.ReadLine();
                        university[i] = sw.ReadLine();
                        dept[i] = sw.ReadLine();
                        cgpa[i] = float.Parse(sw.ReadLine());
                        semester1[i] = Convert.ToInt32(sw.ReadLine());

                    }
                }
            }



            for (int i = 0; i < lineCount / 6; i++)
            {

                for (int j = 0; j < lineCount; j++)
                {
                    if (cgpa[i] > cgpa[i])
                    {
                        float tem = 0;


                        tem = cgpa[i];
                        cgpa[i] = cgpa[j];
                        cgpa[j] = cgpa[i];

                        string temp;
                        temp = name1[i];
                        name1[i] = name1[j];
                        name1[j] = name1[i];

                        temp = dept[i];
                        dept[i] = dept[j];
                        dept[j] = dept[i];

                        temp = university[i];
                        university[i] = university[j];
                        university[j] = university[i];

                        temp = id1[i];
                        id1[i] = id1[j];
                        id1[j] = id1[i];


                        int temp1;
                        temp1 = semester1[i];
                        semester1[i] = semester1[j];
                        semester1[j] = semester1[i];



                    }
                }



                Console.WriteLine("Complete data of student is following\n\n");


                Console.WriteLine($"Stuent # {0}");
                Console.WriteLine($"ID :{id1[0]}");
                Console.WriteLine($"Name :{name1[0]}");
                Console.WriteLine($"Department :{dept[0]}");
                Console.WriteLine($"University :{university[0]}");
                Console.WriteLine($"Semester :{semester1[0]}");
                Console.WriteLine($"CGPA :{cgpa[0]}");


                Console.WriteLine($"Stuent #{1}");
                Console.WriteLine($"ID :{id1[1]}");
                Console.WriteLine($"Name :{name1[1]}");
                Console.WriteLine($"Department :{dept[1]}");
                Console.WriteLine($"University :{university[1]}");
                Console.WriteLine($"Semester :{semester1[1]}");
                Console.WriteLine($"CGPA :{cgpa[1]}");


                Console.WriteLine($"Stuent #{2}");
                Console.WriteLine($"ID :{id1[2]}");
                Console.WriteLine($"Name :{name1[2]}");
                Console.WriteLine($"Department :{dept[2]}");
                Console.WriteLine($"University :{university[2]}");
                Console.WriteLine($"Semester :{semester1[2]}");
                Console.WriteLine($"CGPA :{cgpa[2]}");

            }

        }
        public void markAttend()
        {
            var lineCount = File.ReadAllLines(path1).Length;
            int numberOfStudent = lineCount / 6;
            string[] id1 = new string[lineCount / 6];
            string[] name1 = new string[lineCount / 6];
            int[] semester1 = new int[lineCount / 6];
            string[] dept = new string[lineCount / 6];
            string[] university = new string[lineCount / 6];
            float[] cgpa = new float[lineCount / 6];

            using (StreamReader sw = new StreamReader(path1))
            {
                for (int i = 0; i < lineCount / 6; i++)
                {
                    if (i == 0 || (lineCount % 6 == 0))
                    {
                        id1[i] = sw.ReadLine();
                        name1[i] = sw.ReadLine();
                        dept[i] = sw.ReadLine();
                        university[i] = sw.ReadLine();
                        semester1[i] = Convert.ToInt32(sw.ReadLine());
                        cgpa[i] = float.Parse(sw.ReadLine());

                    }
                }
            }
            File.WriteAllText(path2, String.Empty);
            Console.WriteLine("Enter Present/Absent for Student\n\n");
            string[] presence = new string[lineCount / 6];
            Console.WriteLine("Name\tAttendance");

            for (int i = 0; i < lineCount / 6; i++)
            {



                Console.WriteLine($"Name :{name1[i]}");
                presence[i] = Convert.ToString(Console.ReadLine());


                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path2, true))
                {
                    file.WriteLine($"{name1[i]}\t{presence[i]}");

                }

            }
            Console.WriteLine("Data Written Successfully for attendance\n");


        }
        public void viewAttend()
        {
            var lineCount = File.ReadAllLines(path2).Length;
            string[] atend = new string[lineCount];


            using (StreamReader sw = new StreamReader(path2))
            {
                for (int i = 0; i < lineCount; i++)
                {

                    atend[i] = sw.ReadLine();


                }
            }

            Console.WriteLine("Complete data of student is following\n\n");
            for (int i = 0; i < lineCount; i++)
            {


                Console.WriteLine($"Stuent #{i + 1}");
                Console.WriteLine($"{atend[i]}");


            }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Student obj = new Student();
                obj.getPath(args[0], args[1]);
            Console.WriteLine("Press\n");
            Console.WriteLine("1. Create Student Profile");
            Console.WriteLine("2.Search a Student");
            Console.WriteLine("3.Delete a Student");
            Console.WriteLine("4.Display top-3 Student");
            Console.WriteLine("5.Mark Attendance");
            Console.WriteLine("6.View Attendance");
            Console.WriteLine("7. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            obj.createAStudent();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Search By\n1.ID\n2.Name\n3.Search All");
                            int choice1 = Convert.ToInt32(Console.ReadLine());
                            if(choice1==1)
                            {
                                Console.WriteLine("Enter id to search");
                                string id = Console.ReadLine();
                                obj.searchByID(id);
                            }
                            else if(choice1==2)
                            {
                                Console.WriteLine("Enter name to find :");
                                string nam=Console.ReadLine();
                                obj.searchByName(nam);
                            }
                            else if(choice1==3)
                            {
                                obj.searchAll();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Id to delete\n");
                            string id = Console.ReadLine();
                            obj.delete(id);
                            break;
                        }
                    case 4:
                        {
                            obj.top3();
                            break;
                        }
                    case 5:
                        {
                            obj.markAttend();
                            break;
                        }
                    case 6:
                        {
                            obj.viewAttend();
                            break;
                        }
                    case 7:
                        {
                            System.Environment.Exit(1);
                            break;
                        }
                }


            }

        }
    }
}
