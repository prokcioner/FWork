# Блок-схема
![block-diagram](/blockDiagram.png)

# Описание решения задачи
## ReadLine
Просим написать у пользователя слова, значения, смайлики, через пробел, с помощью *ReadLine* сохроняем полоченную строку в *string*.  
## Split
Далее при помощи метода *Split*, мы разделяем строчку от пользователя на элементы строчного массива. 
## countArr
Потом при помощи функции *countArr* мы узнаём какой размерности будет наш будущий массив в который мы передадим элементы, состоящие из **3 и менее символов**. Добавляем условие, что при значении *count == 0*, консоль нам выведет "пустой" массив. 
## newStrArr
Создаём массив размерностью count, при потощи цикла for  перебираем каждую строчку в строковом массиве, который нам задал пользователь. Если попадается элемент состоящий из **3 или меньше символов**, тогда присваеваем этот элемент, нулевому делеее *k++* элементу в новом массиве.