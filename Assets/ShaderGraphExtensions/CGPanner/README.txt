# CGPanner 1.0

## HOW TO USE
To add the CGPanner node to your shaders, go to 'UV/CG Panner' in the Create Node window.

## DESCRIPTION
The CGPanner node tiles and scroll the value of input UV by the inputs Tiling and Speed respectively. This is used for scrolling textures over Time.

## PORTS
Name    Direction   Type        Binding    Description
--------------------------------------------------------------------------------
UV      Input       Vector 2    UV         Input UV value
Tiling  Input       Vector 2    None       Amount of tiling to apply per channel
Speed   Input       Vector 2    None       Amount of speed to apply per channel
Out     Output      Vector 2    None       Output UV value

## GENERATED CODE EXAMPLE
The following example code represents one possible outcome of this node.

void CG_Panner_float(float2 UV, float2 Tiling, float2 Speed, out float2 Out)
{
    Out = (UV * Tiling) + (_Time.y * Speed);
}