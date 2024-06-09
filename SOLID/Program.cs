namespace SOLID
{
    class Program
    {
        // Такий клас порушує Single responsibility 
        public class Invoice
        {
            public int Id { get; set; }
            public int SumOfInvoice { get; set; }
            public void CalculateTotal()
            {
                // Логика расчета общей суммы счета
            }

            public void PrintInvoice()
            {
                // Логика печати счета
            }

            public void SaveToDatabase()
            {
                // Логика сохранения счета в базу данных
            }
        }
        // Як пофіксити? Поділемо його на інші класи!
        public class InvoiceCalculator
        {
            public void CalculateTotal(Invoice invoice)
            {
                // Логика расчета общей суммы счета
            }
        }

        public class InvoicePrinter
        {
            public void PrintInvoice(Invoice invoice)
            {
                // Логика печати счета
            }
        }

        public class InvoiceRepository
        {
            public void SaveToDatabase(Invoice invoice)
            {
                // Логика сохранения счета в базу данных
            }
        }

        // Open-Closed
/*        class Cook
        {
            public string Name { get; set; }
            public Cook(string name)
            {
                this.Name = name;
            }

            public void MakeDinner()
            {
                Console.WriteLine("Чистим картошку");
                Console.WriteLine("Ставим почищенную картошку на огонь");
                Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
                Console.WriteLine("Посыпаем пюре специями и зеленью");
                Console.WriteLine("Картофельное пюре готово");
            }
        }
*/
        class Cook
        {
            public string Name { get; set; }

            public Cook(string name)
            {
                this.Name = name;
            }

            public void MakeDinner(IMeal meal)
            {
                meal.Make();
            }
        }

        interface IMeal
        {
            void Make();
        }
        class PotatoMeal : IMeal
        {
            public void Make()
            {
                Console.WriteLine("Чистим картошку");
                Console.WriteLine("Ставим почищенную картошку на огонь");
                Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
                Console.WriteLine("Посыпаем пюре специями и зеленью");
                Console.WriteLine("Картофельное пюре готово");
            }
        }
        class SaladMeal : IMeal
        {
            public void Make()
            {
                Console.WriteLine("Нарезаем помидоры и огурцы");
                Console.WriteLine("Посыпаем зеленью, солью и специями");
                Console.WriteLine("Поливаем подсолнечным маслом");
                Console.WriteLine("Салат готов");
            }
        }

        // The Liskov Substitution Principle
        class Vehicle
        {
            public virtual void Park()
            {
                Console.WriteLine("Parking the vehicle");
            }
        }

        class Car : Vehicle
        {
            public override void Park()
            {
                Console.WriteLine("Parking the car");
            }
        }

        class Motorcycle : Vehicle
        {
            public override void Park()
            {
                Console.WriteLine("Parking the motorcycle");
            }
        }

        class Truck : Vehicle
        {
            public override void Park()
            {
                Console.WriteLine("Parking the truck");
            }
        }

        class ParkingLot
        {
            public void ParkVehicle(Vehicle vehicle)
            {
                vehicle.Park();
            }
        }

        // Interface segregation 
        public interface IWorker
        {
            void Work();
            void Eat();
            void Sleep();
        }

        public class HumanWorker : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Human working...");
            }

            public void Eat()
            {
                Console.WriteLine("Human eating...");
            }

            public void Sleep()
            {
                Console.WriteLine("Human sleeping...");
            }
        }

        public class RobotWorker : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot working..");
            }

            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Sleep()
            {
                throw new NotImplementedException();
            }
        }

        // Dependency Inversion Principle

        /*class Book
        {
            public string Text { get; set; }
            public ConsolePrinter Printer { get; set; }

            public void Print()
            {
                Printer.Print(Text);
            }
        }

        class ConsolePrinter
        {
            public void Print(string text)
            {
                Console.WriteLine(text);
            }
        }*/

        interface IPrinter
        {
            void Print(string text);
        }

        class Book
        {
            public string Text { get; set; }
            public IPrinter Printer { get; set; }

            public Book(IPrinter printer)
            {
                this.Printer = printer;
            }

            public void Print()
            {
                Printer.Print(Text);
            }
        }

        class ConsolePrinter : IPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine("Печать на консоли");
            }
        }

        class HtmlPrinter : IPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine("Печать в html");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
