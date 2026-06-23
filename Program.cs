using System;
using AutoHotkey.Interop;

namespace EjemploAHK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando el motor de AutoHotkey, señor...");

            // Instanciar el objeto Interop de AutoHotkey
            var ahk = AutoHotkeyEngine.Instance;

            // --- Ejemplo 1: Ejecutar una línea de comando directa ---
            // Mostraremos un cuadro de mensaje nativo de AHK
            string comandoMsgBox = "MsgBox, 64, Asistente, ¡El script de AHK ha sido ejecutado desde C# con éxito, señor!";
            ahk.ExecRaw(comandoMsgBox);

            // --- Ejemplo 2: Ejecutar un bloque de código completo ---
            // Abriremos el bloc de notas y escribiremos un texto automáticamente
            string scriptCompleto = @"
                Run, notepad.exe
                WinWaitActive, ahk_class Notepad,, 5
                if ErrorLevel {
                    MsgBox, No se pudo encontrar la ventana del Bloc de notas.
                    return
                }
                Send, {Text}Un saludo cordial de parte de su mayordomo digital.
            ";

            Console.WriteLine("Ejecutando script automatizado para el Bloc de notas...");
            ahk.ExecRaw(scriptCompleto);

            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}