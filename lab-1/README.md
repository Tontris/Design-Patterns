# Лабораторна робота

Ця лабораторна робота демонструє дотримання принципів SOLID.

## Принципи SOLID

### Single Responsibility Principle (SRP)

Клас `Animal` має одну відповідальність: він визначає загальні властивості тварини. Дивіться файл [`Animal.cs`](.SOLID%2C%20Composition%20Over%20Inheritance%20Library/Animal)

### Open-Closed Principle (OCP)

Клас `Animal` відкритий для розширення (ми можемо створити нові класи, які успадковують `Animal`), але закритий для модифікації. Дивіться файл [`Animal.cs`](./SOLID, Composition Over Inheritance Library/Animal.cs)

### Liskov Substitution Principle (LSP)

Класи `Lion` та `Elephant` можна використовувати замість базового класу `Animal` без зміни поведінки програми. Дивіться файли [`Lion.cs`](./SOLID, Composition Over Inheritance Library/Lion.cs) та [`Elephant.cs`](./SOLID, Composition Over Inheritance Library/Elephant.cs).

### Interface Segregation Principle (ISP)

Цей принцип не застосовується до цієї лабораторної роботи, оскільки в ній не використовуються інтерфейси.

### Dependency Inversion Principle (DIP)

Клас `Zoo` залежить від абстракцій (`Animal`, `Enclosure`, `ZooWorker`), а не від конкретних класів. Дивіться файл [`Zoo.cs`](./SOLID, Composition Over Inheritance Library/Zoo.cs).

### DRY (Don’t Repeat Yourself)

Використав методи та класи для уникнення повторення коду. Наприклад, використав клас Animal для визначення загальних властивостей тварин, а потім успадкував цей клас в класах Lion та Elephant.

### KISS (Keep It Simple, Stupid)

Мій код простий і зрозумілий. Я використовував прості класи та методи, які легко читаються та розуміються.

### Composition Over Inheritance

Я використовував композицію для створення більш гнучких структур об’єктів. Наприклад, використовував композицію, коли додав тварин до вольєрів в класі Enclosure.

### Program to Interfaces not Implementations

Хоча я не використовував інтерфейси в цьому коді, я дотримувався цього принципу, оскільки я програмував для загальних типів (наприклад, Animal), а не для конкретних реалізацій (Lion, Elephant).

### Fail Fast

Мій код видає помилку швидко, оскільки намагаючись додати тварину, якої не існує.
