namespace WhenKeys.Layout
{
    using MudBlazor;

    public class CustomThemes
    {
        public static MudTheme LightTheme => new()
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Blue.Default,
                Secondary = Colors.Green.Accent4,
                Background = "#FFFFFF",
                Surface = "#F5F5F5",
                AppbarBackground = "#2196F3",
                AppbarText = "#FFFFFF",
                DrawerBackground = "#FFFFFF",
                DrawerText = "#000000",
                DrawerIcon = "#000000"
            }
        };

        public static MudTheme DarkTheme => new()
        {
            PaletteDark = new PaletteDark
            {
                Primary = Colors.Blue.Lighten1,
                Secondary = Colors.Green.Lighten1,
                Background = "#121212",
                Surface = "#1E1E1E",
                AppbarBackground = "#1F1F1F",
                AppbarText = "#FFFFFF",
                DrawerBackground = "#1F1F1F",
                DrawerText = "#FFFFFF",
                DrawerIcon = "#FFFFFF"
            }
        };
    }

}
