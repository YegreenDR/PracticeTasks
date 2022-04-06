

    //static void Main(string[] args)
    //{
        Vokzal vokzal = new Vokzal();
        int Kol = 4;
        for (int i = 0; i < Kol; i++)
        {
            vokzal.Add();
        }
        vokzal[0].ShowInfo();
        vokzal[1].ShowInfo();
        vokzal[2].ShowInfo();
        vokzal.ShowLastTime();
        vokzal.ShowEndPunct();
        Console.ReadKey();
    //}


class Vokzal      
{
    List<Poezd> Poezda = new List<Poezd>();     

    public Poezd this[int index]   
    {
        get
        {
            return Poezda[index];
        }
        set
        {
            if (index >= 0 && value is Poezd)
            {
                Poezda.Add(value);
                Poezda.Sort();
            }
        }
    }

    public void Add()       
    {
        int namber = 0;
        bool flag = true;
        while (flag)
        {
            try
            {
                Console.Write("Введите номер поезда: ");
                namber = Convert.ToInt32(Console.ReadLine());
                flag = !flag;
            }
            catch
            {
                Console.WriteLine("Неверный формат номера");
            }
        }

        Console.Write("Введите конечный пункт назначения: ");
        string EndPunct = Console.ReadLine();
        Poezd poezd = new Poezd(EndPunct, namber);
        Poezda.Add(poezd);
        Poezda.Sort();
    }

    public void ShowLastTime()  
    {
        Console.Write("Введите время для сравнения: ");
        Poezd p1 = new Poezd("null", 1);
        for (int i = 0; i < Poezda.Count; i++)
            if (p1 < this[i])
                this[i].ShowInfo();
    }

    public void ShowEndPunct() 
    {
        Console.Write("Введите пункт назначения: ");
        string punkt = Console.ReadLine();
        int num = 0;
        for (int i = 0; i < Poezda.Count; i++)
        {
            if (Poezda[i].EndPunct == punkt)
            {
                Console.WriteLine(Poezda[i]);
                num++;
            }
        }
        if (num == 0)
            Console.WriteLine("В заданный пункт назначения поезда не ходят!");
    }

}

class Poezd : IComparable
{
    String endPunct;
    public String EndPunct
    {
        get { return endPunct; }
        set { endPunct = value; }
    }

    int namber;
    public int Namber
    {
        get { return namber; }
        set
        {
            if (value > 0)
                namber = value;
        }
    }

    DateTime time;              
    public DateTime Time        
    {
        get { return time; }
        set { time = value; }
    }

    void SetTime()       
    {
        while (true)
        {
            int hour = 0;
            int minute = 0;
            Console.Write("Введите время отправления поезда [hour.minute]: ");
            string t = Console.ReadLine();
            string h = "";
            string m = "";
            int q;
            bool flag = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (!flag)
                {
                    if (Int32.TryParse(Convert.ToString(t[i]), out q))
                    {
                        h = h + t[i];
                    }
                    else
                    {
                        flag = true;
                        continue;
                    }
                }
                if (flag)
                {
                    if (Int32.TryParse(Convert.ToString(t[i]), out q))
                    {
                        m = m + t[i];
                    }
                }
            }
            try
            {
                hour = Int32.Parse(h);
                minute = Int32.Parse(m);
                Time = new DateTime(2012, 12, 12, hour, minute, 0);
                return;
            }
            catch
            {
                Console.WriteLine("Введен неверный формат времени");
            }

        }
    }

    public Poezd(string EndPunct, int Namber)       
    {
        this.EndPunct = EndPunct;
        this.Namber = Namber;
        SetTime();
    }
    public Poezd(string EndPunct, int Namber, DateTime Time)       
    {
        this.EndPunct = EndPunct;
        this.Namber = Namber;
        this.Time = Time;
    }

    public int CompareTo(object input)   
    {
        if (input is Poezd)
        {
            Poezd p1 = (Poezd)input;
            if (this.Time > p1.Time)
                return 1;
            else if (this.Time < p1.Time)
                return -1;
            else
                return 0;
        }
        return 0;
    }

    public override string ToString()    
    {
        string info = String.Format("Поезд №{0} следует в пункт назначения {1}. Время отправления: {2}.{3}!",
            Namber, EndPunct, time.Hour, time.Minute);
        return info;
    }
    public void ShowInfo()     
    {
        Console.WriteLine(ToString());
    }

    public static bool operator >(Poezd p1, Poezd p2)   
    {
        if (p1.Time > p2.Time)
            return true;
        return false;
    }
    public static bool operator <(Poezd p1, Poezd p2)   
    {
        if (p1.Time < p2.Time)
            return true;
        return false;
    }
    public static bool operator ==(Poezd p1, Poezd p2)   
    {
        if (p1.Time == p2.Time)
            return true;
        return false;
    }
    public static bool operator !=(Poezd p1, Poezd p2)  
    {
        if (p1.Time != p2.Time)
            return true;
        return false;
    } }
