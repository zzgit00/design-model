### 23种设计模式
```
SimpleFactory(FactoryMethodPattern) ---> 简单工长模式
StrategyPattern ---> 策略模式
AbstractFactory ---> 抽象工厂模式
Adapter ---> 适配器模式
Builder ---> 构建者模式
Decorator ---> 装饰模式
Facade ---> 外观模式
FactoryMethod ---> 工厂方法模式
ObserverModel ---> 观察者模式
Prototype ---> 原型模式
Proxy ---> 代理模式
State ---> 状态模式
TemplateMethod ---> 模板方法模式
Memento ---> 备忘录模式
Composite ---> 组合模式
Iterator ---> 迭代器模式
Singleton ---> 单例模式
Bridge ---> 桥接模式
Command ---> 命令模式
ChainOfResponsibility ---> 职责链模式
Mediator ---> 中介者模式
Flyweight ---> 享原模式
Interpreter ---> 解释器模式
Visitor ---> 访问者模式
```

### 7种设计原则
```
单一职责原则(SRP) ---> 就一个类而言，应该仅有一个引起它变化的原因。

接口隔离原则(Interface Segregation Principle) ---> 客户端不应该被强迫实现一些他们不会使用的接口，
	应该把胖接口中的方法分组，然后用多个接口代替它，每个接口服务于一个子模块。

开闭原则(Open Close Principle) ---> 软件实体应该可以扩展，但是不可修改。

依赖倒转原则(Dependence Inversion Principle) --->
	高层模块不应该依赖底层模块。两个都应该依赖抽象。抽象不应该依赖细节。细节应该依赖抽象。
	
里氏替换原则(Liskov Substitution Principle) --->
	子类必须能够替换掉它们的父类。
	
迪米特法则(Demeter Principle) ---> 如果两个类不必彼此直接通信，那么这两个类就不应当直接的相互作用。
	如果其中一个类需要调用另一个类的某一个方法的话，可以通过第三者转发这个调用。
	
合成复用原则(Composite Reuse Principle) ---> 尽量使用合成/聚合，尽量不要是使用类继承。
```
