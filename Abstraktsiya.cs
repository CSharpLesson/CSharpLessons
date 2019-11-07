//Абстракция данных - это процесс сокрытия определенных деталей и показа пользователю только важной информации.
//Абстракция может быть достигнута либо с помощью абстрактных классов, либо с помощью интерфейсов (о которых вы узнаете больше в следующей главе).
//Абстрактный класс: это ограниченный класс, который нельзя использовать для создания объектов (для доступа к нему он должен быть унаследован от другого класса).
//Абстрактный метод: может использоваться только в абстрактном классе, и у него нет тела. Тело предоставляется производным классом (унаследованным от).
//Абстрактный класс может иметь как абстрактные, так и обычные методы

abstract class Animal {
  public abstract void animalSound();
  public void sleep() {
    Console.WriteLine("Zzz");
  }
}
//Помните из главы «Наследование», что мы используем :символ для наследования от класса и что мы используем override ключевое слово для переопределения метода базового класса.
// Abstract class
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}
