Как мы указали в предыдущей главе; Наследование позволяет нам наследовать поля и методы от другого класса. Полиморфизм использует эти методы для выполнения различных задач. Это позволяет нам выполнять одно действие разными способами.

Например, представьте, что у базового класса Animalесть метод animalSound(). Производные классы животных могут быть свиньями, кошками, собаками, птицами - и у них также есть своя собственная реализация звука животных (хрюшка свиньи, мяуканье кошки и т. Д.):

class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}




_____________________________________________________________________________________________________________________________________________________________________________
class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}
//The animal makes a sound
//The animal makes a sound
//The animal makes a sound
Не тот результат, который я искал
Вывод из приведенного выше примера, вероятно, не соответствует ожиданиям. Это потому, что метод базового класса переопределяет метод производного класса, когда они имеют одно и то же имя.

Однако C # предоставляет возможность переопределить метод базового класса, добавив virtualключевое слово к методу внутри базового класса и используя overrideключевое слово для каждого метода производного класса:


class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}

