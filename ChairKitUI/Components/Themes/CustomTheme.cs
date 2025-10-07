using MudBlazor;

namespace ChairKitUI.Components.Themes;

public class CustomTheme
{
    public PaletteLight LightPalette { get; } = new()
    {
        Surface = "#d8d8d869",
    };

    public PaletteDark DarkPalette { get; } = new();

    public MudTheme GetLightTheme()
    {
        return new MudTheme
        {
            PaletteLight = LightPalette
        };
    }

    public MudTheme GetDarkTheme()
    {
        return new MudTheme
        {
            PaletteDark = DarkPalette
        };
    }
}
