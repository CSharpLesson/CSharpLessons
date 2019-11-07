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
