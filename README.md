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

### Composite

**Objetivo:** tratar objetos individuales (`File`) y composiciones de objetos (`Folder`) de forma uniforme mediante la interfaz `IFileSystemItem`.

**Clases principales:**

- `Composite/IFileSystemItem.cs`: contrato comun con `GetSize()` y `GetName()`.
- `Composite/File.cs`: hoja (`File`) que representa un archivo con nombre y tamano.
- `Composite/File.cs`: compuesto (`Folder`) que agrupa items, permite `Add(...)` y calcula su tamano sumando recursivamente el de sus hijos.
- `Program.cs`: cliente que construye un arbol simple de carpetas/archivos y consulta el tamano total del nodo raiz.

**Flujo del ejemplo:**

1. Se crean carpetas (`root`, `documents`, `music`).
2. Se agregan archivos a `documents` y `music`.
3. Se agregan ambas carpetas a `root` junto con un archivo adicional.
4. Se imprime `root.GetSize()`, que suma todo el contenido del arbol (7805 KB en el ejemplo actual).

## Ejecutar el proyecto

```bash
dotnet run
```

## Proximos patrones (pendiente)

- Decorator
- Facade
- Flyweight
- Proxy

---

Ire actualizando este README conforme agregues nuevos ejercicios/patrones al proyecto.

