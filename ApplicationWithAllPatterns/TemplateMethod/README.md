﻿Шаблонный метод простыми словами это публичный метод, в нутри абстрактного класса, который в нутри себя вызывает абстрактные и обычные методы абстрактного класса.
Например 
abstract class elexir
{
	protected void Start() => Console.WriteLine("Start");
	protected abstract void CreateSomething();
	public void Make(){
		Start();
		CreateSomething();
	}
}
class tea : elexir
{
	protected override void CreateSomething() => Console.WriteLine("Create Tead");
}

Make - Шаблонный метод


Назначение
Шаблонный метод определяет основу алгоритма и позволяет подклассам переопределять некоторые шаги алгоритма, не изменяя его структуры в целом.

Другими словами: шаблонный метод - это каркас, в который наследники могут подставлять реализации недостающих элементов

Применимость
Практически всегда, когда у вас в голове появляется мысль о повторном использовании кода с помощью наследования, 
стоит подумать как можно выразить отношения между базовым классом и его наследником максимально четко. 
При этом нужно помнить о своих клиентах - как о внешних классах, так и о наследниках: насколько просто создать наследника класса,
какие методы нужно переопределить, что в них можно делать, а что нельзя? Когда и от каких классов иерархии наследования нужно наследовать?
Насколько легко добавить ещё одного наследника, не вдаваясь в детали реализации базового класса?

Формализация отношений между базовым классом и наследником с помощью контрактов и шаблонного метода сделает жизнь разработчиков наследников
проще и понятнее. Шаблонный метод задает каркас, который четко говорит пользователю, что он может сделать и в каком контексте.

Важно, если реализуется паттерн шаблонный метод, значит должна быть реализованна и фабрика или фабричный метод. Идеально подходит для регистрации наследников класса с шаблонным методом в DI
