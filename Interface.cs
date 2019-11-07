//Еще один способ добиться абстракции в C # - с помощью интерфейсов.
//An interfaceявляется полностью « абстрактным классом », который может содержать только абстрактные методы и свойства (с пустыми телами):
interface Animal {
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}
interface IFirstInterface 
{
  void myMethod(); // interface method
}

interface ISecondInterface 
{
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() 
  {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod() 
  {
    Console.WriteLine("Some other text...");
  }
}

class Program 
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
}
//Примечания по интерфейсам:
//Как и абстрактные классы , интерфейсы нельзя использовать для создания объектов (в приведенном выше примере невозможно создать объект «IAnimal» в классе Program)
//Методы интерфейса не имеют тела - тело предоставляется классом "Implement"
//При реализации интерфейса вы должны переопределить все его методы
//Интерфейсы могут содержать свойства и методы, но не поля / переменные
//Члены интерфейса по умолчанию abstractи public
//Интерфейс не может содержать конструктор (так как он не может использоваться для создания объектов)
//Почему и когда использовать интерфейсы?
//1) Для достижения безопасности - скрыть определенные детали и показать только важные детали объекта (интерфейса).
//2) C # не поддерживает «множественное наследование» (класс может наследовать только от одного базового класса). Однако это может быть достигнуто с помощью интерфейсов, поскольку класс может реализовывать несколько интерфейсов. Примечание. Чтобы реализовать несколько интерфейсов, разделите их запятой (см. Пример ниже).
