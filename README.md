# EjemploAHK (C# + AutoHotkey Interop)

Una solución elegante desarrollada en C# utilizando Visual Studio para interactuar directamente con el motor de automatización de **AutoHotkey (AHK)** a través de la librería Interop.

##  Descripción
Este proyecto demuestra cómo inicializar el motor nativo de AutoHotkey desde una aplicación de consola en .NET, permitiendo ejecutar comandos directos (`MsgBox`) y scripts de automatización complejos (interacción con el Bloc de notas) en el entorno Windows.

## Requisitos Previos
- **Visual Studio 2022** (o versiones compatibles con .NET Framework).
- **.NET Framework 4.7.2** o superior.
- Sistema Operativo **Windows** (requerido para la ejecución de AutoHotkey).

## Configuración Especial (¡Importante!)
Para evitar errores de arquitectura del tipo `BadImageFormatException`, el proyecto debe estar configurado explícitamente para compilar en **x86**:
1. Abra las **Propiedades del Proyecto** en Visual Studio.
2. Diríjase a la pestaña **Compilación** (Build).
3. Cambie el **Destino de la plataforma** (Platform target) de `Any CPU` a `x86`.

## Librerías Utilizadas
- [AutoHotkey.Interop](https://www.nuget.org/packages/AutoHotkey.Interop/) (Instalado mediante el Administrador de Paquetes NuGet).

## Estructura del Código Principal
El punto de entrada ejecuta dos escenarios:
1. **Comando Directo:** Despliega un cuadro de mensaje de AHK.
2. **Automatización:** Ejecuta el Bloc de notas (`notepad.exe`) y escribe un saludo de forma automatizada.
