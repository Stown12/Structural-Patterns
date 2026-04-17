# Structural-patterns

Proyecto de consola en C# para practicar e implementar patrones de diseno estructurales.

## Proposito

Este repositorio sirve como espacio de practica para entender como aplicar patrones estructurales en escenarios simples y progresivos. La idea es mantener ejemplos pequenos, faciles de ejecutar y de extender con nuevos patrones.

## Stack

- .NET 10 (proyecto de consola)
- C#

## Patrones implementados actualmente

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

### Bridge

**Objetivo:** desacoplar la abstraccion (`Notification`) de su implementacion (`INotificationSender`) para que ambas jerarquias puedan evolucionar y combinarse de forma independiente.

**Clases principales:**

- `Bridge/INotificationSender.cs`: contrato de envio y clase base `Notification` que delega el canal usado.
- `Bridge/EmailSender.cs`: implementaciones concretas del canal (`EmailSender`, `SmsSender`) y tipos de notificacion (`AlertNotification`, `ReminderNotification`).
- `Program.cs`: cliente que combina tipos de notificacion y canales, y cambia el canal en tiempo de ejecucion con `SetSender(...)`.

**Flujo del ejemplo:**

1. Se crean dos implementaciones del sender: `EmailSender` y `SmsSender`.
2. Se crean dos abstracciones refinadas: `AlertNotification` y `ReminderNotification`.
3. Cada notificacion envia el mensaje usando su sender actual.
4. Se cambia el sender de `alert` con `SetSender(sms)` y se reutiliza la misma abstraccion con otro canal.

## Ejecutar el proyecto

```bash
dotnet run
```

## Proximos patrones (pendiente)

- Composite
- Decorator
- Facade
- Flyweight
- Proxy

---

Ire actualizando este README conforme agregues nuevos ejercicios/patrones al proyecto.

