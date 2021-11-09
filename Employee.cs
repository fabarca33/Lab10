using System;
class Employee {

  private int age;
  private double yearlysalary;
  private int percent;
  private bool inactive;

  public string FirstName {get; set;}
  public string LastName {get; set;}
  public string Id {get; set;}
  public int Age {
  
    get{return age;}
    set{
      if(value >= 18)
      age = value;

      else if(value == 0)
      age = 0;
      
      else{
        age = 18;
      }
    }
  }
  
  public double YearlySalary {
    get{return yearlysalary;} 
    set{
      if(value >= 1000)
      yearlysalary = value;
      
      else{
        yearlysalary = 1000;
     }
    }
  }

  public string EmploymentStatus {get; set;}

  public int Percent {
    get{return percent;}
    set{
      if(value >= 0)
      percent = value;

      else{
        Console.WriteLine("Invalid input. Yearly Salary not updated");
      }
    }
  }

  public Employee(){
    FirstName = "Unknown";
    LastName = "Unknown";
    Id = "Unknown";
    Age = 0;
    EmploymentStatus = "active";
   
  }

  public Employee(string employeefirstname, string employeelastname, string employeeid, int employeeage, double employeeyearlysalary){

    FirstName = employeefirstname;
    LastName = employeelastname;
    Id = employeeid;
    Age = employeeage;
    EmploymentStatus = "active";
    YearlySalary = employeeyearlysalary;
    
  }

  public void Intro()
  {
    Console.WriteLine("First name: " +FirstName);
    Console.WriteLine("Last name: " +LastName);
    Console.WriteLine("Age: " +Age);   
    Console.WriteLine("Id: " +Id);
    Console.WriteLine("Yearly Salary: " +YearlySalary);

  }

  public void IncreaseSalary(int employeepercent)
  {
    Percent = employeepercent;
    
    double NewYearlySalary = YearlySalary+(YearlySalary*Percent/100);
    
    if(Percent > 0)
    Console.WriteLine("Yearly salary updated to " +NewYearlySalary);

    else{
    Console.WriteLine("Salary is " +YearlySalary);
    }

        
  }

  public void RemoveEmployee()
  {
   if(inactive)
   Console.WriteLine("Employee already inactive");
   

   else{
     EmploymentStatus = "inactive";

     Console.WriteLine("Employee removed succesfully!");
     inactive = true;
   }
  }

}