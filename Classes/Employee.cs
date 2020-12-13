using System;

namespace EmployeesListSearch_Polymorphism_Overload.Classes
{
    public class Employee
    {
     
     public string[] list = {"Felipe", "Paulo", "Tsukamoto", "Thiago", "Roger", "Hamilton"};   
               
    
        public void Show() {

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


        public void Show(int index) {

            Console.WriteLine("Search for index: " + list[index] );

        }


        public void Show(string search) {


            foreach (var item in list)
            {
                
                if (item == search) {

                    Console.WriteLine("Search result: " + item);
                    
                }
            
            }

            Console.WriteLine("Search result: name not found");
                 
        }
    
    
    }
}




