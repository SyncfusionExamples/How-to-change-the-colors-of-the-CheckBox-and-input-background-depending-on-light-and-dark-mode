using Syncfusion.Maui.DataSource.Extensions;
using Syncfusion.Maui.Themes;
using System.Reflection;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();

                if (theme != null)
                {

                    if (theme.VisualTheme is SfVisuals.MaterialDark)
                    {
                        sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "CheckBoxColor").SetValue(sfGrid.DefaultStyle, Colors.Yellow);
                        sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "InputBackgroundColor").SetValue(sfGrid.DefaultStyle, Colors.SkyBlue);

                    }
                    else
                    {
                        sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "CheckBoxColor").SetValue(sfGrid.DefaultStyle, Colors.Orange);
                        sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "InputBackgroundColor").SetValue(sfGrid.DefaultStyle, Colors.Green);

                    }
                }
                else
                {
                    sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "CheckBoxColor").SetValue(sfGrid.DefaultStyle, Colors.Orange);
                    sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "InputBackgroundColor").SetValue(sfGrid.DefaultStyle, Colors.Green);

                }
            }
        }
    }
}
