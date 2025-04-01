DerivedClass dcRef = new DerivedClass();
BaseClass bcRef = new BaseClass();

dcRef.Info(); // เรียก Info() จาก DerivedClass
bcRef.Info(); // เรียก Info() จาก BaseClass

class BaseClass
{
    virtual public void Info() // เมทอดที่สามารถ Override ได้
    {
        System.Console.WriteLine("This is BaseClass");
    }
}

class DerivedClass : BaseClass
{
    override public void Info() // Override เมทอดจาก BaseClass
    {
        System.Console.WriteLine("This is DerivedClass");
    }
}
