﻿static class MyClass // нельзя определять не статические методы/функции/и все остальное в статических классах
    //дело в том что статические классы не умеют в наследовании и не умеют в реализации интерфейсов соответственно
    ////при использховании статических классов мы не можем использоваться полиморфизм
{
    public MyClass() /**/
    {
        
    }
}

class Programm
{
    static void Main(string[] args)
    {
        MyClass class1 = new MyClass(); /*/**/
    }
}
