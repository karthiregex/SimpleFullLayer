using System;
using System.IO;

namespace RecapDemo
{
    //class 
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            karthi obj = new karthi();
            obj.Number1 = 45;

            Student sobj = new Student();
            sobj.MyProperty = 45;
            sobj.MyProperty2 = 55;

            FunctionDemo fObj = new FunctionDemo();
            fObj.GetDate5(sobj.MyProperty, sobj.MyProperty2);

            fObj.GetDate5(sobj);
        }
    }

    //Class created
    public class karthi
    {

        public int Number5 { get; set; }
        public int Number1 { get; set; } // expose Private variable to outer class


        public void User(int num1, int number2)
        {

            int result = 0;
            result = num1 + Number1;
        }

        public void FileUpload()
        {
            StreamReader fs = new StreamReader("");

            fs.ReadLine();
            //fs.EndOfStream = "";
            //fs.
        }
    }


    //Class

    //Method

    //Property

    //variable

    //object

    public class FunctionDemo
    {

        //method to read file - no return type
        //Return type - Void - no return, Int , string ,bool , object , interface

        public void FileUpload()
        {
          
        }

        public void jkdjksdh()
        {

        }
        //Method to return int - current dateGetDate

        public int GetDate()
        {
            return 0;
        }

        //object - it support all data types
        public object GetDate2()
        {
            object obj = new object();
            obj = "";
            obj = 9;
            obj = true;
            return obj;
        }

        //object - it support all data types
        public Student GetDate3()
        {
            Student obj = new Student();
           
            return obj;
        }

        public Student GetDate5(int studMark1, int studMark2)
        {
            Student obj = new Student();
            obj.MyProperty = studMark1;
            obj.MyProperty2 = studMark2;
            return obj;
        }

        public Student GetDate5(Student studMark1)
        {
            Student obj = new Student();
            obj = studMark1;
           int num4 = studMark1.MyProperty;
            return obj;
        }
    }

    public class Student
    {
        public int MyProperty { get; set; }

        public int MyProperty2 { get; set; }
    }
}
