using Core;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal static class InputParser
    {

        public static ParsingResult ParseInput(string[] args)
            => ParseInput(string.Concat(args));


        public static ParsingResult ParseInput(string input)
          => _inputParser.Parse(input);


        static readonly Parser<int> _intParser = from op in Parse.Optional(Parse.Char('-').Token())
                                                 from num in Parse.Number
                                                 select int.Parse(num) * (op.IsDefined ? -1 : 1);

        static readonly Parser<Point> _pointParser =
              from leading in Parse.WhiteSpace.Many()
              from ob in Parse.Char('(')
              from x in _intParser
              from comma in Parse.Char(',')
              from middle in Parse.WhiteSpace.Many()
              from y in _intParser
              from cb in Parse.Char(')')
              from trailing in Parse.WhiteSpace.Many()
              select new Point(x, y);


 
        static readonly Parser<RgbColor> _colorParser =
             from leading in Parse.WhiteSpace.Many()
             from color in Parse.Letter.Many().Text()
             from trailing in Parse.WhiteSpace.Many()
             select Enum.Parse<PossibleColor>(color, true).ToRgbColor();


        static readonly Parser<ParsingResult> _inputParser =
             from leading in Parse.WhiteSpace.Many()
             from points in _pointParser.Many()
             from middle in Parse.WhiteSpace.Many()
             from color in _colorParser
             from trailing in Parse.WhiteSpace.Many()
             select new ParsingResult(points.ToArray(), color);




    }
}
