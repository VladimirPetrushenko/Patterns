﻿


Назначение
Строитель отделяет конструирование сложного обхекта от его представления, так что в результате одного и того же процесса конструирования могут 
получаться разные представления

Применимость
Паттерн "Строитель" идеально подходит для ситуаций, когда процесс создания является сложным и состоит из нескольких этапов, при этом одним клиентам
нужно устанавливать одни параметры создаваемого объекта, а другим - другие. Строитель может устанавливать разумные значения по умолчанию, позволяя
клиентам сосредоточиться лишь на важных для них параметрах.

Строитель обычно обладает текучим интерфейсом, что делает его использование более читабельным и декларативным.

Я обратил внимание на то, что в последнее время довольно часто пользуюсь хэтим паттерном при создании тестовых данных, создании и конфигурировании
классов экспорта данных (источник, тип получателя, то, какие данные нужно экспортировать), формировании слабо типизированных объектов, таких как
JSON или Xml, с помощью строго типизированного Fluent API и т.п.

Строитель идеально сочетается с неизменяемыми классами. Неизменяемость упрощает понимание кода и прекрасно подходит для использования в многопоточной
среде. Наличие строителей позволяет обойти ограничения неизменяемости и решить проблемы эффективности, которые обязательно возникнут при работе с такими типами.