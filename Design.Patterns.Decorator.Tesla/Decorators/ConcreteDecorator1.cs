using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public class ConcreteDecorator1(ITeslaModel3 teslaModel3) : TeslaDecorator(teslaModel3);
