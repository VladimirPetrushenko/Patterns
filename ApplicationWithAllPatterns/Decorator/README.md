﻿Папка SealedClasses создана, чтобы показать как через декоратор можно расширить функционал запечатаного класса.
Это реализовано при помощи функции NewFeture. А так же показано как можно изменить существующий функционал,
это реализовано при помощи уже наследования и внедрения необходимой логики в переопределённую функцию Move

Назначение
Динамически добавляет объекту новые обязанности. Является гибкой альтернативой порождению подкласов с
целью расширения функциональности.

Недостатки декораторов
Декоратор, как и большинство других паттернов, имеет некоторые недостатки.
 - Чувствительность к порядку. Код инициализации декораторов очень важен, поскольку именно в процессе 
 создания определяются вложенность и порядок исполнения разных декораторов.
 - Сложность отладки. Разработчику, незнакомому с этим паттерном, замер времени исполнения или кэширование
 результатов декораторами может показаться черной магией. Отлаживать проблемы, которые возникли внутри
 декоратора, может быть довольно сложно
 - Увеличение сложности. Декоратор является довольно тяжеловесным паттероном, к которому стоит прибегать тогда,
 когда выделяемый вспект поведения достаточно сложен. Если нужно кэшировать результаты в одном из десяти методов,
 то сложность, привнесенная декоратором, будет неоправданна.

Применимость
Декоратор позволяет динамически расширять поведение объектов. Он идеально подходит для расширения поведения 
всех методов интерфейса, которое не является частью основной функциональности. Если кэшировать нужно лишь результаты
одного метода класса, то использование декоратора будет слишком тяжеловестным.
Декораторы применяются для добавления всем методом интерфейса некоторого поведения, которое не является частью 
основной функциональности. 
Декораторы отлично подходят для решения следующих задач:
 - кэширования результатов работы
 - замера времени исполнения методов
 - логирования аргументов
 - управления доступом пользователей
 - модификации аргументов или результата работы методов упаковки/распаковки, шифрования и т.п.
Динамическая природа позволяет нанизыват аспекты один на другой, обходя ограничения наследования, использование 
которого привело бы к комбинаторному взрыву числа наследников.