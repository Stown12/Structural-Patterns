# Structural-patterns

Proyecto de consola en C# para practicar e implementar patrones de diseno estructurales.

## Proposito

Este repositorio sirve como espacio de practica para entender como aplicar patrones estructurales en escenarios simples y progresivos. La idea es mantener ejemplos pequenos, faciles de ejecutar y de extender con nuevos patrones.

## Stack

- .NET 10 (proyecto de consola)
- C#

## Patron implementado actualmente

### Adapter

**Objetivo:** adaptar una API existente (`PayPalService`) a una interfaz objetivo comun (`IPaymentProcessor`) para que el cliente no dependa directamente de la implementacion concreta.

**Clases principales:**

- `Adapter/IPaymentProcessor.cs`: contrato esperado por el cliente (`ProcessPayment(decimal amount)`).
- `Adapter/PayPalService.cs`: servicio existente con firma distinta (`SendMoney(string currency, double amount)`).
- `Adapter/PayPalAdapter.cs`: adaptador que convierte `decimal` a `double` y delega en `PayPalService`.
- `Program.cs`: cliente que usa `IPaymentProcessor` sin acoplarse a `PayPalService`.

**Flujo del ejemplo:**

1. Se crea `PayPalService`.
2. Se envuelve en `PayPalAdapter`.
3. El cliente llama `ProcessPayment(99.99m)` via `IPaymentProcessor`.
4. El adaptador traduce la llamada y ejecuta `SendMoney("USD", amount)`.

## Ejecutar el proyecto

```bash
dotnet run
```

## Proximos patrones (pendiente)

- Bridge
- Composite
- Decorator
- Facade
- Flyweight
- Proxy

---

Ire actualizando este README conforme agregues nuevos ejercicios/patrones al proyecto.

