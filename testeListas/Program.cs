using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace testeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //INSTANCIANDO LISTA 
                Console.Write("HOW MANY EMPLOYEES WILL BE REGISTERED? ");
                int employeesCount = int.Parse(Console.ReadLine());
                List<Employee> list = new List<Employee>();
                double salary = 0.0; int id = 0; string name = "";
                int idBonus = 0;

                //INICIO O ARMAZENAMENTO NA LISTA DE FUNCIONARIOS
                for (int i = 0; i < employeesCount; i++)
                {
                    Console.WriteLine($"\nEMPLOYEE #{i + 1}:");
                    Console.Write("Name: ");
                    name = (Console.ReadLine());
                    Console.Write("Id: ");
                    id = (int.Parse(Console.ReadLine()));
                    Console.Write("Salary: R$");
                    salary = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    list.Add(new Employee(id, name, salary));
                }

                //SELECIONANDO ID PARA AUMENTO DE SALARIO
                Console.Write("ENTER THE EMPLOYEE ID THAT WILL HAVE SALARY INCREASED: ");
                idBonus = int.Parse(Console.ReadLine());

                Console.Write("ENTER THE PERCENTAGE: ");
                double plusId = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //CHECANDO SE FUNCIONARIO EXISTE E IMPRIMINDO NO CONSOLE
                Employee emp = list.Find(x => x.Id == idBonus);

                if (emp != null)
                {
                    emp.Increase(plusId);
                }
                foreach (Employee obj in list)
                {
                    Console.WriteLine(obj);
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}