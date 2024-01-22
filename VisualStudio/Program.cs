 System;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
    public int Age => DateTime.Now.Year - YearOfBirth;

   }  using


   class Program
  {  
      static void Main ()
     { 
        Console.Write()
        int n = int.Parse(Console.ReadLine());

        Person[] people = new Person[n];

        for (int i = 0,i < n;i++)
        {
            Console.WriteLine(i+1);
            Console.WriteLine(FirstName);
            string firstName = Console.ReadLine();


            






     