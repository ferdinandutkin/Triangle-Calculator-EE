namespace Core;

public record RgbColor(byte R, byte G, byte B)
{

    public static RgbColor Red => new RgbColor(byte.MaxValue, byte.MinValue, byte.MinValue);

    public static RgbColor Green => new RgbColor(byte.MinValue, byte.MaxValue, byte.MinValue);

    public static RgbColor Blue => new RgbColor(byte.MinValue, byte.MinValue, byte.MaxValue);

    public static RgbColor White => new RgbColor(byte.MinValue, byte.MinValue, byte.MinValue);

    public static RgbColor Yellow => new RgbColor(byte.MaxValue, byte.MaxValue, byte.MinValue);

}

