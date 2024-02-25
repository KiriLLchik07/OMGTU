

using System;
using System.Threading.Channels;
class Univercity
{
    public int count_of_place { get; set; }
    public int level { get; set; }
    public bool projector { get; set; }
    public int number_of_classroom { get; set; }
    public bool computers { get; set; }

    public Univercity(int count_of_place, int level, bool projector, int number_of_classroom, bool computers)
    {
        this.count_of_place = count_of_place;
        this.level = level;
        this.projector = projector;
        this.number_of_classroom = number_of_classroom;
        this.computers = computers;
    }
    public void ChangeProjectorAndCumputers(bool projector, bool cumputers)
    {
        this.projector = projector;
        this.computers = cumputers;
    }

    public override string ToString()
    {
        return string.Format("Аудитория №{0}{1} - мест: {2}, проектор: {3}, компьютеры: {4}", this.level, this.number_of_classroom, this.count_of_place, this.projector ? "есть" : "нет", this.computers ? "есть" : "нет");
    }

}
class UI()
{
    List<Univercity> auditorium = new List<Univercity>();
    public void Menu()
    {
        while (true)
        {
            Console.WriteLine(
                "Выберите действие: \n" +
                "1) Добавить аудиторию в базу данных\n" +
                "2) Изменение данных об аудитории\n" +
                "3) Список аудиторий с заданым количеством мест\n" +
                "4) Список аудиторий на заданном этаже\n" +
                "5) Полный список аудиторий\n" +
                "6) Список аудиторий с компьютерами с заданным количеством мест\n" +
                "7) Список аудиторий с проектором\n" +
                "8) Выйти из программы");

            try 
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите этаж: ");
                        int Level = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите номер аудитории: ");
                        int Auditorium = Convert.ToInt32(Console.ReadLine());
                        if (auditorium.Any(i => i.number_of_classroom == Auditorium && i.level == Level)) throw new Exception("Вы уже создали эту аудиторию!");

                        Console.WriteLine("Введите количество мест в аудитории: ");
                        int Places = Convert.ToInt32(Console.ReadLine());

                        bool Projector = ProjectorAndComputer("Есть ли проектор в аудитории?");
                        bool Computers = ProjectorAndComputer("Есть ли компьютеры в аудитории?");

                        auditorium.Add(new Univercity(Places, Level, Projector, Auditorium, Computers));
                        Console.WriteLine("Аудитория создана успешно");
                        break;

                    case 2:
                        if (!auditorium.Any()) throw new Exception("В базе данных нет никаких аудиторий"); Console.WriteLine("Введите этаж: ");
                        Level = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите номер аудитории: ");
                        Auditorium = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите количество мест в аудитории: ");
                        Places = Convert.ToInt32(Console.ReadLine());
                        Projector = ProjectorAndComputer("Есть ли проектор в аудитории?");
                        Computers = ProjectorAndComputer("Есть ли компьютеры в аудитории?");

                        auditorium.Add(new Univercity(Places, Level, Projector, Auditorium, Computers));
                        Console.WriteLine("Данные об аудиториии изменены");
                        break;

                    case 3:
                        if (!auditorium.Any()) throw new Exception("В базе данных нет никаких аудиторий");
                        Console.WriteLine("Введите количество мест в аудитории: ");
                        Places = Convert.ToInt32(Console.ReadLine());
                        foreach (var place in auditorium.FindAll(place => place.count_of_place >= Places)) Console.WriteLine(place);
                        break;

                    case 4:
                        if (!auditorium.Any()) throw new Exception("В базе данных нет никаких аудиторий");
                        Console.WriteLine("Введите номер этажа:");
                        int level = Convert.ToInt32(Console.ReadLine());
                        foreach (var floor in auditorium.FindAll(floor => floor.level >= level)) Console.WriteLine(floor);
                        break;

                    case 5:
                        if (!auditorium.Any()) throw new Exception("В базе данных нет никаких аудиторий");
                        foreach (var i in auditorium) Console.WriteLine(i);
                        break;

                    case 6:
                        if (!auditorium.Any()) throw new Exception("В базе данных нет никаких аудиторий");
                        Console.WriteLine("Введите количество мест: ");
                        Places = Convert.ToInt32(Console.ReadLine());
                        foreach (var i in auditorium.FindAll(i => i.count_of_place <= Places && i.computers)) Console.WriteLine(i);
                        break;

                    case 7:
                        if (!auditorium.Any()) throw new Exception("В базе данных нет никаких аудиторий");
                        foreach (var i in auditorium.FindAll(i => i.projector)) Console.WriteLine(i);
                        break;

                    case 8:
                        return;

                }

                Console.WriteLine("Нажмите Enter чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    bool ProjectorAndComputer(string message)
    {
        while (true)
        {
            Console.WriteLine(message + " да/нет");
            string line = Console.ReadLine();
            if (line.ToLower() == "да")
                return true;
            else if (line.ToLower() == "нет")
                return false;
            else
                Console.WriteLine("Некорректные данные");
        }
    }
}
class Program
{
    static void Main()
    {
        UI uI = new UI();
        uI.Menu();
    }
}
