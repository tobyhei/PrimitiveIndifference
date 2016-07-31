# PrimitiveIndifference
PrimitiveIndifference is a tiny library to help reduce the boilerplate needed to create simple types from primitives.

In particular this library aims to help ease the pain in avoiding the ['Primitive Obsession'](http://c2.com/cgi/wiki?PrimitiveObsession) anti-pattern.

As discussed in several places, [for example](http://enterprisecraftsmanship.com/2015/03/07/functional-c-primitive-obsession), this is somewhat burdensome to do in C#. To avoid the boiler-plate involved, this library creates a base ValueObject from which a simple domain model can inherit from.
