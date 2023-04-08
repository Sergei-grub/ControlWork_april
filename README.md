# ControlWork_april

## **Описание задания для контрольной работы:**

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []


## Описание решения
Для решения задачи будет использовано 2 метода:
1. Первый метод. Создание и заполнение символьного массива. Данные массива заполняются пользователем до тех пор, пока не будет введена строка.
2. Второй метод. В качестве аргумента принимается созданный массив. Создается второй массив для записи значений, которые соответствуют условию. При соответствии условию будет производится запись значений в новый массив. Для подсчета количества соответствий условию будет использован счетчик. В качестве результата метод выведет на экран не пустые значения, записанные в новый массив или, выведет на экран сообщение об отсутствии значений, которые соответствуют условию.

**Блок-схема работы 2 метода:**

![Блок-схема 2 метода](diagram_method2.png)

Результаты контрольной работы записаны в отдельный репозиторий: https://github.com/Sergei-grub/ControlWork_april.git