BaseClass bcRef = new DerivedClass(); // สร้างอ็อบเจ็กต์ของ DerivedClass แต่เก็บในตัวแปรของ BaseClass
System.Console.WriteLine(bcRef.Data); // เรียกใช้ property Data

class BaseClass
{
    virtual public string Data 
    { 
        get 
        { 
            return "Base Data"; // ค่าจาก BaseClass
        } 
    }
}

class DerivedClass : BaseClass
{
    override public string Data 
    { 
        get 
        { 
            return "Derived Data"; // ค่าจาก DerivedClass
        } 
    }
}


