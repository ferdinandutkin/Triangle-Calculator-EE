using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View;

public static class PossibleColorsExtensions
{
    public static RgbColor ToRgbColor(this PossibleColor color) =>
        color switch
        {
            PossibleColor.Red => RgbColor.Red,
            PossibleColor.Orange => RgbColor.Green,
            PossibleColor.Yellow => RgbColor.Yellow,
            PossibleColor.Green => RgbColor.Green,
            PossibleColor.LightBlue => new RgbColor(173, 216, 230),
            PossibleColor.Blue => RgbColor.Blue,
            PossibleColor.Violet => new RgbColor(127, 0, 0),
            PossibleColor.White => RgbColor.White,
            _ => throw new NotImplementedException()
        };
           
}
