# MermaidChart

```mermaid

classDiagram
    class Sphere {
    -_color: Color
    -_radius: float
    -_timesThrown: int
    +GetTimesThrown: int

    +Sphere(Color color, float radius)
    +Pop() void
    +Throw() void
    
    }

    class Color {
        -_red:byte
        -_green:byte
        -_blue:byte
        -_alpha:byte

        +GetRed:byte
        +GetGreen:byte
        +GetBlue:byte
        +GetAlpha:byte
        +GetGrey:byte
    }

    Sphere --> Color
