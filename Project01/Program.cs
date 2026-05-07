namespace Project01
{
 
    
    public class Employee
    {

        private int id;

        private decimal salary;
       
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
                else
                    throw new ArgumentException("ID must be greater than 0");
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative");
            }
        }

        public string Name { get; set; }
        public string Department { get; set; }

        // Constructors
        public Employee() { }

        public Employee(int id, string name, string department, decimal salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }

        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary:C}");
        }
    }

    // Derived class: Developer
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(int id, string name, string department, decimal salary, string programmingLanguage)
            : base(id, name, department, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void Work()
        {
            Console.WriteLine("Developer is writing code");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Developer, Language: {ProgrammingLanguage}");
        }
    }

    // Derived class: Designer
    public class Designer : Employee
    {
        public string DesignTool { get; set; }

        public Designer(int id, string name, string department, decimal salary, string designTool)
            : base(id, name, department, salary)
        {
            DesignTool = designTool;
        }

        public override void Work()
        {
            Console.WriteLine("Designer is creating UI designs");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Designer, Tool: {DesignTool}");
        }
    }

    //  Employee Type - Manager
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(int id, string name, string department, decimal salary, int teamSize)
            : base(id, name, department, salary)
        {
            TeamSize = teamSize;
        }

        public override void Work()
        {
            Console.WriteLine("Manager is leading the team");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Manager, Team Size: {TeamSize}");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Employee> employees = new List<Employee>();

            try
            {
                // Adding different derived types
                employees.Add(new Developer(1, "Alice", "IT", 75000, "C#"));
                employees.Add(new Designer(2, "Bob", "Design", 68000, "Figma"));
                employees.Add(new Manager(3, "Charlie", "Management", 95000, 5));

               
                Console.WriteLine("--- Work Methods ---");
                foreach (Employee emp in employees)
                {
                    emp.Work(); 
                }

                // Bonus: Display detailed info
                Console.WriteLine("\n--- Employee Details ---");
                foreach (Employee emp in employees)
                {
                    emp.DisplayInfo();
                    Console.WriteLine();
                }

                // Test encapsulation with invalid data
                Console.WriteLine("--- Testing Encapsulation (Invalid Data) ---");
                try
                {
                    Employee invalidEmployee = new Employee(-1, "Invalid", "HR", -5000);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
