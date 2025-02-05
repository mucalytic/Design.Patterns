using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public class ConcreteDecorator2(ITeslaModel3 teslaModel3) : TeslaDecorator(teslaModel3);
