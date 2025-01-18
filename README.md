<!-- Este es un comentario -->

# Primera Intra de Programación

# El Regalo de Felipe

## Curso 2024-2025

![](Puerta.jpeg)

Felipe, durante su cumpleaños, después de mover los hombritos, recibió un obsequio de su abuelo Pedro:
una pequeña caja con mucha intriga. Al terminar la fiesta Felipe corrió a su cuarto y se apresuró para
abrir la caja, para su sorpresa, en la caja había una especie de conjuro y un papel con unas instrucciones.
De repente, por arte de magia el escaparate de Felipe se abre dejando mostrar una inmensa selva detrás. Como
todo buen niño curioso Felipe decide entrar por la puerta y explorar la selva.

En la caja también se encontraba un mapa, según su abuelo, el mapa lo llevaría hasta un tesoro oculto en alguna
parte de la selva. Al caminar durante un tiempo...BINGO!, Felipe se topó con una puerta dorada muy misteriosa,
la cual le habló y le dijo: "Para abrirme, debes introducir un número secreto". El niño ya estaba deseoso de saber qué tesoro estaba detrás de la puerta, para ello agarró rápido las instrucciones de su abuelo y las comenzó a leer.

<div style="background-color: #FFFFE0; border: 2px solid #FFD700; padding: 10px;">
  Querido Nieto:
  Como te mencioné hay un gran tesoro esperándote detrás de una puerta mágica, para abrirla debes escribir en ella un número especial. Para saber cuál es el número debes dirigirte al tablero que tiene la puerta, ella te dirá un mensaje y te dará varias secuencias de direcciones. El número mágico lo obtienes de la siguiente forma:
  Debes contar, por cada una de las secuencias de direcciones, cuantas veces se hace match con ella en el tablero. Un match con una secuencia ocurre si al seguir las direcciones de la misma, se encuentra el mensaje dado por la puerta.
</div>

Como era de esperar Felipe no entendió nada de nada y te llamó a ti que estabas muy tranquilo en casa luego de disfrutar la cajita del cumple y te pidió ayuda. Tu tarea consiste en que Felipe te dirá las secuencias de direcciones pasadas por la puerta, el número proporcionado por ella y una fotografía del tablero y tu debes decirle cual es el número que abre la puerta.

Para ello te sientas en tu PC y preparas las condiciones para el trabajo en tu archivo Solution.cs

```csharp
namespace Exam;

public static class Solution
{
    public static int FindNumber(char[,] board, string target, Direction[][] paths)
    {
        //Borre esta excepción y ponga su solución aquí
        throw new NotImplementedException();
    }
}

public enum Direction
{
    Up, Down, Left, Right
}
```

### Entrada

1. Board: Matriz de caracteres del alfabeto inglés en mayúsculas, que representa el tablero. Nunca será null, ni vacío
2. Target: Cadena de texto compuesta únicamente por caracteres del alfabeto inglés en mayúsculas. Siempre tendrá al menos un caracter
3. Paths: Un array de arrays, donde cada array interno representa una secuencia de direcciones que se debe seguir en el tablero. Siempre tendrá al menos un elemento, y ningún array interno será vacío

### Salida

Un entero que representa la cantidad de veces que al pararse en una posición del tablero y seguir la secuencia de direcciones se halle el mensaje dado por la puerta.

### Ejemplo

![](Ejemplo.png)

```csharp
namespace Exam;

public static class Program
{
    public static void Main(string[] args)
    {
        char[,] board = new char[,]
        {
            {'A', 'N', 'B', 'A', 'O'},
            {'A', 'A', 'D', 'X', 'O'},
            {'X', 'B', 'C', 'F', 'R'},
            {'D', 'C', 'H', 'A', 'D'},
            {'J', 'D', 'T', 'B', 'C'},
        };
        Direction[][] paths = new Direction[][]
        {
            new Direction[]{Direction.Down, Direction.Down, Direction.Down},
            new Direction[]{Direction.Down, Direction.Down, Direction.Left},
            new Direction[]{Direction.Down, Direction.Right, Direction.Up},
            new Direction[]{Direction.Right},
        };
        string message = "ABCD";
        int solve = Solution.FindNumber(board, paths, message);
        //Respuesta esperada 4
    }
}
```

Cosas a tener en cuenta

1. Note que una misma letra puede aparecer en más de un camino a seguir. (Letra de la fila 1, columna 1)
2. Note que un camino a seguir puede tener más de un match exitoso. (Caminos azules)
3. Pueden existir secuencias de direcciones que no hagan match con el mensaje. (Última secuencia de direcciones)

### Importante

Superar el caso de prueba del ejemplo no garantiza que su algoritmo esté totalmente correcto, le recomendamos hacer todas las pruebas que considere necesarias para garantizar la correctitud de su examen.
