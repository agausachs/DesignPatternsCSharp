### BUILDER PATTERN 

Producto básico estandard:
Product parts: PartA1

Standard full featured product:
Product parts: PartA1, PartB1, PartC1

Producto personalizado:
Product parts: PartA1, PartC1


### FACTORY METHOD PATTERN 

App: Lanzada con el ConcreteCreator1.
Cliente: No soy consciente de la clase Creator,pero aún así funciono.
Creator: El mismo código de creator ha funcionado con {Resultat de ConcreteProduct1}

App: Lanzada con el ConcreteCreator2.
Cliente: No soy consciente de la clase Creator,pero aún así funciono.
Creator: El mismo código de creator ha funcionado con {Resultat de ConcreteProduct2}


### SINGLETON PATTERN 

 SINGLETON INGENUO 
El singleton funciona, ambas variables contienen la misma instancia.


 SINGLETON THREAD SAFE 
Si ves el mismo valor, entonces es que el Singleton ha sido reutilizado (bien!)
Si ves valores distintos, entonces es que se han creado 2 Singletons (mal!)

RESULTADO:

BAR
BAR


### ABSTRACT FACTORY PATTERN 

Cliente: Testeando el código cliente con el primer tipo de factory...
El resultado del producto B1
El resultado de el B1 colaborando con el (El resultado del producto A1)

Cliente: Testeando el mismo tipo de código cliente con el segundo tipo de factory...
El resultado del producto B2
El resultado del B2 colaborando con el (El resultado del producto A2)
Valores originales de p1, p2 y p3:
 Valores de instancia p1: 
 Name: Abraham Gausachs, Age: 42, BirthDate: 29/12/1978 
 ID#: 666
 Valores de instancia p2: 
 Name: Abraham Gausachs, Age: 42, BirthDate: 29/12/1978 
 ID#: 666
 Valores de instancia p3: 
 Name: Abraham Gausachs, Age: 42, BirthDate: 29/12/1978 
 ID#: 666

Valores de p1, p2 y p3 después de cambiar p1:
 Valores de instancia p1: 
 Name: Frank, Age: 32, BirthDate: 01/01/1900 
 ID#: 7878
 Valores de instancia p2 (los valores de referencia han cambiado): 
 Name: Abraham Gausachs, Age: 42, BirthDate: 29/12/1978 
 ID#: 7878
 Valores de instancia p3 (todo sigue igual): 
 Name: Abraham Gausachs, Age: 42, BirthDate: 29/12/1978 
 ID#: 666


### ADAPTER PATTERN 

La interfaz del Adaptee es incompatible con el cliente.
Pero el cliente adapter puede llamar a su método.
Esto es Request específico.



### COMPOSITE PATTERN 

Cliente: Recibí un componente simple:
RESULT: Hoja

Cliente: Ahora tengo un árbol compuesto:
RESULT: Rama(Rama(Hoja+Hoja)+Rama(Hoja))

Cliente: No necesito comprobar las clases componentes aunque este gestionando un árbol:

RESULT: Rama(Rama(Hoja+Hoja)+Rama(Hoja)+Hoja)


### FACADE PATTERN 

Fachada inicializa subsistemas:
Subsistema1: Preparado!
Subsistema2: Prepárate!
Fachada le pide a los subsistemas que ejecuten la acción:
Subsistema1: Adelante!
Subsistema2: Fuego!


### PROXY PATTERN 

Client: Ejecutando el código del cliente con un RealSubject:
RealSubject: Manipulando Request.

Client: Ejecutando el mismo código del cliente pero a través del proxy
Proxy: Comprobando el acceso antes de disparar realmente el request
RealSubject: Manipulando Request.
Proxy: Logando el timestamp de la request. 3/7/2021 7:44:17 PM


### BRIDGE PATTERN 

Abstract: Base operation with:
ConcreteImplentationA: El resultado en la plataforma A.

ExtendedAbstraction: Operación extendida con:ConcreteImplementationB: El resultado en la plataforma B.


### DECORATOR PATTERN 

Client: Tengo un componente simple:
RESULT: ConcreteComponent

Client: Ahora tengo un componente decorado:
RESULT: ConcreteDecoratorB(ConcreteComponent)


### FLYWEIGHT PATTERN 

FlyweightFactory: Tengo 5 flyweights:
Camaro2018_Chevrolet_pink
black_C300_Mercedes Benz
C500_Mercedes Benz_red
BMW_M5_red
BMW_white_X6

Cliente: Añadiendo coche a la base de datos
FlyweightFactory: Reusando un flyweight existente
Flyweight: Mostrando estado compartido {"Model":"M5","Color":"red","Company":"BMW","Owner":null,"Number":null} y estado único {"Model":"M5","Color":"red","Company":"BMW","Owner":"James Doe","Number":"CL234IR"}

Cliente: Añadiendo coche a la base de datos
FlyweightFactory: No puedo encontrar un flyweight, creo uno nuevo
Flyweight: Mostrando estado compartido {"Model":"X1","Color":"red","Company":"BMW","Owner":null,"Number":null} y estado único {"Model":"X1","Color":"red","Company":"BMW","Owner":"James Doe","Number":"CL234IR"}

FlyweightFactory: Tengo 6 flyweights:
Camaro2018_Chevrolet_pink
black_C300_Mercedes Benz
C500_Mercedes Benz_red
BMW_M5_red
BMW_white_X6
BMW_red_X1


### CHAIN OF RESPONSIBILITY PATTERN 

Cadena: Mono > Ardilla > Perro

Client: Quién quiere una Nuez?
    Ardilla: Me comeré la Nuez.
Client: Quién quiere una Banana?
    Mono: Me comeré la Banana.
Client: Quién quiere una Taza de café?
   Taza de café ha sido ignorada.

Subcadena: Ardilla > Perro

Client: Quién quiere una Nuez?
    Ardilla: Me comeré la Nuez.
Client: Quién quiere una Banana?
   Banana ha sido ignorada.
Client: Quién quiere una Taza de café?
   Taza de café ha sido ignorada.


###  ITERATOR PATTERN 

Travesía recta:
Primero
Segundo
Tercero

Recorrido inverso
Tercero
Segundo
Primero


###  MEMENTO PATTERN 

Originator: Mi estado inicial es: Super-duper-super-puper-super.

Caretaker: Guardando estado del Originator...
Originator: Estoy haciendo algo importante.
Originator: y mi estado ha cambiado a: CnREskxaafQuSrQZHtgnsbYjBMrRWQ

Caretaker: Guardando estado del Originator...
Originator: Estoy haciendo algo importante.
Originator: y mi estado ha cambiado a: YHgPJYZAqHcnJyknGQvrjmBdTnatOr

Caretaker: Guardando estado del Originator...
Originator: Estoy haciendo algo importante.
Originator: y mi estado ha cambiado a: ErQVSUZOtDLTOlXQdmKZSmhrtxROHh


Caretaker: Aquí está la lista de mementos:
3/7/2021 7:44:18 PM / (Super-dup)...
3/7/2021 7:44:18 PM / (CnREskxaa)...
3/7/2021 7:44:18 PM / (YHgPJYZAq)...

Cliente: Ahora, vamos a hacer rollback!

Caretaker: Restaurando estado a: 3/7/2021 7:44:18 PM / (YHgPJYZAq)...
Originator: Mi estado ha cambiado a: YHgPJYZAqHcnJyknGQvrjmBdTnatOr


###  STATE PATTERN 

Context: Transición a ConcreteStateA.
ConcreteStateA maneja la request1.
ConcreteStateA quiere cambiar el estado del contexto.
Context: Transición a ConcreteStateB.
ConcreteStateB maneja la request2.
ConcreteStateB quiere cambiar el estado del contexto.
Context: Transición a ConcreteStateA.


### TEMPLATE METHOD PATTERN 

El mismo código cliente puede funcionar con diferentes subclases:
AbstractClass dice: Estoy haciendo la mayor parte de mi trabajo.
ConcreteClass1 dice: Implementada Operación 1.
AbstractClass dice: Pero permito a las subclases sobreescribir algunas operaciones.
ConcreteClass2 dice: Implementada Operación 2.
AbstractClass dice: Pero estoy haciendo la mayor parte de mi trabajo de todas maneras.


Insisto que el mismo código cliente puede funcionar con diferentes subclases:
AbstractClass dice: Estoy haciendo la mayor parte de mi trabajo.
ConcreteClass2 dice: Implementada Operación1.
AbstractClass dice: Pero permito a las subclases sobreescribir algunas operaciones.
ConcreteClass2 dice: Hook1 sobreescrito.
ConcreteClass2 dice: Implementada Operación2.
AbstractClass dice: Pero estoy haciendo la mayor parte de mi trabajo de todas maneras.


### COMMAND PATTERN 

Invoker: Alguien quiere algo antes de que empiece?
SimpleCommand: Mira, puedo hacer cosas simples como printar (Di Hola!)
Invoker: ... haciendo algo realmente importante ...
Invoker: Alguien quiere algo antes de que acabe?
ComplexCommand: Cosas complejas deberían ser hechas por un objeto receptor.
Receiver: Trabajando en (Enviar email.)
Receiver: Trabajando en (Guardar informe.)


###  MEDIATOR PATTERN 

El Cliente dispara la operación A.
Componente 1 hace A.
Mediator reacciona con A y dispara las siguientes operaciones:
Component 2 hace C.


El Cliente dispara la operación D.
Componente 2 hace D.
Mediator reacciona con D y dispara las siguientes operaciones:
Componente 2 hace B.
Component 2 hace C.


### OBSERVER PATTERN 

Subject: Vinculado al observador.
Subject: Vinculado al observador.

Subject: Estoy haciendo algo importante.
Subject: Mi estado ha cambiado a: 7
Subject: Notificando observadores...
ConcreteObserverB: Reaccionado al evento.

Subject: Estoy haciendo algo importante.
Subject: Mi estado ha cambiado a: 3
Subject: Notificando observadores...
ConcreteObserverB: Reaccionado al evento.
Subject: Desvincula al observador.

Subject: Estoy haciendo algo importante.
Subject: Mi estado ha cambiado a: 4
Subject: Notificando observadores...


###  STRATEGY PATTERN 

Cliente: Strategy está en modo orden normal.
Context: Ordenando datos usando la estrategia (no estoy seguro como lo haré)
System.Collections.Generic.List`1[System.String]

Cliente: Strategy está en modo orden inverso.
Context: Ordenando datos usando la estrategia (no estoy seguro como lo haré)
System.Collections.Generic.List`1[System.String]


###  VISITOR PATTERN 

El código cliente funciona con todos los visitors via la interfície base Visitor
A + ConcreteVisitor1
B + ConcreteVisitor1

Este permite al mismo código cliente funcionar con diferentes tipos de visitors.
A + ConcreteVisitor2
B + ConcreteVisitor2


###  SINGLE RESPONSIBILITY PRINCIPLE 

 BAD GARAGE 
Bad - Abro Compuerta
Bad - Hago Servicio
Bad - Cierro Compuerta


 GOOD GARAGE 
GarageStationUtility - Abro compuerta
Good - Hago Servicio
GarageStationUtility - Cierro compuerta


###  OPEN CLOSED PRINCIPLE 

 BAD ACCOUNTS 
Bad Regular 
80
Bad Salary 
100
Bad Corporate 
90

GOOD ACCOUNTS 
Good Regular 
80
Good Salary 
100
Good Corporate 
90


###  LISKOV SUBSTITUTION PRINCIPLE 

 BAD SHAPE TRIANGLE
Circulo

 GOOD SHAPE CIRCLE - TRIANGLE
Circulo
Triangulo


###  INTERFACE SEGREGATION PRINCIPLE 

 BAD ONLINE ORDER 
Bad Online Order Añadir a Carrito
Bad Online Order Procesar Tarjeta de crédito

 BAD OFFLINE ORDER 
Bad Offline Order Añadir a Carrito
Bad Offline Order, Procesar Tarjeta Crédito. No debería poder

 GOOD ONLINE ORDER 
Good Online Order Añadir a Carrito
Good Online Order Procesar con Tarjeta de crédito
 GOOD OFFLINE ORDER 
Good Offline Order Añadir a Carrito


###  DEPENDENCY INVERSION PRINCIPLE 

Jeep arranca
Jeep parado